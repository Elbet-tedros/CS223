using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab111
{
    internal class Class1
    {

        public static List<Class1> Products = new List<Class1>();
        public int number { get; set; }
        public int price { get; set; }
        public int inventorNum { get; set; }
        public int count { get; set; }
        public string object_name { get; set; }
        public bool isAvailable { get; set; }
        public bool urgent { get; set; }
        public bool noturgent { get; set; }

        public void save()
        {
            string path = "Server=LAPTOP-2GJ2F7U2; Database=csharpdb; Integrated Security=true;";
            SqlConnection conn = new SqlConnection(path);
            
            string query = "Insert into dbtable values('"+ this.number +"','"+this.price+"','"+this.inventorNum+"','"+this.count+"','"+this.object_name+"');";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                
            }
            catch(Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
            conn.Close();
            Products.Add(this);
        }
        public static List<Class1> getAll()
        {
            string path = "Server=LAPTOP-2GJ2F7U2; Database=csharpdb; Integrated Security=true;";
            SqlConnection conn = new SqlConnection(path);
            string query = "select * from dbtable;";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Class1 item = new Class1();
                    item.number = (int)dr["num"];
                    item.price = (int)dr["price"];
                    item.inventorNum = (int)dr["invnum"];
                    item.count = (int)dr["ct"];
                    item.object_name = (string)dr["objname"];
                    Products.Add(item);
                }
            }catch(Exception e3)
            {
                MessageBox.Show(e3.Message);
            };
            conn.Close();
            return Products;
        }
        public static Class1 findOne(string name)
        {
            string path = "Server=LAPTOP-2GJ2F7U2; Database=csharpdb; Integrated Security=true;";
            SqlConnection conn = new SqlConnection(path);
            string query = "select * from dbtable;";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Class1 item = new Class1();
                    item.number = (int)dr["num"];
                    item.price = (int)dr["price"];
                    item.inventorNum = (int)dr["invnum"];
                    item.count = (int)dr["ct"];
                    item.object_name = (string)dr["objname"];
                    Products.Add(item);
                }
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.Message);
            };
            conn.Close();
            return Products.Find(Products => Products.object_name == name);
        }
    }
}
