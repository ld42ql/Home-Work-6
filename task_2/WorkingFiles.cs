using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class WorkingFiles
    {
        private string fileName = String.Empty;
        private double count;
        private double value_a;
        private double value_b;
        private int indexFuction;


        /// <summary>
        /// Конструктор для данных
        /// </summary>
        /// <param name="function">функция</param>
        /// <param name="FileName">имя файла</param>
        /// <param name="value_a">значение от</param>
        /// <param name="value_b">значение до></param>
        /// <param name="count">шаг</param>
        public WorkingFiles(int indexFuction, string fileName, double value_a, double value_b, double count)
        {
            this.indexFuction = indexFuction;
            this.fileName = fileName;
            this.value_a = value_a;
            this.value_b = value_b;
            this.count = count;
        }

        /// <summary>
        /// Выбор функции
        /// </summary>
        /// <returns></returns>
        FunOneValue index()
        {
            switch (indexFuction)
            {
                case 1: return Function.MyFunc;
                case 2: return Function.MyFunc1;
                case 3: return Function.MyFunc2;
                default:
                    return Function.Default;
            }
        }
        /// <summary>
        /// Записываем выполненые действия функций в указанный файл 
        /// </summary>
        public void WriteFunc()
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    while (value_a <= value_b)
                    {
                        bw.Write(index()(value_a));
                        value_a += count;
                    }
                }
            }
        }

        /// <summary>
        /// Открываем и читаем файл
        /// </summary>
        /// <returns>Минимальное значение</returns>
        public double ReadFunc()
        {
            double min = double.MaxValue;
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader bw = new BinaryReader(fs))
                {

                    for (int i = 0; i < fs.Length / sizeof(double); i++)
                    {
                        double d = bw.ReadDouble();
                        if (d < min) min = d;
                    }
                }
            }
            return min;
        }

    }
}
