using System;

namespace FP_CS
{
    public static partial class Function
    {
        public static A Pipe<A>(A a) =>
            a;

        public static B Pipe<A, B>(A a, Func<A, B> ab) =>
            ab(a);

        public static C Pipe<A, B, C>(A a, Func<A, B> ab, Func<B, C> bc) =>
            bc(ab(a));

        public static D Pipe<A, B, C, D>(A a, Func<A, B> ab, Func<B, C> bc, Func<C, D> cd) =>
            cd(bc(ab(a)));

        public static E Pipe<A, B, C, D, E>(A a, Func<A, B> ab, Func<B, C> bc, Func<C, D> cd, Func<D, E> de) =>
            de(cd(bc(ab(a))));

        public static F Pipe<A, B, C, D, E, F>(A a, Func<A, B> ab, Func<B, C> bc, Func<C, D> cd, Func<D, E> de, Func<E, F> ef) =>
            ef(de(cd(bc(ab(a)))));
        
        public static G Pipe<A, B, C, D, E, F, G>(A a, Func<A, B> ab, Func<B, C> bc, Func<C, D> cd, Func<D, E> de, Func<E, F> ef, Func<F, G> fg) =>
            fg(ef(de(cd(bc(ab(a))))));

        public static H Pipe<A, B, C, D, E, F, G, H>(A a, Func<A, B> ab, Func<B, C> bc, Func<C, D> cd, Func<D, E> de, Func<E, F> ef, Func<F, G> fg, Func<G, H> gh) =>   
            gh(fg(ef(de(cd(bc(ab(a)))))));
        
        public static I Pipe<A, B, C, D, E, F, G, H, I>(A a, Func<A, B> ab, Func<B, C> bc, Func<C, D> cd, Func<D, E> de, Func<E, F> ef, Func<F, G> fg, Func<G, H> gh, Func<H, I> hi) => 
            hi(gh(fg(ef(de(cd(bc(ab(a))))))));

        public static J Pipe<A, B, C, D, E, F, G, H, I, J>(A a, Func<A, B> ab, Func<B, C> bc, Func<C, D> cd, Func<D, E> de, Func<E, F> ef, Func<F, G> fg, Func<G, H> gh, Func<H, I> hi, Func<I, J> ji) =>
            ji(hi(gh(fg(ef(de(cd(bc(ab(a)))))))));
        
        public static K Pipe<A, B, C, D, E, F, G, H, I, J, K>(A a, Func<A, B> ab, Func<B, C> bc, Func<C, D> cd, Func<D, E> de, Func<E, F> ef, Func<F, G> fg, Func<G, H> gh, Func<H, I> hi, Func<I, J> ji, Func<J, K> jk) => 
            jk(ji(hi(gh(fg(ef(de(cd(bc(ab(a))))))))));

        public static L Pipe<A, B, C, D, E, F, G, H, I, J, K, L>(A a, Func<A, B> ab, Func<B, C> bc, Func<C, D> cd, Func<D, E> de, Func<E, F> ef, Func<F, G> fg, Func<G, H> gh, Func<H, I> hi, Func<I, J> ji, Func<J, K> jk, Func<K, L> lk) =>
            lk(jk(ji(hi(gh(fg(ef(de(cd(bc(ab(a)))))))))));

        public static M Pipe<A, B, C, D, E, F, G, H, I, J, K, L, M>(A a, Func<A, B> ab, Func<B, C> bc, Func<C, D> cd, Func<D, E> de, Func<E, F> ef, Func<F, G> fg, Func<G, H> gh, Func<H, I> hi, Func<I, J> ji, Func<J, K> jk, Func<K, L> lk, Func<L, M> mk) =>
            mk(lk(jk(ji(hi(gh(fg(ef(de(cd(bc(ab(a))))))))))));

