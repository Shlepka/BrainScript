using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainScript
{
    public partial class C : Form
    {

        int quection_count;  //счетчик questionов 
        int correct_answers; // кол-во правильных ответов 
        int wrong_answers; // кол-во неправильных ответов

        string[] array; // 

        int correct_answers_number; // номер правильного ответа 
        int selected_response; // номер выбранного ответа 


        System.IO.StreamReader Read;
        public C()
        {
            ShowInTaskbar = false;
            InitializeComponent();
        }


        void start()
        {
            var Encoding = System.Text.Encoding.GetEncoding(65001); // кодировка UTF-8
            try
            {

                Read = new System.IO.StreamReader( System.IO.Directory.GetCurrentDirectory() + @"\c.txt", Encoding); 
                this.Text = Read.ReadLine();
                quection_count = 0;
                correct_answers = 0;
                wrong_answers = 0;
                array = new String[15];
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка считывания файла, проверьте его целостность");
            }
            question();

        }
        void question()
        {
            label1.Text = Read.ReadLine();

            radioButton1.Text = Read.ReadLine();
            radioButton2.Text = Read.ReadLine();
            radioButton3.Text = Read.ReadLine();

            correct_answers_number = int.Parse(Read.ReadLine());

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            button1.Enabled = false;
            quection_count +=  1;

            if (Read.EndOfStream == true) button1.Text = "Завершить";

        }
        void stateConnection(object sender, EventArgs e)
        {

            button1.Enabled = true; 
            button1.Focus();
            RadioButton selector = (RadioButton)sender;       
            var tmp = selector.Name;
            selected_response = int.Parse(tmp.Substring(11)); // узнаем номер выбраного ответа 
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selected_response == correct_answers_number) correct_answers =
                                             correct_answers + 1;
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

                start(); return;
            }
            if (button1.Text == "Завершить")
            {

                Read.Close();

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


                if (wrong_answers != 0) MessageBox.Show(
                                          Str, "Тестирование завершено");
            }
            if (button1.Text == "Следующий вопрос") question();

            if (button1.Text == "Начать тестирование сначала")
            {
                button2.Visible = true;
            }
            else
            {
                button2.Visible = false;

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void C_Load(object sender, EventArgs e)
        {
            button1.Text = "Следующий вопрос";
            button2.Text = "Выход";

            radioButton1.CheckedChanged += new EventHandler(stateConnection);
            radioButton2.CheckedChanged += new EventHandler(stateConnection);
            radioButton3.CheckedChanged += new EventHandler(stateConnection);
            start();
        }
    }
}
