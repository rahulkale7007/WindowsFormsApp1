
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btncreate = new System.Windows.Forms.Button();
            this.btncreatefile = new System.Windows.Forms.Button();
            this.btnBinarWrite = new System.Windows.Forms.Button();
            this.btnbinaryread = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.Label();
            this.btndeletefile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(497, 69);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(75, 23);
            this.btncreate.TabIndex = 0;
            this.btncreate.Text = "CreateFolder";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btncreatefile
            // 
            this.btncreatefile.Location = new System.Drawing.Point(578, 67);
            this.btncreatefile.Name = "btncreatefile";
            this.btncreatefile.Size = new System.Drawing.Size(75, 23);
            this.btncreatefile.TabIndex = 1;
            this.btncreatefile.Text = "CreateFile";
            this.btncreatefile.UseVisualStyleBackColor = true;
            this.btncreatefile.Click += new System.EventHandler(this.btncreatefile_Click);
            // 
            // btnBinarWrite
            // 
            this.btnBinarWrite.Location = new System.Drawing.Point(324, 210);
            this.btnBinarWrite.Name = "btnBinarWrite";
            this.btnBinarWrite.Size = new System.Drawing.Size(75, 23);
            this.btnBinarWrite.TabIndex = 2;
            this.btnBinarWrite.Text = "BinaryWrite";
            this.btnBinarWrite.UseVisualStyleBackColor = true;
            this.btnBinarWrite.Click += new System.EventHandler(this.btnBinarWrite_Click);
            // 
            // btnbinaryread
            // 
            this.btnbinaryread.Location = new System.Drawing.Point(405, 210);
            this.btnbinaryread.Name = "btnbinaryread";
            this.btnbinaryread.Size = new System.Drawing.Size(75, 23);
            this.btnbinaryread.TabIndex = 3;
            this.btnbinaryread.Text = "BinaryRead";
            this.btnbinaryread.UseVisualStyleBackColor = true;
            this.btnbinaryread.Click += new System.EventHandler(this.btnbinaryread_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(324, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(324, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(324, 121);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(153, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(195, 77);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(93, 13);
            this.txtId.TabIndex = 7;
            this.txtId.Text = "Enter Employee Id";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(195, 103);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(112, 13);
            this.txtName.TabIndex = 8;
            this.txtName.Text = "Enter Employee Name";
            // 
            // txtSalary
            // 
            this.txtSalary.AutoSize = true;
            this.txtSalary.Location = new System.Drawing.Point(195, 129);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(113, 13);
            this.txtSalary.TabIndex = 9;
            this.txtSalary.Text = "Enter Employee Salary";
            // 
            // btndeletefile
            // 
            this.btndeletefile.Location = new System.Drawing.Point(578, 119);
            this.btndeletefile.Name = "btndeletefile";
            this.btndeletefile.Size = new System.Drawing.Size(75, 23);
            this.btndeletefile.TabIndex = 10;
            this.btndeletefile.Text = "DeleteFile";
            this.btndeletefile.UseVisualStyleBackColor = true;
            this.btndeletefile.Click += new System.EventHandler(this.btndeletefile_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "ShowDetails";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btndeletefile);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnbinaryread);
            this.Controls.Add(this.btnBinarWrite);
            this.Controls.Add(this.btncreatefile);
            this.Controls.Add(this.btncreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btncreatefile;
        private System.Windows.Forms.Button btnBinarWrite;
        private System.Windows.Forms.Button btnbinaryread;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtSalary;
        private System.Windows.Forms.Button btndeletefile;
        private System.Windows.Forms.Button button1;
    }
}

