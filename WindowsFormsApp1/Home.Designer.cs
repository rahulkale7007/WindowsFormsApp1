
namespace WindowsFormsApp1
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.form1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.form2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.form3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form1ToolStripMenuItem1,
            this.form2ToolStripMenuItem1,
            this.form3ToolStripMenuItem1,
            this.studentToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // form1ToolStripMenuItem1
            // 
            this.form1ToolStripMenuItem1.Name = "form1ToolStripMenuItem1";
            this.form1ToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.form1ToolStripMenuItem1.Text = "Form1";
            this.form1ToolStripMenuItem1.Click += new System.EventHandler(this.form1ToolStripMenuItem1_Click);
            // 
            // form2ToolStripMenuItem1
            // 
            this.form2ToolStripMenuItem1.Name = "form2ToolStripMenuItem1";
            this.form2ToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.form2ToolStripMenuItem1.Text = "Form2";
            this.form2ToolStripMenuItem1.Click += new System.EventHandler(this.form2ToolStripMenuItem1_Click);
            // 
            // form3ToolStripMenuItem1
            // 
            this.form3ToolStripMenuItem1.Name = "form3ToolStripMenuItem1";
            this.form3ToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.form3ToolStripMenuItem1.Text = "Form3";
            this.form3ToolStripMenuItem1.Click += new System.EventHandler(this.form3ToolStripMenuItem1_Click);
            // 
            // studentToolStripMenuItem1
            // 
            this.studentToolStripMenuItem1.Name = "studentToolStripMenuItem1";
            this.studentToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.studentToolStripMenuItem1.Text = "Student";
            this.studentToolStripMenuItem1.Click += new System.EventHandler(this.studentToolStripMenuItem1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem form1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem form2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem form3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem1;
    }
}