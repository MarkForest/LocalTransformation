using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace global_transform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics graphics = e.Graphics)
            {
                Rectangle rect = new Rectangle(30, 30, 60, 60);
                Pen penB = new Pen(Brushes.Blue, 4);
                Pen penR = new Pen(Brushes.Red, 4);
                //примитивы до глобольного преобразования
                graphics.DrawRectangle(penB, rect);
                graphics.DrawLine(penR, 30, 200, 200, 170);
                graphics.FillEllipse(Brushes.Coral, new Rectangle(100, 30, 100, 100));

                Matrix matrix = new Matrix();
                matrix.Scale(1.4f, 1.4f);
                matrix.RotateAt(-10, new PointF(0.0f, 0.0f));

                graphics.Transform = matrix;
                graphics.DrawRectangle(penB, rect);
                graphics.DrawLine(penR, 30, 200, 200, 170);
                graphics.FillEllipse(Brushes.Coral, new Rectangle(100, 30, 100, 100));

            }
        }
    }
}
