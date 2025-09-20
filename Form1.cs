using System;
using System.Windows.Forms;

namespace MelangeurDeLettres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMelanger_Click(object sender, EventArgs e)
        {
            string inputText = textBoxInput.Text.Trim();
            if (string.IsNullOrEmpty(inputText))
            {
                labelResult.Text = "Veuillez entrer un mot ou une phrase.";
                return;
            }

            string shuffledText;
            if (checkBoxShuffleWords.Checked)
            {
                shuffledText = ShuffleWords(inputText);
            }
            else
            {
                shuffledText = ShuffleLetters(inputText);
            }
            labelResult.Text = shuffledText;
        }

        private string ShuffleLetters(string input)
        {
            char[] characters = input.ToCharArray();
            Random rng = new Random();
            int n = characters.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                char value = characters[k];
                characters[k] = characters[n];
                characters[n] = value;
            }
            return new string(characters);
        }

        private string ShuffleWords(string input)
        {
            string[] words = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = ShuffleLetters(words[i]);
            }
            return string.Join(" ", words);
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(labelResult.Text))
            {
                Clipboard.SetText(labelResult.Text);
                MessageBox.Show("Résultat copié dans le presse-papiers!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
