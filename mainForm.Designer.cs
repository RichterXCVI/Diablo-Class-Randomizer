namespace Diablo_IV_Class_Randomizer_v1._0
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnRandomClass = new Button();
            txtSelectedClass = new TextBox();
            lblVersion = new Label();
            menuMain = new MenuStrip();
            cmbGame = new ToolStripComboBox();
            menuMain.SuspendLayout();
            SuspendLayout();
            // 
            // btnRandomClass
            // 
            btnRandomClass.BackColor = Color.Transparent;
            btnRandomClass.FlatStyle = FlatStyle.Flat;
            btnRandomClass.Font = new Font("Diablo", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRandomClass.ForeColor = Color.Red;
            btnRandomClass.Image = (Image)resources.GetObject("btnRandomClass.Image");
            btnRandomClass.Location = new Point(133, 212);
            btnRandomClass.Name = "btnRandomClass";
            btnRandomClass.Size = new Size(145, 44);
            btnRandomClass.TabIndex = 0;
            btnRandomClass.Text = "Select Class";
            btnRandomClass.UseVisualStyleBackColor = false;
            btnRandomClass.Click += btnRandomClass_Click;
            // 
            // txtSelectedClass
            // 
            txtSelectedClass.BackColor = SystemColors.WindowText;
            txtSelectedClass.BorderStyle = BorderStyle.None;
            txtSelectedClass.Font = new Font("Diablo", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            txtSelectedClass.ForeColor = Color.Firebrick;
            txtSelectedClass.Location = new Point(79, 111);
            txtSelectedClass.Name = "txtSelectedClass";
            txtSelectedClass.ReadOnly = true;
            txtSelectedClass.Size = new Size(273, 31);
            txtSelectedClass.TabIndex = 1;
            txtSelectedClass.TextAlign = HorizontalAlignment.Center;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.BackColor = Color.Transparent;
            lblVersion.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lblVersion.ForeColor = Color.Red;
            lblVersion.Location = new Point(12, 304);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(42, 20);
            lblVersion.TabIndex = 2;
            lblVersion.Text = "v1.2";
            // 
            // menuMain
            // 
            menuMain.BackColor = Color.Transparent;
            menuMain.Items.AddRange(new ToolStripItem[] { cmbGame });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(405, 25);
            menuMain.TabIndex = 4;
            // 
            // cmbGame
            // 
            cmbGame.Alignment = ToolStripItemAlignment.Right;
            cmbGame.BackColor = SystemColors.InfoText;
            cmbGame.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGame.FlatStyle = FlatStyle.Flat;
            cmbGame.Font = new Font("Diablo", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbGame.ForeColor = Color.Firebrick;
            cmbGame.MaxDropDownItems = 3;
            cmbGame.Name = "cmbGame";
            cmbGame.Size = new Size(200, 21);
            cmbGame.ToolTipText = "Selects Game to load classes";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 11F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(405, 331);
            Controls.Add(lblVersion);
            Controls.Add(txtSelectedClass);
            Controls.Add(btnRandomClass);
            Controls.Add(menuMain);
            DoubleBuffered = true;
            Font = new Font("Digital-7 Mono", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuMain;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Diablo Class Randomizer";
            Load += MainForm_Load;
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRandomClass;
        private TextBox txtSelectedClass;
        private Label lblVersion;
        private MenuStrip menuMain;
        private ToolStripComboBox cmbGame;
    }
}