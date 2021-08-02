using System;

namespace FP_CS
{
    public static partial class Function
    {
        public static Func<A, B> Flow<A, B>(Func<A, B> ab) => 
            ab;
        
        public static Func<A, C> Flow<A, B, C>(Func<A, B> ab, Func<B, C> bc) =>
            a => bc(ab(a));

        public static Func<A, D> Flow<A, B, C, D>(Func<A, B> ab, Func<B, C> bc, Func<C, D> cd) =>
            a => cd(bc(ab(a)));

        public static Func<A, E> Flow<A, B, C, D, E>(Func<A, B> ab, Func<B, C> bc, Func<C, D> cd, Func<D, E> de) =>
            a => de(cd(bc(ab(a))));
        
        public static Func<A, F> Flow<A, B, C, D, E, F>(Func<A, B> ab, Func<B, C> bc, Func<C, D> cd, Func<D, E> de, Func<E, F> ef) =>
            a => ef(de(cd(bc(ab(a)))));

        public static Func<A, G> Flow<A, B, C, D, E, F, G>(Func<A, B> ab, Func<B, C> bc, Func<C, D> cd, Func<D, E> de, Func<E, F> ef, Func<F, G> fg) =>
            a => fg(ef(de(cd(bc(ab(a))))));

        public static Func<A, H> Flow<A, B, C, D, E, F, G, H>(Func<A, B> ab, Func<B, C> bc, Func<C, D> cd, Func<D, E> de, Func<E, F> ef, Func<F, G> fg, Func<G, H> gh) =>
            a => gh(fg(ef(de(cd(bc(ab(a)))))));

        public static Func<A, I> Flow<A, B, C, D, E, F, G, H, I>(Func<A, B> ab, Func<B, C> bc, Func<C, D> cd, Func<D, E> de, Func<E, F> ef, Func<F, G> fg, Func<G, H> gh, Func<H, I> hi) => 
            a => hi(gh(fg(ef(de(cd(bc(ab(a))))))));

        public static Func<A, J> Flow<A, B, C, D, E, F, G, H, I, J>(Func<A, B> ab, Func<B, C> bc, Func<C, D> cd, Func<D, E> de, Func<E, F> ef, Func<F, G> fg, Func<G, H> gh, Func<H, I> hi, Func<I, J> ij) =>
            a => ij(hi(gh(fg(ef(de(cd(bc(ab(a)))))))));
    }
}
