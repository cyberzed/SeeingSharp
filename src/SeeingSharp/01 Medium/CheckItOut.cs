namespace SeeingSharp
{
    public class CheckItOut
    {
        public short ThatIsSoChecked()
        {
            var x1 = short.MaxValue;
            var x2 = short.MaxValue;

            return checked ((short) (x1 + x2));
        }

        public short ThatIsSoUnchecked()
        {
            var x1 = short.MaxValue;
            var x2 = short.MaxValue;

            return unchecked((short) (x1 + x2));
        }

        public short DefaultWay()
        {
            var x1 = short.MaxValue;
            var x2 = short.MaxValue;

            return (short) (x1 + x2);
        }
    }
}