using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        string[] array;
        System.IO.StreamReader Read;
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            button1.Text = "Возврат";
            Start();
        }
        void Start()
        {
            var Encoding = System.Text.Encoding.GetEncoding(65001);
            try
            {

                Read = new System.IO.StreamReader(
                System.IO.Directory.GetCurrentDirectory() +
                                               @"\t.txt", Encoding);
                this.Text = Read.ReadLine();
                array = new String[10];
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка 1");
            }
            LabText();
        }
        void LabText()
        {
                label1.Text = Read.ReadLine();
            label2.Text = Read.ReadLine();
            label3.Text = Read.ReadLine();
            label4.Text = Read.ReadLine();
            label5.Text = Read.ReadLine();
            label6.Text = Read.ReadLine();
            label7.Text = Read.ReadLine();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Возврат")
            {
                this.Close();
                Form4 Redactor = new Form4();
                Redactor.Show();
            }

        }
    }
}
