using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableExercise
{
    public struct AmateurNullable<T> where T : struct
    {
        private T _Value;
        private bool _HasValue;

        public AmateurNullable(T val)
        {
            _Value = val;
            _HasValue = true;
        }

        public T Value
        {
            get
            {
                if(_HasValue)
                {
                    return _Value;
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
            set
            {
                _Value = value;
                _HasValue = true;
            }
        }

        public bool HasValue
        {
            get => _HasValue;
        }

        public static implicit operator AmateurNullable<T>(AmateurNullable target)
        {
            return new AmateurNullable<T>();
        }

        public static implicit operator AmateurNullable<T>(T val)
        {
            return new AmateurNullable<T>(val);
        }

        public static explicit operator T(AmateurNullable<T> val)
        {
            if(val.HasValue)
            {
                return val.Value;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }

    // This is a placeholder class, which is necessary to be able
    // to cast null to AmateurNullable<T>. When an implicit cast of
    // null is determined, the proram will resolve to
    // operator AmateurNullable<T>(AmateurNullable target)
    public sealed class AmateurNullable
    {
        
    }
}
