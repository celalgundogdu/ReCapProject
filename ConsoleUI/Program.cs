using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new InMemoryCarDal());
            //foreach (Car car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.BrandId + " " + car.ModelYear);
            //}

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByBrandId(3))
            {
                Console.WriteLine(car.Descriptions + " " + car.DailyPrice);
            }
            Console.WriteLine("-------------------------");
            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(car.Descriptions + " " +car.DailyPrice);
            }

            Console.Read();
        }
    }
}
