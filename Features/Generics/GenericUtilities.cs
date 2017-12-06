using System;

namespace Features.Generics
{
    // Constraints possíveis com Generics
    // where T : IComparable (Constraints de interface)
    // where T : Product     (Constraint de classe)
    // where T : struct      (Constraint de Value Types)
    // where T : class       (Constraint de Reference Type)
    // where T : new()       (Constraint de tipo de construtor)
    public class GenericUtilities
    {
        // É possível criar classes ou métodos genéricos
        public T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        // Para instanciar uma Generic, é necessário um constraint de construtor default
        public void InstanciarGeneric<T>(T value) where T : new()
        {
            var obj = new T();
        }
    }
}