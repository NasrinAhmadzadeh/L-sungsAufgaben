using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sub
{
    
    
    class Program
    {
        private static List<Product> Produculist;
        private static Basket basket = new Basket();
        static void Main(string[] args)
        {
            Init();
            Console.WriteLine(" Geben Sie bitte Ihre Brieftasche ein:");
            var Budget = Console.ReadLine();
            basket.Budget = double.Parse(Budget);
            string Userkey = "";
            Console.WriteLine("Geben Sie bitte die Product und deren Anzahl mit lehrer Zeichnen ein:");
            while (Userkey != "q")
            {
                Userkey = GetProductFromUser(double.Parse(Budget));
                if (Userkey == "q" && basket.Basketprodukt.Count < 4)
                {
                    Console.WriteLine("Mindestens 4 Waren !!!");
                    Userkey = "";

                }

            }
            basket.Closebasket();
            Console.ReadLine();
        }

            private static string GetProductFromUser(double budget)
            {
                Product product = new Product();
                var readstring = Console.ReadLine();
                var splitware = readstring.Split(' ');
                if (splitware.Length == 2)
                {
                    string nameproduct = splitware[0];
                    int numberproduct = int.Parse(splitware[1]);
                    bool find = false;

                    for (int i=0;i<Produculist.Count;i++)
                    {
                        if (Produculist[i].Name.Trim().ToLower().Equals(nameproduct.Trim().ToLower())) ;
                        {
                            find = true;
                            product = Produculist[i];
                        }
                    }
                    if (find==true)
                    {
                        Console.WriteLine(product.Name + "  " + numberproduct + " x" + product.Price + "Euro");
                        basket.Basketprodukt.Add(new Tuple<Product, int>(product, int.Parse(splitware[2])));

                        Console.WriteLine("Remain:" + (basket.Budget-basket.Totalprice) + "Euro");
                         if ( budget-basket.Totalprice<0)
                        {
                            Console.WriteLine("Reicht nicht:enter to Exit");
                            Console.ReadLine();
                            Environment.Exit(0);

                        }
                    }
                }

                return readstring;
               
            }
        
        private static void Init()
        {
           Produculist = new List<Product>();
            Produculist.Add(new Product(1, "Würst",1.80));
            Produculist.Add(new Product(2, "Käse", 2.20));
            Produculist.Add(new Product(3, "Brot", 5.80));
            Produculist.Add(new Product(4, "Milch", 2.80));

            Console.WriteLine("..............................................");
            for (int i = 0; i < Produculist.Count; i++)
            {
                Console.WriteLine("ID:" + Produculist[i].Id + "Name:" + Produculist[i].Name + "Price:" + Produculist[i].Price + "Euro");
            }
                Console.WriteLine("...............................................");
            }
        }
    }
   


    

