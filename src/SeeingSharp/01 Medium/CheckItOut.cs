namespace SeeingSharp
{
    public class CheckItOut
    {
        public void ThatIsSoChecked()
        {
            var x1 = short.MaxValue;
            var x2 = short.MaxValue;

            var x = checked ((short) x1 + x2);
        }

        public void ThatIsSoUnchecked()
        {
            var x1 = short.MaxValue;
            var x2 = short.MaxValue;

            var x = unchecked((short) x1 + x2);
        }

        public void DefaultWay()
        {
            var x1 = short.MaxValue;
            var x2 = short.MaxValue;

            var x = (short) (x1 + x2);
        }
    }
}