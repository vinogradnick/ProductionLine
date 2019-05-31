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
using ProductionLine = ProductionLine.Models.ProductionLine;

namespace ProductionLine.Views
{
    public partial class ProductLinesView : Form
    {
        private Models.ProductionLine line;
        public ProductLinesView()
        {
            InitializeComponent();
            listBox1.DataSource = Form1.lines;
        }

        private void SelectProductLine()
        {
            pictureBox1.Image = line.Image;
            label6.Text = line.Name;
           
            listBox2.DataSource = new List<Models.ProductionLine>(Form1.lines);
            dataGridView1.DataSource = line.Products;
            comboBox2.DataSource = Form1.genaList;
            
            line.generator=((Generator)comboBox2.SelectedItem);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            line = Form1.lines[listBox1.SelectedIndex];
            timer1.Start();
            SelectProductLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            line.GenerateProduct(this,Update);
        }

        private void Update()
        {
            label7.Text = line.Products.Count.ToString();
            this.dataGridView1.Invalidate();
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = line.Products;
            label9.Text = line.Materials.Count.ToString();
            checkBox1.Checked = line.isSend;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            line.GenThread?.Abort();
            line.generator=((Generator)comboBox2.SelectedItem);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Update();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pl = (Models.ProductionLine) listBox2.SelectedItem;
            if (line.ID != pl.ID)
            {
                line.SenderThread?.Abort();
                line.SendProduct(pl);
            }
           
        }
    }
}
