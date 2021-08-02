using System;
using Xunit;

namespace FP_CS.Tests
{
    public class EitherTests
    {
        [Fact]
        public void SomefulOptionShouldBeConvertedToEitherRight()
        {
            var o = Option.Of("hello");
            var e = Either.FromOption<string, string>("left value")(o);

            Assert.Equal(EitherType.Right, e.Type);
            Assert.Equal("hello", e.Right);
        }

        [Fact]
        public void NonefulOptionShouldBeConvertedToEitherLeft()
        {
            var o = Option.None<string>();
            var e = Either.FromOption<string, string>("left value")(o);

            Assert.Equal(EitherType.Left, e.Type);
            Assert.Equal("left value", e.Left);
        }
    }
}
