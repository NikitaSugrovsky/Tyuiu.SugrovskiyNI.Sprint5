using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SugrovskiyNI.Sprint5.Task0.V22.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint5.Task0.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 3;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Сугровский Н. И. | ИИПб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Класс File. Запись данных в текстовый файл                                   *");
            Console.WriteLine("* Задание #0                                                                   *");
            Console.WriteLine("* Вариант #22                                                                  *");
            Console.WriteLine("* Выполнил: Сугровский Никита Игоревич | ИИПб-23-1                             *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3                              *");
            Console.WriteLine("* Результат сохранить в текстовый файл OutPutFileTask0.txt                     *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("*              (1-x)^2                                                         *");
            Console.WriteLine("*     y (x) = ----------                                                       *");
            Console.WriteLine("*               -3x                                                            *");
            Console.WriteLine("********************************************************************************");


            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            string res = ds.SaveToFileTextData(z);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан");
            Console.ReadKey();
        }
    }
}
