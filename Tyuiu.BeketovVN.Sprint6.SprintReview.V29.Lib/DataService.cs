using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.BeketovVN.Sprint6.SprintReview.V29.Lib
{
    public class DataService
    {
        public int[,] GetRandomMatrix(int n, int m, int n1, int n2)
        {
            Random rand = new Random();
            int[,] array = new int[n, m];

            for (int j = 0; j < m; j++)
            {
                int currentValue = rand.Next(n1, n2);

                for (int i = 0; i < n; i++)
                {
                    array[i, j] = currentValue;
                    currentValue = rand.Next(currentValue + 1, n2); // Генерация следующего числа больше предыдущего
                }
            }

            return array;
        }

        public int GetMatrix(int[,] array, int c, int k, int l)
        {
            
            int sum = 0;
            for (int j = k; j <= l; j++)
            {
                sum += array[c, j];
            }

            return sum;
           
        }
    }
}
