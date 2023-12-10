﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.BrukhovAA.Sprint6.Task7.V12.Lib
{
    public class DataService : ISprint6Task7V12
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int colums = lines[0].Split(';').Length;

            int[,] array = new int[rows, colums];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    array[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            int resRow = array.GetUpperBound(0) + 1;
            int resColum = array.Length / resRow;
            for (int r = 0; r < resRow; r++)
            {
                if (array[r, 9] != 10)
                {
                    array[r, 9] = 0;
                }
            }
            return array;
        }
    }
}
