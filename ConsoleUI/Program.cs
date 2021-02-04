using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;
using Entities.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Car car1 = new Car {Id=7, BrandId=5, ColorId=2, DailyPrice=500, ModelYear=2021, Description="Son Model Araba" };
            Car car2 = new Car { Id = 8, BrandId = 3, ColorId = 1, DailyPrice = 200, ModelYear = 2008, Description = "Eski Kasalı Araba" };

            //car1'i ekledik ve listeyi ekrana yazdırdık 
            Console.WriteLine("---------------car1 eklendikten sonra---------------");
            carManager.Add(car1);
            carManager.Add(car2);

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
            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("------Seçilen markaya sahip olan arabalar------");
            foreach (var car in carManager.GetCarsByBrandId(4))
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
