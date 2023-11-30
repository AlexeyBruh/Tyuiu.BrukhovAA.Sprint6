using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BrukhovAA.Sprint6.Task0.V9.Lib
{
    public class DataService : ISprint6Task0V9
    {
        public double Calculate(int x)
        {
            double y = (4 - Math.Pow(x, 3)) / Math.Pow(x, 2);
            return Math.Round(y, 3);
        }
    }
}
