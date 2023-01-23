using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnbinarywrite_Click(object sender, EventArgs e)
        {
            
            try
            {
                // first use namespace of BinaryFormatter
               
                FileStream fs = new FileStream(@"E:\SkillMine\Employee.dat", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(textBox1.Text);
                emp.Name = textBox2.Text;
                emp.Salary = Convert.ToInt32(textBox3.Text);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("Employee record added to file");
            }
            catch(Exception ex)
            {
                MessageBox.Show("ex.Message");
            }

        }

        private void btnsoapwrite_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"E:\SkillMine\EmployeeSOAP.soap", FileMode.Create, FileAccess.Write);
                // step 2
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(textBox1.Text);
                emp.Name = textBox2.Text;
                emp.Salary = Convert.ToInt32(textBox3.Text);
                // step 3
                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("Employee record added to file");
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
                // step1 1
                FileStream fs = new FileStream(@"E:\SkillMine\Employee.dat", FileMode.Open, FileAccess.Read);
                // step 2
                Employee emp = new Employee();
                // step 3
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                emp = (Employee)binaryFormatter.Deserialize(fs);
                fs.Close();

                textBox1.Text = emp.Id.ToString();
                textBox2.Text = emp.Name;
                textBox3.Text = emp.Salary.ToString();
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
                // step1 1
                FileStream fs = new FileStream(@"E:\SkillMine\EmployeeSOAP.soap", FileMode.Open, FileAccess.Read);
                // step 2
                Employee emp = new Employee();
                // step 3
                SoapFormatter soap = new SoapFormatter();
                emp = (Employee)soap.Deserialize(fs);
                fs.Close();

                textBox1.Text = emp.Id.ToString();
                textBox2.Text = emp.Name;
                textBox3.Text = emp.Salary.ToString();
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
                // step1 1
                FileStream fs = new FileStream(@"E:\SkillMine\EmployeeXML.xml", FileMode.Create, FileAccess.Write);
                // step 2
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(textBox1.Text);
                emp.Name = textBox2.Text;
                emp.Salary = Convert.ToInt32(textBox3.Text);
                // step 3
                XmlSerializer xml = new XmlSerializer(typeof(Employee));
                xml.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("Employee record added to file");
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
                // step1 1
                FileStream fs = new FileStream(@"E:\SkillMine\EmployeeXML.xml", FileMode.Open, FileAccess.Read);
                // step 2
                Employee emp = new Employee();
                // step 3
                XmlSerializer xml = new XmlSerializer(typeof(Employee));
                emp = (Employee)xml.Deserialize(fs);
                fs.Close();

                textBox1.Text = emp.Id.ToString();
                textBox2.Text = emp.Name;
                textBox3.Text = emp.Salary.ToString();
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
                // step1 1
                FileStream fs = new FileStream(@"E:\SkillMine\EmployeeJSON.json", FileMode.Create, FileAccess.Write);
                // step 2
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(textBox1.Text);
                emp.Name = textBox2.Text;
                emp.Salary = Convert.ToInt32(textBox3.Text);
                // step 3
                JsonSerializer.Serialize<Employee>(fs, emp);
                fs.Close();
                MessageBox.Show("Employee record added to file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnjsonread_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"E:\SkillMine\EmployeeJSON.json", FileMode.Open, FileAccess.Read);
                // step 2
                Employee emp = new Employee();
                // step 3

                emp = JsonSerializer.Deserialize<Employee>(fs);
                fs.Close();

                textBox1.Text = emp.Id.ToString();
                textBox2.Text = emp.Name;
                textBox3.Text = emp.Salary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
