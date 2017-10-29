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
        [Fact]
        public void Return0GivenValuesOf0()
        {
            var result = _mathHelper.Max(0, 0);

            Assert.Equal(0, result);
        }
    }
}
