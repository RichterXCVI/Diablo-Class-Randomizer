using System.Timers;
using System.Media;


namespace Diablo_IV_Class_Randomizer_v1._0
{
    public partial class MainForm : Form
    {

        // Calls sound to play when button is clicked
        private readonly SoundPlayer soundEffect = new(Properties.Resources.class_selected);

        // Keep track of btnRandomClass clicks
        int buttonClickCount = 0;


        public MainForm()
        {
            InitializeComponent();
        }


        // Check if Game if selected, if not Notify user with error
        private async void btnRandomClass_Click(object sender, EventArgs e)
        {
            if (cmbGame.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a game.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save game selection to string to associate correct classes per game
            string game = cmbGame.SelectedItem.ToString();

            // Increase count to 1 if btnRandomClass clicked
            buttonClickCount++;


            // Check if btnRandomClass is greater than 0 if greater, txtSelectedClass is cleared, sound plays and NEW class is shown.
            if (buttonClickCount > 0)
            {
                txtSelectedClass.Clear();
                soundEffect.Play();
                await Task.Delay(1000);
                buttonClickCount = 0; // reset the counter
            }
            else
                await Task.Delay(1000);

            // Randomizing classes based off game selected using Fisher-Yates shuffle algorithm
            Random rng = new();


            if (game == "Diablo IV")
            {
                string[] classes = { "Barbarian", "Druid", "Sorceress", "Rogue", "Necromancer" };
                for (int i = classes.Length - 1; i > 0; i--)
                {
                    // Generate a random index between 0 and i
                    int j = rng.Next(0, i + 1);

                    // Swap the current item with the randomly chosen item
                    (classes[j], classes[i]) = (classes[i], classes[j]);
                }
                txtSelectedClass.Text = classes[0];
            }
            else if (game == "Diablo III")
            {
                string[] classes = { "Barbarian", "Crusader", "Demon Hunter", "Monk", "Necromancer", "Witch Doctor", "Wizard" };
                for (int i = classes.Length - 1; i > 0; i--)
                {
                    // Generate a random index between 0 and i
                    int j = rng.Next(0, i + 1);

                    // Swap the current item with the randomly chosen item
                    (classes[j], classes[i]) = (classes[i], classes[j]);
                }
                txtSelectedClass.Text = classes[0];
            }
            else if (game == "Diablo II: Resurrected")
            {
                string[] classes = { "Amazon", "Assassin", "Barbarian", "Druid", "Necromancer", "Paladin", "Sorceress" };
                for (int i = classes.Length - 1; i > 0; i--)
                {
                    // Generate a random index between 0 and i
                    int j = rng.Next(0, i + 1);

                    // Swap the current item with the randomly chosen item
                    (classes[j], classes[i]) = (classes[i], classes[j]);
                }
                txtSelectedClass.Text = classes[0];
            }
            else if (game == "Diablo I")
            {
                string[] classes = { "Warrior", "Rogue", "Sorcerer" };
                for (int i = classes.Length - 1; i > 0; i--)
                {
                    // Generate a random index between 0 and i
                    int j = rng.Next(0, i + 1);

                    // Swap the current item with the randomly chosen item
                    (classes[j], classes[i]) = (classes[i], classes[j]);
                }
                txtSelectedClass.Text = classes[0];
            }
            else if (game == "Diablo Immortal")
            {
                string[] classes = { "Barbarian", "Blood Knight", "Crusader", "Demon Hunter", "Monk", "Necromancer", "Wizard" };
                for (int i = classes.Length - 1; i > 0; i--)
                {
                    // Generate a random index between 0 and i
                    int j = rng.Next(0, i + 1);

                    // Swap the current item with the randomly chosen item
                    (classes[j], classes[i]) = (classes[i], classes[j]);
                }
                txtSelectedClass.Text = classes[0];
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Add Names to comboBox
            cmbGame.Items.Add("Select Game");
            cmbGame.Items.Add("Diablo IV");
            cmbGame.Items.Add("Diablo III");
            cmbGame.Items.Add("Diablo II: Resurrected");
            cmbGame.Items.Add("Diablo I");
            cmbGame.Items.Add("Diablo Immortal");
            cmbGame.SelectedIndex = 0;
        }

        private void cmbGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clears textbox on Game Selection
            txtSelectedClass.Clear();
        }
    }
}