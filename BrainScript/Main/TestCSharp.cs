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
    public partial class TestCSharp : Form
    {
        public TestCSharp()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
         
         
           
        }

        private void labelEdit1_Click(object sender, EventArgs e)
        {

        }

        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TestCSharp_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void Start_Click(object sender, EventArgs e)
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
            
            CSharp cSharp = new CSharp();
            cSharp.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LectureCSharp lrcCharp = new LectureCSharp();
            lrcCharp.Show();
   
        }
    }
}
