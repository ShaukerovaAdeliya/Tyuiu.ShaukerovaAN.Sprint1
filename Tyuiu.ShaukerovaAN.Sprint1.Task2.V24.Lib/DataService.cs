using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShaukerovaAN.Sprint1.Task2.V24.Lib
{
    public class DataService : ISprint1Task2V24
    {
        public int CalculateDiffSquare(int value, int valueTwo)
        {
            return (value - valueTwo) * (value - valueTwo);
        }
    }
}