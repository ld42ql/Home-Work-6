using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    delegate double FunOneValue(double value);
    delegate string Info(string msg);

    static class Function
    {
        /// <summary>
        /// Функция 2x - 50x + 10
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double MyFunc(double x)
        {
            return x * x - 50 * x + 10;
        }

        /// <summary>
        /// Функция х^3
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double MyFunc1(double x)
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
        /// Функция по-умолчанию
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double Default(double x)
        {
            return x;
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

        /// <summary>
        /// Сообщение о ошибке функции
        /// </summary>
        /// <param name="msg">Не верный параметр</param>
        /// <returns></returns>
        public static string WrongMSGFun(string msg)
        {
            return $"Вы выбрали функцию номер: {msg}. Такой функции нет :( ";
        }
    }
}
