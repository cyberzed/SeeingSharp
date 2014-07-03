namespace SeeingSharp
{
    public class Scopey
    {
        public Scopey()
        {
            var scope = 0;

            {
                var tightScope = 1;
            }
        }
    }
}