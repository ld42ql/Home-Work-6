using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    static class Table
    {
        

        /// <summary>
        /// Ввывод таблицы от и до, с результатом работы функции c одним значением
        /// </summary>
        /// <param name="F">Метов функции</param>
        /// <param name="valuу_x">значение "х" и начало таблицы</param>
        /// <param name="valueEnd">конец таблицы</param>
        /// <returns></returns>
        static public StringBuilder TableOneValue(FunOneValue F, double valuу_x, double valueEnd)
        {
            StringBuilder table = new StringBuilder("----- X ----- Y -----");
            table.AppendLine();
            while (valuу_x <= valueEnd)
            {
                table.AppendLine($"| {valuу_x,8:0.000} | {F(valuу_x),8:0.000} |");
                valuу_x++;
            }
            table.AppendLine("---------------------");
            return table;
        }

        /// <summary>
        /// Ввывод таблицы от и до, с результатом работы функции c двумя значениями
        /// </summary>
        /// <param name="F">Метов функции</param>
        /// <param name="valuу_x">значение "х" и начало таблицы</param>
        /// <param name="value_y">значение "у"</param>
        /// <param name="valueEnd">конец таблицы</param>
        /// <returns></returns>
        static public StringBuilder TableTwoValue(FunTwoValue F, double valuу_x, double value_y, double valueEnd)
        {
            StringBuilder table = new StringBuilder("----- X ----- Y -----");
            table.AppendLine();
            while (valuу_x <= valueEnd)
            {
                table.AppendLine($"| {valuу_x,8:0.000} | {value_y,8:0.000} | {F(valuу_x, value_y),8:0.000} |");
                valuу_x++;
                value_y++;
            }
            table.AppendLine("---------------------");
            return table;
        }
    }
}
