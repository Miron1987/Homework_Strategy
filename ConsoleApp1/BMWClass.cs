using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BMWClass
    {

        IStrategy _strategy;

        public void CreateCar()
        {
            if (_strategy == null)
            {
                Console.WriteLine("Вы не выбрали стратегию создания автомобиля !!!");
                return;
            }

            _strategy.ToMadeCar();

        }

        public void SetCarCreation (IStrategy strategy)
        {
            _strategy = strategy;
        }
    }

    //интерфейс создания автомобилей
    interface IStrategy
    {
        void ToMadeCar();
    }

    class AddBMWSeriesOne : IStrategy
    {
        public void ToMadeCar()
        {
            Console.WriteLine("Создаем кузов модели BMW - 1");
            Console.WriteLine("Создаем двигатель модели BMW - 1");
            Console.WriteLine("Создаем электрику модели BMW - 1");
            Console.WriteLine("Создаем внутреннюю отделку модели BMW - 1");
            Console.WriteLine("Собираем BMW - 1");
        }

        public AddBMWSeriesOne() => this.ToMadeCar();
    }

    class AddBMWSeriesTwo : IStrategy
    {
        public void ToMadeCar()
        {
            Console.WriteLine("Создаем кузов модели BMW - 2");
            Console.WriteLine("Создаем двигатель модели BMW - 2");
            Console.WriteLine("Создаем электрику модели BMW - 2");
            Console.WriteLine("Создаем внутреннюю отделку модели BMW - 2");
            Console.WriteLine("Собираем BMW - 2");
        }

        public AddBMWSeriesTwo() => this.ToMadeCar();
    }

    class AddBMWSeriesThree : IStrategy
    {
        public void ToMadeCar()
        {
            Console.WriteLine("Создаем кузов модели BMW - 3");
            Console.WriteLine("Создаем двигатель модели BMW - 3");
            Console.WriteLine("Создаем электрику модели BMW - 3");
            Console.WriteLine("Создаем внутреннюю отделку модели BMW - 3");
            Console.WriteLine("Собираем BMW - 3");
        }

        public AddBMWSeriesThree() => this.ToMadeCar();
    }

    class AddBMWSeriesFour : IStrategy
    {
        public void ToMadeCar()
        {
            Console.WriteLine("Создаем кузов модели BMW - 4");
            Console.WriteLine("Создаем двигатель модели BMW - 4");
            Console.WriteLine("Создаем электрику модели BMW - 4");
            Console.WriteLine("Создаем внутреннюю отделку модели BMW - 4");
            Console.WriteLine("Собираем BMW - 4");
        }

        public AddBMWSeriesFour() => this.ToMadeCar();
    }

    class AddBMWSeriesFive : IStrategy
    {
        public void ToMadeCar()
        {
            Console.WriteLine("Создаем кузов модели BMW - 5");
            Console.WriteLine("Создаем двигатель модели BMW - 5");
            Console.WriteLine("Создаем электрику модели BMW - 5");
            Console.WriteLine("Создаем внутреннюю отделку модели BMW - 5");
            Console.WriteLine("Собираем BMW - 5");
        }

        public AddBMWSeriesFive() => this.ToMadeCar();
    }
}
