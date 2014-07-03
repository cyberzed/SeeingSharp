using System;
using System.Diagnostics;

namespace SeeingSharp
{
    public class ShowInDebug
    {
        public class BadIdea
        {
            public Guid Id
            {
                get { return Guid.NewGuid(); }
            }

            public override string ToString()
            {
                return Id.ToString();
            }
        }

        [DebuggerDisplay("Id: {Id}")]
        public class GoodIdea
        {
            public Guid Id
            {
                get { return Guid.NewGuid(); }
            }
        }
    }
}