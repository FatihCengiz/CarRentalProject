using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemory());

            carManager.Delete(new Car { CarId = 1 });//CarId = 1 olan elemanı siler

            
            carManager.Add(new Car
            { CarId = 5, BrandId = 3, ColorId = 2, ModelYear = 2010, DailyPrice = 18000, Description = "Diesel 1.7" });

            foreach (var car in carManager.GetAll())//listeyi dönüyoruz
            {
                Console.WriteLine(car.Description);
            }
            carManager.Delete(new Car { CarId = 1 });
            CarManager carManager1 = new CarManager(new InMemory());
        }
    }
}

