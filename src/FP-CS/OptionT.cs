using System;

namespace FP_CS
{
    public class Option<T>
    {
        internal Option()
        {
        }

        internal Option(T value)
        {
            Value = value;
        }

        public T Value { get; }
    }

    public static class OptionExtensions
    {
        public static bool IsSome<T>(this Option<T> option) =>
            Option.IsSome(option);

        public static bool IsNone<T>(this Option<T> option) =>
            Option.IsNone(option);
    }
}
