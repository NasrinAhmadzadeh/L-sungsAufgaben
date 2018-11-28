using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarKeeperDB
{
    public class DBManager
    {
        string connectionString =
       "Data Source=DE-ADN-BCSDTQ2\\SQLEXPRESS;Initial Catalog=Bar;"
       + "Integrated Security=true";

        SqlConnection connection = new SqlConnection();
        public void SelectZutat()
        {

            connection.ConnectionString = connectionString;
            connection.Open();
            SqlCommand com = new SqlCommand();
            string selectZutat = "Select * from dbo.Table_Zutat";
            try
            {
                com.Connection = connection;
                com.CommandText = selectZutat;
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("\t{0}\t{1}",
                            reader[0], reader[1]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


        }


        public void SelectFrucht()
        {


            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            SqlCommand com = new SqlCommand();
            string selectFrucht = "Select * from dbo.Frucht";

            try
            {
                com.Connection = connection;
                com.CommandText = selectFrucht;
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}",
                            reader[0], reader[1], reader[2]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }



        public void SelectGetränk()

        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            SqlCommand com = new SqlCommand();
            string SelectGetränk = " Select * from dbo.Table_Getränk";

            try
            {
                com.Connection = connection;
                com.CommandText = SelectGetränk;

                SqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}",
                            reader[0], reader[1], reader[2], reader[3], reader[4]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }


        public void SelectGetränkZutat()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            SqlCommand com = new SqlCommand();
            string GetränkZutat = "select * from dbo.Table_GetränkZutat";

            try
            {
                com.Connection = connection;
                com.CommandText = GetränkZutat;
                SqlDataReader reader = com.ExecuteReader();

                while(reader.Read())
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}",
                            reader[0], reader[1], reader[2], reader[3]);
                }
                reader.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        public void FruchtZutat()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            SqlCommand com = new SqlCommand();
            string FruchtZutat = "Select * from dbo.Table_FruchtZutat";
             try
            {
                com.Connection = connection;
                com.CommandText = FruchtZutat;

                SqlDataReader reader = com.ExecuteReader();
                 while (reader.Read())
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}",
                            reader[0], reader[1], reader[2], reader[3]);
                }
                reader.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

    }
    }



   

 

