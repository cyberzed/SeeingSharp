namespace SeeingSharp
{
    public class IAmImmutable
    {
        public int Value { get; private set; }
        public string Text { get; private set; }

        public IAmImmutable(int value, string text)
        {
            Value = value;
            Text = text;
        }
    }
}