using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BeketovVN.Sprint6.Task5.V25.Lib
{
    public class DataService : ISprint6Task5V25
    {
        public int len;
        public double[] LoadFromDataFile(string path)
        {
            int len = 0;
            using (StreamReader streamReader = new StreamReader(path))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    len++;
                }
            }

            double[] numArray = new double[len];
            int index = 0;
            using (StreamReader streamReader = new StreamReader(path))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    numArray[index] = Convert.ToDouble(line);
                    index++;
                }
            }

            numArray = numArray.Where(val => val != 0).ToArray();
            return numArray;
        }
    }
}
