using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SugrovskiyNI.Sprint5.Task3.V22.Lib
{
    public class DataService : ISprint5Task3V22
    {
        public double SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.txt";


            double z = Math.Pow(1 - x, 2) / (-3 * x);

            z = Math.Round(z, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(z));
            }

            return z;
        }
    }
}

