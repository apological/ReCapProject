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

            Console.WriteLine("~~.car1 eklendikten sonra.~~");
            carManager.Add(car1);


            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id);
            }

            

        }
    }
}
