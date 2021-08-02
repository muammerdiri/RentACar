using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs;
using Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {

        ICarDal _entityFramework;

        public CarManager(EfCarDal _entityFramework)
        {
            this._entityFramework = _entityFramework;
        }

        public void Add(Car car)
        {

            if (car.CarName.Length >= 2 && car.DailyPrice > 0)
            {
               
                 _entityFramework.Add(car);
            }
            else if (car.CarName.Length < 2)
            {
                Console.WriteLine("Lütfen iki karakter yada daha uzun bir isim giriniz");
            }
            else
            {
                
                Console.WriteLine("hatalı giriş");
            }
        }

        public void Delete(Car car)
        {
            _entityFramework.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _entityFramework.GetList();
        }

        public List<Car> GetByBrantId(int brandId)
        {
           return _entityFramework.GetList(p => p.BrandId == brandId);
        }

        public List<Car> GetByColorId(int colorId)
        {
            return _entityFramework.GetList(p => p.ColorId == colorId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _entityFramework.GetCarDetails();
        }

        public void Update(Car car)
        {
            _entityFramework.Update(car);
        }
    }
}