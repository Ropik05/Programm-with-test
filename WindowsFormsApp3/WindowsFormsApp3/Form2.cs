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
using static WindowsFormsApp3.Program;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void buttonlogin_MouseEnter(object sender, EventArgs e)
        {
            Image Bbuttom = WindowsFormsApp3.Properties.Resources.Bbutton;
            buttonlogin.BackgroundImage = Bbuttom;
            buttonlogin.ForeColor = Color.White;
        }
        private void buttonlogin_MouseLeave(object sender, EventArgs e)
        {
            Image Pbuttom = WindowsFormsApp3.Properties.Resources.Pbutton;
            buttonlogin.BackgroundImage = Pbuttom;
            buttonlogin.ForeColor = Color.Black;
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            String loginUser = login.Text;
            String passwordUser = password.Text;

            DataTable table = new DataTable();

            string connStr = "server=localhost;user=root;database=Chisla;password=root;";

            MySqlConnection conn = new MySqlConnection(connStr);

            conn.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP  ", conn);
            command.Parameters.Add("@uL",MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP",MySqlDbType.VarChar).Value = passwordUser; 
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if(table.Rows.Count > 0)
            {
                MySqlCommand Admin = new MySqlCommand("SELECT * FROM `admin` WHERE `Name` = @uL  ", conn);
                Admin.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                adapter.SelectCommand = Admin;
                adapter.Fill(table);
                if (table.Rows.Count > 1)
                {
                    MessageBox.Show("Администратор");
                    this.Hide();
                    Form5 Redactor = new Form5();
                    Redactor.Show();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Авторизован");
                    this.Hide();
                    Form4 Testform = new Form4();
                    Testform.Show();
                   conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Неверно введен логин или пароль");
            }
        }
    }
}
