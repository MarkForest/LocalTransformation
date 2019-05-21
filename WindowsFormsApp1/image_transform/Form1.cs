using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace image_transform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Graphics graphics = e.Graphics)
            {
                try
                {
                    graphics.DrawImage(Image.FromFile("1.jpg"), 0, 0, 100, 100);
                }
                catch  {}
                Matrix matrix = new Matrix();
                matrix.RotateAt(45, new PointF(150, 150));
                matrix.Translate(100, 100);
                graphics.Transform = matrix;

                try
                {
                    graphics.DrawImage(Image.FromFile("2.jpg"), 0, 0, 100, 100);
                }
                catch{}

                matrix.Reset();
                matrix.Translate(150, 10);
                matrix.Shear(0.5f, 0.3f);

                graphics.Transform = matrix;
                try
                {
                    graphics.DrawImage(Image.FromFile("2.jpg"), 0, 0, 100, 100);
                }
                catch { }
            }
        }
    }
}
