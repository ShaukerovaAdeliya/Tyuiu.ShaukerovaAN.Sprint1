﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.ShaukerovaAN.Sprint1.Task0.V19.Lib;

namespace Tyuiu.ShaukerovaAN.Sprint1.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(3, res);

        }
    }
}
