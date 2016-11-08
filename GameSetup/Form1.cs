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
            name.MaxLength = 10;
        }

        private void draw_Click(object sender, EventArgs e)
        {
            string name1;
            name1 = name.Text;

            Graphics draw = this.CreateGraphics();
            Pen Bpen = new Pen(Color.Black);
            SolidBrush Bbrush = new SolidBrush(Color.Black);
            Font BFont = new Font("Consolas", 25);
            Font Font1 = new Font("Consolas", 11);
            Font Font2 = new Font("Consolas", 9);
            Font Font3 = new Font("Consolas", 8);
            Font Font4 = new Font("Consolas", 7);

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

                if (name1.Length <= 3)
                {
                    draw.DrawString(name1 + " died of:", Font1, Bbrush, 103, 183);
                }
                else if (name1.Length <= 6 && name1.Length > 3)
                {
                    draw.DrawString(name1 + " died of:", Font2, Bbrush, 107, 183);
                }
                else if (name1.Length == 7 || name1.Length == 8)
                {
                    draw.DrawString(name1 + " died of:", Font3, Bbrush, 104, 183);
                }
                else
                {
                    draw.DrawString(name1 + " died of:", Font4, Bbrush, 105, 183);
                }
            }

        }

        private void name_Click(object sender, EventArgs e)
        {
            name.Text = "";
        }
    }
}
