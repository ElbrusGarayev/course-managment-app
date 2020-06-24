using Npgsql;
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
    public partial class AdminSystem : Form
    {
        private int id;
        DBConnection db = new DBConnection();

        public AdminSystem(int id)
        {
            InitializeComponent();
            main.Visible = true; 
            db.connect();
            this.id = id;
            dgv.Font = new Font("Cera Stencil", 13);
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            db.close();
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

        public void gridview(String text)
        {
            db.dataSet.Tables.Clear();
            info.Text = text;
            panel.Visible = false;
            main.Visible = false;
            allUsers.Visible = false;
            panelSearch.Visible = false;
        }

        private void Revenue_Click(object sender, EventArgs e)
        {
            gridview("Revenue");
            Wrapper.Show();
            db.execute("select f.f_id, s.s_name, f.amount, f.f_date from fees f inner join students s on f.fs_id = s.s_id");
            dgv.DataSource = db.dataSet.Tables[0];
            dgv.Columns[0].HeaderText = "Fee ID";
            dgv.Columns[1].HeaderText = "Client";
            dgv.Columns[2].HeaderText = "Fee Amount";
            dgv.Columns[3].HeaderText = "Date";
        }

        private void Attendance_Click(object sender, EventArgs e)
        {
            gridview("Attendance");
            db.execute("select s.s_name||' '||s.s_surname, c.c_name, a.a_status, a.a_date " +
                 "from attendance a " +
                 "inner join courses c on a.c_id = c.c_id " +
                 "inner join students s on a.s_id = s.s_id ");
 
            dgv.DataSource = db.dataSet.Tables[0];
            dgv.Columns[0].HeaderText = "Student";
            dgv.Columns[1].HeaderText = "Course";
            dgv.Columns[2].HeaderText = "Status";
            dgv.Columns[3].HeaderText = "Date";
        }

        private void Marks_Click(object sender, EventArgs e)
        {
            gridview("Marks");
            db.execute("select s.s_name||' '||s.s_surname, c.c_name, m.mark, m.m_date " +
                 "from marks m " +
                 "inner join courses c on m.mc_id = c.c_id " +
                 "inner join students s on m.ms_id = s.s_id ");

            dgv.DataSource = db.dataSet.Tables[0];
            dgv.Columns[0].HeaderText = "Student";
            dgv.Columns[1].HeaderText = "Course";
            dgv.Columns[2].HeaderText = "Status";
            dgv.Columns[3].HeaderText = "Date";
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            LoginPage logPage = new LoginPage();
            id = 0;
            this.Hide();
            logPage.Show();
        }

        private void TeacherEnable_Click(object sender, EventArgs e)
        {
            panelTeacher.Enabled = true;
            panelStudent.Enabled = false;
        }

        private void StudentEnable_Click(object sender, EventArgs e)
        {
            panelTeacher.Enabled = false;
            panelStudent.Enabled = true;
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            main.Visible = false;
            panelSearch.Visible = false;
            allUsers.Visible = false;
            infoAdd.Text = "Add User";
        }

        private void AddTeacher_Click(object sender, EventArgs e)
        {
            String name = namet.Text;
            String surname = surnamet.Text;
            String email = emailt.Text;
            String password = passwordt.Text;
            String salary = salaryt.Text;
            try
            {
                db.executeNonQuery("insert into teachers values(nextval('t_seq'), '" + name + "','" + surname
                + "','" + email + "','" + password + "'," + salary + ")");
                namet.Clear();
                surnamet.Clear();
                emailt.Clear();
                passwordt.Clear();
                salaryt.Clear();
                MessageBox.Show("Successfully added!!!");
            }
            catch
            {
                MessageBox.Show("Something went wrong!!!");
            }
        }
       
        private void AddStudent_Click(object sender, EventArgs e)
        {
            String name = names.Text;
            String surname = surnames.Text;
            String email = emails.Text;
            String password = passwords.Text;
            try
            {
                db.executeNonQuery("insert into students values(nextval('s_seq'), '" + name + "','" + surname
                + "','" + email + "','" + password + "')");
                names.Clear();
                surnames.Clear();
                emails.Clear();
                passwords.Clear();
                MessageBox.Show("Successfully added!!!");
            }
            catch
            {
                MessageBox.Show("Something went wrong!!!");
            }
        }

        private void SearchUser_Click(object sender, EventArgs e)
        {
            if (teachRadio.Checked)
            {
                salarybox.Show();
                db.dataSet.Tables.Clear();
                try
                {
                    db.execute("select * from teachers where t_id = " + Convert.ToInt32(idbox.Text));
                    namebox.Text = db.dataSet.Tables[0].Rows[0][1].ToString();
                    surnamebox.Text = db.dataSet.Tables[0].Rows[0][2].ToString();
                    emailbox.Text = db.dataSet.Tables[0].Rows[0][3].ToString();
                    pwdbox.Text = db.dataSet.Tables[0].Rows[0][4].ToString();
                    salarybox.Text = db.dataSet.Tables[0].Rows[0][5].ToString();
                }
                catch
                {
                    MessageBox.Show("User not found !!!");
                }
            }
            else if (studRadio.Checked)
            {
                salarybox.Hide();
                db.dataSet.Tables.Clear();
                try
                {
                    db.execute("select * from students where s_id = " + Convert.ToInt32(idbox.Text));
                    namebox.Text = db.dataSet.Tables[0].Rows[0][1].ToString();
                    surnamebox.Text = db.dataSet.Tables[0].Rows[0][2].ToString();
                    emailbox.Text = db.dataSet.Tables[0].Rows[0][3].ToString();
                    pwdbox.Text = db.dataSet.Tables[0].Rows[0][4].ToString();
                }
                catch
                {
                    MessageBox.Show("User not found !!!");
                }
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            main.Visible = false;
            panelSearch.Visible = true;
            allUsers.Visible = false;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (teachRadio.Checked)
            {
                String comm = "update teachers set t_name = '" + namebox.Text +"'" +
                    ", t_surname = '" + surnamebox.Text + "', t_mail = '" + emailbox.Text +"'" +
                    ", t_password = '" + pwdbox.Text + "', t_salary = " + Convert.ToInt32(salarybox.Text) +
                    " where t_id = " + Convert.ToInt32(idbox.Text);
                try
                {
                    db.executeNonQuery(comm);
                    MessageBox.Show("Successfully Updated!!!");
                }
                catch
                {
                    MessageBox.Show("Something went wrong!!!");
                }
            }
            if (studRadio.Checked)
            {
                String comm = "update students set s_name = '" + namebox.Text + "'" +
                    ", s_surname = '" + surnamebox.Text + "', s_email = '" + emailbox.Text + "'" +
                    ", s_password = '" + pwdbox.Text + "' where s_id = " + Convert.ToInt32(idbox.Text);
                try
                {
                    db.executeNonQuery(comm);
                    MessageBox.Show("Successfully Updated!!!");
                }
                catch
                {
                    MessageBox.Show("Something went wrong!!!");
                }
            }
            namebox.Clear();
            surnamebox.Clear();
            emailbox.Clear();
            pwdbox.Clear();
            salarybox.Clear();
        }

        private void Users_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            main.Visible = false;
            panelSearch.Visible = false;
            allUsers.Visible = true;
        }

        private void Filldgv_Click(object sender, EventArgs e)
        {
            usersdgv.Font = new Font("Cera Stencil", 13);
            db.dataSet.Tables.Clear();
            if (teachers.Checked)
            {
                try
                {
                    db.execute("select t_id, t_name, t_surname, t_mail from teachers");
                    usersdgv.DataSource = db.dataSet.Tables[0];
                    usersdgv.Columns[0].HeaderText = "User ID";
                    usersdgv.Columns[1].HeaderText = "Name";
                    usersdgv.Columns[2].HeaderText = "Surname";
                    usersdgv.Columns[3].HeaderText = "E-mail";
                }
                catch
                {
                    MessageBox.Show("Something went wrong!!!");
                }
            }
            else if (students.Checked)
            {
                try
                {
                    db.execute("select s_id, s_name, s_surname, s_email from students");
                    usersdgv.DataSource = db.dataSet.Tables[0];
                    usersdgv.Columns[0].HeaderText = "User ID";
                    usersdgv.Columns[1].HeaderText = "Name";
                    usersdgv.Columns[2].HeaderText = "Surname";
                    usersdgv.Columns[3].HeaderText = "E-mail";
                }
                catch
                {
                    MessageBox.Show("Something went wrong!!!");
                }
            }
        }

        private void Idbox_Leave(object sender, EventArgs e)
        {
            if (idbox.Text.Equals("")) { idbox.Text = "ID"; idbox.ForeColor = Color.Gray; }
        }

        private void Idbox_Enter(object sender, EventArgs e)
        {
            if (idbox.Text == "ID")
            {
                idbox.Clear();
                idbox.ForeColor = Color.Black;
            }
        }

        private void AddCourse_Click(object sender, EventArgs e)
        {
            AddCourse add = new AddCourse(id);
            this.Hide();
            add.Show();
        }
    }
}
