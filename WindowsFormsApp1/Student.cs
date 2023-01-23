using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Text.Json;

namespace WindowsFormsApp1
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtid.Text + " " + txtname.Text+" "+txtpercentage.Text+" "+deptList.Text);
        }

        private void btnbinarywrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMine\Employee.dat", FileMode.Create, FileAccess.Write);
                Student1 std = new Student1();
                std.Id = Convert.ToInt32(txtid.Text);
                std.Name = txtname.Text;
                std.Percentage = Convert.ToInt32(txtpercentage.Text);
                std.Department = deptList.Text;

                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, std);
                fs.Close();
                MessageBox.Show("Student record added to file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnbinaryread_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMine\Employee.dat", FileMode.Open, FileAccess.Read);
                Student1 std = new Student1();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                std = (Student1)binaryFormatter.Deserialize(fs);
                fs.Close();

                txtid.Text = std.Id.ToString();
                txtname.Text = std.Name;
                txtpercentage.Text = std.Percentage.ToString();
                deptList.Text = std.Department;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnsoapwrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMine\EmployeeSOAP.soap", FileMode.Create, FileAccess.Write);
                Student1 std = new Student1();
                std.Id = Convert.ToInt32(txtid.Text);
                std.Name = txtname.Text;
                std.Percentage = Convert.ToInt32(txtpercentage.Text);
                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fs, std);
                fs.Close();
                MessageBox.Show("Student record added to file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnsoapread_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMine\EmployeeSOAP.soap", FileMode.Open, FileAccess.Read);
                Student1 std = new Student1();
                SoapFormatter soap = new SoapFormatter();
                std = (Student1)soap.Deserialize(fs);
                fs.Close();

                txtid.Text = std.Id.ToString();
                txtname.Text = std.Name;
                txtpercentage.Text = std.Percentage.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnxmlwrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMine\EmployeeXML.xml", FileMode.Create, FileAccess.Write);
                Student1 std = new Student1();
                std.Id = Convert.ToInt32(txtid.Text);
                std.Name = txtname.Text;
                std.Percentage = Convert.ToInt32(txtpercentage.Text);
                XmlSerializer xml = new XmlSerializer(typeof(Student1));
                xml.Serialize(fs, std);
                fs.Close();
                MessageBox.Show("Student record added to file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnxmlread_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMine\EmployeeXML.xml", FileMode.Open, FileAccess.Read);
                Student1 std = new Student1();
                XmlSerializer xml = new XmlSerializer(typeof(Student1));
                std = (Student1)xml.Deserialize(fs);
                fs.Close();

                txtid.Text = std.Id.ToString();
                txtname.Text = std.Name;
                txtpercentage.Text = std.Percentage.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnjsonwrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMine\EmployeeJSON.json", FileMode.Create, FileAccess.Write);
                Student1 std = new Student1();
                std.Id = Convert.ToInt32(txtid.Text);
                std.Name = txtname.Text;
                std.Percentage = Convert.ToInt32(txtpercentage.Text);
                JsonSerializer.Serialize<Student1>(fs, std);
                fs.Close();
                MessageBox.Show("Student record added to file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnjsnread_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMine\EmployeeJSON.json", FileMode.Open, FileAccess.Read);
                Student1 std = new Student1();
                std = JsonSerializer.Deserialize<Student1>(fs);
                fs.Close();
                txtid.Text = std.Id.ToString();
                txtname.Text = std.Name;
                txtpercentage.Text = std.Percentage.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtname.Clear();
            txtpercentage.Clear();
            deptList.ResetText();
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Department_Click(object sender, EventArgs e)
        {

        }
    }
}
