namespace SeeingSharp
{
    public class ItIsGenericNoMatterWhat
    {
        public void IsIt()
        {
            YesItIs<int>(23);
            YesItIs(23);
        }

        public void YesItIs<TInput>(TInput input)
        { }
    }
}