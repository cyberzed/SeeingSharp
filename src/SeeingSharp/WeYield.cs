using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace SeeingSharp
{
    public class WeYield
    {
        public IEnumerable<int> RandomStuff
        {
            get
            {
                var rand = new Random();

                for (var i = 0; i < 10; i++)
                {
                    yield return rand.Next(0, 1001);
                }
            }
        }
    }

    public class ItsADefaultThing
    {
        public int Zero
        {
            get { return default(int); }
        }

        public string Nothing
        {
            get { return default(string); }
        }

        public ConsoleKey Something
        {
            get { return default(ConsoleKey); }
        }
    }

    public class WeCantDoThisAnymore
    {
        [Obsolete]
        public string Ouch { get; set; }

        [Obsolete("Don't use this", true)]
        public int Auch { get; set; }
    }

    public class ShowInDebug
    {
        public class BadIdea
        {
            public Guid Id
            {
                get { return Guid.NewGuid(); }
            }

            public override string ToString()
            {
                return Id.ToString();
            }
        }

        [DebuggerDisplay("Id: {Id}")]
        public class GoodIdea
        {
            public Guid Id
            {
                get { return Guid.NewGuid(); }
            }
        }
    }

    public class DontShowInDebug
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public Guid AbsolutelyNotImportant { get; set; }

        public Guid Important()
        {
            return Guid.NewGuid();
        }

        [DebuggerStepThrough]
        public Guid NotSoImportant()
        {
            return Guid.Empty;
        }
    }

    [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
    public class RestrictedAttribute : Attribute
    {
    }

    public class Numbers
    {
        public decimal Money
        {
            get
            {
                var x = 0M;
                return x;
            }
        }

        public float Floating
        {
            get
            {
                var x = 1F;
                return x;
            }
        }

        public double Double
        {
            get
            {
                var x = 2D;
                return x;
            }
        }

        public long Long
        {
            get
            {
                var x = 3L;
                return x;
            }
        }

        public ulong Ulong
        {
            get
            {
                var x = 4UL;
                return x;
            }
        }

        public uint Uint
        {
            get
            {
                var x = 5U;
                return x;
            }
        }
    }

    public class WhereIsItGeneric<TEntity> where TEntity : class, new()
    {
    }

    //TODO: Generic implicit...

    public class ReallyStupidIdea
    {
        public event EventHandler @event = (o, e) => { };

        public int @int { get; set; }
    }

    public class IAmImmutable
    {
        public int Value { get; private set; }
        public string Text { get; private set; }

        public IAmImmutable(int value, string text)
        {
            Value = value;
            Text = text;
        }
    }

    public class Options
    {
        public Options()
        {
#if DEBUG
            Debug.WriteLine("Test");
#elif TRACE
            Trace.WriteLine("Test")
#else
            Console.WriteLine("Test");
#endif
        }
    }

    public class PathIdeas
    {
        public string BadPathing(string path, string filename)
        {
            if (path.EndsWith("\\"))
            {
                return path + filename;
            }

            return path + "\\" + filename;
        }

        public string AwesomePathToHeaven(string path, string filename)
        {
            return Path.Combine(path, filename);
        }
    }

    public class ItIsTimeForFun
    {
        public TimeSpan MightBeAccurate()
        {
            var start = DateTime.Now;

            //DO STUFF!!!

            var end = DateTime.Now;

            return end - start;
        }

        public TimeSpan EvenMoreAccurate()
        {
            var stp = Stopwatch.StartNew();

            //DO STUFF!!!

            stp.Stop();

            return stp.Elapsed;
        }
    }

    public class WhatIsIt
    {
        public void IsItWhatYouThing(object foo)
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