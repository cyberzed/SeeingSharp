namespace SeeingSharp
{
    // ReSharper disable All

    public static class WhereDoWeGoto
    {
        public static int HaveFun(int x)
        {
            var target = x + 10;

            Loop:

            if (x == target)
            {
                goto Exit;
            }
            else if(x == 42)
            {
                goto Ups;
            }
            else
            {
                goto INCR;
            }

            Ups:
            x = 1;
            goto Exit;

            INCR:
            x++;
            goto Loop;

            Exit:
            return x;
        }
    }
}