using System.Diagnostics;

namespace SeeingSharp
{
    public class Options
    {
        public Options()
        {
#if DEBUG
            Debug.WriteLine("Test");
#elif TRACE
            Trace.WriteLine("Test")
#else
            Console.WriteLine("Test");
#endif
        }
    }
}