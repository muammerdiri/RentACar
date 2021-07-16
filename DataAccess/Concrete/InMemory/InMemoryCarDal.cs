using DataAccess.Abstract;
using Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>{

               /* new Car{Id=1,BrandId=1,ColorId=2,DailyPrice=1000,ModelYear="2018",Description="Laborghini Aventedor"},
                new Car{Id=2,BrandId=4,ColorId=1,DailyPrice=500,ModelYear="2012",Description="Bmw i8"},
                new Car{Id=3,BrandId=2,ColorId=2,DailyPrice=750,ModelYear="2005",Description="Mercedes CLA 180"},
                new Car{Id=4,BrandId=2,ColorId=3,DailyPrice=600,ModelYear="2003",Description="Porsche Cayman"},
                new Car{Id=5,BrandId=3,ColorId=4,DailyPrice=300,ModelYear="2001",Description="Fiat Egea"},*/
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> fliter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p => p.Id == id).ToList();
        }

        public List<Car> GetList(Expression<Func<Car, bool>> fliter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);

            carToDelete.Id = car.Id;
            carToDelete.ColorId = car.ColorId;
            carToDelete.BrandId = car.BrandId;
            carToDelete.DailyPrice = car.DailyPrice;
            carToDelete.Description = car.Description;
            carToDelete.ModelYear = car.ModelYear;
        }
    }
}