using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GaitovaAA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.GaitovaAA.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вызов библиотеки DataService и метода Getmessage
            //из библиотеки Tyuiu.GaitovaAA.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Арина"));
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}