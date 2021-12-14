
using Entities.DTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using Core.DataAccess;
using System.Text;


namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();

    }

   
}