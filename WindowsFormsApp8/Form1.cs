using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class SuperPaint : Form
    {
        Graphics graphics;
        Pen pen;
        Point point;
        Bitmap bitmap;
        bool Draw;

        public SuperPaint()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(OpenFile.ShowDialog() == DialogResult.OK)
            {
                Picture.Load(OpenFile.FileName);
            }
        }

       

        private void повернутьВправоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Picture.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            Picture.Invalidate();
        }

        private void повернутьВлевоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Picture.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            Picture.Invalidate();
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void FormLoad(object sender, EventArgs e)
        {
            bitmap = new Bitmap(Picture.Height, Picture.Width);
            graphics = Graphics.FromImage(bitmap);
            pen = new Pen(ForeColor);
            graphics.Clear(Color.MediumTurquoise);
            Picture.Image = bitmap;
        }
    }
}
