using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_DB.DataManager
{
    public class FileNameManager
    {

        string conStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=CU;Integrated Security = true";   
        public void InsertFileName(string fileName)
        {
            using (SqlConnection openCon = new SqlConnection(conStr))
            {
                string saveFileQuery = "INSERT into dbo.FileName (Name) VALUES ('" + fileName + "')";

                using (SqlCommand querySaveStaff = new SqlCommand(saveFileQuery))
                {
                    querySaveStaff.Connection = openCon;

                    openCon.Open();
                    querySaveStaff.ExecuteNonQuery();

                }
            }
        }

        public int CheckFileName(string fileName)
        {
            int count;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.FileName where Name='" + fileName + "'", con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    count = dt.Rows.Count;
                }
                con.Close();
            }
            return count;
        }
    }
}
