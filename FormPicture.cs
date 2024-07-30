using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Cube
{
    public partial class FormPicture : Form
    {
        private Rectangle rectP;
       

        static public Image Copy(Image srcBitmap, Rectangle section)
        {
            // Вырезаем выбранный кусок картинки

            Bitmap bmp = new Bitmap(section.Width, section.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(srcBitmap, 0, 0, section, GraphicsUnit.Pixel);
            }

            //Возвращаем кусок картинки           

            return bmp;
        }

        public FormPicture(string fnamePict)
        {
            InitializeComponent();
            pict.ImageLocation = fnamePict;
            pict.Load();
            picH.Image = pict.Image;         
        }

        private void FormPicture_Load(object sender, EventArgs e)
        {

        }

        private void FormPicture_FormClosed(object sender, FormClosedEventArgs e)
        {
            MdiParent.Focus();
        }

        private void pict_MouseDown(object sender, MouseEventArgs e)
        {
           
            if (e.Button == MouseButtons.Left)
            {
                rectP.X = e.X;
                rectP.Y = e.Y;
                rectP.Height = 1;
                rectP.Width = 1;
                panel1.Left = rectP.X+12;
                panel1.Top = rectP.Y+41;
                panel1.Height = 1;
                panel1.Width = 1;
                picH.Image = Copy(pict.Image, rectP);
                panel1.Visible = true;

            }
        }

        private void pict_MouseUp(object sender, MouseEventArgs e)
        {           
            
        }

        private void pict_MouseMove(object sender, MouseEventArgs e)
        {
            
               
                if (e.Button == MouseButtons.Left)
                {
                    if ((e.X - rectP.X >0) && (e.Y - rectP.Y>0))
                    {
                    Size s = new Size(e.X - rectP.X, e.Y - rectP.Y);
                    rectP.Size = s;
                    panel1.Size = rectP.Size;
                    picH.Image = Copy(pict.Image, rectP);
                    }
                }
            

        }

        private void btnCD_Click(object sender, EventArgs e)
        {
            pict.Image = Copy(pict.Image, rectP);           
            btnR.Enabled = true;
                panel1.Visible=false;
        }

        private void picH_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void picH_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pict_Click(object sender, EventArgs e)
        {

        }

        private void btnR_Click(object sender, EventArgs e)
        {
            pict.Load();
        }       
    }
}
