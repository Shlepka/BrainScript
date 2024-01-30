using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BrainScript
{
    public partial class InfoProgram : Form
    {
        public InfoProgram()
        {

 
            InitializeComponent();
        }
      
        

        private void spaceBorderLabel1_Click(object sender, EventArgs e)
        {

        }


        private void dungeonLabel1_Click(object sender, EventArgs e)
        {
         

        }

        private void InfoProgram_Load(object sender, EventArgs e)
        {
            FileStream load = new FileStream("info.txt", FileMode.Open);
            StreamReader read = new StreamReader(load);
            dungeonLabel1.Text = read.ReadToEnd();

        }

 



        private void dungeonHeaderLabel1_Click(object sender, EventArgs e)
        {

        }

    
    }
}
