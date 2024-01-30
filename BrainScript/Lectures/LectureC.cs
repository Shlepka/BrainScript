using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainScript.Lectures
{
    public partial class LectureC : Form
    {
        System.IO.StreamReader Read;
        public LectureC()
        {
            ShowInTaskbar = false;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.TabStop = false;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.WordWrap = true;
        }

        private void LectureC_Load(object sender, EventArgs e)
        {
            button1.Text = "Назад";
            var Encoding = System.Text.Encoding.GetEncoding(65001); // кодировка UTF-8
            try
            {

                Read = new System.IO.StreamReader(System.IO.Directory.GetCurrentDirectory() + @"\lecture_c.txt", Encoding);
                textBox1.Text = Read.ReadToEnd();

            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка считывания файла, проверьте его целостность");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
