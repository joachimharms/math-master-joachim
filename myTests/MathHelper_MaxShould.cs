using System;
using Xunit;
using myLib;

namespace myTests
{
    public class MaxHelper_MaxShould
    {
        private readonly MathHelper _mathHelper;

        public MaxHelper_MaxShould()
        {
            _mathHelper = new MathHelper();
        }
        [Theory]
        [InlineDataAttribute(89,89, 89)]
        [InlineDataAttribute(-40789,-40789, -40789)]
        [InlineDataAttribute(275,275, 275)]
        [InlineDataAttribute(1,1, 1)]
        [InlineDataAttribute(9999,9999, 9999)]
        [InlineDataAttribute(0,0, 0)]
        public void ReturnValueWhenValueOfOperandsAreTheSame(int value1, int value2, int expectedResult)
        {
            var result = _mathHelper.Max(value1, value2);

            Assert.Equal(expectedResult, result);
        }
    }
}
