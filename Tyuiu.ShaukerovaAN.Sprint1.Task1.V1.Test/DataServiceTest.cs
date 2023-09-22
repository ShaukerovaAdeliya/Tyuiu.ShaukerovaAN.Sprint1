using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShaukerovaAN.Sprint1.Task1.V1.Lib;

namespace Tyuiu.ShaukerovaAN.Sprint1.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 9.0;
            double y = 3.0;
            double a = 4.0;
            var res = ds.Calculate(x, y, a);
            Assert.AreEqual(25, res);

        }
    }
}