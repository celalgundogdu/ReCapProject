using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Descriptions.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("Araba eklendi");
            }
            else
            {
                Console.WriteLine("Araba eklenemedi.\nAraba ismi en az iki karakter ve araba fiyatı sıfırdan büyük olmalıdır.");
            }
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            // business codes 
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(car => car.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(car => car.ColorId == colorId);   
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
