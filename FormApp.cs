using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace Cube
{
    public partial class FormApp : Form
    {

        private FormPicture[] frmpict=new FormPicture[1];
        private FormCube[] frmc = new FormCube[1];
        private int n = 0;
        protected Cube3d cube;

        Array IncArr(Array arr)
        {
            Array newarr = Array.CreateInstance(arr.GetType().GetElementType(), arr.Length+1);
            arr.CopyTo(newarr, 0);
            return newarr;
        }

        public FormApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void новоеОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                n++;
                frmpict=(FormPicture[])IncArr(frmpict);
                frmc = (FormCube[])IncArr(frmc);
                frmpict[n] = new FormPicture(openFileDialog1.FileName);
                frmpict[n].MdiParent = this;
                frmpict[n].Text = openFileDialog1.FileName;
                frmpict[n].Tag = n;
                frmpict[n].Show();
            }
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                if (object.ReferenceEquals(this.ActiveMdiChild.GetType(), typeof(FormPicture)))
                {
                    сохранитьИзображениеКубаToolStripMenuItem.Enabled = false;
                    нарисоватьКубToolStripMenuItem.Visible = true;
                    
                }
                else
                {
                    сохранитьИзображениеКубаToolStripMenuItem.Enabled = true;
                    нарисоватьКубToolStripMenuItem.Visible = false;
                }
            }
            else
            {
                сохранитьИзображениеКубаToolStripMenuItem.Enabled = false;
                нарисоватьКубToolStripMenuItem.Visible = false;
            }
        }

        private FormPicture FormPicture(Form ActiveMdiChild)
        {
            throw new NotImplementedException();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormApp_Enter(object sender, EventArgs e)
        {
            сохранитьИзображениеКубаToolStripMenuItem.Enabled = true;
            нарисоватьКубToolStripMenuItem.Visible = false;            
        }

        private void нарисоватьКубToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(ActiveMdiChild.Tag);
            frmc[k] = new FormCube();
            frmc[k].Tag = k;
            frmc[k].Text = "Cube:"+ ActiveMdiChild.Text;
            frmc[k].cube = new Cube3d(frmc[k].cb);
            frmc[k].cube.Bit = new Bitmap(frmpict[k].pict.Image);
            frmc[k].MdiParent = this;
            frmc[k].Show();
        }

        private void сохранитьИзображениеКубаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(ActiveMdiChild.Tag);           
            Bitmap bt = new Bitmap(frmc[k].cb.Width, frmc[k].cb.Height);
            Rectangle rect=new Rectangle(0,0,frmc[k].cb.Width, frmc[k].cb.Height);
            frmc[k].cb.DrawToBitmap(bt, rect);
            bt.Save("ddd.bmp");            
        }
    }
}
