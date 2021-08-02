using System;
using Xunit;

namespace FP_CS.Tests
{
    public class OptionTests
    {
        [Fact]
        public void NonEmptyStringShouldBeSome() =>
            Assert.True(Option.Of("foobar").IsSome());

        [Fact]
        public void TruthfulPredicateShouldBeSome() =>
            Assert.True(Option.FromPredicate<string>(s => s == "foo")("foo").IsSome());

        [Fact]
        public void FalsefulPredicateShouldBeNone() =>
            Assert.True(Option.FromPredicate<string>(s => s == "bar")("foo").IsNone());


        [Fact]
        public void NullValueShouldBeNone() =>
            Assert.True(Option.Of<object>(null).IsNone());

        [Fact]
        public void EmptyStringShouldBeNone() =>
            Assert.True(Option.Of("").IsNone());

        [Fact]
        public void EmptyArrayShouldBeNone() =>
            Assert.True(Option.Of(new int[] {}).IsNone());

        [Fact]
        public void MapShouldBeAppliedToSomefulOption()
        {
            var a = Option.Of("hello");
            var b = Option.Map<string, string>(s => s.ToUpper())(a);

            Assert.Equal(b.Value, "HELLO");
        }

        [Fact]
        public void MapShouldNotBeAppliedToNonefulOption()
        {
            Func<object, object> ab = a => 
            {
                Assert.True(false, "This should not have been called");
                return a;
            };

            var a = Option.Of();
            var b = Option.Map(ab)(a);
        }
    }
}
