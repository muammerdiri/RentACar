
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

using System;

namespace ConsoleUI
{
    class Program
    {
        public static void Main(string[] args)
        {


            RentalTest();


        }

        private static void RACTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //foreach (var car in carManager.GetByDailyPrice(500, 950).Data)
            //{
            //    Console.WriteLine(car.DailyPrice);
            //}
            //foreach (var car in carManager.GetAllByBrandId(2).Data)
            //{
            //    Console.WriteLine(car.ModelYear);
            //}
            //foreach (var car in carManager.GetCarsByColourId(4).Data)
            //{
            //    Console.WriteLine(car.ModelYear);
            //}

        }
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //var result = carManager.GetAll();

            //if (result.Success == true)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine(car.Description + "  " + car.BrandId);

            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}
            // carManager.Add(new Car() { BrandId = 1, ColourId = 3, DailyPrice = 775,ModelYear=2016, Description = "165 Hp" });
            //carManager.Update(new Car() {Id=1002, BrandId = 1, ColourId = 3, DailyPrice = 625, ModelYear = 2016, Description = "156 Hp" });
            //carManager.Remove(new Car() { Id = 1003 });
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}
            //Console.WriteLine(carManager.GetById(3).Description);
            //var result = carManager.GetCarDetails();
            //foreach (var c in result)
            //{
            //    Console.WriteLine(c.Id + " " + c.BrandName + " " + c.ColourName + " " + c.DailyPrice + " ");
            //}

        }
        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //var result = brandManager.GetAll();

            //if (result.Success == true)
            //{
            //    foreach (var brand in result.Data)
            //    {
            //        Console.WriteLine(brand.BrandName+ "  " + brand.BrandId);

            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}
            //Console.WriteLine(brandManager.GetById(1).BrandName);
            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName);
            //}
            //brandManager.Add(new Brand() { BrandName = "Aston Martin" });
            //brandManager.Update(new Brand() { BrandId = 1002, BrandName = "Tofaş" });
            //brandManager.Remove(new Brand() { BrandId = 1002 });
        }
        public static void ColourTest()
        {
            ColorManager colourManager = new ColorManager(new EfColorDal());
            //var result = colourManager.GetAll();

            //if (result.Success == true)
            //{
            //    foreach (var colour in result.Data)
            //    {
            //        Console.WriteLine(colour.ColourName + "  " + colour.ColourId);

            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}
            //Console.WriteLine(colourManager.GetById(2).ColourName);
            //foreach (var colour in colourManager.GetAll())
            //{
            //    Console.WriteLine(colour.ColourName);
            //}
            //colourManager.Add(new Colour() { ColourName = "Eflatun" });
            //colourManager.Update(new Colour() { ColourId = 1002, ColourName = "Morcivert" });
            //colourManager.Remove(new Colour() { ColourId = 1002 });
        }
        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //customerManager.Add(new Customer { CustomerId = 10, CompanyName = "Samsung", UserId = 10 });
            //customerManager.Add(new Customer { CustomerId = 11, CompanyName = "Opel", UserId = 11 });
        }
        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Rental rental1 = new Rental();
            rental1.Id = 15;
            rental1.CustomerId = 15;
            rental1.RentDate = new DateTime(2021, 07, 19);
            rental1.ReturnTime = new DateTime(2021, 07, 25);
            var result = rentalManager.Add(rental1);
            Console.WriteLine(result.Message);

        }
    }
}
