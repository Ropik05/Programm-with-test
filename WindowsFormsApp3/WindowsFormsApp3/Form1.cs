using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp3.Program;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        string connection = "server=localhost;port=3306;username=root;password=root;database=Chisla";
        string Rnumber = Numer.Value;
        int NumberQ = 1;
        int quection_count=0;
        int correct_answers;
        int wrong_answers;
        int KMoss;
        string Name;
        string[] array;

        int correct_answers_number;
        int selected_response;


        System.IO.StreamReader Read;


        public Form1()
        {
            InitializeComponent();
        }

        void start()
        {
            var Encoding = System.Text.Encoding.GetEncoding(65001);
            try
            {
                string connStr = "server=localhost;user=root;database=Chisla;password=root;";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string sql = "SELECT TestName, questions FROM `chooses`WHERE RNumer=0";
                sql = sql.Remove(sql.IndexOf("=") + 1);
                sql = sql + Rnumber;
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Name = reader[0].ToString();
                    KMoss = Convert.ToInt16(reader[1]);
                }
                conn.Close();
                reader.Close();
                quection_count = 0;
                correct_answers = 0;
                wrong_answers = 0;
            
                array = new String[10];
            }
            catch (Exception em)
            {  
                MessageBox.Show($"Error:{em.Message}");
            }
            вопрос();

        }
      

        void вопрос()
        {
            if (NumberQ!= KMoss) { 
            string connStr = "server=localhost;user=root;database=Chisla;password=root;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "SELECT text, 1var, 2var, 3var, correct FROM `qestion` WHERE number=0";
             sql = sql.Replace("qestion", Name);
             sql = sql.Remove(sql.IndexOf("=") + 1);
             sql = sql + NumberQ.ToString();
             MySqlCommand command = new MySqlCommand(sql, conn);
             MySqlDataReader reader = command.ExecuteReader();
             while (reader.Read())
             {
                    // элементы массива [] - это значения столбцов из запроса SELECT
                    label1.Text = reader[0].ToString();
                    radioButton1.Text = reader[1].ToString();
                    radioButton2.Text = reader[2].ToString();
                    radioButton3.Text = reader[3].ToString();
                    correct_answers_number = Convert.ToInt16(reader[4]);

             }

                reader.Close();
            
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;

                button1.Enabled = false;
                quection_count = quection_count + 1;
            }
            if(quection_count==KMoss)
            {
                button1.Text = "Завершить";
            }
           

        }

        void состаяниеперключение(object sender, EventArgs e)
        {
          
            button1.Enabled = true; 
            button1.Focus();
            RadioButton Переключатель = (RadioButton)sender;
            var tmp = Переключатель.Name;
           
            selected_response = int.Parse(tmp.Substring(11));
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
     
            if (selected_response == correct_answers_number) 
                correct_answers = correct_answers + 1;
            if (selected_response != correct_answers_number)
            {
                wrong_answers = wrong_answers + 1;
                array[wrong_answers] = label1.Text;
            }
            if (button1.Text == "Начать тестирование сначала")
            {
                button1.Text = "Следующий вопрос";
              
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;

                NumberQ = 1;
                start(); return;
            }
            if (button1.Text == "Завершить")
            {
            
                
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
               
                label1.Text = String.Format("Тестирование завершено.\n" +
                    "Правильных ответов: {0} из {1}.\n" +
                    "Набранные балы: {2:F2}.", correct_answers,
                    quection_count, (correct_answers * 5.0F) / quection_count);
              
                button1.Text = "Начать тестирование сначала";
              
                var Str = "Список ошибок " +
                          ":\n\n";
                for (int i = 1; i <= wrong_answers; i++)
                    Str = Str + array[i] + "\n";

             
                if (wrong_answers != 0) MessageBox.Show(Str, "Тестирование завершено");
            }
            if (button1.Text == "Следующий вопрос")
            {
                NumberQ++;
                вопрос();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            this.Close();
            Process.GetCurrentProcess().Kill();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Следующий вопрос";
            button2.Text = "Выход";
            radioButton1.CheckedChanged += new EventHandler(состаяниеперключение);
            radioButton1.Checked=false;
            radioButton2.CheckedChanged += new EventHandler(состаяниеперключение);
            radioButton2.Checked = false;
            radioButton3.CheckedChanged += new EventHandler(состаяниеперключение);
            radioButton3.Checked = false;
            start();

        }
       
    }
}
