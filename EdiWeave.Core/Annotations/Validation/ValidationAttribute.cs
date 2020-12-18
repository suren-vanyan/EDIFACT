﻿using EdiWeave.Core.Model.Edi;
using EdiWeave.Core.Model.Edi.ErrorContexts;
using System;
using System.Collections.Generic;

namespace EdiWeave.Core.Annotations.Validation
{
    /// <summary>
    /// Abstract attribute for validation.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public abstract class ValidationAttribute : Attribute, IValidator
    {
        /// <summary>
        /// Protected constructor. Initializes a new instance of the <see cref="ValidationAttribute"/> class.
        /// </summary>
        /// <param name="priority"></param>
        protected ValidationAttribute(int priority)
        {
            Priority = priority;
        }

        /// <summary>
        /// The validation attribute priority.
        /// </summary>
        public int Priority { get; private set; }

        /// <summary>
        /// Detects if an item is valid.
        /// </summary>
        /// <param name="instanceContext">The instance context.</param>
        /// <param name="segmentIndex">The segment position.</param>
        /// <param name="inSegmentIndex">The position within the segment.</param>
        /// <param name="inCompositeIndex">The position within the component if any.</param>
        /// <param name="repetitionIndex">The repetition position.</param>
        /// <returns>A list of segment errors if invalid, otherwise nothing.</returns>
        //public abstract List<SegmentErrorContext> IsValid(InstanceContext instanceContext, int segmentIndex, int inSegmentIndex,
        //    int inCompositeIndex, int repetitionIndex);

        public virtual List<SegmentErrorContext> Validate(InstanceContext instanceContext, int segmentIndex,
            int inSegmentIndex, int inCompositeIndex, int repetitionIndex)
        {
            throw new NotImplementedException();
        }
    }
}
