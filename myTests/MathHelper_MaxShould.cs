using System;
using Xunit;
using myLib;

namespace myTests
{
    public class MaxHelper_MaxShould
    {
        [Fact]
        public void Return0GivenValuesOf0()
        {
            var _mathHelper = new MathHelper(); 
            var result = _mathHelper.Max(0, 0);

            if(result == 0)
            {
                System.Console.WriteLine("Success");
            }
            else
            {
                System.Console.WriteLine("Failed");
            }
        }
    }
}
