using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    #region *** Балеев Владимир  * Задание № 2***
    /* Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
     * Сделать меню с различными функциями и представьте пользователю выбор для какой функции и на каком отрезке находить минимум.
     * Используйте массив делегатов.*/
    #endregion
    class Program
    {
        static double value_a, value_b, count;
        static int index;
        static string fileName = String.Empty;

        static void Main(string[] args)
        {
            Console.Write("Название файла: ");
            fileName = Console.ReadLine() + ".bin";

            Console.Write("Введите начало \"х\": ");
            if (!Double.TryParse(Console.ReadLine(), out value_a))
            {
                ConsoleWronf(Function.WrongMSG, value_a);
            }

            Console.Write("Введите конец \"х\": ");
            if (!Double.TryParse(Console.ReadLine(), out value_b))
            {
                ConsoleWronf(Function.WrongMSG, value_b);
            }

            Console.Write("Введите шаг: ");
            if (!Double.TryParse(Console.ReadLine(), out count))
            {
                ConsoleWronf(Function.WrongMSG, count);
            }

            Console.WriteLine($"Есть функции:\n1 - \"2x - 50x + 10\"\n2 - \"х^3\"\n3 - \"Косинус х от натурального логарифма\"\n");
            Console.Write("Номер функции: ");
            if (!Int32.TryParse(Console.ReadLine(), out index))
            {
                ConsoleWronf(Function.WrongMSGFun, index);
            }

            WorkingFiles workingFiles = new WorkingFiles(index, fileName, value_a, value_b, count);

            try
            {
                workingFiles.WriteFunc();
                Console.WriteLine($"Функция успешно записана в файл: {fileName}");
            }
            catch
            {
                Console.WriteLine($"Функция не записалась в файл: {fileName}");
            }

            Console.WriteLine($"Минимум функции на отрезке находится {workingFiles.ReadFunc()}.bin");



            void ConsoleWronf(Info wrong, double value)
            {
                Console.WriteLine(wrong(Convert.ToString(value)));
            }
        }
    }

}
