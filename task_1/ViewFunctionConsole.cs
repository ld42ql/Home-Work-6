using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    delegate string Info(string msg);

    /// <summary>
    /// Выводим в консоль результаты работы функций
    /// </summary>
    static class ViewFunctionConsole
    {
        static double x, y, a;

        static public void ConsoleTable()
        {
            Console.Write("Введите \"х\":");
            if (!Double.TryParse(Console.ReadLine(), out x))
            {
                ConsoleWronf(Function.WrongMSG, x);
            }

            Console.Write("Введите до какого числа \"х\" строить таблицу :");
            if (!Double.TryParse(Console.ReadLine(), out a))
            {
                ConsoleWronf(Function.WrongMSG, a);
            }

            Console.WriteLine(Table.TableOneValue(Math.Atan, x, a));

            Console.WriteLine(Table.TableOneValue(new FunOneValue(Math.Atan), x, a));

            Console.WriteLine("Таблица функции MyFunc:");
            Console.WriteLine(Table.TableOneValue(new FunOneValue(Function.MyFunc), x, a));

            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
            Console.WriteLine(Table.TableOneValue(Function.MyFunc, x, a));//Упрощение(c C# 2.0). Делегат создается автоматически. 

            Console.WriteLine("Таблица функции Sin:");
            Console.WriteLine(Table.TableOneValue(Math.Sin, x, a));//Можно передавать уже созданные функции
            Console.WriteLine("Таблица функции x^2:");

            //Упрощение(с C# 2.0). Использование анонимного метода
            Console.WriteLine(Table.TableOneValue(delegate (double x)
            {
                return x * x;
            }, 0, 3));

            Console.Write("Введите \"х\":");
            if (!Double.TryParse(Console.ReadLine(), out x))
            {
                ConsoleWronf(Function.WrongMSG, x);
            }
            Console.Write("Введите \"y\":");
            if (!Double.TryParse(Console.ReadLine(), out y))
            {
                ConsoleWronf(Function.WrongMSG, y);
            }

            Console.Write("Введите до какого числа \"х\" строить таблицу :");
            if (!Double.TryParse(Console.ReadLine(), out a))
            {
                ConsoleWronf(Function.WrongMSG, a);
            }

            Console.WriteLine("Таблица функции a*x^2:");
            Console.WriteLine(Table.TableTwoValue(Function.MyFunc3, x, y, a));

            Console.WriteLine("Таблица функции a*sin(x):");
            Console.WriteLine(Table.TableTwoValue(new FunTwoValue(Function.MyFunc4), x, y, a));

        }

        
        static void ConsoleWronf(Info wrong, double value)
        {
            Console.WriteLine(wrong(Convert.ToString(value)));
        }
    }
}
   
