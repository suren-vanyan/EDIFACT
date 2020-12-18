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

using System;

namespace EdiWeave.Core.Annotations.Edi
{
    /// <summary>
    /// Attribute to mark a loop.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class GroupAttribute : EdiAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAttribute"/> class.
        /// </summary>
        /// <param name="id"></param>
        public GroupAttribute(string id)
            : base(id)
        {
        }
    }
}
