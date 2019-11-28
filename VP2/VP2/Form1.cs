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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
          


        }


        private void button2_Click(object sender, EventArgs e)
        {
            string x = textBox3.Text;
            string y = textBox4.Text;

            string x1, y1;
            var fileStream = new FileStream(@"C:\Users\Asad Rehman\Source\Repos\VP2\VP2\bin\Debug\Log.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                x1 = streamReader.ReadLine();
                y1 = streamReader.ReadLine();
                if (x == x1 && y == y1)
                {
                    Form2 f = new Form2();
                    f.Show();
                }
            }

        }

      
    }
}
