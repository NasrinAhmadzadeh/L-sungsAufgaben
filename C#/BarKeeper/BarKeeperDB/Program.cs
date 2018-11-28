using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
    
namespace BarKeeperDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ZutatTable");
            var dbManager = new DBManager();
            dbManager.SelectZutat();
            //Console.Read();
            // Console.ReadKey();


            Console.WriteLine("........................................");
            Console.WriteLine("FruchtTable");
            dbManager.SelectFrucht();
            // Console.Read();

            Console.WriteLine("...........................................");
            Console.WriteLine("GetränkTable");
            dbManager.SelectGetränk();
            //Console.Read();

            Console.WriteLine("............................................");
            Console.WriteLine("GetränkZutat");
            dbManager.SelectGetränkZutat();
            //Console.Read();


            Console.WriteLine("....................................................");
            Console.WriteLine("FruchtZutat");
            dbManager.FruchtZutat();
            Console.Read();
        }
    }
}
