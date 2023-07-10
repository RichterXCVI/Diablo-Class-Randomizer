using System;
using System.Drawing;
using System.Windows.Forms;

namespace DiabloClassRandomizer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public class CustomButton : Button
        {
            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                // Draw a custom border using a Pen with the desired color and thickness
                using (Pen borderPen = new Pen(Color.Red, 2))
                {
                    Rectangle borderRect = new Rectangle(0, 0, Width - 1, Height - 1);
                    e.Graphics.DrawRectangle(borderPen, borderRect);
                }
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.Show();
            Hide();
        }
    }
}
