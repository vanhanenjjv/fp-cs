using System;

namespace FP_CS
{
    public static partial class Function
    {
        public static Func<A> Constant<A>(A a) =>
            () => a;
    }
}
