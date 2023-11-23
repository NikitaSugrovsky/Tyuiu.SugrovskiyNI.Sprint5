using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.SugrovskiyNI.Sprint5.Task6.V4.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint5.Task6.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Сугровский Н. И. | ИИПб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #6                                                                    *");
            Console.WriteLine("* Обработка текстовых файло                                                    *");
            Console.WriteLine("* Задание #6                                                                   *");
            Console.WriteLine("* Вариант #4                                                                   *");
            Console.WriteLine("* Выполнил: Сугровский Никита Игоревич | ИИПб-23-1                             *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask6V4.txt (файл взять из архива     *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:\\DataSprint5\\   и       *");
            Console.WriteLine("* скопировать в неё файл) в котором есть набор символьных данных.Найти         *");
            Console.WriteLine("* количество заглавных русских букв в заданной строке.                         *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask6V4.txt";

            Console.WriteLine("Данные находятся в файле: " + path);


            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Количество заглавных русских букв  " + res);
            Console.ReadKey();
        }
    }
}
