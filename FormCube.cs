using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.Platform.Windows;

namespace Cube
{
    public partial class FormCube : Form
    {
        private int dx, dy,rx=0,ry=0;
        public Cube3d cube;
        public FormCube()
        {
            InitializeComponent();            
        }

        private void FormCube_Load(object sender, EventArgs e)
        {
            cube.DrawCube(cb,rx,ry);
            
        }

        private void cb_Load(object sender, EventArgs e)
        {
           
        }

        private void cb_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FormCube_ResizeEnd(object sender, EventArgs e)
        {
            
        }

        private void cb_Resize(object sender, EventArgs e)
        {
            cube.Init(cb);
            cube.DrawCube(cb,rx,ry);
        }

        private void cb_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dx = e.X;
                dy = e.Y;
            }
        }

        private void cb_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
                cube.DrawWire(cb, rx+e.X-dx, ry+e.Y-dy);
            }
        }

        private void cb_MouseUp(object sender, MouseEventArgs e)
        {
            rx += e.X - dx;
            ry += e.Y - dy;
            cube.DrawCube(cb, rx, ry);
        }
    }
}
