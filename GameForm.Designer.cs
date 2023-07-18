namespace DiabloClassRandomizer
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.PbGame1 = new System.Windows.Forms.PictureBox();
            this.PbGame2 = new System.Windows.Forms.PictureBox();
            this.PbGame3 = new System.Windows.Forms.PictureBox();
            this.PbGame4 = new System.Windows.Forms.PictureBox();
            this.PbGame5 = new System.Windows.Forms.PictureBox();
            this.PbGamePage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbGame1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbGame2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbGame3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbGame4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbGame5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbGamePage)).BeginInit();
            this.SuspendLayout();
            // 
            // PbGame1
            // 
            this.PbGame1.BackgroundImage = global::DiabloClassRandomizer.Properties.Resources.diablo1;
            this.PbGame1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PbGame1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PbGame1.Location = new System.Drawing.Point(35, 54);
            this.PbGame1.Name = "PbGame1";
            this.PbGame1.Size = new System.Drawing.Size(324, 101);
            this.PbGame1.TabIndex = 0;
            this.PbGame1.TabStop = false;
            this.PbGame1.Tag = "PbGame1";
            this.PbGame1.Click += new System.EventHandler(this.PbGame1_Click);
            // 
            // PbGame2
            // 
            this.PbGame2.BackgroundImage = global::DiabloClassRandomizer.Properties.Resources.diablo2;
            this.PbGame2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PbGame2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PbGame2.Location = new System.Drawing.Point(35, 172);
            this.PbGame2.Name = "PbGame2";
            this.PbGame2.Size = new System.Drawing.Size(324, 101);
            this.PbGame2.TabIndex = 2;
            this.PbGame2.TabStop = false;
            this.PbGame2.Tag = "PbGame2";
            this.PbGame2.Click += new System.EventHandler(this.PbGame2_Click);
            // 
            // PbGame3
            // 
            this.PbGame3.BackgroundImage = global::DiabloClassRandomizer.Properties.Resources.diablo3;
            this.PbGame3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PbGame3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PbGame3.Location = new System.Drawing.Point(35, 290);
            this.PbGame3.Name = "PbGame3";
            this.PbGame3.Size = new System.Drawing.Size(324, 101);
            this.PbGame3.TabIndex = 3;
            this.PbGame3.TabStop = false;
            this.PbGame3.Tag = "PbGame3";
            this.PbGame3.Click += new System.EventHandler(this.PbGame3_Click);
            // 
            // PbGame4
            // 
            this.PbGame4.BackgroundImage = global::DiabloClassRandomizer.Properties.Resources.diablo4;
            this.PbGame4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PbGame4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PbGame4.Location = new System.Drawing.Point(35, 411);
            this.PbGame4.Name = "PbGame4";
            this.PbGame4.Size = new System.Drawing.Size(324, 101);
            this.PbGame4.TabIndex = 4;
            this.PbGame4.TabStop = false;
            this.PbGame4.Tag = "PbGame4";
            this.PbGame4.Click += new System.EventHandler(this.PbGame4_Click);
            // 
            // PbGame5
            // 
            this.PbGame5.BackgroundImage = global::DiabloClassRandomizer.Properties.Resources.diabloimmortal;
            this.PbGame5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PbGame5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PbGame5.Location = new System.Drawing.Point(35, 529);
            this.PbGame5.Name = "PbGame5";
            this.PbGame5.Size = new System.Drawing.Size(324, 101);
            this.PbGame5.TabIndex = 5;
            this.PbGame5.TabStop = false;
            this.PbGame5.Tag = "PbGame5";
            this.PbGame5.Click += new System.EventHandler(this.PbGame5_Click);
            // 
            // PbGamePage
            // 
            this.PbGamePage.BackgroundImage = global::DiabloClassRandomizer.Properties.Resources.gamepage;
            this.PbGamePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbGamePage.Location = new System.Drawing.Point(-1, 0);
            this.PbGamePage.Name = "PbGamePage";
            this.PbGamePage.Size = new System.Drawing.Size(384, 661);
            this.PbGamePage.TabIndex = 6;
            this.PbGamePage.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(384, 661);
            this.Controls.Add(this.PbGame5);
            this.Controls.Add(this.PbGame4);
            this.Controls.Add(this.PbGame3);
            this.Controls.Add(this.PbGame2);
            this.Controls.Add(this.PbGame1);
            this.Controls.Add(this.PbGamePage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Game";
            ((System.ComponentModel.ISupportInitialize)(this.PbGame1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbGame2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbGame3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbGame4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbGame5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbGamePage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbGame1;
        private System.Windows.Forms.PictureBox PbGame2;
        private System.Windows.Forms.PictureBox PbGame3;
        private System.Windows.Forms.PictureBox PbGame4;
        private System.Windows.Forms.PictureBox PbGame5;
        private System.Windows.Forms.PictureBox PbGamePage;
    }
}