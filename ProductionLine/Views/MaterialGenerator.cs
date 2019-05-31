using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductionLine.Models;

namespace ProductionLine.Views
{
    public partial class MaterialGenerator : Form
    {
        private Generator generator;
        public MaterialGenerator()
        {
            InitializeComponent();

            pictureBox1.Image = Image.FromFile($@"\\Mac\Home\Desktop\gifs\ph.gif");

            listBox1.DataSource = Form1.genaList;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            generator = Form1.genaList[listBox1.SelectedIndex];
            Bind();
        }

        private void Bind()
        {
            label6.Text = generator.Name;
            label7.Text = generator.Speed.ToString();
            checkBox1.Checked = generator.Status;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Start();
            generator.Status = checkBox1.Checked;
            generator.GenerateMaterialsThread();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = generator.Materials.Count.ToString();
        }
    }
}
