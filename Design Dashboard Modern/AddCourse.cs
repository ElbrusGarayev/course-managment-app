using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Design_Dashboard_Modern
{
    public partial class AddCourse : Form
    {
        public static int loggedUser;
        private int id;
        DBConnection db = new DBConnection();
        public AddCourse(int loggedID)
        {
            loggedUser = loggedID;
            db.connect();
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            new AdminSystem(loggedUser).Show();
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
            if (Sidebar.Width == 270)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                LineaSidebar.Width = 52;
                AnimacionSidebar.Show(Sidebar);
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 270;
                LineaSidebar.Width = 252;
                AnimacionSidebarBack.Show(Sidebar);
            }
        }
        /////////////////////////////////////////////////////
        private void Pay_Click(object sender, EventArgs e)
        {
            try
            {
                db.executeNonQuery("insert into courses values(nextval('c_seq'), '" +
                cname.Text + "', " + Convert.ToInt32(cprice.Text) + ", " + teacherID + ")");
                MessageBox.Show("Successfully Added!!!");
            }
            catch
            {
                MessageBox.Show("Something went wrong!!!");
            }
        }

        private List<string> fillComboBox()
        {
            List<string> list = new List<string>();
            db.execute("select t_name from teachers");
            foreach (DataRow dr in db.dataSet.Tables[0].Rows)
                list.Add(Convert.ToString(dr["t_name"]));
            return list;
        }
        int teacherID;
        private void Box_SelectedValueChanged(object sender, EventArgs e)
        {
            String teacherName = box.SelectedValue.ToString();
            String command = "select t_id from teachers where t_name = '" + teacherName + "'";
            try
            {
                teacherID = Convert.ToInt32(db.get(command));
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void fill_Click(object sender, EventArgs e)
        {
            box.DataSource = fillComboBox();
            db.dataSet.Tables.Clear();
        }
    }
}
