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
    public partial class StudentSystem : Form
    {
        public static int loggedUser;
        public StudentSystem(int loggedID)
        {
            loggedUser = loggedID;
            db.connect();
            InitializeComponent();
            dgv.Font = new Font("Tahoma", 13);
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
        /////////////////////////////////////////////////////
        
        DBConnection db = new DBConnection();
        DataTable dt = new DataTable();
        private void Attendance_Click(object sender, EventArgs e)
        {
            gridView("Attendance");
            db.execute("select c.c_name, t.t_name ||' '|| t.t_surname, a.a_status, a.a_date " +
                "from attendance a " +
                "inner join courses c on a.c_id = c.c_id " +
                "inner join teachers t on c.ct_id = t.t_id " +
                "where s_id = " + loggedUser);
            dgv.DataSource = db.dataSet.Tables[0];
            dgv.Columns[0].HeaderText = "Course Name";
            dgv.Columns[1].HeaderText = "Teacher Name";
            dgv.Columns[2].HeaderText = "Status";
            dgv.Columns[3].HeaderText = "Date";
            dgv.Font = new Font("Tahoma", 13);
        }

        private void Marks_Click(object sender, EventArgs e)
        {
            gridView("Marks");
            db.execute("select c.c_name, t.t_name ||' '||t.t_surname, m.mark, m.m_date " +
                "from marks m " +
                "inner join courses c on m.mc_id = c.c_id " +
                "inner join teachers t on c.ct_id = t.t_id " +
                "where ms_id = " + loggedUser);
            dgv.DataSource = db.dataSet.Tables[0];
            dgv.Columns[0].HeaderText = "Course Name";
            dgv.Columns[1].HeaderText = "Teacher Name";
            dgv.Columns[2].HeaderText = "Mark";
            dgv.Columns[3].HeaderText = "Date";
        }

        private void CourseReg_Click(object sender, EventArgs e)
        {
            cname.Show();
            cprice.Show();
            register.Show();
            dgv.Enabled = true;
            dgv.Size = new Size(350, 450);
            info.Text = "Course Registration";
            db.dataSet.Tables.Clear();
            db.execute("select c_name, c_price||'$' from courses");
            dgv.DataSource = db.dataSet.Tables[0];
            dgv.Columns[0].HeaderText = "Course Name";
            dgv.Columns[1].HeaderText = "Monthly Price";;
        }

        private void Dgv_Click(object sender, EventArgs e)
        {
            cname.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
            cprice.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            int courseID = db.getCourseID(cname.Text);
            db.executeNonQuery("insert into subscriptions values (nextval('sub_seq'), + '" +
                loggedUser + "','" + courseID + "')");
            MessageBox.Show("Thanks for your registering!!!");
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            LoginPage logPage = new LoginPage();
            loggedUser = 0;
            this.Hide();
            logPage.Show();
        }

        private void MySubs_Click(object sender, EventArgs e)
        {
            gridView("My Subscriptions");
            db.execute("select c.c_name, t.t_name||' '||t.t_surname " +
                "from subscriptions s " +
                "inner join courses c on s.sub_course = c.c_id " +
                "inner join teachers t on c.ct_id = t.t_id " +
                "where sub_stud = " + loggedUser);
            dgv.DataSource = db.dataSet.Tables[0];
            dgv.Columns[0].HeaderText = "Course Name";
            dgv.Columns[1].HeaderText = "Teacher Name";
            
        }

        private void gridView(String lblText)
        {
            cname.Hide();
            cprice.Hide();
            register.Hide();
            dgv.Enabled = false;
            dgv.Size = new Size(565, 450);
            info.Text = lblText;
            db.dataSet.Tables.Clear();
            dgv.Font = new Font("Tahoma", 13);
        }

        private void Todo_Click(object sender, EventArgs e)
        {
            TodoSystem todo = new TodoSystem(loggedUser);
            
            todo.Show();
            this.Hide();
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment(loggedUser);
            db.dataSet.Tables.Clear();
            pay.Show();
            this.Hide();
        }
    }
}
