using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    static class Class
    {
        static int[] a;

        public static void Save(string fileName, int n)
        {
            Random rnd = new Random();
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            for (int i = 1; i < n; i++)
            {
                bw.Write(rnd.Next(0, 10_000_000));

            }
            fs.Close();
            bw.Close();
        }

        public static void Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            a = new int[fs.Length / sizeof(int)];
            for (int i = 1; i < fs.Length / sizeof(int); i++)
            {
                a[i] = br.ReadInt32();
            }
            br.Close();
            fs.Close();

        }

        /// <summary>
        /// максимальное произведение двух элементов, номера которых различаются не менее чем на 8
        /// </summary>
        /// <returns></returns>
        public static decimal Result()
        {
            List<int> list = new List<int>(a.Length);
            list.AddRange(a);
            decimal max = 1;
            List<int> list1 = new List<int>(a.Length);
            list1.AddRange(a);
            list1.Sort();
            for (int i = 1; i < 3; i++)
            {
                int maxIndex = list.LastIndexOf(list1[list1.Count - i]);
                for (int j = i + 1; j < 16; j++)
                {
                    int index = list.IndexOf(list1[list1.Count - j]);
                    if (Math.Abs(maxIndex - index) >= 8 && list[maxIndex] * list[index] > max)
                    {
                        max = list[maxIndex] * list[index];
                    }
                }
            }
            return max;
        }
    }
}
