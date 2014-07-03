using System;

namespace SeeingSharp
{
    public class WeCantDoThisAnymore
    {
        [Obsolete]
        public string Ouch { get; set; }

        [Obsolete("Don't use this", true)]
        public int Auch { get; set; }
    }
}