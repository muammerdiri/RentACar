using System;
using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using Business.Contants;
using Core.Utilities.Results;
using Core.Utilities.Business.BusinessRules;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Core.Utilities.Helper.FileHelper.Core.Utilities.Helper.FileHelpers;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }
       
        public IResult Add(IFormFile file, CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckCarImageLimit(carImage.CarId));

            if (result != null)
            {
                return result;
            }

            carImage.ImagePath = ImageFileHelper.Add(file);
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult();
        }
 
        public IResult Delete(CarImage carImage)
        {
            ImageFileHelper.Delete(carImage.ImagePath);
            _carImageDal.Delete(carImage);
            return new SuccessResult();
        }
  

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetList(), Messages.ImagesListed);
        }
  
        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.Id == id), Messages.ImageFound);
        }

        public IDataResult<List<CarImage>> GetCarImageByCarId(int carId)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetList(x => x.CarId == carId), Messages.ImagesListed);
        }

        
        public IResult Update(IFormFile file, CarImage carImage)
        {
            carImage.ImagePath = ImageFileHelper.Update(_carImageDal.Get(c => c.Id == carImage.Id).ImagePath, file);
            carImage.Date = DateTime.Now;
            _carImageDal.Update(carImage);
            return new SuccessResult();
        }




        private IResult CheckCarImageLimit(int carId)
        {
            var CarImages = _carImageDal.GetList(c => c.CarId == carId).Count;
            if (CarImages >= 5)
            {
                return new ErrorResult("Message.CarImageLimit");
            }

            return new SuccessResult();
        }
        private List<CarImage> ShowDefaultImage(int carId)
        {
            string path = @"\Images\ghost.png";
            var result = _carImageDal.GetList(c => c.CarId == carId).Any();

            if (result)
            {
                return new List<CarImage>(_carImageDal.GetList(c => c.CarId == carId));
            }

            List<CarImage> carImage = new List<CarImage>();
            carImage.Add(new CarImage { CarId = carId, ImagePath = path, Date = DateTime.Now });

            return new List<CarImage>(carImage);
        }
    }
}