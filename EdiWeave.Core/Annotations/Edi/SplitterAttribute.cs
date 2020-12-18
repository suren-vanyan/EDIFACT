using System;
using System.Collections.Generic;
using System.Text;

namespace EdiWeave.Core.Annotations.Edi
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class SplitterAttribute : Attribute
    {
        public SplitterAttribute()
        {

        }
    }
}
