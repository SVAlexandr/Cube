namespace Cube
{
    partial class FormCube
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.SuspendLayout();
            // 
            // cb
            // 
            this.cb.AccumBits = ((byte)(0));
            this.cb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb.AutoCheckErrors = false;
            this.cb.AutoFinish = false;
            this.cb.AutoMakeCurrent = true;
            this.cb.AutoSwapBuffers = true;
            this.cb.BackColor = System.Drawing.Color.Black;
            this.cb.ColorBits = ((byte)(32));
            this.cb.DepthBits = ((byte)(16));
            this.cb.Location = new System.Drawing.Point(0, 0);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(556, 376);
            this.cb.StencilBits = ((byte)(0));
            this.cb.TabIndex = 0;
            this.cb.Load += new System.EventHandler(this.cb_Load);
            this.cb.Click += new System.EventHandler(this.cb_Click);
            this.cb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cb_MouseDown);
            this.cb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cb_MouseMove);
            this.cb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cb_MouseUp);
            this.cb.Resize += new System.EventHandler(this.cb_Resize);
            // 
            // FormCube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 375);
            this.Controls.Add(this.cb);
            this.DoubleBuffered = true;
            this.Name = "FormCube";
            this.Text = "FormCube";
            this.Load += new System.EventHandler(this.FormCube_Load);
            this.ResizeEnd += new System.EventHandler(this.FormCube_ResizeEnd);
            this.ResumeLayout(false);

        }

        #endregion

        public Tao.Platform.Windows.SimpleOpenGlControl cb;

    }
}