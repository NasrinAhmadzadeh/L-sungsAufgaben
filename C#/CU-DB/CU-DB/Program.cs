using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CU_DB.DataManager;


namespace CU_DB
{
   public class Program
    {
        static void Main(string[] args)
        {
            var diagnossDataManager = new DiagnosseDataManager();

            Console.WriteLine("Enter your Directory Path:");
            var path = Console.ReadLine();


            //var dt = diagnossDataManager.GetDataTableFromCsv(path);
            //diagnossDataManager.InsertDataIntoSql(dt);4

            FileManager fileManager = new FileManager();
            fileManager.InsertFromFolder(path);

            Console.ReadKey();
           



        }
    }
}
