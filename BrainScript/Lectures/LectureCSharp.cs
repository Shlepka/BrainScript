using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace BrainScript.Lectures
{
    public partial class LectureCSharp : Form
    {

        System.IO.StreamReader Read;
        public LectureCSharp()
        {
            ShowInTaskbar = false;
            InitializeComponent();

        }


        private void LectureCSharp_Load(object sender, EventArgs e)
        {

            button1.Text = "Назад";
            var Encoding = System.Text.Encoding.GetEncoding(65001); // кодировка UTF-8
            try
            {

                Read = new System.IO.StreamReader(System.IO.Directory.GetCurrentDirectory() + @"\lecture_charp.txt", Encoding);
                textBox1.Text = Read.ReadToEnd();

            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка считывания файла, проверьте его целостность");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bigTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBox1.TabStop = false;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.WordWrap = true;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
