
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entitiy.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        public static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());


            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName);
                Console.WriteLine(car.ColorName);
                Console.WriteLine(car.BrandName);
                Console.WriteLine(car.DailyPrice);
                
                Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*");
            }

           
        }
    }
}
