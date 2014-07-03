using System;
using System.Runtime.InteropServices;

namespace SeeingSharp
{
    public class IsThisAUnion
    {
        public void ItCertainlyIs()
        {
            var a = new A {Int32 = int.MaxValue};

            Console.WriteLine(a.Int32);
            Console.WriteLine("{0:X} {1:X} {2:X} {3:X}", a.One, a.Two, a.Three, a.Four);

            a.Four = 0;
            a.Three = 0;

            Console.WriteLine(a.Int32);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public class A
    {
        [FieldOffset(0)] public byte One;

        [FieldOffset(1)] public byte Two;

        [FieldOffset(2)] public byte Three;

        [FieldOffset(3)] public byte Four;

        [FieldOffset(0)] public int Int32;
    }
}