        public static N Pipe<A, B, C, D, E, F, G, H, I, J, K, L, M, N>(A a, Func<A, B> ab, Func<B, C> bc, Func<C, D> cd, Func<D, E> de, Func<E, F> ef, Func<F, G> fg, Func<G, H> gh, Func<H, I> hi, Func<I, J> ji, Func<J, K> jk, Func<K, L> lk, Func<L, M> mk, Func<M, N> nm) =>
            nm(mk(lk(jk(ji(hi(gh(fg(ef(de(cd(bc(ab(a)))))))))))));
        
        public static O Pipe<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O>(A a, Func<A, B> ab, Func<B, C> bc, Func<C, D> cd, Func<D, E> de, Func<E, F> ef, Func<F, G> fg, Func<G, H> gh, Func<H, I> hi, Func<I, J> ji, Func<J, K> jk, Func<K, L> lk, Func<L, M> mk, Func<M, N> nm, Func<N, O> on) =>
            on(nm(mk(lk(jk(ji(hi(gh(fg(ef(de(cd(bc(ab(a))))))))))))));

        public static P Pipe<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P>(A a, Func<A, B> ab, Func<B, C> bc, Func<C, D> cd, Func<D, E> de, Func<E, F> ef, Func<F, G> fg, Func<G, H> gh, Func<H, I> hi, Func<I, J> ji, Func<J, K> jk, Func<K, L> lk, Func<L, M> mk, Func<M, N> nm, Func<N, O> on, Func<O, P> op) =>
            op(on(nm(mk(lk(jk(ji(hi(gh(fg(ef(de(cd(bc(ab(a)))))))))))))));

        public static Q Pipe<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q>(A a, Func<A, B> ab, Func<B, C> bc, Func<C, D> cd, Func<D, E> de, Func<E, F> ef, Func<F, G> fg, Func<G, H> gh, Func<H, I> hi, Func<I, J> ji, Func<J, K> jk, Func<K, L> lk, Func<L, M> mk, Func<M, N> nm, Func<N, O> on, Func<O, P> op, Func<P, Q> qp) =>
            qp(op(on(nm(mk(lk(jk(ji(hi(gh(fg(ef(de(cd(bc(ab(a))))))))))))))));

        public static R Pipe<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R>(A a, Func<A, B> ab, Func<B, C> bc, Func<C, D> cd, Func<D, E> de, Func<E, F> ef, Func<F, G> fg, Func<G, H> gh, Func<H, I> hi, Func<I, J> ji, Func<J, K> jk, Func<K, L> lk, Func<L, M> mk, Func<M, N> nm, Func<N, O> on, Func<O, P> op, Func<P, Q> qp, Func<Q, R> rq) =>
            rq(qp(op(on(nm(mk(lk(jk(ji(hi(gh(fg(ef(de(cd(bc(ab(a)))))))))))))))));

        public static S Pipe<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S>(A a, Func<A, B> ab, Func<B, C> bc, Func<C, D> cd, Func<D, E> de, Func<E, F> ef, Func<F, G> fg, Func<G, H> gh, Func<H, I> hi, Func<I, J> ji, Func<J, K> jk, Func<K, L> lk, Func<L, M> mk, Func<M, N> nm, Func<N, O> on, Func<O, P> op, Func<P, Q> qp, Func<Q, R> rq, Func<R, S> rs) =>
            rs(rq(qp(op(on(nm(mk(lk(jk(ji(hi(gh(fg(ef(de(cd(bc(ab(a))))))))))))))))));

        public static T Pipe<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T>(A a, Func<A, B> ab, Func<B, C> bc, Func<C, D> cd, Func<D, E> de, Func<E, F> ef, Func<F, G> fg, Func<G, H> gh, Func<H, I> hi, Func<I, J> ji, Func<J, K> jk, Func<K, L> lk, Func<L, M> mk, Func<M, N> nm, Func<N, O> on, Func<O, P> op, Func<P, Q> qp, Func<Q, R> rq, Func<R, S> rs, Func<S, T> st) =>
            st(rs(rq(qp(op(on(nm(mk(lk(jk(ji(hi(gh(fg(ef(de(cd(bc(ab(a)))))))))))))))))));
    }
}
