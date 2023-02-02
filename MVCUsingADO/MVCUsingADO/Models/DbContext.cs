using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

namespace MVCUsingADO.Models
{
    public class DbContext
    {
        readonly static string Cs = ConfigurationManager.ConnectionStrings["ADOcs"].ConnectionString;

        public static SqlConnection con = new SqlConnection(Cs);

        public static void Add(Category c)
        {
            SqlCommand cmd = new SqlCommand("sp_create", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.Parameters.AddWithValue("@category", c.CategoryName);
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }




        public static List<Category> GetData()
        {
            List<Category> data = new List<Category>();
            SqlCommand cmd = new SqlCommand("sp_alldata", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                data.Add(new Category
                {
                    Id = Convert.ToInt32(dr[0]),
                    CategoryName = Convert.ToString(dr[1])
                });
            }
            return data;
        }


        public static void Delete(Category c)
        {

            SqlCommand cmd = new SqlCommand("sp_delete", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", c.Id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


        }


        public static void Update(Category c)
        {
            SqlCommand cmd = new SqlCommand("sp_update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.Parameters.AddWithValue("@category", c.CategoryName);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

    }
}