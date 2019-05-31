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
using ProductionLine.Properties;
using ProductionLine.Views;
using Logger = ProductionLine.Views.Logger;

namespace ProductionLine
{
    public partial class Form1 : Form
    {
        public static List<Models.ProductionLine> lines = new List<Models.ProductionLine>();
        public List<string> datalist = new List<string>() { "90ph","line1","sender","giphy","5M1t"};
        public static List<Generator> genaList= new List<Generator>();
        public Form1()
        {
            InitializeComponent();
            this.pictureBox1.Image = Image.FromFile($@"\\Mac\Home\Desktop\gifs\banner.gif");
            Random random =new Random();
            for (int i = 0; i < 5; i++)
            {
                
                lines.Add(new Models.ProductionLine()
                {
                    
                    Image = Image.FromFile($@"\\Mac\Home\Desktop\gifs\{datalist[random.Next(5)]}.gif"),
                    Name = Faker.User.Username(),
                    Speed = random.Next(100)
                });
            }

            for (int i = 0; i < 4; i++)
            {
                genaList.Add(new Generator()
                {
                    Materials = new List<Material>(),
                    Name = Faker.Company.Sector(),
                    Speed = random.Next(500),
                    Status = false
                });
                
            }
           
        }

        private void списокЛинийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductLinesView view = new ProductLinesView();
            view.Show();
        }

        private void генераторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gen = new MaterialGenerator();
            gen.Show();
        }

        private void логгерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var log = new Logger();
            log.Show();
        }
    }
}
