using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entitites.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            ColorTest();
            
            //BrandTest();
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand1 = new Brand { BrandId = 37, Name = "TOGG" };
            brandManager.Remove(brand1);
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name);
            }
        }

        public static void ColorTest()
        {
            Color color1 = new Color { Name = "Yavru agzi" };
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(color1);
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Name);  
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ModelYear + " " + car.Description + car.BrandId);
            }
        }
    }
}
