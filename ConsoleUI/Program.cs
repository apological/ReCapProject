using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Car car1 = new Car {Id=7, BrandId=2, ColorId=1, DailyPrice=450, ModelYear=2021, Description="Son Model Araba" };


            //car1'i ekledik ve listeyi ekrana yazdırdık 
            Console.WriteLine("---------------car1 eklendikten sonra---------------");
            carManager.Add(car1);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            //car1'i sildik ve listeyi ekrana yazdırdık
            Console.WriteLine("---------------car1 silindikten sonra---------------");
            carManager.Delete(car1);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            //Seçtiğimiz brand ve color id'ye sahip olan tüm arabaları listeledik
            Console.WriteLine("-------Seçilen renge sahip olan arabalar-------");
            foreach (var car in carManager.GetAllByColor(2))
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("------Seçilen markaya sahip olan arabalar------");
            foreach (var car in carManager.GetAllByBrand(2))
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
