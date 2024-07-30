using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;

using System.Text;
using Tao.OpenGl;
using Tao.Platform.Windows;

namespace Cube
{
    public partial class Cube3d : Component
    {
        private Bitmap bit;
        public Bitmap Bit{set {bit=value;} get{return bit;}}
        public Cube3d(SimpleOpenGlControl cb)
        {
            cb.InitializeContexts();
            InitializeComponent();
            Init(cb);  
        }

        public Bitmap GetBitmap(SimpleOpenGlControl cb)
        {
            Bitmap res = new Bitmap(cb.Width, cb.Height);
            return res;
        }

        public void Init(SimpleOpenGlControl cb)
        {
            Gl.glClearColor(160.0f/255.0f, 160.0f/255.0f, 160.0f/255.0f, 1.0f);

            // установка порта вывода в соотвествии с размерами элемента anT 
            Gl.glViewport(0, 0, cb.Width, cb.Height);


            // настройка проекции 
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, (float)cb.Width / (float)cb.Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();         
        }

        public void DrawCube(SimpleOpenGlControl cb,int x, int y)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            DrawWire(cb,x,y);
            Color tmpC=new Color();
            Gl.glLoadIdentity();
            Gl.glTranslated(0, 0, -6);
            Gl.glRotated(45, 1, 1, 0);
            Gl.glRotated(x, 0, 1, 1);
            Gl.glRotated(y, 1, 0, 1);
            Gl.glScaled(0.005, 0.005, 0.005);
            Gl.glPushMatrix();
            Gl.glBegin(Gl.GL_POINTS);

            for (int i = 0; i < bit.Width; i++)
            {
                for (int j = 0; j < bit.Height; j++)
                {
                    tmpC=bit.GetPixel(i, j);
                    Gl.glColor3f(tmpC.R/255.0f, tmpC.G/255.0f, tmpC.B/255.0f);
                    Gl.glVertex3i(tmpC.R, tmpC.G, tmpC.B);
                }
            }
            Gl.glPointSize(1);
            Gl.glPopMatrix();
            Gl.glEnd();
            Gl.glFlush();
            cb.Invalidate();
        }

        public void DrawWire(SimpleOpenGlControl cb,int x,int y)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            Gl.glLoadIdentity();


            Gl.glPushMatrix();
            Gl.glTranslated(0, 0, -6);
            Gl.glRotated(45, 1, 1, 0);
            Gl.glRotated(x, 0, 1 , 1);
            Gl.glRotated(y, 1, 0, 1);
            Gl.glScaled(0.005, 0.005, 0.005);

            // рисуем каркас куба
            Gl.glBegin(Gl.GL_LINE_STRIP);
            Gl.glColor3f(0, 0, 0);
            Gl.glVertex3i(0, 0, 0);
            Gl.glColor3f(0, 0, 1.0f);
            Gl.glVertex3i(0, 0, 255);
            Gl.glColor3f(0, 1.0f, 1.0f);
            Gl.glVertex3i(0, 255, 255);
            Gl.glColor3f(0, 1.0f, 1.0f);
            Gl.glVertex3i(0, 255, 0);
            Gl.glColor3f(0, 0, 0);
            Gl.glVertex3i(0, 0, 0);
            Gl.glColor3f(1.0f, 0, 0);
            Gl.glVertex3i(255, 0, 0);
            Gl.glColor3f(1.0f, 1.0f, 0);
            Gl.glVertex3i(255, 255, 0);
            Gl.glColor3f(1.0f, 1.0f, 1.0f);
            Gl.glVertex3i(255, 255, 255);
            Gl.glColor3f(1.0f, 0, 1.0f);
            Gl.glVertex3i(255, 0, 255);
            Gl.glColor3f(1.0f, 0, 0);
            Gl.glVertex3i(255, 0, 0);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_LINE_STRIP);
            Gl.glColor3f(0, 0, 1.0f);
            Gl.glVertex3i(0, 0, 255);
            Gl.glColor3f(1.0f, 0, 1.0f);
            Gl.glVertex3i(255, 0, 255);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_LINE_STRIP);
            Gl.glColor3f(0, 1.0f, 1.0f);
            Gl.glVertex3i(0, 255, 255);
            Gl.glColor3f(1.0f, 1.0f, 1.0f);
            Gl.glVertex3i(255, 255, 255);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_LINE_STRIP);
            Gl.glColor3f(0, 1.0f, 0);
            Gl.glVertex3i(0, 255, 0);
            Gl.glColor3f(1.0f, 1.0f, 0);
            Gl.glVertex3i(255, 255, 0);
            Gl.glEnd();

            Gl.glPopMatrix();
            Gl.glFlush();
            cb.Invalidate();
        }
        
    }
}
