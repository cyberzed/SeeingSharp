using System;

namespace SeeingSharp
{
    public class ItsADefaultThing
    {
        public int Zero
        {
            get { return default(int); }
        }

        public string Nothing
        {
            get { return default(string); }
        }

        public ConsoleKey Something
        {
            get { return default(ConsoleKey); }
        }
    }
}