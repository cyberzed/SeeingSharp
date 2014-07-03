using System;

namespace SeeingSharp
{
    [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
    public class RestrictedAttribute : Attribute
    {
    }
}