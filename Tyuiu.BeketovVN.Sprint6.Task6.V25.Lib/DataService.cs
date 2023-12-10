using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BeketovVN.Sprint6.Task6.V25.Lib
{
    public class DataService : ISprint6Task6V25
    {
        public string CollectTextFromFile(string path)
        {
            StringBuilder resultStringBuilder = new StringBuilder();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        if (word.Contains("E") || word.Contains("e"))
                        {
                            resultStringBuilder.Append(word).Append(" ");
                            break; // Прекращаем проверку после первого найденного слова
                        }
                    }
                }
            }

            return resultStringBuilder.ToString().Trim();
        }
    }
}
