using BrainScript.Lectures;
using BrainScript.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainScript.Main
{
    public partial class TestKotlin : Form
    {
        public TestKotlin()
        {
            InitializeComponent();
        }

        private void bigLabel1_Click(object sender, EventArgs e)
        {

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

            Kotlin kotlin = new Kotlin();
            kotlin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LectureKotlin lrcKotlin = new LectureKotlin();
            lrcKotlin.Show();
        }
    }
}
