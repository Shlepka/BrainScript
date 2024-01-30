using BrainScript.Lectures;
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
    public partial class TestC : Form
    {
        public TestC()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
          
            if (Program.menu.sidebarExpand)
            {
                Program.menu.sidebarTransition.Start();
            }
            else
            {
                Program.menu.sidebarTransition.Stop();
            }

          
          

            C testS = new C();
            testS.Show();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            LectureC lrcc = new LectureC();
            lrcc.Show();
        }

        private void TestC_Load(object sender, EventArgs e)
        {

        }

        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
