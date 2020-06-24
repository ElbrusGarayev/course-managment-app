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
    public partial class TodoSystem : Form
    {

        public static int loggedUser;
        public TodoSystem(int loggedID)
        {
            loggedUser = loggedID;
            db.connect();
            InitializeComponent();
            fillDGV(loggedID);
        }
        public void fillDGV(int loggedID)
        {
            dgv.Font = new Font("Tahoma", 13);
            foreach (var item in db.getCourseID(loggedID))
            {
                db.execute("select c.c_name, t.t_name||' '||t.t_surname, ex.ex_url, ex.ex_dline " +
                    "from exercises ex " +
                    "inner join courses c on ex.ex_cid = c.c_id " +
                    "inner join teachers t on c.ct_id = t.t_id " +
                    "where ex.ex_cid = " + item);

            }
            if (db.dataSet.Tables.Count > 0)
            {
                dgv.DataSource = db.dataSet.Tables[0];
                dgv.Columns[0].HeaderText = "Course Name";
                dgv.Columns[1].HeaderText = "Teacher Name";
                dgv.Columns[2].HeaderText = "Exercise URL";
                dgv.Columns[3].HeaderText = "Exercise Deadline";
            }
        }

        private void TodoSystem_Load(object sender, System.EventArgs e)
        {
            
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
            if(Sidebar.Width == 270)
            {
                Sidebar.Visible = false;
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
        
        DBConnection db = new DBConnection();

        private void Turnin_Click(object sender, EventArgs e)
        {
            db.executeNonQuery("insert into solutions values(nextval('sol_seq')," +
                db.getExerciseID(exurl.Text) + "," + loggedUser + ",'" + solutions.Text +
                "', '" + DateTime.Now.ToString("MM/dd/yyyy") + "')");
            MessageBox.Show("Turned in successfully!!!");
        }

        private void Exurl_Enter(object sender, EventArgs e)
        {
            if (exurl.Text == "Exercise URL")
            {
                exurl.Text = "";
                exurl.ForeColor = Color.Black;
            }
                
        }

        private void Exurl_Leave(object sender, EventArgs e)
        {
            if (exurl.Text == "")
            {
                exurl.Text = "Exercise URL";
                exurl.ForeColor = Color.Gray;
            }
                
        }

        private void Solutions_Enter(object sender, EventArgs e)
        {
            if (solutions.Text == "Solution URL")
            {
                solutions.Text = "";
                solutions.ForeColor = Color.Black;
            }
                
        }

        private void Solutions_Leave(object sender, EventArgs e)
        {
            if (solutions.Text == "") {
                solutions.Text = "Solution URL";
                solutions.ForeColor = Color.Gray;
            }
                
        }

        private void Dgv_Click(object sender, EventArgs e)
        {
            exurl.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
