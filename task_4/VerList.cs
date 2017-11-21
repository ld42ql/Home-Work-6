using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    //формате xx-xx-xx, xxx-xxx или xxx-xx-xx.
    static class VerList
    {
        static SearchData regex_1 = new SearchData("number.txt", @"^\d{2}(-\d\d){2}$");
        static SearchData regex_2 = new SearchData("number.txt", @"^\d{3}-\d{3}$");
        static SearchData regex_3 = new SearchData("number.txt", @"^\d{3}(-\d\d){2}$");

        /// <summary>
        /// Прверка по регулярным выражениям
        /// </summary>
        /// <returns></returns>
        static public List<string> ViewRegex()
        {
            List<string> list = new List<string>();
            list.AddRange(regex_1.listRegex());
            list.AddRange(regex_2.listRegex());
            list.AddRange(regex_3.listRegex());

            return list;
        }
    }
}
