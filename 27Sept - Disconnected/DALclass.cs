using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace DAL
{
    public class DALclass
    {
        SqlConnection cn = null;
       
        SqlDataAdapter da = null;

        DataSet ds = null;

        public DALclass()
        {
            ds = new DataSet();//in memory cache called DataSet
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["IMS"].ConnectionString);
        }

        private DataTable Connect()
        {
            da = new SqlDataAdapter("select * from COURSE", cn);

            //da takes the data from the database using a select query and will disconnect
            //from the database server once it fills/pushes the data to the DataSet
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "COURSE");//disconnect from our database server
                                     //Single dataset object can hold multiple tables inside it
                                     //To identify each table uniquely we can use a index or name.
                                     //index starts with 0, but better to work with name.
            DataTable dt_course = ds.Tables["course"];
            return dt_course;
        }
        private DataTable Connectstudent()
        {
            da = new SqlDataAdapter("select * from student", cn);

            //da takes the data from the database using a select query and will disconnect
            //from the database server once it fills/pushes the data to the DataSet
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "student");//disconnect from our database server
                                  //Single dataset object can hold multiple tables inside it
                                  //To identify each table uniquely we can use a index or name.
                                  //index starts with 0, but better to work with name.
            DataTable dt_student = ds.Tables["student"];
            return dt_student;
        }

        public bool Insertcourse(course c)
        {
            DataTable dt_course = Connect();

            DataRow drow= dt_course.NewRow();

            drow["courseid"] = c.courseid;
            drow["coursename"] = c.coursename;
            drow["deptid"] = c.deptid;
            drow["duration"] = c.duration;


            dt_course.Rows.Add(drow);

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);

            // SqlCommandBuilder => TO MAKE DATTABLE (DATABASE) IN EDITABLE MODE

            int i = da.Update(ds.Tables["COURSE"]);

            //record added to the (original)database table

            bool status = false;

            if (i == 1)
            {
                status = true;
            }
            return status;


        }

        public bool Insertstudent(Student s)
        {
            DataTable dt_student = Connectstudent();

            DataRow drow = dt_student.NewRow();

            drow["studid"] = s.StudentId;
            drow["name"] = s.StudName;
            drow["crsid"] = s.CourseId;



            dt_student.Rows.Add(drow);

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);

            // SqlCommandBuilder => TO MAKE DATTABLE (DATABASE) IN EDITABLE MODE

            int i = da.Update(ds.Tables["student"]);

            //record added to the (original)database table

            bool status = false;

            if (i == 1)
            {
                status = true;
            }
            return status;


        }




    }
}
