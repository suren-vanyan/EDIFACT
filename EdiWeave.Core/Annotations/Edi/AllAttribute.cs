using System;

namespace EdiWeave.Core.Annotations.Edi
{
    /// <summary>
    /// Attribute to mark a no-sequence group.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class AllAttribute : EdiAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllAttribute"/> class.
        /// </summary>
        public AllAttribute()
            : base(null)
        {
        }
    }
}
