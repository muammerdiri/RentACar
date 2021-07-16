
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

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car Name: "+car.Name);
            }
          /*  Car car2 = new Car();
            
           
                
                car2.Id = 2;
                car2.BrandId = 1;
                car2.Name = "Bmw";
                car2.ColorId = 2;
                car2.DailyPrice = 520;
                car2.Description = "Güzel araba offf";
                car2.ModelYear = "2020";

            carManager.Add(car2);

                Console.WriteLine("Eklendi");*/
            
            
            
        }
    }
}
