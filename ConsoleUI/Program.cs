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
            // 1. Gün Test
            //CarManager carManager = new CarManager(new InMemoryCarDal());
            //foreach (Car car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.BrandId + " " + car.ModelYear);
            //}

            // 2. Gün Test
            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetCarsByBrandId(3))
            //{
            //    Console.WriteLine(car.Descriptions + " " + car.DailyPrice);
            //}
            //Console.WriteLine("-------------------------");
            //foreach (var car in carManager.GetCarsByColorId(1))
            //{
            //    Console.WriteLine(car.Descriptions + " " +car.DailyPrice);
            //}

            // 3. Gün Test
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
            Console.WriteLine("---------------------------------");
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarId + " - "+ car.BrandName + " - " + car.ColorName + " - " + car.DailyPrice);
            }

            Console.Read();
        }
    }
}
