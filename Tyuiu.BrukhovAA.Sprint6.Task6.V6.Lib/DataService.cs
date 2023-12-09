using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.BrukhovAA.Sprint6.Task6.V6.Lib
{
    public class DataService : ISprint6Task6V6
    {
        public string CollectTextFromFile(string path)
        {
            string str = "";
            string resStr = "";
            List<string> array = new List<string>();
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    foreach(char c in line)
                    {
                        str = str + c;
                        if(char.IsWhiteSpace(c))
                        {
                            array.Add(str);
                            str = "";
                        }
                    }
                }
            }
            foreach(string s in array)
            {
                if(s.Contains('b'))
                {
                    resStr += s;
                }
            }
            return resStr;
        }
    }
}
