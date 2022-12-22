using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekPPK
{
    public partial class adminLogin : Form
    {
        private string admin, idAdmin;
        public int idAdminInt;

        MySqlConnection conn;
        String uid = "root";
        String passwd = "";
        String dbase = "projek";
        String server = "127.0.0.1";
        String connString;

        public adminLogin()
        {
            InitializeComponent();
            InitConnection();
        }

        private void InitConnection()
        {
            try
            {
                conn = new MySqlConnection();
                connString = "server=" + server + ";" +
                      "database=" + dbase + ";" +
                      "uid=" + uid + ";" +
                      "password=" + passwd + ";" +
                      "sslMode=none";
                conn.ConnectionString = connString;
                conn.Open();
                
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                
            }
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MouseEnter_SignUp(object sender, EventArgs e)
        {
            
        }

        private void MouseLeave_SignUp(object sender, EventArgs e)
        {
            
        }

        private void tb_leave(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            if (temp.Text == "")
            {
                temp.ForeColor = Color.Gray;
                temp.Text = temp.Name;
            }
            else
            {
                temp.ForeColor = Color.Black;
            }
        }

        private void tb_enter(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            if (temp.Text == temp.Name)
            {
                temp.ForeColor = Color.Black;
                temp.Clear();
            }
            else
            {
                temp.ForeColor = Color.Black;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
        
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminLogin_Load(object sender, EventArgs e)
        {

        }

        private void login()
        {
            int count = 0;
            String sql = "select * from ADMIN where USERNAME_ADMIN='" + Username.Text + "' and PASSWORD_ADMIN='" + Password.Text + "';";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            this.admin = Username.Text;
            while (reader.Read())
            {
                count += 1;
                this.idAdmin = reader["ID_ADMIN"].ToString();
                this.idAdminInt = Convert.ToInt32(this.idAdmin);
            }
            //reader.Close();
            if (count == 1)
            {
                //menuju
                ((Form)this.TopLevelControl).Hide();
                adminChildDataView sg = new adminChildDataView();
                adminParent f2 = new adminParent(sg, this.idAdmin);
                f2.Show();
            }
            else if (Username.Text == "Username" || Password.Text == "Password" || Username.Text == "")
            {
                MessageBox.Show("Fill Username and Password");
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
            reader.Close();
        }
    }
}
