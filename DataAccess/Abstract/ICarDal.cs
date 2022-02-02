
using Entities.DTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using Core.DataAccess;
using System.Text;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null);

    }

   
}