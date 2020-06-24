using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Design_Dashboard_Modern
{
    public class DBConnection
    {
        /*public NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; " +
                "Port=5432;  Database=CourseDB; User Id=postgres;" +
                " Password=Engineer6544;");*/
        public NpgsqlConnection connection = new NpgsqlConnection("User ID=mdrzdnlvuxcogl;" +
            "Password=084b4ac02b99d0b2ad2972634830f5e3dcc9891464fb05cb5040b2cfe9798cf8;" +
            "Host=ec2-34-193-117-204.compute-1.amazonaws.com;" +
            "Port=5432;Database=d6oh0nldsptlp3;Pooling=true;" +
            "SSL Mode=Require;TrustServerCertificate=True;");
        public NpgsqlDataAdapter da = null;
        public DataSet dataSet = new DataSet();
        public NpgsqlCommand command = new NpgsqlCommand();
        public NpgsqlDataReader reader = null;
        public void connect()
        {
            connection.Open();
        }
        public void close()
        {
            connection.Close();
        }
        public void execute(String com)
        {
            da = new NpgsqlDataAdapter(com, connection);
            da.Fill(dataSet);
        }
        public void executeNonQuery(String com)
        {
            command = new NpgsqlCommand(com, connection);
            command.ExecuteNonQuery();
            //close();
        }

        public string get(String com)
        {
            command = new NpgsqlCommand(com, connection);
            string result = command.ExecuteScalar().ToString();
            return result;
        }
        public int getAdminID(String email, String password)
        {
            String com = "select emp_id from employees where emp_mail = '" + email + "' and emp_password = '" + password + "'";
            execute(com);
            if (getID("emp_id").Count > 0)
                return getID("emp_id")[0];
            else
                return -1;
        }
        public int getTeacherID(String email, String password)
        {
            String com = "select t_id from teachers where t_mail = '" + email + "' and t_password = '" + password + "'";
            execute(com);
            if (getID("t_id").Count > 0)
                return getID("t_id")[0];
            else
                return -1;
        }
        public int getStudentID(String email, String password)
        {

            String com = "select s_id from students where s_email = '" + email + "' and s_password = '" + password + "'";
            execute(com);
            if (getID("s_id").Count > 0)
                return getID("s_id")[0];
            else
                return -1;

        }
        public int getCourseID(String courseName)
        {
            dataSet.Tables.Clear();
            execute("select c_id from courses where c_name = '" + courseName + "'");
            return getID("c_id")[0];
        }

        public int getCourseTID(int teacher)
        {
            dataSet.Tables.Clear();
            execute("select c_id from courses where ct_id = '" + teacher + "'");
            return getID("c_id")[0];
        }

        public List<int> getCourseID(int studId)
        {
            dataSet.Tables.Clear();
            execute("select sub_course from subscriptions where sub_stud = " + studId);
            return getCourses("sub_course");
        }

        public List<int> getCourses(String colName)
        {
            List<int> results = new List<int>();
            int i = 0;
            String result = "-1";
            foreach (DataTable dt in dataSet.Tables)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    result = dr.Table.Rows[i][colName].ToString();
                    results.Add(Convert.ToInt32(result));
                    i++;
                }
            }
            dataSet.Tables.Clear();
            return results;
        }

        private List<int> getID(String colName)
        {
            List<int> results = new List<int>();
            int i = 0;
            String result = "-1";
            foreach (DataTable dt in dataSet.Tables)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    result = dr.Table.Rows[i][colName].ToString();
                    results.Add(Convert.ToInt32(result));
                    i++;
                }
            }
            return results;
        }

        public int getExerciseID(String url)
        {
            dataSet.Tables.Clear();
            execute("select ex_id from exercises where ex_url = '" + url + "'");
            return getID("ex_id")[0];
        }

        public int getCardID(String cardNumber, int pin)
        {
            String com = "select id from cards where number = '" + cardNumber + "' and pin = " + pin;
            execute(com);
            return getID("id")[0];
        }

    }
}
