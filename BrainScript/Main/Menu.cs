using BrainScript.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace BrainScript
{
    public partial class Menu : Form
    {
        InfoProgram info;
        TestCSharp test1;
        TestC test2;
        TestKotlin test3;

        public Menu()
        {
            Program.menu = this;
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.panel1_KeyDown);
        }
        bool menuExpand = true;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuTransition.Start();

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if(menuExpand == false )
            {
                menuContainer.Height += 10;
                if(menuContainer.Height >= 218)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if(menuContainer.Height <= 54)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

      

        private void menuContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public bool sidebarExpand = true;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 80)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    pnInfo.Width = sidebar.Width;
                    pnAbout.Width = sidebar.Width;
                    pnExit.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 5;
                if(sidebar.Width >= 174)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnInfo.Width = sidebar.Width;
                    pnAbout.Width = sidebar.Width;
                    pnExit.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                }
            }

        }

        public void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           
           

            if (test1 == null)
            {
                test1 = new TestCSharp();
                test1.FormClosed += Test1_FormClosed;
                test1.MdiParent = this;
                test1.Dock = DockStyle.Fill;
                test1.Show();
                

            }
            else
            {
                test1.Activate();
            }
        }

        private void Test1_FormClosed(object sender, FormClosedEventArgs e)
        {
            test1 = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(info == null)
            {
                info = new InfoProgram();
                info.FormClosed += Info_FormClosed;
                info.MdiParent = this;
                info.Dock = DockStyle.Fill;
                info.Show();
            }
            else
            {
                info.Activate();
            }
        }

        private void Info_FormClosed(object sender, FormClosedEventArgs e)
        {
            info = null;
        }

        private void button10_Click(object sender, EventArgs e)
        {
          
            if (test2 == null)
            {
                test2 = new TestC();
                test2.FormClosed += Test2_FormClosed;
                test2.MdiParent = this;
                test2.Dock = DockStyle.Fill;
                test2.Show();
            }
            else
            {
                test2.Activate();
            }
        }
        private void Test2_FormClosed(object sender, FormClosedEventArgs e)
        {
            test2 = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа разработана студентом МГГТК АГУ  группы ИС-41 Лавинским Степаном");
        }

        private void button8_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Вы действительно хотите выйти?","Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
                Application.Exit();

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (test3 == null)
            {
                test3 = new TestKotlin();
                test3.FormClosed += Test3_FormClosed;
                test3.MdiParent = this;
                test3.Dock = DockStyle.Fill;
                test3.Show();


            }
            else
            {
                test3.Activate();
            }
        }
        private void Test3_FormClosed(object sender, FormClosedEventArgs e)
        {
            test3 = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {// если код нажатой клавиши равер коду клавиши "F1"
                Help.ShowHelp(this, @"help.chm");  //запуск файла справки
            }
        }
    }
}
