namespace BrainScript
{
    partial class InfoProgram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.SuspendLayout();
            // 
            // dungeonHeaderLabel1
            // 
            this.dungeonHeaderLabel1.AutoSize = true;
            this.dungeonHeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonHeaderLabel1.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dungeonHeaderLabel1.ForeColor = System.Drawing.Color.Black;
            this.dungeonHeaderLabel1.Location = new System.Drawing.Point(342, 9);
            this.dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            this.dungeonHeaderLabel1.Size = new System.Drawing.Size(224, 50);
            this.dungeonHeaderLabel1.TabIndex = 4;
            this.dungeonHeaderLabel1.Text = "BrainScript";
            this.dungeonHeaderLabel1.Click += new System.EventHandler(this.dungeonHeaderLabel1_Click);
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.dungeonLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dungeonLabel1.Location = new System.Drawing.Point(28, 110);
            this.dungeonLabel1.MaximumSize = new System.Drawing.Size(800, 0);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(0, 30);
            this.dungeonLabel1.TabIndex = 5;
            this.dungeonLabel1.Click += new System.EventHandler(this.dungeonLabel1_Click);
            // 
            // InfoProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 577);
            this.Controls.Add(this.dungeonLabel1);
            this.Controls.Add(this.dungeonHeaderLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoProgram";
            this.Load += new System.EventHandler(this.InfoProgram_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
    }
}