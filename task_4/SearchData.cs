using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task_4
{
    class SearchData
    {
        string fileName = String.Empty;
        string formRegex = String.Empty;
        List<string> listFile = new List<string>();

        /// <summary>
        /// Поиск в файле по регулярным выражениям
        /// </summary>
        /// <param name="fileName">Название файла</param>
        /// <param name="formRegex">Регулярное выражение</param>
        public SearchData(string fileName, string formRegex)
        {
            this.fileName = fileName;
            this.formRegex = formRegex;
        }

        void ReadFile(string fileName)
        {
            try
            {
                using (StreamReader inputFile = File.OpenText(fileName))
                {
                    for (int i = 0; i < 1000; i++)
                    {
                        listFile.Add(inputFile.ReadLine());
                    }
                    
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Проверка по заданному регулярному выражению
        /// </summary>
        /// <returns></returns>
        public List<string> listRegex()
        {
            ReadFile(fileName);
            List<string> resuktList = new List<string>();
            Regex regex = new Regex(formRegex);
            foreach (var item in listFile)
            {
                if (regex.Match(item).Success) { resuktList.Add(item); }
            }
            return resuktList;
        }
    }
}
