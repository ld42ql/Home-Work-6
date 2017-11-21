using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    #region *** Балеев Владимир  * Задание № 4 ***
    /***Модифицировать задачу “Сложную задачу” ЕГЭ так, чтобы она решала задачу с 10 000 000 элементов менее чем за минуту.*/
    #endregion

    class Program
    {

        static void Main(string[] args)
        {

            Class.Save("data.bin", 10_000_000);
            Class.Load("data.bin");
            DateTime d = DateTime.Now;
            Console.WriteLine(Class.Result());
            Console.WriteLine(DateTime.Now - d);
            Console.ReadKey();
        }
    }
}
