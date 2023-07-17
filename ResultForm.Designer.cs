namespace DiabloClassRandomizer
{
    partial class ResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.PbClass = new System.Windows.Forms.PictureBox();
            this.classLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PbResultPage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbResultPage)).BeginInit();
            this.SuspendLayout();
            // 
            // PbClass
            // 
            this.PbClass.BackColor = System.Drawing.Color.Transparent;
            this.PbClass.BackgroundImage = global::DiabloClassRandomizer.Properties.Resources.randomclass;
            this.PbClass.Location = new System.Drawing.Point(12, 207);
            this.PbClass.Name = "PbClass";
            this.PbClass.Size = new System.Drawing.Size(360, 70);
            this.PbClass.TabIndex = 0;
            this.PbClass.TabStop = false;
            // 
            // classLabel
            // 
            this.classLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.classLabel.BackColor = System.Drawing.Color.Black;
            this.classLabel.Font = new System.Drawing.Font("Diablo", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.classLabel.Location = new System.Drawing.Point(122, 225);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(176, 21);
            this.classLabel.TabIndex = 3;
            this.classLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackgroundImage = global::DiabloClassRandomizer.Properties.Resources.diablo1;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Diablo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(126, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PbResultPage
            // 
            this.PbResultPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbResultPage.BackgroundImage")));
            this.PbResultPage.Location = new System.Drawing.Point(0, 0);
            this.PbResultPage.Name = "PbResultPage";
            this.PbResultPage.Size = new System.Drawing.Size(383, 661);
            this.PbResultPage.TabIndex = 4;
            this.PbResultPage.TabStop = false;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(384, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.PbClass);
            this.Controls.Add(this.PbResultPage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Results";
            ((System.ComponentModel.ISupportInitialize)(this.PbClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbResultPage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbClass;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox PbResultPage;
    }
}