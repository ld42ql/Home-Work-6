using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    delegate List<string[]> DelSort();

    static class WorkingFiles
    {
        public static List<string[]> list = new List<string[]>();

        /// <summary>
        /// Заполняем лист из файла
        /// </summary>
        static public void ReadStudents(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                while (!sr.EndOfStream)
                {
                    try
                    {
                        list.Add(sr.ReadLine().Split(';'));
                    }
                    catch { }
                }
            }
        }

        /// <summary>
        /// Подсчет студентов на курсах
        /// </summary>
        /// <param name = "value_a" > от курса</param>
        /// <param name = "value_b" > до курса</param>
        /// <returns>количество</returns>
        static public int Result(int value_a, int value_b)
        {
            int count = 0;
            try
            {
                for (int i = 0; i < list.Count; i++)
                {
                    string[] students = list[i];

                    if (int.Parse(students[6]) >= value_a && int.Parse(students[6]) <= value_b) { count++; }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return count;
        }

        /// <summary>
        /// Подсчет студентов на курсах по возрасту
        /// </summary>
        /// <param name = "value_a" > от лет</param>
        /// <param name = "value_b" > до лет</param>
        /// <returns>количество</returns>
        static public int[] ResultYears(int value_a, int value_b)
        {
            int[] count = new int[6];
            try
            {
                for (int i = 0; i < list.Count; i++)
                {
                    string[] students = list[i];

                    if (int.Parse(students[5]) >= value_a && int.Parse(students[5]) <= value_b)
                    {
                        count[int.Parse(students[6]) - 1]++;
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return count;
        }

        /// <summary>
        /// Сортировка студентов по возрасту
        /// </summary>
        static public List<string[]> SortStudent()
        {
            List<string[]> ResultList = new List<string[]>();
            try
            {
                for (int i = 13; i < 50; i++)
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        string[] students = list[j];

                        if (int.Parse(students[5]) == i)
                        {
                            ResultList.Add(students);
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return ResultList;
        }

        /// <summary>
        /// Сортировка студентов по возрасту и по курсу
        /// </summary>
        static public SortedDictionary<string, string[]> SortStudentYearAndClass()
        {
           SortedDictionary<string, string[]> dictionary = new SortedDictionary<string, string[]>();
            string[,][] count = new string[6,30][];
            try
            {
                for (int i = 0; i < list.Count; i++)
                {
                    string[] students = list[i];
                    dictionary.Add($"{students[5]} - {students[6]} - {i}", students);
                }

            }
            catch (Exception)
            {

                throw;
            }
            return dictionary;
        }
    }
}
