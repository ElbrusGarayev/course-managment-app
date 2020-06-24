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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            db.connect();
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
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
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
        //////////////////////////////////////////
        DBConnection db = new DBConnection();

        private void Email_Enter(object sender, EventArgs e)
        {
            if (email.Text == "E-mail")
            {
                email.Clear();
                email.ForeColor = Color.White;
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (email.Text.Equals("")) { email.Text = "E-mail"; email.ForeColor = Color.Gray; }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Password")
            {
                password.Clear();
                password.ForeColor = Color.White;
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (password.Text.Equals("")) { password.Text = "Password"; password.ForeColor = Color.Gray; }
        }
        private void Login_Click(object sender, EventArgs e)
        {
            if (admin.Checked)
            {
                int id = db.getAdminID(email.Text, password.Text);
                if (id != -1)
                {
                    AdminSystem admin = new AdminSystem(id);
                    this.Hide();
                    admin.Show();
                }
                else
                {
                    password.Clear();
                    MessageBox.Show("Email or Password is wrong!!!");
                }
            }
            else if (teacher.Checked)
            {
                int id = db.getTeacherID(email.Text, password.Text);
                if (id != -1)
                {
                    TeachersSystem teachersSystem = new TeachersSystem(id);
                    db.close();
                    this.Hide();
                    teachersSystem.Show();
                }
                else
                {
                    password.Clear();
                    MessageBox.Show("Email or Password is wrong!!!");
                }
            }
            else if (student.Checked)
            {
                int id = db.getStudentID(email.Text, password.Text);
                if (id != -1)
                {
                    StudentSystem student = new StudentSystem(id);
                    this.Hide();
                    student.Show();
                }
                else
                {
                    password.Clear();
                    MessageBox.Show("Email or Password is wrong!!!");
                }
                    
            }
        }
    }
}
