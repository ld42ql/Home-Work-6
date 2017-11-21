using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class GenerateData
    {
       static Random random = new Random();
        /// <summary>
        /// Генерируем файл с номерами
        /// </summary>
        /// <param name="value">количество номеров</param>
      public static  void TelephoneNumber(int value)
        {
            int format;
            List<string> listNumber = new List<string>();
            for (int i = 0; i < value; i++)
            {
                format = random.Next(1, 7);
                int x, y, z;
                switch (format)
                {
                    case 1:
                        x = random.Next(10, 99);
                        y = random.Next(10, 99);
                        z = random.Next(10, 99);

                        listNumber.Add($"{x}-{y}-{z}");
                        break;
                    case 2:
                        x = random.Next(100, 999);
                        y = random.Next(100, 999);
                        listNumber.Add($"{x}-{y}");
                        break;
                    case 3:
                        x = random.Next(100, 999);
                        y = random.Next(10, 99);
                        z = random.Next(10, 99);
                        listNumber.Add($"{x}-{y}-{z}");
                        break;
                    case 4:
                        x = random.Next(100, 999);
                        y = random.Next(100, 999);
                        z = random.Next(10, 99);
                        listNumber.Add($"{x}-{y}-{z}");
                        break;
                    case 5:
                        x = random.Next(1000, 9999);
                        y = random.Next(100, 999);
                        z = random.Next(10, 99);
                        listNumber.Add($"{x}-{y}-{z}");
                        break;
                    case 6:
                        x = random.Next(1000, 9999);
                        y = random.Next(10, 999);
                        z = random.Next(10, 99);
                        listNumber.Add($"{x}-{y}{z}");
                        break;
                    default:
                        listNumber.Add($"{random.Next(1000, 999999)}");
                        break;
                }
            }
            
            using (StreamWriter outputFile = new StreamWriter("number.txt"))
            {
                foreach (string line in listNumber)
                    outputFile.WriteLine(line);
            }
        }
    }
}

