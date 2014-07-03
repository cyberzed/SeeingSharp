namespace SeeingSharp
{
    public class TouchingPrivates
    {
        public int Unwritable { get; private set; }

        public static void Overwrite(TouchingPrivates item)
        {
            item.Unwritable = 5;
        }
    }
}