using System;
using System.IO;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace task_3
{
    #region *** Балеев Владимир  * Задание № 3 ***
    /* Подсчитать количество студентов:
     * а) учащихся на 5 и 6 курсах;
     * б)*подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(частотный массив);
     * в) отсортировать список по возрасту студента;
     * г) **отсортировать список по курсу и возрасту студента.*/
    #endregion
    class Program
    {


        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;

            WorkingFiles.ReadStudents("students_4.csv");


            Console.WriteLine(WorkingFiles.Result(5, 6));

            int[] arrayYears = WorkingFiles.ResultYears(18, 20);

            for (int i = 0; i < arrayYears.Length; i++)
            {
                Console.WriteLine($"На курсе {i + 1} - учатся {arrayYears[i]}.");
            }

            WorkingFiles.SortStudent();

            Console.WriteLine("Прошла сортировка по возрасту");

            WorkingFiles.SortStudentYearAndClass();

            Console.WriteLine("Прошла сортировка по возрасту и курсу");

            Console.WriteLine(DateTime.Now - dt);

            Console.ReadKey();
        }
    }
}
