using Business.Abstract;
using Business.Contants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {

        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        
        public IResult Add(Rental rental)
        {
           
            if (!CarDeliveryVerification(rental.CarId))
            {
                return new ErrorResult(Messages.CarNotRented);
            }
            
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.CarRented);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>( _rentalDal.GetList(), Messages.RentalsListed);
        }
        

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdate);
        }
        public bool CarDeliveryVerification(int id)
        {
            var result = _rentalDal.Get(r => r.CarId == id && r.ReturnTime == null);

            if (result==null)
            {
                return true;
            }
            return false;
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id)); 
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetail()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetail());
        }
    }
}
