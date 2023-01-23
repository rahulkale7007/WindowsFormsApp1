
namespace WindowsFormsApp1
{
    partial class Student
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
            this.stdid = new System.Windows.Forms.Label();
            this.stdname = new System.Windows.Forms.Label();
            this.stdpercentage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpercentage = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnbinarywrite = new System.Windows.Forms.Button();
            this.btnbinaryread = new System.Windows.Forms.Button();
            this.btnsoapwrite = new System.Windows.Forms.Button();
            this.btnsoapread = new System.Windows.Forms.Button();
            this.btnxmlwrite = new System.Windows.Forms.Button();
            this.btnxmlread = new System.Windows.Forms.Button();
            this.btnjsonwrite = new System.Windows.Forms.Button();
            this.btnjsnread = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.Department = new System.Windows.Forms.Label();
            this.deptList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // stdid
            // 
            this.stdid.AutoSize = true;
            this.stdid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdid.Location = new System.Drawing.Point(66, 74);
            this.stdid.Name = "stdid";
            this.stdid.Size = new System.Drawing.Size(117, 16);
            this.stdid.TabIndex = 0;
            this.stdid.Text = "Enter Student Id";
            // 
            // stdname
            // 
            this.stdname.AutoSize = true;
            this.stdname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdname.Location = new System.Drawing.Point(66, 98);
            this.stdname.Name = "stdname";
            this.stdname.Size = new System.Drawing.Size(145, 16);
            this.stdname.TabIndex = 1;
            this.stdname.Text = "Enter Student Name";
            // 
            // stdpercentage
            // 
            this.stdpercentage.AutoSize = true;
            this.stdpercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdpercentage.Location = new System.Drawing.Point(66, 159);
            this.stdpercentage.Name = "stdpercentage";
            this.stdpercentage.Size = new System.Drawing.Size(184, 16);
            this.stdpercentage.TabIndex = 2;
            this.stdpercentage.Text = "Enter Student Percentage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(283, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "STUDENT INFO";
            // 
            // txtpercentage
            // 
            this.txtpercentage.Location = new System.Drawing.Point(288, 155);
            this.txtpercentage.Name = "txtpercentage";
            this.txtpercentage.Size = new System.Drawing.Size(134, 20);
            this.txtpercentage.TabIndex = 4;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(288, 92);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(134, 20);
            this.txtname.TabIndex = 5;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(288, 66);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(134, 20);
            this.txtid.TabIndex = 6;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(429, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Show Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnbinarywrite
            // 
            this.btnbinarywrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbinarywrite.Location = new System.Drawing.Point(288, 216);
            this.btnbinarywrite.Name = "btnbinarywrite";
            this.btnbinarywrite.Size = new System.Drawing.Size(119, 23);
            this.btnbinarywrite.TabIndex = 8;
            this.btnbinarywrite.Text = "Binary Write";
            this.btnbinarywrite.UseVisualStyleBackColor = true;
            this.btnbinarywrite.Click += new System.EventHandler(this.btnbinarywrite_Click);
            // 
            // btnbinaryread
            // 
            this.btnbinaryread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbinaryread.Location = new System.Drawing.Point(413, 216);
            this.btnbinaryread.Name = "btnbinaryread";
            this.btnbinaryread.Size = new System.Drawing.Size(111, 23);
            this.btnbinaryread.TabIndex = 9;
            this.btnbinaryread.Text = "Binary Read";
            this.btnbinaryread.UseVisualStyleBackColor = true;
            this.btnbinaryread.Click += new System.EventHandler(this.btnbinaryread_Click);
            // 
            // btnsoapwrite
            // 
            this.btnsoapwrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsoapwrite.Location = new System.Drawing.Point(288, 262);
            this.btnsoapwrite.Name = "btnsoapwrite";
            this.btnsoapwrite.Size = new System.Drawing.Size(119, 23);
            this.btnsoapwrite.TabIndex = 10;
            this.btnsoapwrite.Text = "Soap Write";
            this.btnsoapwrite.UseVisualStyleBackColor = true;
            this.btnsoapwrite.Click += new System.EventHandler(this.btnsoapwrite_Click);
            // 
            // btnsoapread
            // 
            this.btnsoapread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsoapread.Location = new System.Drawing.Point(413, 262);
            this.btnsoapread.Name = "btnsoapread";
            this.btnsoapread.Size = new System.Drawing.Size(119, 23);
            this.btnsoapread.TabIndex = 11;
            this.btnsoapread.Text = "Soap Read";
            this.btnsoapread.UseVisualStyleBackColor = true;
            this.btnsoapread.Click += new System.EventHandler(this.btnsoapread_Click);
            // 
            // btnxmlwrite
            // 
            this.btnxmlwrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxmlwrite.Location = new System.Drawing.Point(288, 305);
            this.btnxmlwrite.Name = "btnxmlwrite";
            this.btnxmlwrite.Size = new System.Drawing.Size(119, 23);
            this.btnxmlwrite.TabIndex = 12;
            this.btnxmlwrite.Text = "XML Write";
            this.btnxmlwrite.UseVisualStyleBackColor = true;
            this.btnxmlwrite.Click += new System.EventHandler(this.btnxmlwrite_Click);
            // 
            // btnxmlread
            // 
            this.btnxmlread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxmlread.Location = new System.Drawing.Point(413, 305);
            this.btnxmlread.Name = "btnxmlread";
            this.btnxmlread.Size = new System.Drawing.Size(119, 23);
            this.btnxmlread.TabIndex = 13;
            this.btnxmlread.Text = "XML Read";
            this.btnxmlread.UseVisualStyleBackColor = true;
            this.btnxmlread.Click += new System.EventHandler(this.btnxmlread_Click);
            // 
            // btnjsonwrite
            // 
            this.btnjsonwrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjsonwrite.Location = new System.Drawing.Point(288, 350);
            this.btnjsonwrite.Name = "btnjsonwrite";
            this.btnjsonwrite.Size = new System.Drawing.Size(119, 23);
            this.btnjsonwrite.TabIndex = 14;
            this.btnjsonwrite.Text = "JSON Write";
            this.btnjsonwrite.UseVisualStyleBackColor = true;
            this.btnjsonwrite.Click += new System.EventHandler(this.btnjsonwrite_Click);
            // 
            // btnjsnread
            // 
            this.btnjsnread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjsnread.Location = new System.Drawing.Point(413, 350);
            this.btnjsnread.Name = "btnjsnread";
            this.btnjsnread.Size = new System.Drawing.Size(119, 23);
            this.btnjsnread.TabIndex = 15;
            this.btnjsnread.Text = "JSON Read";
            this.btnjsnread.UseVisualStyleBackColor = true;
            this.btnjsnread.Click += new System.EventHandler(this.btnjsnread_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(553, 88);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 16;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.Location = new System.Drawing.Point(66, 128);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(144, 16);
            this.Department.TabIndex = 17;
            this.Department.Text = "Student Department";
            this.Department.Click += new System.EventHandler(this.Department_Click);
            // 
            // deptList
            // 
            this.deptList.FormattingEnabled = true;
            this.deptList.Items.AddRange(new object[] {
            "CSE",
            "IT",
            "CIVIL",
            "MECH",
            "E&TC"});
            this.deptList.Location = new System.Drawing.Point(288, 123);
            this.deptList.Name = "deptList";
            this.deptList.Size = new System.Drawing.Size(134, 21);
            this.deptList.TabIndex = 18;
            this.deptList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deptList);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnjsnread);
            this.Controls.Add(this.btnjsonwrite);
            this.Controls.Add(this.btnxmlread);
            this.Controls.Add(this.btnxmlwrite);
            this.Controls.Add(this.btnsoapread);
            this.Controls.Add(this.btnsoapwrite);
            this.Controls.Add(this.btnbinaryread);
            this.Controls.Add(this.btnbinarywrite);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtpercentage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stdpercentage);
            this.Controls.Add(this.stdname);
            this.Controls.Add(this.stdid);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stdid;
        private System.Windows.Forms.Label stdname;
        private System.Windows.Forms.Label stdpercentage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpercentage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnbinarywrite;
        private System.Windows.Forms.Button btnbinaryread;
        private System.Windows.Forms.Button btnsoapwrite;
        private System.Windows.Forms.Button btnsoapread;
        private System.Windows.Forms.Button btnxmlwrite;
        private System.Windows.Forms.Button btnxmlread;
        private System.Windows.Forms.Button btnjsonwrite;
        private System.Windows.Forms.Button btnjsnread;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.ComboBox deptList;
    }
}