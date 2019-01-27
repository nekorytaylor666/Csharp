using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoMigrationsHW
{
    public class CarShop
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public List<Car> Cars { get; set; }

        public CarShop()
        {
            Cars = new List<Car>();
        }
    }
}
