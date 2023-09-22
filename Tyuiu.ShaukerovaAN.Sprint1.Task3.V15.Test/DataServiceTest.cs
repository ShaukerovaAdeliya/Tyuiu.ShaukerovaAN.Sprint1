using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShaukerovaAN.Sprint1.Task3.V15.Lib;

namespace Tyuiu.ShaukerovaAN.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double V = 60;
            double L = 80;
            double S = 10;
            double T = 3;
            double wait = 430;
            var res = ds.DistanceOverTime(V, L, S, T); 
            Assert.AreEqual(wait, res);


        }
    }
}
