using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{


    #region *** Балеев Владимир  * Задание № 4 ***
    /* В файле могут встречаться номера телефонов, записанные в формате xx-xx-xx, xxx-xxx или xxx-xx-xx.     * Вывести все номера телефонов, которые содержатся в файле.*/
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            GenerateData.TelephoneNumber(1000);

            foreach (var item in VerList.ViewRegex())
            {
                Console.WriteLine($"{item} ");
            }
        }
    }
}
