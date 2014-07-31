using System.Runtime.InteropServices;

namespace SeeingSharp
{
    [StructLayout(LayoutKind.Explicit)]
    public class IsThisAUnion
    {
        [FieldOffset(0)] public byte One;

        [FieldOffset(1)] public byte Two;

        [FieldOffset(2)] public byte Three;

        [FieldOffset(3)] public byte Four;

        [FieldOffset(0)] public uint UInt32;
    }
}