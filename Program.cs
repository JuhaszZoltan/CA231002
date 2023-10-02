using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA231002
{
    internal class Program
    {
        static void Main()
        {
            var autok = new List<Auto>();
            using (var sr = new StreamReader(@"..\..\src\onvezeto.txt", Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                {
                    autok.Add(new Auto(sr.ReadLine()));
                }
            }
            var f3 = autok.OrderBy(a => a.Gyorsulas).Last();
            Console.WriteLine("3. feladat: leggyorsabb auto:");
            Console.WriteLine($"\tModel: {f3.Model}\n" +
                $"\tTeljesitmeny: {f3.Teljesitmeny} le.\n" +
                $"\tTomeg: {f3.Tomeg} t\n" +
                $"\tGyorsulas: {f3.Gyorsulas} sec to 100kmph\n" +
                $"\tBeavatkozas/10K km: {f3.NoBeavatkozas}");

            var f4 = autok.OrderBy(a => a.NoBeavatkozas).Last();
            Console.WriteLine("4. feladat: legkevesbe onnállo auto:");
            Console.WriteLine($"\t{f4.Model}");

            var f6 = autok.Average(a => a.Tomeg);
            Console.WriteLine("6. feladat: autok atlagos tomege:");
            Console.WriteLine($"\t{f6:0.00} tonna");

            using (var sw = new StreamWriter(@"..\..\src\omegkgban.txt", false, Encoding.UTF8))
            {
                int id = 1;
                foreach (var a in autok)
                {
                    sw.WriteLine($"{id} {a.Tomeg*1000}");
                    id++;
                }
            }
            Console.ReadKey(true);
        }
    }
}
