using System;
using System.Collections.Generic;

namespace SeeingSharp.Sub
{
    public class MagicCanHappen
    {
        public void Magic()
        {
            var limit = 10;
            //limit = "five";

            for (var i = 0; i < limit; i++)
            {
                Console.WriteLine(i);
            }

            //for (var i = 0; i < limit; i++)
            //{
            //    Console.WriteLine("Værdien er: {0}", i);
            //}
        }
    }

    #region Haha

    public class var
    {
        private static readonly List<string> Numbers = new List<string>
        {"Et", "To", "Tre", "Fire", "Fem", "Seks", "Syv", "Otte", "Ni", "Ti"};

        private readonly int number;

        public var(int number)
        {
            this.number = number;
        }

        public static implicit operator var(string text)
        {
            int index = Numbers.IndexOf(text);

            if (index == -1)
            {
                throw new ArgumentOutOfRangeException("text");
            }

            return new var(index);
        }

        public static implicit operator var(int number)
        {
            if (number < 0 || number >= Numbers.Count)
            {
                throw new ArgumentOutOfRangeException("number");
            }

            return new var(number);
        }

        public static implicit operator int(var x)
        {
            return x.number;
        }

        public override string ToString()
        {
            return Numbers[number];
        }
    }

    #endregion
}