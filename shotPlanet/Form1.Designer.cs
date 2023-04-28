namespace shotPlanet
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.mark = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.dixuong = new System.Windows.Forms.Timer(this.components);
            this.level = new System.Windows.Forms.Timer(this.components);
            this.timer_checker = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new shotPlanet.Component1(this.components);
            this.planet = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.mark);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 533);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 28);
            this.panel2.TabIndex = 1;
            // 
            // mark
            // 
            this.mark.AutoSize = true;
            this.mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mark.Location = new System.Drawing.Point(3, 7);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(45, 16);
            this.mark.TabIndex = 0;
            this.mark.Text = "Mark:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // dixuong
            // 
            this.dixuong.Interval = 1000;
            this.dixuong.Tick += new System.EventHandler(this.dixuong_Tick);
            // 
            // level
            // 
            this.level.Interval = 500;
            this.level.Tick += new System.EventHandler(this.level_Tick);
            // 
            // timer_checker
            // 
            this.timer_checker.Enabled = true;
            this.timer_checker.Interval = 300;
            this.timer_checker.Tick += new System.EventHandler(this.timer_checker_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.planet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 537);
            this.panel1.TabIndex = 2;
            // 
            // planet
            // 
            this.planet.BackColor = System.Drawing.Color.Transparent;
            this.planet.Image = global::shotPlanet.Properties.Resources.maybay1;
            this.planet.Location = new System.Drawing.Point(207, 469);
            this.planet.Name = "planet";
            this.planet.Size = new System.Drawing.Size(63, 65);
            this.planet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.planet.TabIndex = 0;
            this.planet.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.planet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer dixuong;
        private Component1 panel1;
        private System.Windows.Forms.PictureBox planet;
        private System.Windows.Forms.Label mark;
        private System.Windows.Forms.Timer level;
        private System.Windows.Forms.Timer timer_checker;
    }
}

