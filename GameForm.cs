using System;
using System.Windows.Forms;
using System.Drawing;
using System.Media;
using System.Configuration;


namespace DiabloClassRandomizer
{
    public partial class GameForm : Form
    {
        private const string SoundLocation = "Resources\\Audio\\freshmeat.wav";
        private readonly SoundPlayer mediaPlayer;

        public GameForm()
        {
            InitializeComponent();

            // Initialize the media player instance
            mediaPlayer = new SoundPlayer(SoundLocation);
        }

        // Diablo I Click Event
        private void PbGame1_Click(object sender, EventArgs e)
        {
            var selectedImage = (PictureBox)sender;
            var selectedGame = selectedImage.Tag.ToString();

            try
            {
                // Play the audio file
                mediaPlayer.Play();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during playback
                // You can display an error message or perform any necessary actions
                // based on your application's requirements
                Console.WriteLine($"Error playing audio: {ex.Message}");
            }

            // Randomize the classes based on the selected game
            var selectedClass = RandomizeClass(selectedGame);

            // Navigate to the ResultForm and pass the selected game and class as parameters
            var resultForm = new ResultForm(selectedGame, selectedClass);
            resultForm.Show();
            this.Hide();
        }

        // Diablo II Click Event

        private void PbGame2_Click(object sender, EventArgs e)
        {
            var selectedImage = (PictureBox)sender;
            var selectedGame = selectedImage.Tag.ToString();

            try
            {
                // Play the audio file
                mediaPlayer.Play();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during playback
                // You can display an error message or perform any necessary actions
                // based on your application's requirements
                Console.WriteLine($"Error playing audio: {ex.Message}");
            }

            // Randomize the classes based on the selected game
            var selectedClass = RandomizeClass(selectedGame);

            // Navigate to the ResultForm and pass the selected game and class as parameters
            var resultForm = new ResultForm(selectedGame, selectedClass);
            resultForm.Show();
            this.Hide();
        }

        // Diablo III Click Event
        private void PbGame3_Click(object sender, EventArgs e)
        {
            var selectedImage = (PictureBox)sender;
            var selectedGame = selectedImage.Tag.ToString();

            try
            {
                // Play the audio file
                mediaPlayer.Play();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during playback
                // You can display an error message or perform any necessary actions
                // based on your application's requirements
                Console.WriteLine($"Error playing audio: {ex.Message}");
            }

            // Randomize the classes based on the selected game
            var selectedClass = RandomizeClass(selectedGame);

            // Navigate to the ResultForm and pass the selected game and class as parameters
            var resultForm = new ResultForm(selectedGame, selectedClass);
            resultForm.Show();
            this.Hide();
        }

        // Diablo IV Click Event
        private void PbGame4_Click(object sender, EventArgs e)
        {
            var selectedImage = (PictureBox)sender;
            var selectedGame = selectedImage.Tag.ToString();

            try
            {
                // Play the audio file
                mediaPlayer.Play();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during playback
                // You can display an error message or perform any necessary actions
                // based on your application's requirements
                Console.WriteLine($"Error playing audio: {ex.Message}");
            }

            // Randomize the classes based on the selected game
            var selectedClass = RandomizeClass(selectedGame);

            // Navigate to the ResultForm and pass the selected game and class as parameters
            var resultForm = new ResultForm(selectedGame, selectedClass);
            resultForm.Show();
            this.Hide();
        }

        // Diablo Immortal Click Event
        private void PbGame5_Click(object sender, EventArgs e)
        {
            var selectedImage = (PictureBox)sender;
            var selectedGame = selectedImage.Tag.ToString();

            try
            {
                // Play the audio file
                mediaPlayer.Play();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during playback
                // You can display an error message or perform any necessary actions
                // based on your application's requirements
                Console.WriteLine($"Error playing audio: {ex.Message}");
            }

            // Randomize the classes based on the selected game
            var selectedClass = RandomizeClass(selectedGame);

            // Navigate to the ResultForm and pass the selected game and class as parameters
            var resultForm = new ResultForm(selectedGame, selectedClass);
            resultForm.Show();
            this.Hide();
        }


        private int previousClassIndex = -1; // Initialize the previous class index to an invalid value

        private string RandomizeClass(string game)
        {
            // Generate a random class based on the selected game
            string[] classes;
            switch (game)
            {
                case "PbGame1":
                    classes = new string[] { "Monk", "Rogue", "Sorcerer", "Warrior" }; // classes for Diablo I
                    break;
                case "PbGame2":
                    classes = new string[] { "Amazon", "Assassin", "Barbarian", "Druid", "Necromancer", "Paladin", "Sorceress" }; // classes for Diablo II
                    break;
                case "PbGame3":
                    classes = new string[] { "Barbarian", "Crusader", "Demon Hunter", "Monk", "Necromancer", "Witch Doctor", "Wizard" }; // classes for Diablo III
                    break;
                case "PbGame4":
                    classes = new string[] { "Barbarian", "Druid", "Necromancer", "Rogue", "Sorcerer" }; // classes for Diablo IV
                    break;
                case "PbGame5":
                    classes = new string[] { "Barbarian", "Blood Knight", "Crusader", "Demon Hunter", "Monk", "Necromancer", "Wizard" }; // classes for Diablo Immortal
                    break;
                default:
                    classes = new string[0]; // Invalid game, no classes
                    break;
            }

            // Create a random number generator
            var random = new Random();

            // Generate a new index that is not the same as the previous index
            int newIndex;
            do
            {
                newIndex = random.Next(classes.Length);
            } while (newIndex == previousClassIndex);

            // Update the previous index with the newly generated index
            previousClassIndex = newIndex;

            // Return the class at the new index
            return classes[newIndex];
        }

    }
}
