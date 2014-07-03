using System;

namespace SeeingSharp
{
    public struct OperatorPatchMeThrough
    {
        public int Value { get; private set; }

        public OperatorPatchMeThrough(int value) : this()
        {
            Value = value;
        }

        public static OperatorPatchMeThrough operator +(OperatorPatchMeThrough item1, OperatorPatchMeThrough item2)
        {
            return new OperatorPatchMeThrough(item1.Value + item2.Value);
        }

        public static bool operator true(OperatorPatchMeThrough item)
        {
            return item.Value > 0;
        }

        public static bool operator false(OperatorPatchMeThrough item)
        {
            return item.Value < 0;
        }

        public static implicit operator OperatorPatchMeThrough(bool val)
        {
            return new OperatorPatchMeThrough(val ? 1 : 0);
        }

        public static explicit operator bool(OperatorPatchMeThrough item)
        {
            if (item.Value < 0)
            {
                throw new InvalidOperationException();
            }

            return item.Value > 0;
        }
    }
}