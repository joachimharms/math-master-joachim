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

            // Wir ersetzen folgende Logik durch die Assertfunktion, die von xUnit bereitgestellt wird.
            // if(result == 0)
            // {
            //     System.Console.WriteLine("Success");
            // }
            // else
            // {
            //     System.Console.WriteLine("Failed");
            // }

            Assert.Equal(0, result);
        }
    }
}
