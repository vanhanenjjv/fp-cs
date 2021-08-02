using System;

namespace FP_CS
{
    public static class Option
    {
        public static Func<T, Option<T>> FromPredicate<T>(Func<T, bool> predicate) =>
            x => 
            {
                if (!predicate(x))
                    return None<T>();

                return Some(x);
            };

        public static Option<T> Some<T>(T value) => 
            new Option<T>(value);

        public static Option<object> None() => 
            new Option<object>();

        public static Option<T> None<T>() => 
            new Option<T>();

        public static Option<object> Of() => 
            new Option<object>();

        public static Option<T> Of<T>(T value) => 
            new Option<T>(value);

        public static bool IsSome<T>(Option<T> option) 
        {
                if (option.Value == null)
                    return false;

                if (option.Value is string str)
                {
                    if (str == string.Empty)
                        return false;
                }

                if (option.Value is Array arr)
                {
                    if (arr.Length == 0)
                        return false;
                }

                return true;
        }

        public static bool IsNone<T>(Option<T> option) => 
            !IsSome(option);

        public static Func<Option<A>, Option<B>> Map<A, B>(Func<A, B> ab) =>
            option => 
            {
                if (!option.IsSome())
                    return None<B>();

                return Option.Some(ab(option.Value));
            };
    }
}