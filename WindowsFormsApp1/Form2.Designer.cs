
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.txtId = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.Label();
            this.btnbinarywrite = new System.Windows.Forms.Button();
            this.btnbinaryread = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.createfolder = new System.Windows.Forms.Button();
            this.createfile = new System.Windows.Forms.Button();
            this.deletefile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(183, 126);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(102, 13);
            this.txtId.TabIndex = 0;
            this.txtId.Text = "Enter Department Id";
            this.txtId.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(183, 159);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(93, 13);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Department Name";
            // 
            // txtLocation
            // 
            this.txtLocation.AutoSize = true;
            this.txtLocation.Location = new System.Drawing.Point(183, 194);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(134, 13);
            this.txtLocation.TabIndex = 2;
            this.txtLocation.Text = "Enter Department Location";
            // 
            // btnbinarywrite
            // 
            this.btnbinarywrite.Location = new System.Drawing.Point(266, 248);
            this.btnbinarywrite.Name = "btnbinarywrite";
            this.btnbinarywrite.Size = new System.Drawing.Size(75, 23);
            this.btnbinarywrite.TabIndex = 3;
            this.btnbinarywrite.Text = "BinaryWrite";
            this.btnbinarywrite.UseVisualStyleBackColor = true;
            this.btnbinarywrite.Click += new System.EventHandler(this.btnbinarywrite_Click);
            // 
            // btnbinaryread
            // 
            this.btnbinaryread.Location = new System.Drawing.Point(347, 248);
            this.btnbinaryread.Name = "btnbinaryread";
            this.btnbinaryread.Size = new System.Drawing.Size(75, 23);
            this.btnbinaryread.TabIndex = 4;
            this.btnbinaryread.Text = "BinaryRead";
            this.btnbinaryread.UseVisualStyleBackColor = true;
            this.btnbinaryread.Click += new System.EventHandler(this.btnbinaryread_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(397, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(397, 159);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(397, 191);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 20);
            this.textBox3.TabIndex = 7;
            // 
            // createfolder
            // 
            this.createfolder.Location = new System.Drawing.Point(550, 126);
            this.createfolder.Name = "createfolder";
            this.createfolder.Size = new System.Drawing.Size(93, 23);
            this.createfolder.TabIndex = 8;
            this.createfolder.Text = "CreateFolder";
            this.createfolder.UseVisualStyleBackColor = true;
            this.createfolder.Click += new System.EventHandler(this.createfolder_Click);
            // 
            // createfile
            // 
            this.createfile.Location = new System.Drawing.Point(550, 157);
            this.createfile.Name = "createfile";
            this.createfile.Size = new System.Drawing.Size(75, 23);
            this.createfile.TabIndex = 9;
            this.createfile.Text = "CreateFile";
            this.createfile.UseVisualStyleBackColor = true;
            this.createfile.Click += new System.EventHandler(this.createfile_Click);
            // 
            // deletefile
            // 
            this.deletefile.Location = new System.Drawing.Point(550, 194);
            this.deletefile.Name = "deletefile";
            this.deletefile.Size = new System.Drawing.Size(75, 23);
            this.deletefile.TabIndex = 10;
            this.deletefile.Text = "DeleteFile";
            this.deletefile.UseVisualStyleBackColor = true;
            this.deletefile.Click += new System.EventHandler(this.deletefile_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deletefile);
            this.Controls.Add(this.createfile);
            this.Controls.Add(this.createfolder);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnbinaryread);
            this.Controls.Add(this.btnbinarywrite);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Name = "Form2";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtLocation;
        private System.Windows.Forms.Button btnbinarywrite;
        private System.Windows.Forms.Button btnbinaryread;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button createfolder;
        private System.Windows.Forms.Button createfile;
        private System.Windows.Forms.Button deletefile;
    }
}