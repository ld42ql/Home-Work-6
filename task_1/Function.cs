using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    delegate double FunOneValue(double value);
    delegate double FunTwoValue(double value_x, double value_y);

    static class Function
    {
        /// <summary>
        /// Функция х^3
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double MyFunc(double x)
        {
            return x * x * x;
        }

        /// <summary>
        /// Функция косинус от натурального логарифма
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double MyFunc2(double x)
        {
            return Math.Cos(Math.Log(x));
        }

        /// <summary>
        /// Функция производной "у" на "х" в степени два
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double MyFunc3(double x, double y)
        {
            return y * Math.Pow(x, 2);
        }

        /// <summary>
        /// Функция производной "у" на косинус "х"
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double MyFunc4(double x, double y)
        {
            return y * Math.Sin(x);
        }

        /// <summary>
        /// Сообщение о ошибке
        /// </summary>
        /// <param name="msg">Не верный параметр</param>
        /// <returns></returns>
        public static string WrongMSG(string msg)
        {
            return $"В параметр {msg} ввели не число :( ";
        }
    }
}
