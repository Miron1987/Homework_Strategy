using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BMWClass bmw = new BMWClass();

            bmw.CreateCar();
            Console.WriteLine();
            bmw.SetCarCreation(new AddBMWSeriesOne());
            Console.WriteLine();
            bmw.SetCarCreation(new AddBMWSeriesTwo());
            Console.WriteLine();
            bmw.SetCarCreation(new AddBMWSeriesThree());
            Console.WriteLine();
            bmw.SetCarCreation(new AddBMWSeriesFour());
            Console.WriteLine();
            bmw.SetCarCreation(new AddBMWSeriesFive());

        }
    }
}
