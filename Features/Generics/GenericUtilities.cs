using System;

namespace Features.Generics
{
    public class GenericUtilities
    {
        // É possível criar classes ou métodos genéricos
        public T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}