namespace OPTICAL_FLOW_EMGU
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.hmin_trackBar1 = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hmax_trackBar2 = new System.Windows.Forms.TrackBar();
            this.smin_trackBar3 = new System.Windows.Forms.TrackBar();
            this.smax_trackBar4 = new System.Windows.Forms.TrackBar();
            this.vmin_trackBar5 = new System.Windows.Forms.TrackBar();
            this.vmax_trackBar6 = new System.Windows.Forms.TrackBar();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.imageBox3 = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hmin_trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hmax_trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smin_trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smax_trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmin_trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmax_trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(12, 12);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(244, 294);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // hmin_trackBar1
            // 
            this.hmin_trackBar1.Location = new System.Drawing.Point(262, 12);
            this.hmin_trackBar1.Maximum = 255;
            this.hmin_trackBar1.Name = "hmin_trackBar1";
            this.hmin_trackBar1.Size = new System.Drawing.Size(274, 45);
            this.hmin_trackBar1.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hmax_trackBar2
            // 
            this.hmax_trackBar2.Location = new System.Drawing.Point(262, 63);
            this.hmax_trackBar2.Maximum = 255;
            this.hmax_trackBar2.Name = "hmax_trackBar2";
            this.hmax_trackBar2.Size = new System.Drawing.Size(274, 45);
            this.hmax_trackBar2.TabIndex = 4;
            this.hmax_trackBar2.Value = 255;
            // 
            // smin_trackBar3
            // 
            this.smin_trackBar3.Location = new System.Drawing.Point(262, 114);
            this.smin_trackBar3.Maximum = 255;
            this.smin_trackBar3.Name = "smin_trackBar3";
            this.smin_trackBar3.Size = new System.Drawing.Size(274, 45);
            this.smin_trackBar3.TabIndex = 5;
            // 
            // smax_trackBar4
            // 
            this.smax_trackBar4.Location = new System.Drawing.Point(262, 165);
            this.smax_trackBar4.Maximum = 255;
            this.smax_trackBar4.Name = "smax_trackBar4";
            this.smax_trackBar4.Size = new System.Drawing.Size(274, 45);
            this.smax_trackBar4.TabIndex = 6;
            this.smax_trackBar4.Value = 255;
            // 
            // vmin_trackBar5
            // 
            this.vmin_trackBar5.Location = new System.Drawing.Point(262, 216);
            this.vmin_trackBar5.Maximum = 255;
            this.vmin_trackBar5.Name = "vmin_trackBar5";
            this.vmin_trackBar5.Size = new System.Drawing.Size(274, 45);
            this.vmin_trackBar5.TabIndex = 7;
            // 
            // vmax_trackBar6
            // 
            this.vmax_trackBar6.Location = new System.Drawing.Point(262, 267);
            this.vmax_trackBar6.Maximum = 255;
            this.vmax_trackBar6.Name = "vmax_trackBar6";
            this.vmax_trackBar6.Size = new System.Drawing.Size(274, 45);
            this.vmax_trackBar6.TabIndex = 8;
            this.vmax_trackBar6.Value = 255;
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(542, 12);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(245, 294);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // imageBox3
            // 
            this.imageBox3.Location = new System.Drawing.Point(793, 12);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(249, 294);
            this.imageBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox3.TabIndex = 2;
            this.imageBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 346);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageBox3);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.vmax_trackBar6);
            this.Controls.Add(this.vmin_trackBar5);
            this.Controls.Add(this.smax_trackBar4);
            this.Controls.Add(this.smin_trackBar3);
            this.Controls.Add(this.hmax_trackBar2);
            this.Controls.Add(this.hmin_trackBar1);
            this.Controls.Add(this.imageBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hmin_trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hmax_trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smin_trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smax_trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmin_trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmax_trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.TrackBar hmin_trackBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar hmax_trackBar2;
        private System.Windows.Forms.TrackBar smin_trackBar3;
        private System.Windows.Forms.TrackBar smax_trackBar4;
        private System.Windows.Forms.TrackBar vmin_trackBar5;
        private System.Windows.Forms.TrackBar vmax_trackBar6;
        private Emgu.CV.UI.ImageBox imageBox2;
        private Emgu.CV.UI.ImageBox imageBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

