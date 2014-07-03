using System.Data;

namespace SeeingSharp
{
    public class WhereDoWeGoto
    {
        public static void HaveFun()
        {
            var x = 0;

            Loop:

            if (x == 2)
            {
                goto Exit;
            }
            else
            {
                goto INCR;
            }

            Ups:
            x = 1;

            INCR:
            x++;
            goto Loop;

            Exit:
            ;
        }
    }
}