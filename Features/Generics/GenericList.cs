using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Features.Generics
{
    public class GenericList<T>
    {
        private ICollection<T> list;

        public GenericList()
        {
            list = new Collection<T>();
        }

        public void Add(T value)
        {
            list.Add(value);
        }

        public T this[int index]
        {
            get
            {
                return list.ElementAt(index);
            }
        }
    }
}