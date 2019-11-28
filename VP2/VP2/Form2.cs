using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace VP_Assignment_2
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.FlatAppearance.BorderSize = 0;

            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Student ID";
            dataGridView1.Columns[1].Name = "Student Name";
            dataGridView1.Columns[2].Name = "Semester";

            dataGridView1.Columns[3].Name = "CGPA";
            dataGridView1.Columns[4].Name = "Department";
            dataGridView1.Columns[5].Name = "University";
            var fileStream = new FileStream(@"C:\Users\Asad Rehman\Source\Repos\AsadRehman21\VP_Assignment-2\VP2\VP2\bin\Debug\Log1.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {

                string x = streamReader.ReadLine();
                while (x != null)
                {

                    dataGridView1.Rows.Add(x, streamReader.ReadLine(), streamReader.ReadLine(), streamReader.ReadLine(), streamReader.ReadLine(), streamReader.ReadLine());

                    x = streamReader.ReadLine();
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(25, 51, 54);
            button2.BackColor = Color.FromArgb(25, 51, 54);
            button3.BackColor = Color.FromArgb(25, 51, 54);
            button4.BackColor = Color.FromArgb(25, 51, 54);
            button5.BackColor = Color.FromArgb(25, 51, 54);
            button6.BackColor = Color.FromArgb(32, 91, 94);
            button7.BackColor = Color.FromArgb(25, 51, 54);
            button8.BackColor = Color.FromArgb(25, 51, 54);
            label1.Text = button6.Text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            panel1.Visible = true;
            panel3.Visible = false;
            panel1.BringToFront();
            button1.BackColor = Color.FromArgb(32, 91, 94);
            button2.BackColor = Color.FromArgb(25, 51, 54);
            button3.BackColor = Color.FromArgb(25, 51, 54);
            button4.BackColor = Color.FromArgb(25, 51, 54);
            button5.BackColor = Color.FromArgb(25, 51, 54);
            button6.BackColor = Color.FromArgb(25, 51, 54);
            button7.BackColor = Color.FromArgb(25, 51, 54);
            button8.BackColor = Color.FromArgb(25, 51, 54);
            label1.Text = button1.Text;


        }

        private void button2_Click(object sender, EventArgs e)
        {

            panel3.Visible = true;




            button2.BackColor = Color.Aqua;
            button1.BackColor = Color.FromArgb(25, 51, 54);
            button2.BackColor = Color.FromArgb(32, 91, 94);
            button3.BackColor = Color.FromArgb(25, 51, 54);
            button4.BackColor = Color.FromArgb(25, 51, 54);
            button5.BackColor = Color.FromArgb(25, 51, 54);
            button6.BackColor = Color.FromArgb(25, 51, 54);
            button7.BackColor = Color.FromArgb(25, 51, 54);
            button8.BackColor = Color.FromArgb(25, 51, 54);
            label1.Text = button2.Text;

            dataGridView2.ColumnCount = 6;
            dataGridView2.Columns[0].Name = "Student ID";
            dataGridView2.Columns[1].Name = "Student Name";
            dataGridView2.Columns[2].Name = "Semester";

            dataGridView2.Columns[3].Name = "CGPA";
            dataGridView2.Columns[4].Name = "Department";
            dataGridView2.Columns[5].Name = "University";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(25, 51, 54);
            button2.BackColor = Color.FromArgb(25, 51, 54);
            button3.BackColor = Color.FromArgb(32, 91, 94);
            button4.BackColor = Color.FromArgb(25, 51, 54);
            button5.BackColor = Color.FromArgb(25, 51, 54);
            button6.BackColor = Color.FromArgb(25, 51, 54);
            button7.BackColor = Color.FromArgb(25, 51, 54);
            button8.BackColor = Color.FromArgb(25, 51, 54);
            label1.Text = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(25, 51, 54);
            button2.BackColor = Color.FromArgb(25, 51, 54);
            button3.BackColor = Color.FromArgb(25, 51, 54);
            button4.BackColor = Color.FromArgb(32, 91, 94);
            button5.BackColor = Color.FromArgb(25, 51, 54);
            button6.BackColor = Color.FromArgb(25, 51, 54);
            button7.BackColor = Color.FromArgb(25, 51, 54);
            button8.BackColor = Color.FromArgb(25, 51, 54);
            label1.Text = button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(25, 51, 54);
            button2.BackColor = Color.FromArgb(25, 51, 54);
            button3.BackColor = Color.FromArgb(25, 51, 54);
            button4.BackColor = Color.FromArgb(25, 51, 54);
            button5.BackColor = Color.FromArgb(32, 91, 94);
            button6.BackColor = Color.FromArgb(25, 51, 54);
            button7.BackColor = Color.FromArgb(25, 51, 54);
            button8.BackColor = Color.FromArgb(25, 51, 54);
            label1.Text = button5.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(25, 51, 54);
            button2.BackColor = Color.FromArgb(25, 51, 54);
            button3.BackColor = Color.FromArgb(25, 51, 54);
            button4.BackColor = Color.FromArgb(25, 51, 54);
            button5.BackColor = Color.FromArgb(25, 51, 54);
            button6.BackColor = Color.FromArgb(25, 51, 54);
            button7.BackColor = Color.FromArgb(25, 51, 54);
            button8.BackColor = Color.FromArgb(32, 91, 94);
            label1.Text = button8.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(25, 51, 54);
            button2.BackColor = Color.FromArgb(25, 51, 54);
            button3.BackColor = Color.FromArgb(25, 51, 54);
            button4.BackColor = Color.FromArgb(25, 51, 54);
            button5.BackColor = Color.FromArgb(25, 51, 54);
            button6.BackColor = Color.FromArgb(25, 51, 54);
            button7.BackColor = Color.FromArgb(32, 91, 94);
            button8.BackColor = Color.FromArgb(25, 51, 54);
            label1.Text = button7.Text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string[] row = new string[] { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text };
            dataGridView1.Rows.Add(row);
            var fileStream = @"C:\Users\Asad Rehman\Source\Repos\AsadRehman21\VP_Assignment-2\VP2\VP2\bin\Debug\Log1.txt";
            using (StreamWriter streamWriter = File.AppendText(fileStream))
            {

                streamWriter.WriteLine(textBox1.Text);
                streamWriter.WriteLine(textBox2.Text);
                streamWriter.WriteLine(textBox3.Text);
                streamWriter.WriteLine(textBox4.Text);
                streamWriter.WriteLine(textBox5.Text);
                streamWriter.WriteLine(textBox6.Text);




            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 2|| comboBox1.SelectedIndex == 1|| comboBox1.SelectedIndex == 0)
            {
                textBox7.Clear();
            }

        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                dataGridView2.Rows.Clear();
                dataGridView2.Refresh();
                var fileStream = new FileStream(@"C:\Users\Asad Rehman\Source\Repos\AsadRehman21\VP_Assignment-2\VP2\VP2\bin\Debug\Log1.txt", FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {

                    string a = streamReader.ReadLine();
                    string b, c, d, g, f;
                    while (a != null)
                    {
                        b = streamReader.ReadLine();
                        c = streamReader.ReadLine();
                        d = streamReader.ReadLine();
                        g = streamReader.ReadLine();
                        f = streamReader.ReadLine();

                        if (a == textBox7.Text)
                        {
                            dataGridView2.Rows.Add(a, b, c, d, g, f);
                            break;
                        }
                        a = streamReader.ReadLine();
                    }
                    if (a == null)
                    {
                        MessageBox.Show("No Data Exist");
                    }

                }
            }
          else  if (comboBox1.SelectedIndex == 1)
            {
                dataGridView2.Rows.Clear();
                dataGridView2.Refresh();
                var fileStream = new FileStream(@"C:\Users\Asad Rehman\Source\Repos\AsadRehman21\VP_Assignment-2\VP2\VP2\bin\Debug\Log1.txt", FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {

                    string a = streamReader.ReadLine();
                    string b, c, d, g, f;
                    while (a != null)
                    {
                        b = streamReader.ReadLine();
                        c = streamReader.ReadLine();
                        d = streamReader.ReadLine();
                        g = streamReader.ReadLine();
                        f = streamReader.ReadLine();

                        if (b == textBox7.Text)
                        {
                            dataGridView2.Rows.Add(a, b, c, d, g, f);
                            break;
                        }
                        a = streamReader.ReadLine();
                    }
                    if (a == null)
                    {
                        MessageBox.Show("No Data Exist");
                    }

                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                textBox7.Clear();
                dataGridView2.Rows.Clear();
                dataGridView2.Refresh();
                var fileStream = new FileStream(@"C:\Users\Asad Rehman\Source\Repos\AsadRehman21\VP_Assignment-2\VP2\VP2\bin\Debug\Log1.txt", FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {

                    string a = streamReader.ReadLine();
                    string b, c, d, g, f;
                    while (a != null)
                    {
                        b = streamReader.ReadLine();
                        c = streamReader.ReadLine();
                        d = streamReader.ReadLine();
                        g = streamReader.ReadLine();
                        f = streamReader.ReadLine();

                       
                            dataGridView2.Rows.Add(a, b, c, d, g, f);

                        a = streamReader.ReadLine();
                    }

                }
            }
        }
    }
}
