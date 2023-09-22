using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShaukerovaAN.Sprint1.Task4.V28.Lib
{
    public class DataService : ISprint1Task4V28
    {
        public double Calculate(double x, double y)
        {
            var res = ((Math.Cos(60 * Math.PI / 2)) / (Math.Exp(2 * x + y)));
            return res;
        }
    }
}
