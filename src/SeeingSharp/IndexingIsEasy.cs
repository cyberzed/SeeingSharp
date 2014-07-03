using System.Collections.Generic;

namespace SeeingSharp
{
    public class IndexingIsEasy
    {
        private readonly Dictionary<int, string> lookup = new Dictionary<int, string>
        {
            {1, "One"},
            {2, "Two"}
        };

        public string this[int key]
        {
            get { return lookup[key]; }
        }

        public IEnumerable<string> this[IEnumerable<int> keys]
        {
            get
            {
                foreach (var key in keys)
                {
                    yield return lookup[key];
                }
            }
        }
    }
}