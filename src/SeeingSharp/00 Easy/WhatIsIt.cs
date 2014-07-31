using System.Diagnostics;

namespace SeeingSharp
{
    public class WhatIsIt
    {
        public void IsItWhatYouThink(object foo)
        {
            if (foo is string)
            {
                Debug.WriteLine(foo);
            }
            else
            {
                Debug.WriteLine(foo.ToString());
            }
        }

        public void AsItShouldBe(object bar)
        {
            var x = bar as string;

            if (!string.IsNullOrEmpty(x))
            {
                Debug.WriteLine(x);
            }
        }
    }
}