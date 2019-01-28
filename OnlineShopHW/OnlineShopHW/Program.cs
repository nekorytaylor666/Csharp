using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopHW
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new OnlineShopContext())
            {
                Category molochnye = new Category
                {
                    Name = "Молочные продукты"
                };

                Product kefir = new Product
                {
                    Name = "Kefir",
                    Price = 240,
                    Category = molochnye
                };

                Shop small = new Shop
                {
                    Address = "Abaya 24"
                };

                small.Categories.Add(molochnye);
                kefir.Shop = small;
                small.Products.Add(kefir);

                context.SaveChanges();
            }
        }
    }
}
