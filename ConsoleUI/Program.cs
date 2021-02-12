using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //GetAllTest(carManager);
            //CarAddTest(carManager);
            //GetCarDetailsTest(carManager);
            //GetByIdTest(carManager);
            //UpdateTest(carManager);
            //DeleteTest(carManager);

            //ColorAddTest(colorManager);
            //ColorDeleteTest(colorManager);
            //ColorUpdateTest(colorManager);
            ColorGetAllTest(colorManager);
            //ColorGetByIdTest(colorManager);

            //BrandAddTest(brandManager);
            //BrandDeleteTest(brandManager);
            //BrandUpdateTest(brandManager);
            //BrandGetAllTest(brandManager);
            //BrandgetByIdTest(brandManager);
        }

        private static void BrandgetByIdTest(BrandManager brandManager)
        {
            var result = brandManager.GetById(6);
            if (result.Success==true)
            {
                foreach (var brand in brandManager.GetById(6).Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void BrandUpdateTest(BrandManager brandManager)
        {
            brandManager.Update(new Brand { BrandId = 6, BrandName = "VolksWagen" });
        }

        private static void BrandDeleteTest(BrandManager brandManager)
        {
            brandManager.Delete(new Brand { BrandId = 6 });
        }

        private static void BrandGetAllTest(BrandManager brandManager)
        {
            var result = brandManager.GetAll();
            if (result.Success==true)
            {
                foreach (var brand in brandManager.GetAll().Data)
                {
                    Console.WriteLine(brand.BrandId + "/" + brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void BrandAddTest(BrandManager brandManager)
        {
            brandManager.Add(new Brand { BrandName = "Var" });
        }

        private static void ColorGetByIdTest(ColorManager colorManager)
        {
            var result = colorManager.GetById(2);
            if (result.Success==true)
            {
                foreach (var color in colorManager.GetById(2).Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }
        }

        private static void ColorGetAllTest(ColorManager colorManager)
        {
            var result = colorManager.GetAll();
            if (result.Success==true)
            {
                foreach (var color in colorManager.GetAll().Data)
                {
                    Console.WriteLine(color.ColorId + "/" + color.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void ColorUpdateTest(ColorManager colorManager)
        {
            colorManager.Update(new Color { ColorId = 1002, ColorName = "yeşil" });
        }

        private static void ColorDeleteTest(ColorManager colorManager)
        {
            colorManager.Delete(new Color { ColorId = 1002 });
        }

        private static void ColorAddTest(ColorManager colorManager)
        {
            colorManager.Add(new Color { ColorName = "Kırmızı" });
        }

        private static void DeleteTest(CarManager carManager)
        {
            carManager.Delete(new Car { Id = 3003 });
        }

        private static void UpdateTest(CarManager carManager)
        {
            carManager.Update(new Car { Id = 3, BrandId = 3, ColorId = 2, ModelYear = "2020", DailyPrice = 250, Description = "Otomatik", CarName = "Renault Megan" });
        }

        private static void GetByIdTest(CarManager carManager)
        {
            var result = carManager.GetById(1);
            if (result.Success==true)
            {
                foreach (var car in carManager.GetById(1).Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetAllTest(CarManager carManager)
        {
            var result = carManager.GetAll();
            if (result.Success==true)
            {
                foreach (var car in carManager.GetAll().Data)
                {
                    Console.WriteLine(car.Id + "/" + car.BrandId + "/" + car.ColorId + "/" + car.CarName + "/" + car.DailyPrice + "/" + car.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarAddTest(CarManager carManager)
        {
            carManager.Add(new Car { BrandId = 1, ColorId = 2, ModelYear = "2018", DailyPrice = 150, Description = "Manuel", CarName = "Hyundai i20" });
        }

        private static void GetCarDetailsTest(CarManager carManager)
        {
            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {
                foreach (var car in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
