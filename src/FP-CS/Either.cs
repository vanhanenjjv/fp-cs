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

        public static Func<R, Either<L, R>> FromPredicate<L, R>(Func<R, bool> predicate, Func<L> onFalse) =>
            value => 
            {
                if (!predicate(value))
                    return Either.Left<L, R>(onFalse());

                return Either.Right<L, R>(value);
            };

        public static Func<Either<L, A>, Either<L, B>> Chain<L, A, B>(Func<A, Either<L, B>> ab) =>
            a => 
            {
                if (a.IsLeft())
                    return Either.Left<L, B>(a.Left);

                return ab(a.Right);
            };

        public static Func<Either<L, R>, B> Match<L, R, B>(Func<L, B> onLeft, Func<R, B> onRight) =>
            either =>
            {
                if (either.IsLeft())
                    return onLeft(either.Left);

                return onRight(either.Right);
            };
    }
}