using System;

namespace FP_CS
{
    public static class Either
    {
        public static Either<L, R> Of<L, R>(R value) =>
            new Either<L, R>(value);

        public static Either<L, R> Left<L, R>(L value) =>
            new Either<L, R>(value);
            
        public static Either<L, R> Right<L, R>(R value) =>
            new Either<L, R>(value);

        public static bool IsLeft<L, R>(Either<L, R> either) =>
            either.Type == EitherType.Left;

        public static bool IsRight<L, R>(Either<L, R> either) =>
            either.Type == EitherType.Right;

        public static Func<Option<R>, Either<L, R>> FromOption<L, R>(L left) =>
            option => 
            {
                if (option.IsNone())
                    return Either.Left<L, R>(left);

                return Either.Right<L, R>(option.Value);
            };
    }
}