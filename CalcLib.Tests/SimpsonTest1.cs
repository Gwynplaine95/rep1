using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WPF_Integral.Classes;

namespace WPF_Integral.Tests
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void Simpson_Correct_Answer()
        {
            double upperlimit = 100000;
            double lowerlimit = 1;
            int count = 100;
            Func<double, double> IntegralFunction = x => 11 * x - Math.Log(11 * x) - 2;

            double expectedResult= 54998510381,81696;

            Simpson calculator =new Simpson();
            double actualResult= calculator.Integrate(upperlimit, lowerlimit,count,IntegralFunction);
            Assert.Equal(expectedResult,actualResult);
        }
    }
}
