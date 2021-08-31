using Business.Abstract;
using Business.Contants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {

        ICarDal _entityFramework;

        public CarManager(ICarDal _entityFramework)
        {
            this._entityFramework = _entityFramework;
        }

        public IResult Add(Car car)
        {

            if (car.CarName.Length <= 2 && car.DailyPrice <= 0)
            {
               
                Console.WriteLine(Messages.InvalidName);
            }
            _entityFramework.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _entityFramework.Delete(car);
            return new SuccessResult(Messages.CarDelete);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>( _entityFramework.GetList(),Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetByBrantId(int brandId)
        {
           return new SuccessDataResult<List<Car>> (_entityFramework.GetList(p => p.BrandId == brandId),Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>> (_entityFramework.GetList(p => p.ColorId == colorId),Messages.CarsListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>( _entityFramework.GetCarDetails(),Messages.CarsListed);
        }

        public IResult Update(Car car)
        {
            _entityFramework.Update(car);
            return new SuccessResult(Messages.CarUpdate);
        }
    }
}