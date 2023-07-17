using System;
using System.Linq;
using System.Windows.Forms;

namespace DiabloClassRandomizer
{
    public partial class ResultForm : Form
    {
        private string selectedClass;

        public ResultForm(string selectedGame, string selectedClass)
        {
            InitializeComponent();
            this.selectedClass = selectedClass;
            UpdateLabel();
            this.PbClass.Parent = this.PbResultPage;
        }

        private void UpdateLabel()
        {
            // Update the label text with the selected class
            classLabel.Text = selectedClass;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Navigate back to the previous form (GameForm)
            var gameForm = new GameForm();
            gameForm.Show();
            this.Close();
        }
    }
}
