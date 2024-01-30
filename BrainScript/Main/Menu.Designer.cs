namespace BrainScript
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.test = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnTestCSharp = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.pnInfo = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.pnAbout = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pnExit = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnInfo.SuspendLayout();
            this.pnAbout.SuspendLayout();
            this.pnExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 34);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "BrainScript";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnHam
            // 
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(12, 5);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(36, 26);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHam.TabIndex = 1;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sidebar.Controls.Add(this.menuContainer);
            this.sidebar.Controls.Add(this.pnInfo);
            this.sidebar.Controls.Add(this.pnAbout);
            this.sidebar.Controls.Add(this.pnExit);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 34);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(171, 636);
            this.sidebar.TabIndex = 1;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.menuContainer.Controls.Add(this.panel2);
            this.menuContainer.Controls.Add(this.panel5);
            this.menuContainer.Controls.Add(this.panel11);
            this.menuContainer.Controls.Add(this.panel7);
            this.menuContainer.Location = new System.Drawing.Point(0, 0);
            this.menuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(167, 221);
            this.menuContainer.TabIndex = 7;
            this.menuContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.menuContainer_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.test);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 51);
            this.panel2.TabIndex = 8;
            // 
            // test
            // 
            this.test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.test.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test.ForeColor = System.Drawing.Color.White;
            this.test.Image = ((System.Drawing.Image)(resources.GetObject("test.Image")));
            this.test.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.test.Location = new System.Drawing.Point(-10, -8);
            this.test.Margin = new System.Windows.Forms.Padding(0);
            this.test.Name = "test";
            this.test.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.test.Size = new System.Drawing.Size(186, 63);
            this.test.TabIndex = 2;
            this.test.Text = "      Тесты";
            this.test.UseVisualStyleBackColor = false;
            this.test.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnTestCSharp);
            this.panel5.Location = new System.Drawing.Point(3, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(167, 47);
            this.panel5.TabIndex = 10;
            // 
            // btnTestCSharp
            // 
            this.btnTestCSharp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnTestCSharp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTestCSharp.ForeColor = System.Drawing.Color.White;
            this.btnTestCSharp.Image = global::BrainScript.Properties.Resources.csharp;
            this.btnTestCSharp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestCSharp.Location = new System.Drawing.Point(-9, -7);
            this.btnTestCSharp.Name = "btnTestCSharp";
            this.btnTestCSharp.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnTestCSharp.Size = new System.Drawing.Size(186, 63);
            this.btnTestCSharp.TabIndex = 2;
            this.btnTestCSharp.Text = "      C#";
            this.btnTestCSharp.UseVisualStyleBackColor = false;
            this.btnTestCSharp.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.button10);
            this.panel11.Location = new System.Drawing.Point(3, 113);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(167, 47);
            this.panel11.TabIndex = 12;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Image = global::BrainScript.Properties.Resources.c;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(-9, -7);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(186, 63);
            this.button10.TabIndex = 2;
            this.button10.Text = "      C++";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button9);
            this.panel7.Location = new System.Drawing.Point(3, 166);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(167, 47);
            this.panel7.TabIndex = 11;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = global::BrainScript.Properties.Resources.kotlin;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(-9, -7);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(186, 63);
            this.button9.TabIndex = 2;
            this.button9.Text = "      Kotlin";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // pnInfo
            // 
            this.pnInfo.Controls.Add(this.btnInfo);
            this.pnInfo.Location = new System.Drawing.Point(3, 224);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(167, 47);
            this.pnInfo.TabIndex = 9;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Image = global::BrainScript.Properties.Resources.info;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(-9, -7);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnInfo.Size = new System.Drawing.Size(186, 63);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Text = "             О программе";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.button5_Click);
            // 
            // pnAbout
            // 
            this.pnAbout.Controls.Add(this.button2);
            this.pnAbout.Location = new System.Drawing.Point(3, 277);
            this.pnAbout.Name = "pnAbout";
            this.pnAbout.Size = new System.Drawing.Size(167, 47);
            this.pnAbout.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::BrainScript.Properties.Resources.developer;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-9, -7);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(186, 63);
            this.button2.TabIndex = 2;
            this.button2.Text = "          Разработчик";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnExit
            // 
            this.pnExit.Controls.Add(this.button8);
            this.pnExit.Location = new System.Drawing.Point(3, 330);
            this.pnExit.Name = "pnExit";
            this.pnExit.Size = new System.Drawing.Size(167, 47);
            this.pnExit.TabIndex = 9;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::BrainScript.Properties.Resources.exit;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(-9, -7);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(186, 63);
            this.button8.TabIndex = 2;
            this.button8.Text = "          Выйти";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.Enabled = true;
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 670);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.pnInfo.ResumeLayout(false);
            this.pnAbout.ResumeLayout(false);
            this.pnExit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel pnExit;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel pnAbout;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnTestCSharp;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button test;
    }
}

