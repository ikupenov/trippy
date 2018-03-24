using System;

namespace Trippy
{
    public static class TypeExtensions
    {
        public static bool IsSubclassOf<T>(this Type @this)
        {
            return @this.IsSubclassOf(typeof(T));
        }

        public static bool HasParameterlessConstructor(this Type @this)
        {
            return @this.GetConstructor(Type.EmptyTypes) != null;
        }
    }
}
