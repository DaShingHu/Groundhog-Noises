namespace Groundhog_Viewer
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.mTabAbout = new MetroFramework.Controls.MetroTabPage();
            this.mTabMain = new MetroFramework.Controls.MetroTabPage();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.metroTabControl1.SuspendLayout();
            this.mTabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.mTabMain);
            this.metroTabControl1.Controls.Add(this.mTabAbout);
            this.metroTabControl1.Location = new System.Drawing.Point(25, 67);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(609, 459);
            this.metroTabControl1.TabIndex = 2;
            // 
            // mTabAbout
            // 
            this.mTabAbout.HorizontalScrollbarBarColor = true;
            this.mTabAbout.Location = new System.Drawing.Point(4, 35);
            this.mTabAbout.Name = "mTabAbout";
            this.mTabAbout.Size = new System.Drawing.Size(601, 420);
            this.mTabAbout.TabIndex = 1;
            this.mTabAbout.Text = "About";
            this.mTabAbout.VerticalScrollbarBarColor = true;
            // 
            // mTabMain
            // 
            this.mTabMain.Controls.Add(this.pnlImage);
            this.mTabMain.Controls.Add(this.btnRandom);
            this.mTabMain.Controls.Add(this.btnPause);
            this.mTabMain.Controls.Add(this.btnPlay);
            this.mTabMain.HorizontalScrollbarBarColor = true;
            this.mTabMain.Location = new System.Drawing.Point(4, 35);
            this.mTabMain.Name = "mTabMain";
            this.mTabMain.Size = new System.Drawing.Size(601, 420);
            this.mTabMain.TabIndex = 0;
            this.mTabMain.Text = "Groundhogs";
            this.mTabMain.VerticalScrollbarBarColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.White;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(3, 391);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(146, 23);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.White;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Location = new System.Drawing.Point(155, 391);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(291, 23);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.White;
            this.btnRandom.FlatAppearance.BorderSize = 0;
            this.btnRandom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRandom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom.Location = new System.Drawing.Point(452, 391);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(146, 23);
            this.btnRandom.TabIndex = 5;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // pnlImage
            // 
            this.pnlImage.BackColor = System.Drawing.Color.White;
            this.pnlImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlImage.Location = new System.Drawing.Point(4, 4);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(594, 381);
            this.pnlImage.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(658, 560);
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(21, 63, 21, 21);
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Groundhog";
            this.metroTabControl1.ResumeLayout(false);
            this.mTabMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage mTabAbout;
        private MetroFramework.Controls.MetroTabPage mTabMain;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Panel pnlImage;
    }
}

