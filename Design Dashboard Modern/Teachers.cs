using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Dashboard_Modern
{
    public partial class TeachersSystem : Form
    {
        public static int loggedUser;
        DBConnection db = new DBConnection();
        public TeachersSystem(int loggedID)
        {
            InitializeComponent();
            loggedUser = loggedID;
            dgv.Font = new Font("Cera Stencil", 13);
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            if(Sidebar.Width == 270)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 52;
                AnimacionSidebar.Show(Sidebar);
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 270;
                SidebarWrapper.Width = 300;
                LineaSidebar.Width = 252;
                AnimacionSidebarBack.Show(Sidebar);
            }
        }
        private void gridview(String text)
        {
            infos.Text = text;
            db.dataSet.Tables.Clear();
                
        }
        private void Attendance_Click(object sender, EventArgs e)
        {
            submit.Show();
            submitMark.Hide();
            panelAttendance.Show();
            db.connect();
            dgv.Columns.Clear();
            gridview("Attendance");
            db.execute("select s.s_id, s.s_name, s.s_surname from students s " +
                "inner join subscriptions s2 on s.s_id = s2.sub_stud " +
                "inner join courses c on s2.sub_course = c.c_id " +
                "where c.ct_id = " + loggedUser);
            dgv.DataSource = db.dataSet.Tables[0];
            dgv.Columns[0].HeaderText = "Student ID";
            dgv.Columns[1].HeaderText = "Student Name";
            dgv.Columns[2].HeaderText = "Student Surname";
            dgv.Columns.Add("status", "Status");
            db.close();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            LoginPage logPage = new LoginPage();
            loggedUser = 0;
            this.Hide();
            logPage.Show();
        }

        private void Cnumber_Leave(object sender, EventArgs e)
        {
            if (pwdbox.Text.Equals("")) { pwdbox.Text = "Password"; pwdbox.ForeColor = Color.Gray; }
        }

        private void Cnumber_Enter(object sender, EventArgs e)
        {
            if (pwdbox.Text == "Password")
            {
                pwdbox.Clear();
                pwdbox.ForeColor = Color.Black;
            }
        }

        private void Mark_Click(object sender, EventArgs e)
        {
            submitMark.Show();
            submit.Hide();
            panelAttendance.Show();
            db.connect();
            gridview("Marks");
            dgv.Columns.Clear();
            db.execute("select s.s_id, s.s_name, s.s_surname from students s " +
                "inner join subscriptions s2 on s.s_id = s2.sub_stud " +
                "inner join courses c on s2.sub_course = c.c_id " +
                "where c.ct_id = " + loggedUser);
            dgv.DataSource = db.dataSet.Tables[0];
            dgv.Columns[0].HeaderText = "Student ID";
            dgv.Columns[1].HeaderText = "Student Name";
            dgv.Columns[2].HeaderText = "Student Surname";
            dgv.Columns.Add("mark", "Mark");
            db.close();
        }

        private void Createtask_Click(object sender, EventArgs e)
        {
            panelAttendance.Hide();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            bool flag = true;
            db.connect();
            String pwd = db.get("select t_password from teachers where t_id = " + loggedUser);
            int courseID = db.getCourseTID(loggedUser);
            db.close();
            if (pwd.Equals(pwdbox.Text)){
                try
                {
                    for (int i = 0; i < dgv.Rows.Count - 1; i++)
                    {
                        db.connect();
                        String attendance = dgv.Rows[i].Cells["status"].Value.ToString();
                    if (attendance.Equals("+") || attendance.Equals("q"))
                        db.executeNonQuery("insert into attendance values(nextval('a_seq')," + courseID + ","
                            + dgv.Rows[i].Cells["s_id"].Value.ToString() + ", localtimestamp, '"
                                + attendance + "')");
                    else
                        flag = false;
                        db.close();
                }
                if (flag)
                    MessageBox.Show("Successfully Added!!!");
                else
                    MessageBox.Show("Wrong Format!!!");

                }
                catch
                {
                    MessageBox.Show("Something went wrong!!!");
                }
            }
            else
                MessageBox.Show("Password is wrong!");
            
            
        }

        private void SubmitMark_Click(object sender, EventArgs e)
        {
            bool flag = true;
            db.connect();
            String pwd = db.get("select t_password from teachers where t_id = " + loggedUser);
            int courseID = db.getCourseTID(loggedUser);
            db.close();
            if (pwd.Equals(pwdbox.Text))
            {
                try
                {
                    for (int i = 0; i < dgv.Rows.Count - 1; i++)
                    {
                        db.connect();
                        int mark = Convert.ToInt32(dgv.Rows[i].Cells["mark"].Value);
                        if (mark >= 0 && mark <= 100)
                            db.executeNonQuery("insert into marks values(nextval('m_seq')," + courseID + ","
                                    + dgv.Rows[i].Cells["s_id"].Value.ToString() + ","
                                        + mark + ", localtimestamp" + ")");
                        else
                            flag = false;
                        db.close();
                    }
                    if(flag)
                        MessageBox.Show("Successfully Added!!!");
                    else
                        MessageBox.Show("Wrong Format!!!");
                }
                catch
                {
                    MessageBox.Show("Something went wrong!!!");
                }
            }
            else
                MessageBox.Show("Password is wrong!");
            
        }

        private void SubmitTask_Click(object sender, EventArgs e)
        {
            db.connect();
            String task = tasklink.Text;
            String deadline = dtp.Text;
            int courseID = db.getCourseTID(loggedUser);
            String command = "insert into exercises values (nextval('ex_seq'), " + courseID + ",'" + task + "', '" + deadline + "')";
            try
            {
                db.executeNonQuery(command);
                MessageBox.Show("Successfully Sended!!!");
            }
            catch
            {
                MessageBox.Show("Something went wrong!!!");
            }
            db.close();
        }

        private void Checktask_Click(object sender, EventArgs e)
        {
            pwdbox.Hide();
            submitMark.Hide();
            submit.Hide();
            panelAttendance.Show();
            db.connect();
            gridview("Solutions");
            dgv.Columns.Clear();
            db.execute("select s.s_name||' '||s.s_surname, e.ex_url, s2.sol_url, s2.sol_date " +
                "from solutions s2 " +
                "inner join students s on s2.sol_sid = s.s_id " +
                "inner join exercises e on s2.sol_exid = e.ex_id " +
                "inner join courses c on e.ex_cid = c.c_id " +
                "inner join teachers t on c.ct_id = t.t_id " +
                "where c.ct_id = " + loggedUser);
            dgv.DataSource = db.dataSet.Tables[0];
            dgv.Columns[0].HeaderText = "Student Name";
            dgv.Columns[1].HeaderText = "Exercise URL";
            dgv.Columns[2].HeaderText = "Solution URL";
            dgv.Columns[3].HeaderText = "Solution Date";
            db.close();
        }
    }
}
