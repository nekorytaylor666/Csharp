using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Model1())
            {
                var libarian1 = new Libarian
                {
                    Name = "Artem",

                };
                var customer1 = new Customer
                {
                    Name = "ANNA"
                };
                var book1 = new Book
                {
                    BookName = "Eragon"
                };
                context.Books.Add(book1);
                context.Customers.Add(customer1);
                context.Libarians.Add(libarian1);
            }

        }
    }
}
