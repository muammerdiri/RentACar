using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.DTOs;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId


                             select new CarDetailDto
                             {

                                 CarId = c.CarId,
                                 ColorName = co.ColorName,
                                 BrandName = b.BrandName,
                                 CarName = c.CarName,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,
                                 CarImages = ((from ci in context.CarImages
                                               where (c.CarId == ci.CarId)
                                               select new CarImage
                                               {
                                                   Id = ci.Id,
                                                   CarId = ci.CarId,
                                                   Date = ci.Date,
                                                   ImagePath = ci.ImagePath
                                               }).ToList()).Count == 0
                                                    ? new List<CarImage> { new CarImage { Id = -1, CarId = c.CarId, Date = DateTime.Now, ImagePath = "/images/default.jpg" } }
                                                    : (from ci in context.CarImages
                                                       where (c.CarId == ci.CarId)
                                                       select new CarImage
                                                       {
                                                           Id = ci.Id,
                                                           CarId = ci.CarId,
                                                           Date = ci.Date,
                                                           ImagePath = ci.ImagePath
                                                       }).ToList()
                             };

                return filter == null
                ? result.ToList()
                : result.Where(filter).ToList();


            };

            
            
        }
    }
}
