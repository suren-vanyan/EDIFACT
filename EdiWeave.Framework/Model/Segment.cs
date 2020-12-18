﻿//---------------------------------------------------------------------
// This file is part of ediFabric
//
// Copyright (c) ediFabric. All rights reserved.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
// KIND, WHETHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
// PURPOSE.
//---------------------------------------------------------------------

using EdiWeave.Core.Annotations.Edi;
using EdiWeave.Core.ErrorCodes;
using EdiWeave.Core.Model.Edi.ErrorContexts;
using EdiWeave.Framework.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EdiWeave.Framework.Model
{
    class Segment : ParseNode
    {
        private readonly List<string> _firstMatchValues = new List<string>();
        public IReadOnlyCollection<string> FirstMatchValues
        {
            get { return _firstMatchValues.AsReadOnly(); }
        }

        private readonly List<string> _secondMatchValues = new List<string>();
        public IReadOnlyCollection<string> SecondMatchValues
        {
            get { return _secondMatchValues.AsReadOnly(); }
        }

        public bool IsTrigger
        {
            get { return Parent is Loop && IndexInParent() == 0; }
        }

        private Segment(TypeInfo typeInfo, string name, string ediName, object instance = null)
            : base(typeInfo, name, ediName)
        {
            if (instance == null) return;
            BuildChildren(instance, true);
        }

        public Segment(PropertyInfo propertyInfo, SegmentAttribute sAttr, object instance = null)
            : this(propertyInfo.GetGenericType(), propertyInfo.Name, sAttr.Id, instance)
        {
            if (sAttr.First != null)
            {
                var eAttr = (EdiCodesAttribute)sAttr.First.GetTypeInfo().GetCustomAttributes(typeof(EdiCodesAttribute)).SingleOrDefault();
                if (eAttr == null)
                    throw new Exception(string.Format("Type {0} is not annotated with {1}.",
                        sAttr.First.Name, typeof(EdiCodesAttribute).Name));
                _firstMatchValues = eAttr.Codes.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (sAttr.Second != null)
                {
                    var eAttrS = (EdiCodesAttribute)sAttr.Second.GetTypeInfo().GetCustomAttributes(typeof(EdiCodesAttribute)).SingleOrDefault();
                    if (eAttrS == null)
                        throw new Exception(string.Format("Type {0} is not annotated with {1}.",
                            sAttr.Second.Name, typeof(EdiCodesAttribute).Name));
                    _secondMatchValues = eAttrS.Codes.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                }
            }
        }

        public Segment(TypeInfo typeInfo, object instance = null)
            : this(typeInfo, typeInfo.Name, typeInfo.Name, instance)
        {
        }

        public Segment(Segment segment)
            : this(segment.TypeInfo, segment.Name, segment.EdiName)
        {
            segment.Parent.InsertChild(segment.IndexInParent() + 1, this);
        }

        public override IEnumerable<ParseNode> NeighboursWithExclusion(IEnumerable<ParseNode> exclusion)
        {
            return new List<ParseNode> {Parent};
        }

        public override void SetParsed()
        {
            IsParsed = true;
            if (Parent != null)
                Parent.SetParsed();
        }

        public override void Parse(string value, Separators separators, bool allowPartial)
        {
            if (String.IsNullOrEmpty(value)) throw new ArgumentNullException("value");
            if (separators == null) throw new ArgumentNullException("separators");

            if (!Children.Any())
                BuildChildren();

            SetParsed();

            var index = 0;
            foreach (var currentToParse in value.GetDataElements(separators))
            {
                if (String.IsNullOrEmpty(currentToParse))
                {
                    index++;
                    continue;
                }

                if (index >= Children.Count)
                {
                    if (allowPartial)
                        continue;

                    var errorContext = new DataElementErrorContext("", index, DataElementErrorCode.TooManyDataElements,
                            0, 0, currentToParse, "Too many Data Elements");
                    throw new ParserSegmentException(errorContext);
                }

                var currentElement = Children.ElementAt(index);

                var repetitions = currentElement.IsX12RepetitionSeparator()
                    ? new List<string> { currentToParse }
                    : currentToParse.GetRepetitions(separators);

                var repIndex = 0;
                foreach (var repetition in repetitions)
                {
                    repIndex++;
                    if (String.IsNullOrEmpty(repetition)) continue;
                    if (currentElement.IsParsed)
                    {
                        currentElement = currentElement.InsertRepetition();
                        index++;
                    }
                    try
                    {
                        currentElement.Parse(repetition, separators, allowPartial); 
                    }
                    catch (ParserElementException ex)
                    {
                        var errorContext = new DataElementErrorContext(currentElement.EdiName, index, ex.ErrorCode,
                            ex.ComponentPosition, repIndex, repetition, ex.Message);
                        throw new ParserSegmentException(errorContext);
                    }
                                      
                }
                index++;
            }
        }

        public override ParseNode InsertRepetition()
        {
            if (IsTrigger)
            {
                return (Segment) new Loop(Parent).Children.First();
            }

            return new Segment(this);
        }

        public string Generate(Separators separators, bool preserveWhitespace)
        {
            if (separators == null) throw new ArgumentNullException("separators");

            var result = new List<string> {EdiName};

            foreach (var element in Children)
            {
                string value;
                if (element is ComplexDataElement)
                {
                    var composite = new List<string>();
                    foreach (var child in element.Children.OfType<DataElement>())
                    {
                        composite.Add(child.Value.EscapeLine(separators));
                        composite.Add(separators.ComponentDataElement.ToString());
                    }
                    value = composite.TrimEndWithEscape(separators.Escape, separators.ComponentDataElement,
                        preserveWhitespace);
                }
                else
                {
                    var de = element as DataElement;
                    if (de == null)
                        throw new Exception(String.Format("Unexpected node {0} under parent {1}", element.TypeInfo.FullName,
                            element.Parent.TypeInfo.FullName));

                    value = de.Value.EscapeLine(separators);
                }

                var separator = element.IsRepetition()
                    ? separators.RepetitionDataElement
                    : separators.DataElement;

                result.Add(separator.ToString());
                result.Add(value);
            }

            return result.TrimEndWithEscape(separators.Escape, separators.DataElement, preserveWhitespace) +
                   separators.Segment;
        }

        public bool Match(SegmentContext segmentContext)
        {
            // The names must match
            if (EdiName == segmentContext.Name)
            {
                // If no identity match is required, mark this as a match
                if (String.IsNullOrEmpty(segmentContext.FirstValue) || !FirstMatchValues.Any())
                    return true;
               
                // Match the value 
                // This must have been defined in the enum of the first element of the segment.
                if (FirstMatchValues.Any() && !String.IsNullOrEmpty(segmentContext.FirstValue) &&
                    FirstMatchValues.Contains(segmentContext.FirstValue))
                {
                    if (SecondMatchValues.Any() && !String.IsNullOrEmpty(segmentContext.SecondValue))
                    {
                        return SecondMatchValues.Contains(segmentContext.SecondValue);
                    }

                    return true;
                }
            }

            return false;
        }

        public override void Parse(string value, bool allowPartial)
        {
            if (String.IsNullOrEmpty(value)) throw new ArgumentNullException("value");
            
            if (!Children.Any())
                BuildChildren();

            SetParsed();

            var remainder = value;
            var index = 0;
            foreach (var child in Children.OfType<DataElement>())
            {
                index++;
                if (child.MaxSize == 0)
                {
                    throw new Exception(string.Format("DataElement {0} MaxSize is 0.", child.EdiName));
                }

                if (remainder.Length < child.MaxSize)
                {
                    if (allowPartial)
                        continue;

                    var errorContext = new DataElementErrorContext("", index, DataElementErrorCode.TooManyDataElements,
                            0, 0, remainder, "Too many Data Elements");
                    throw new ParserSegmentException(errorContext);
                }

                var current = remainder.Substring(0, child.MaxSize);
                remainder = remainder.Substring(child.MaxSize);
                child.Parse(current, allowPartial);
            }
        }

        public string Generate(Func<DataElement, string> pad)
        {
            var result = "";

            foreach (var element in Children)
            {
                if (element is ComplexDataElement)
                {
                    foreach (var child in element.Children.OfType<DataElement>())
                    {
                        result = result + pad(child);
                    }                    
                }
                else
                {
                    var de = element as DataElement;
                    if (de == null)
                        throw new Exception(String.Format("Unexpected node {0} under parent {1}", element.TypeInfo.FullName,
                            element.Parent.TypeInfo.FullName));

                    result = result + pad(de);
                }
            }

            return result;
        }
    }
}
