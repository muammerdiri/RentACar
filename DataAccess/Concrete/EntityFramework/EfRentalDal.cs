using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetail()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.CarId
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join u in context.Users
                             on r.UserId equals u.Id
                             select new RentalDetailDto
                             {    
                               
                                 BrandName=b.BrandName,
                                 FirstName=u.FirstName,
                                 LastName=u.LastName,
                                 RentDate = r.RentDate,
                                 ReturnTime = r.ReturnTime        
                             };
                return result.ToList();


            }
        }
    }
}
