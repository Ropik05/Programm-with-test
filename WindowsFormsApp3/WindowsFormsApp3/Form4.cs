using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static WindowsFormsApp3.Program;

namespace WindowsFormsApp3
{
    public partial class Form4 : Form
    {
        string Rnumber;
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = "Выберите действие";
            button1.Text = "Тесты";
            button2.Text = "Теория";
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Visible = false;
            button8.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
        }
        void Choose1()
        {
            button1.Text = "Проверка";
            button2.Text = "1 Тест";
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button3.Text = "2 Тест";
            button4.Text = "3 Тест";
            button5.Text = "4 Тест";
            button6.Text = "5 Тест";
            button8.Text = "1 Тест";
            button1.Visible = false;
            button2.Visible = false;
            button8.Visible = true;
            button7.Visible = true;
            button7.Text = "Проверка";
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;

        }
        void Chooose2()
        {
            button1.Text = "Проверка";
            button2.Text = "1 Тест";
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button3.Text = "3 параграф";
            button4.Text = "4 параграф";
            button5.Text = "5 параграф";
            button6.Text = "6 параграф";
            button8.Text = "2 параграф";
            button1.Visible = false;
            button2.Visible = false;
            button8.Visible = true;
            button7.Visible = true;
            button7.Text = "1 параграф";
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "4 параграф")
            {
                Numer.Value = "4";
                this.Hide();
                Form3 Redactor = new Form3();
                Redactor.Show();
            }
            if (button4.Text == "3 Тест")
            {
                Numer.Value = "4";
                this.Hide();
                Form1 Redactor = new Form1();
                Redactor.Show();
            }
        }

        void Skip()
        {
            this.Hide();
            Form1 Redactor = new Form1();
            Redactor.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Тесты")
            {
                Choose1();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
                if (button2.Text == "Теория")
            {
                Chooose2();

            }
        }
        private void button3_Click(object sender, EventArgs e)
           {
                   if (button3.Text == "2 Тест")
               {
                   Numer.Value = "3";
                   this.Hide();
                   Form1 Redactor = new Form1();
                   Redactor.Show();
               }
                    if (button3.Text == "3 параграф")
               {
                   Numer.Setup = "3";
                   this.Hide();
                   Form3 Redactor = new Form3();
                   Redactor.Show();
               }
           }

           private void button5_Click(object sender, EventArgs e)
           {
                   if (button5.Text == "4 Тест")
               {
                   Numer.Value = "5";
                   this.Hide();
                   Form1 Redactor = new Form1();
                   Redactor.Show();
               }
            if (button5.Text == "5 параграф")
            {
                Numer.Value = "5";
                this.Hide();
                Form3 Redactor = new Form3();
                Redactor.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
             if (button6.Text == "5 Тест")
            {
                Numer.Value = "6";
                this.Hide();
                Form1 Redactor = new Form1();
                Redactor.Show();
            }
            if (button6.Text == "6 параграф")
            {
                Numer.Value = "6";
                this.Hide();
                Form3 Redactor = new Form3();
                Redactor.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "Проверка")
            {
                Numer.Value = "1";
                Skip();
            }
            if (button7.Text == "1 параграф")
            {
                Numer.Value = "1";
                this.Hide();
                Form3 Redactor = new Form3();
                Redactor.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "1 Тест")
            {
                Numer.Value = "2";
                this.Hide();
                Form1 Redactor = new Form1();
                Redactor.Show();
            }
            if (button8.Text == "2 параграф")
            {
                Numer.Value = "2";
                this.Hide();
                Form3 Redactor = new Form3();
                Redactor.Show();
            }
        }
            private void button1_MouseEnter(object sender, EventArgs e)
            {
                Image Gbuttom = WindowsFormsApp3.Properties.Resources.Gbutton;
                button1.BackgroundImage = Gbuttom;
                button1.ForeColor = Color.White;
            }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Image Gbuttom = WindowsFormsApp3.Properties.Resources.Gbutton;
            button2.BackgroundImage = Gbuttom;
            button2.ForeColor = Color.White;
        }
        private void button3_MouseEnter(object sender, EventArgs e)
        {
            Image Gbuttom = WindowsFormsApp3.Properties.Resources.Gbutton;
            button3.BackgroundImage = Gbuttom;
            button3.ForeColor = Color.White;
        }
        private void button4_MouseEnter(object sender, EventArgs e)
        {
            Image Gbuttom = WindowsFormsApp3.Properties.Resources.Gbutton;
            button4.BackgroundImage = Gbuttom;
            button4.ForeColor = Color.White;
        }
        private void button5_MouseEnter(object sender, EventArgs e)
        {
            Image Gbuttom = WindowsFormsApp3.Properties.Resources.Gbutton;
            button5.BackgroundImage = Gbuttom;
            button5.ForeColor = Color.White;
        }
        private void button6_MouseEnter(object sender, EventArgs e)
        {
            Image Gbuttom = WindowsFormsApp3.Properties.Resources.Gbutton;
            button6.BackgroundImage = Gbuttom;
            button6.ForeColor = Color.White;
        }
        private void button7_MouseEnter(object sender, EventArgs e)
        {
            Image Gbuttom = WindowsFormsApp3.Properties.Resources.Gbutton;
            button7.BackgroundImage = Gbuttom;
            button7.ForeColor = Color.White;
        }
        private void button8_MouseEnter(object sender, EventArgs e)
        {
            Image Gbuttom = WindowsFormsApp3.Properties.Resources.Gbutton;
            button8.BackgroundImage = Gbuttom;
            button8.ForeColor = Color.White;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Image Bbuttom = WindowsFormsApp3.Properties.Resources.Bbutton;
            button1.BackgroundImage = Bbuttom;
            button1.ForeColor = Color.White;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            Image Bbuttom = WindowsFormsApp3.Properties.Resources.Bbutton;
            button2.BackgroundImage = Bbuttom;
            button2.ForeColor = Color.White;
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            Image Bbuttom = WindowsFormsApp3.Properties.Resources.Bbutton;
            button3.BackgroundImage = Bbuttom;
            button3.ForeColor = Color.White;
        }
        private void button4_MouseLeave(object sender, EventArgs e)
        {
            Image Bbuttom = WindowsFormsApp3.Properties.Resources.Bbutton;
            button4.BackgroundImage = Bbuttom;
            button4.ForeColor = Color.White;
        }
        private void button5_MouseLeave(object sender, EventArgs e)
        {
            Image Bbuttom = WindowsFormsApp3.Properties.Resources.Bbutton;
            button5.BackgroundImage = Bbuttom;
            button5.ForeColor = Color.White;
        }
        private void button6_MouseLeave(object sender, EventArgs e)
        {
            Image Bbuttom = WindowsFormsApp3.Properties.Resources.Bbutton;
            button6.BackgroundImage = Bbuttom;
            button6.ForeColor = Color.White;
        }
        private void button7_MouseLeave(object sender, EventArgs e)
        {
            Image Bbuttom = WindowsFormsApp3.Properties.Resources.Bbutton;
            button7.BackgroundImage = Bbuttom;
            button7.ForeColor = Color.White;
        }
        private void button8_MouseLeave(object sender, EventArgs e)
        {
            Image Bbuttom = WindowsFormsApp3.Properties.Resources.Bbutton;
            button8.BackgroundImage = Bbuttom;
            button8.ForeColor = Color.White;
        }
    }
}
