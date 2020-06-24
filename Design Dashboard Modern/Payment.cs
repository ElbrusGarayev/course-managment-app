using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Design_Dashboard_Modern
{
    public partial class Payment : Form
    {
        public static int loggedUser;
        private int id;
        DBConnection db = new DBConnection();
        public Payment(int loggedID)
        {
            loggedUser = loggedID;
            db.connect();
            //fillName();
            //fillComboBox();
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            db.close();
            this.Close();
            new StudentSystem(loggedUser).Show();
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
            if (checkCardInfo())
            {
                doPay(id, Convert.ToInt32(amount.Text));
                db.executeNonQuery("insert into fees values(nextval('f_seq'), localtimestamp, " + loggedUser + ", " + Convert.ToInt32(amount.Text) + ")");
                MessageBox.Show("Successfully paid!");
            }
            else
                MessageBox.Show("Credentials are wrong!!!");
        }

        public void doPay(int cardID, int amount)
        {
            String command = "update cards set balance = balance - " + amount + " where id = " + cardID;
            db.executeNonQuery(command);
        }

        private bool checkCardInfo()
        {
            db.dataSet.Tables.Clear();
            int cardID = db.getCardID(cnumber.Text, Convert.ToInt32(pin.Text));
            id = cardID;
            return cardID > 0;
        }

        private string fillName()
        {
            String command = "select s_name||' '||s_surname from students where s_id = " + loggedUser;
            return db.get(command);
        }

        private List<string> fillComboBox()
        {
            
            List<string> list = new List<string>();
            db.execute("select c.c_name " +
                "from subscriptions s " +
                "inner join courses c on s.sub_course = c.c_id " +
                "where sub_stud = " + loggedUser);
            foreach (DataRow dr in db.dataSet.Tables[0].Rows)
                list.Add(Convert.ToString(dr["c_name"]));
            return list;
        }

        private void Box_SelectedValueChanged(object sender, EventArgs e)
        {
            String courseName = box.SelectedValue.ToString();
            String command = "select c_price from courses where c_name = '" + courseName + "'";
            amount.Text = db.get(command);
        }

        private void fill_Click(object sender, EventArgs e)
        {
            box.DataSource = fillComboBox();
            nameS.Text = fillName();
            db.dataSet.Tables.Clear();
        }
    }
}
