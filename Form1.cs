using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les2AO
{
    public partial class Form1 : Form
    {
        //maakt de afbeeldingen aan
        string[] afbeeldingen = { "G0.jpg", "G1.jpg", "G2.jpg", "G3.jpg", "G4.jpg", "G5.jpg", "G6.jpg", "G7.jpg", "G8.jpg", "G9.jpg", "G10.jpg" };
        int huidigeAfbeelding = 0;
        string[] guessedLettersTotal = { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
        string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        string[] WordList = {
            "apple",
            "banana",
            "cherry",
            "dog",
            "elephant",
            "forest",
            "guitar",
            "happy",
            "island",
            "jazz",
            "kangaroo",
            "lemon",
            "mountain",
            "notebook",
            "ocean",
            "piano",
            "quasar",
            "rainbow",
            "sunset",
            "tiger"
        };
        List<char> charList = new List<char>();

        public void resetTheList()
        {

            huidigeAfbeelding = 0;
            Hangman.Image = Image.FromFile("images\\" + afbeeldingen[huidigeAfbeelding]);
            int WordListLength = WordList.Length;
            int randomWord = new Random().Next(0, WordListLength);
            string TheChosenOne = WordList[randomWord];
            string[] LenChosenOne = new string[TheChosenOne.Length];
            for (int i = 0; i < TheChosenOne.Length; i++)
            {
                LenChosenOne[i] = "_";
            }
            label1.Text = string.Join(" ", LenChosenOne);

            foreach (char c in TheChosenOne)
            {
                charList.Add(c);
            }
            Console.WriteLine("Original String: " + TheChosenOne);
            Console.WriteLine("List of Characters: " + string.Join(" ", charList));
            LettersUsed.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
            resetTheList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string imageName = $"images/{afbeeldingen[huidigeAfbeelding]}";
            Console.WriteLine("imageName: " + imageName);
            Hangman.Image = Image.FromFile(imageName);
            
        }
        //reset button
        private void button1_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("lengte afbeeldingen: " + afbeeldingen.Length);
            resetTheList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool continueLoop = true;
            string guessZaLettah = GuessedLetter.Text;

            bool alreadyOwned = guessedLettersTotal.Contains(guessZaLettah);
            bool InAlph = alphabet.Contains(guessZaLettah);

            for (int j = 0; j <= guessedLettersTotal.Length; j++)
            {
                if (continueLoop && !alreadyOwned && InAlph && guessedLettersTotal[j] == " ")
                {
                    continueLoop = false;
                    if (true) { } 

                    guessedLettersTotal[j] = guessZaLettah;
                }
            }

            
            LettersUsed.Text = string.Join(" ", guessedLettersTotal);
            Console.WriteLine(string.Join(" + ", guessedLettersTotal));
        }
    }
}
