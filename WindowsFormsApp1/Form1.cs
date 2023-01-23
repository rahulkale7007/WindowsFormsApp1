using System;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            string path = @"D:\SkillMineDoc";
            try
            {
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Directory is already exists");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Directory created...");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ex.Message");
            }
        }

        private void btncreatefile_Click(object sender, EventArgs e)
        {
            string path = @"D:SkillMineDoc\Text2.txt";
            try
            {
                if (File.Exists(path))
                {
                    MessageBox.Show("File is already exists");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       

        private void btndeletefile_Click(object sender, EventArgs e)
        {
            string path = @"D:\SkillMineDoc\Test1.txt";
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                    MessageBox.Show("File has been removed");
                }
                else
                {
                    MessageBox.Show("File not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // MessageBox.Show("textBox1.text");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           // MessageBox.Show("textBox2.text");

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           // MessageBox.Show("textBox3.text");

        }

        private void btnbinaryread_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\SkillMineDoc\emp.dat", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                textBox1.Text = br.ReadInt32().ToString();
                textBox2.Text = br.ReadString();
                textBox3.Text = br.ReadDouble().ToString();
                br.Close();
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text+" "+textBox2.Text+" "+textBox3.Text);
        }

        private void btnBinarWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\SkillMineDoc\emp.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(textBox1.Text));
                bw.Write(textBox2.Text);
                bw.Write(Convert.ToDouble(textBox3.Text));
                bw.Close();
                fs.Close();
                MessageBox.Show("Data saved to file..");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
