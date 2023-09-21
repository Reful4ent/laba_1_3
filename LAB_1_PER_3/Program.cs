using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAB_1_PER_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void ToContinue()
            {
                Console.Write("\nНажмите любую клавишу...");
                Console.ReadKey();
                Console.Clear();
            }
         

            /*string forColor;
            int _color;

            string forInAir, forInWater;
            int _inAir, _inWater;

            string forBasePrice;
            double _basePrice;

            Flower flower = new Flower();

            void Print()
            {
                Console.WriteLine("Название: {0}", flower.Name);
                Console.WriteLine("Цвет: {0}", flower.Color);
                Console.WriteLine("Состояние цветка: {0}", flower.State);
                Console.WriteLine("Скорость, за которую цветок завянет на воздухе: {0}", flower.FadingInAir);
                Console.WriteLine("Скорость, за которую цветок завянет в воде: {0}", flower.FadingInWater);
                Console.WriteLine("Базовая стоимость: {0}", flower.BasePrice);
                Console.WriteLine("Реальная стоимость: {0}", flower.RealPrice());

                if (flower.InWater)
                    Console.WriteLine("Цветок находится в воде");
                else
                    Console.WriteLine("Цветок находится на воздухе");

                if (flower.State == 0)
                    Console.WriteLine("Цветок завял");
                else
                    Console.WriteLine("Цветок не завял");
            }


            //цветок 1
            Console.Write("Введите название цветка: ");
            try
            {
                flower.Name = Console.ReadLine();
            }
            catch (ArgumentException e) { Console.WriteLine(e.Message); }
            ToContinue();

            Console.Write("Введите цвет (0 - Красный, 1 - Зеленый, 2 - Синий): ");
            do forColor = Console.ReadLine();
            while (!int.TryParse(forColor, out _color));
            flower.Color = (Color)(_color % 3);
            ToContinue();

            Console.Write("Введите количество часов, через которые цветок завянет на воздухе: ");
            do forInAir = Console.ReadLine();
            while (!int.TryParse(forInAir, out _inAir));
            try
            {
                flower.FadingInAir = _inAir;
            }
            catch (ArgumentException e) { Console.WriteLine(e.Message); }
            ToContinue();

            Console.Write("Введите количество часов, через которые цветок завянет в воде: ");
            do forInWater = Console.ReadLine();
            while (!int.TryParse(forInWater, out _inWater));
            try
            {
                flower.FadingInWater = _inWater;
            }
            catch (ArgumentException e) { Console.WriteLine(e.Message); }
            ToContinue();

            Console.Write("Введите базовую цену: ");
            do forBasePrice = Console.ReadLine();
            while (!double.TryParse(forBasePrice, out _basePrice));
            try
            {
                flower.BasePrice = _basePrice;
            }
            catch (ArgumentException e) { Console.WriteLine(e.Message); }
            ToContinue();

            Print();
            ToContinue();

            Console.WriteLine("Сдвиг внутренних часов на 5");
            flower.MoveInnerClock(5);
            Print();
            ToContinue();



            Console.WriteLine("Перемещение цветка в воду");
            flower.InWater = true;
            Print();
            ToContinue();


            Console.WriteLine("Сдвиг внутренних часов на 4");
            flower.MoveInnerClock(4);
            Print();*/










            //Букет
            int n = 0;
            string _n;
            Bouqet bouquet = new Bouqet();
            void PrintForBouquet()
            {
                Console.WriteLine("Базовая цена букета: {0}", bouquet.GetBasePrice());
                Console.WriteLine("Настоящая цена букета: {0}", bouquet.GetRealPrice());
                Console.WriteLine("Количество цветов в букете: {0}", bouquet.Size());
                Console.WriteLine("Количество завядших цветков в букете: {0}", bouquet.NumOfWithered());
                Console.WriteLine("Cocтояние букета: {0}", bouquet.GetState());
                ToContinue();
            }
            Flower _flower = new Flower();
            Console.Write("Введите количество цветов в букете: ");
            do _n = Console.ReadLine();
            while (!int.TryParse(_n, out n));
            Console.Clear();
            for (int i = 0; i < n; i++)
            {
                string _forName;
                string _forColor;
                int __color;

                string _forInAir, _forInWater;
                int __inAir, __inWater;

                string _forBasePrice;
                double __basePrice;
                
                while (true)
                {
                    Console.Write("Введите название цветка: ");
                    _forName = Console.ReadLine();
                    try
                    {
                       _flower.Name = _forName;
                    }
                    catch (ArgumentException e)
                    {
                        _forName = _flower.Name;
                        Console.WriteLine(e.Message);
                    }
                    finally
                    {
                        _flower.Name = _forName;
                    }
                    ToContinue();

                    Console.Write("Введите цвет (0 - Красный, 1 - Зеленый, 2 - Синий): ");
                    do _forColor = Console.ReadLine();
                    while (!int.TryParse(_forColor, out __color));
                    ToContinue();

                    Console.Write("Введите количество часов, через которые цветок завянет на воздухе: ");
                    do _forInAir = Console.ReadLine();
                    while (!int.TryParse(_forInAir, out __inAir));
                    try
                    {
                        _flower.FadingInAir = __inAir;
                    }
                    catch (ArgumentException e)
                    {
                        __inAir = (int)_flower.FadingInAir;
                        Console.WriteLine(e.Message);
                    }
                    finally
                    {
                        _flower.FadingInAir = __inAir;
                    }
                    ToContinue();

                    Console.Write("Введите количество часов, через которые цветок завянет в воде: ");
                    do _forInWater = Console.ReadLine();
                    while (!int.TryParse(_forInWater, out __inWater));
                    try
                    {
                        _flower.FadingInWater = __inWater;
                    }
                    catch (ArgumentException e)
                    {
                        __inWater = (int)_flower.FadingInWater;
                        Console.WriteLine(e.Message);
                    }
                    finally
                    {
                        _flower.FadingInWater = __inWater;
                    }
                    ToContinue();

                    Console.Write("Введите базовую цену: ");
                    do _forBasePrice = Console.ReadLine();
                    while (!double.TryParse(_forBasePrice, out __basePrice));
                    try
                    {
                        _flower.BasePrice = __basePrice;
                    }
                    catch (ArgumentException e)
                    {
                        __basePrice = _flower.BasePrice;
                        Console.WriteLine(e.Message);
                    }
                    finally
                    {
                        _flower.BasePrice = __basePrice;
                    }
                    ToContinue();

                    bouquet.AddFlower(_forName, (Color)(__color % 3), __inAir, __inWater, __basePrice);
                    break;

                }
            }

            bouquet.PrintBouguet();
            PrintForBouquet();
            try
            {
                bouquet.RemoveFlower(0);
            }
            catch (ArgumentException e) { Console.WriteLine(e.Message); }


            bouquet.PrintBouguet();
            PrintForBouquet();

            Console.WriteLine("Перемещаем букет в воду:");
            bouquet.SetPlacement(true);
            bouquet.PrintBouguet();
            PrintForBouquet();

            Console.WriteLine("Сдвигаем часы:");
            bouquet.MoveInnerClock(5);
            bouquet.PrintBouguet();
            PrintForBouquet();

            Console.WriteLine("Удаляем завядшие цветы:");
            bouquet.RemoveWithered();
            bouquet.PrintBouguet();
            PrintForBouquet();

        }
    }
}
