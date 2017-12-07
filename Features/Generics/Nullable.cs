namespace Features.Generics
{
    // Implementação da classe Nullable que faz uso de uma contraint de value type
    public class Nullable<T> where T : struct
    {
        private object _value;
        
        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get
            {
                return _value != null;
            }
        }

        public T GetValueOrDefault {
            get
            {
                if(HasValue)
                    return (T) _value;
                
                return default(T);
            }
        }
        
        
        
    }
}