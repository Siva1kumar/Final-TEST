using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Mvcdress.Models
{
    public class datacompount
    {
        static string CONNECTIONSTRING = @"Data Source=RILPT182;Initial Catalog=Mall;Persist Security Info=True;User ID=sa;Password=sa123";

        public int Mall_id { get; private set; }
        public string Mall_name { get; private set; }

        private string dress_type;
        private int dress_price;
        private int dress_size;

        public List<datacompount> GetAllDresses()
        {
            var list = new List<datacompount>();
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                try
                {
                    con.Open();
                    SqlCommand sqlCmd = con.CreateCommand();
                    sqlCmd.CommandText = "SELECT * FROM SHOP";
                    var reader = sqlCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var shop = new datacompount();
                        shop.Mall_id = Convert.ToInt32(reader[0]);
                        shop.Mall_name = reader[1].ToString();
                        shop.dress_type = reader[2].ToString();
                        shop.dress_price = Convert.ToInt32(reader[3]);
                        shop.dress_size = Convert.ToInt32(reader[3]);
                        list.Add(shop);
                    }
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
            return list;
        }
    }
}