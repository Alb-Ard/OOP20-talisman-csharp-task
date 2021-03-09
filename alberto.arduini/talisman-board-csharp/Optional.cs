using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talisman
{
    public class Optional<T>
    {
        private readonly T value;
        private readonly bool hasValue;

        public T Value => HasValue ? value : throw new NullReferenceException("The optional does not have a value");

        public bool HasValue => hasValue;

        private Optional(T value)
        {
            this.value = value;
            hasValue = true;
        }

        private Optional()
        {
            value = default;
            hasValue = false;
        }

        public void IfPresent(Action<T> action)
        {
            if (HasValue)
                action?.Invoke(Value);
        }

        public void IfPresentOrElse(Action<T> presentAction, Action notPresentAction)
        {
            if (HasValue)
                presentAction?.Invoke(Value);
            else
                notPresentAction?.Invoke();
        }

        public void IfNotPresent(Action action)
        {
            if (!HasValue)
                action?.Invoke();
        }

        public static Optional<T> Of(T value)
        {
            return value == null ? throw new ArgumentNullException($"{nameof(value)} can't be null") : new Optional<T>(value);
        }

        public static Optional<T> OfNullable(T value)
        {
            return value == null ? Empty() : new Optional<T>(value);
        }

        public static Optional<T> Empty()
        {
            return new Optional<T>();
        }
    }
}
