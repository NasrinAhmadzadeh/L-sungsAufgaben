using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sub
{
    public class Basket
    {
        public List<Tuple<Product, int>>
        Basketprodukt = new List<Tuple<Product, int>>();
        public double Budget { get; set; }
        public double Totalprice
        {
            get
            {
                double totalprice = 0;
                for(int i = 0; i < Basketprodukt.Count; i++)
                {
                    totalprice += Basketprodukt[i].Item1.Price * Basketprodukt[i].Item2;
                }
                return totalprice;
            }
        }
        public void Closebasket()
        {
            Console.WriteLine(".............................................");
            for (int i = 0; i < Basketprodukt.Count; i++)
            {
                Console.WriteLine("      " + Basketprodukt[i].Item1.Name + +Basketprodukt[i].Item2 + "x" + Basketprodukt[i].Item1.Price + "Euro");
                Console.WriteLine("                    " + Basketprodukt[i].Item1.Price * Basketprodukt[i].Item2);
                Console.WriteLine(".....................................................");
                Console.WriteLine(" Gesamt                                 " + Totalprice + "Euro ");
                Console.WriteLine("Gegeben                                 " + Budget + "Euro");
                Console.WriteLine("Zrück                                   " + (Budget - Totalprice));
            }


        }
    }
     
}
