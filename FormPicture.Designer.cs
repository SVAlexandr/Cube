namespace Cube
{
    partial class FormPicture
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
            this.btnCD = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.pict = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picH = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pict)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picH)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCD
            // 
            this.btnCD.Location = new System.Drawing.Point(12, 12);
            this.btnCD.Name = "btnCD";
            this.btnCD.Size = new System.Drawing.Size(95, 23);
            this.btnCD.TabIndex = 1;
            this.btnCD.Text = "Обрезать";
            this.btnCD.UseVisualStyleBackColor = true;
            this.btnCD.Click += new System.EventHandler(this.btnCD_Click);
            // 
            // btnR
            // 
            this.btnR.Enabled = false;
            this.btnR.Location = new System.Drawing.Point(122, 12);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(95, 23);
            this.btnR.TabIndex = 2;
            this.btnR.Text = "Восстановить";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // pict
            // 
            this.pict.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pict.Location = new System.Drawing.Point(12, 41);
            this.pict.Name = "pict";
            this.pict.Size = new System.Drawing.Size(637, 382);
            this.pict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pict.TabIndex = 0;
            this.pict.TabStop = false;
            this.pict.Click += new System.EventHandler(this.pict_Click);
            this.pict.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pict_MouseDown);
            this.pict.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pict_MouseMove);
            this.pict.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pict_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.picH);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 401);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // picH
            // 
            this.picH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picH.BackColor = System.Drawing.SystemColors.Menu;
            this.picH.Location = new System.Drawing.Point(1, 1);
            this.picH.Name = "picH";
            this.picH.Size = new System.Drawing.Size(637, 399);
            this.picH.TabIndex = 0;
            this.picH.TabStop = false;
            this.picH.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picH_MouseDown);
            this.picH.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picH_MouseMove);
            // 
            // FormPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(458, 354);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnCD);
            this.Controls.Add(this.pict);
            this.DoubleBuffered = true;
            this.Name = "FormPicture";
            this.Text = "FormPicture";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPicture_FormClosed);
            this.Load += new System.EventHandler(this.FormPicture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pict)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCD;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pict;
        private System.Windows.Forms.PictureBox picH;
    }
}