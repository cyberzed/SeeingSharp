using System;
using System.Diagnostics;

namespace SeeingSharp
{
    public class DontShowInDebug
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public Guid AbsolutelyNotImportant { get; set; }

        public Guid VeryImportant { get; set; }

        public Guid Important()
        {
            return Guid.NewGuid();
        }

        [DebuggerStepThrough]
        public Guid NotSoImportant()
        {
            return Guid.Empty;
        }
    }
}