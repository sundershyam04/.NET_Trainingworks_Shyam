using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingHandson
{
    public class LibraryDBoperations
    {
        SqlConnection cn;
        SqlCommand cmd;

        //public LibraryDBoperations()
        //{
             
        //}

        public string GetBookName()
        {
            cn = new SqlConnection("Data Source=DESKTOP-45VNN8N;Initial Catalog=Lib;Integrated Security=True");

            cmd = new SqlCommand("select Book_Name from LibBook where" +
               " Book_No= 871", cn);

            cn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                return dr[0].ToString();
            }

            cn.Close();
            

            return null;
        }

        public string GetBookAuthor()
        {
            cn = new SqlConnection("Data Source=DESKTOP-45VNN8N;Initial Catalog=Lib;Integrated Security=True");

            cmd = new SqlCommand("select Author from LibBook where" +
               " Book_No= 871", cn);

            cn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                return dr[0].ToString();
            }

            cn.Close();


            return null;
        }




    }
}
