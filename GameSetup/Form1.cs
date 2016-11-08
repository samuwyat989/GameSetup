using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSetup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void draw_Click(object sender, EventArgs e)
        {
            string name1;
            name1 = name.Text;

            Graphics draw = this.CreateGraphics();
            Pen Bpen = new Pen(Color.Black);
            SolidBrush Bbrush = new SolidBrush(Color.Black);
            Font BFont = new Font("Consolas", 25);
            Font LFont = new Font("Consolas", 11);

            Point[] grave = { new Point(100, 150), new Point(105, 150), new Point(105, 145), new Point(205, 145), new Point(205, 150),
                new Point(210, 150), new Point(210, 350), new Point(100, 350)};
            
            if (name.Text == "Please input name")
            {
                draw.Clear(Color.White);
                draw.DrawString("Please input a \n name above", BFont, Bbrush, 53, 150);
            }
            else
            {
                draw.Clear(Color.White);
                draw.DrawPolygon(Bpen, grave);
                draw.DrawLine(Bpen, 50, 350, 260, 350);
                draw.DrawString("R.I.P", BFont, Bbrush, 103, 150);
                draw.DrawString(name1 + " died of:", LFont, Bbrush, 103, 180);
            }

            if (name.SelectionLength == 5)
            {
                draw.DrawString("Yes", BFont, Bbrush, 103, 150);
            }
            else
            {
                draw.DrawString("No", BFont, Bbrush, 103, 150);
            }
            

        }

        private void name_Click(object sender, EventArgs e)
        {
            name.Text = "";
        }
    }
}
