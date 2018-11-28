using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sub
{
   public class Product
    {
        
            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }

            public Product()
            {

            }
            public Product(int id, string name, double price)
            {
                Name = name;
                Id = id;
                Price = price;
            }
        }

    }

