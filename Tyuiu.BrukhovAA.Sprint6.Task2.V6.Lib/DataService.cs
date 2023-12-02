using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BrukhovAA.Sprint6.Task2.V6.Lib
{
    public class DataService : ISprint6Task2V6
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = 0;
            int len = Math.Abs(startValue) + Math.Abs(stopValue) + 1;
            double[] array = new double[len];
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x - 0.7 != 0)
                {
                    double y = (Math.Cos(x) / (x - 0.7)) - Math.Sin(x) * 12 * x + 2;
                    y = Math.Round(y, 2);
                    array[count] = y;
                    count++;
                }
                else
                {
                    double y = 0;
                    array[count] = y;
                    count++;
                }

            }
            return array;
        }
    }
}
