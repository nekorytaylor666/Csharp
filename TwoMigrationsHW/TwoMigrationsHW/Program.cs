using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoMigrationsHW
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new CarShopContext())
            {
                Car car1 = new Car
                {
                    Model = "Mercedes",
                    Color = "Red",
                    Price = 20000
                };

                context.Cars.Add(car1);

                CarShop carshop = new CarShop
                {
                    Address = "Abaya 25"
                };

                carshop.Cars.Add(car1);
                context.CarShops.Add(carshop);
                context.SaveChanges();
            }
        }
    }
}
