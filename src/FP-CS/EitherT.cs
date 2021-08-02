using System;

namespace FP_CS
{
    public enum EitherType
    {
        Left,
        Right
    }

    public class Either<L, R>
    {
        internal Either(R right)
        {
            Right = right;
            Type = EitherType.Right;
        }

        internal Either(L left)
        {
            Left = left;
            Type = EitherType.Left;
        }

        public EitherType Type { get; }
        public L Left { get; }
        public R Right { get; }
    }

    public static class EitherExtensions
    {
        public static bool IsLeft<L, R>(this Either<L, R> either) =>
            Either.IsLeft(either);

        public static bool IsRight<L, R>(this Either<L, R> either) =>
            Either.IsRight(either);
    }
}
