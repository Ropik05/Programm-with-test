using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            button1.Text = "Продолжить";
            button2.Text = "Выход";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
