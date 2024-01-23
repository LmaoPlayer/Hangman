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
  "tiger",
  "adventure",
  "balloon",
  "chocolate",
  "dolphin",
  "explorer",
  "flamingo",
  "galaxy",
  "hummingbird",
  "iceberg",
  "jungle",
  "kiwi",
  "labyrinth",
  "melody",
  "nebula",
  "orchard",
  "parrot",
  "quest",
  "rhapsody",
  "stargazer",
  "trampoline",
  "universe",
  "velvet",
  "whimsical",
  "xylophone",
  "zephyr",
  "amethyst",
  "blossom",
  "cascade",
  "dream",
  "enchant",
  "fantasy",
  "gemstone",
  "horizon",
  "inspire",
  "jovial",
  "kaleidoscope",
  "luminous",
  "moonlight",
  "mystical",
  "navigate",
  "opulent",
  "paradise",
  "quiver",
  "radiant",
  "serenade",
  "tranquility",
  "utopia",
  "vibrant",
  "wanderlust",
  "xenon",
  "yearning",
  "zenith",
  "abyss",
  "blissful",
  "celestial",
  "dandelion",
  "ethereal",
  "fountain",
  "galaxy",
  "hibiscus",
  "iridescent",
  "journey",
  "kismet",
  "labyrinth",
  "meadow",
  "nocturne",
  "oasis",
  "pulsar",
  "quest",
  "ripple",
  "sapphire",
  "symphony",
  "twilight",
  "unity",
  "voyage",
  "whimsy",
  "zenith",
  "aurora",
  "breeze",
  "cascade",
  "drizzle",
  "elixir",
  "fauna",
  "gleam",
  "harmony",
  "illusion",
  "jubilant",
  "kinetic",
  "luminescent",
  "marigold",
  "nocturnal",
  "oceanic",
  "parchment",
  "quixotic",
  "rapture",
  "solstice",
  "tapestry",
  "verdant",
  "waterfall",
  "zeal",
  "alchemy",
  "bountiful",
  "crystalline",
  "effervescent",
  "fable",
  "gossamer",
  "halcyon",
  "incandescent",
  "juniper",
  "lagoon",
  "meander",
  "nectar",
  "oracle",
  "prismatic",
  "quench",
  "resplendent",
  "silhouette",
  "transcendent",
  "vernal",
  "whimsical",
  "zenith",
  "ambrosia",
  "celestial",
  "efflorescent",
  "glistening",
  "idyllic",
  "jubilation",
  "kindle",
  "luminosity",
  "nebulous",
  "opulent",
  "pristine",
  "radiant",
  "serendipity",
  "timeless",
  "verdant",
  "whimsy",
  "zenithal",
  "allure",
  "bewitch",
  "cascade",
  "diaphanous",
  "ephemeral",
  "flourish",
  "grandeur",
  "haven",
  "iridescence",
  "jubilant",
  "lustrous",
  "meadow",
  "nebulae",
  "opalescent",
  "paradigm",
  "quiescent",
  "resplendent",
  "serenity",
  "tapestry",
  "umber",
  "velvety",
  "wondrous",
  "zenith",
  "ambrosial",
  "celestial",
  "effervesce",
  "gossamer",
  "halcyon",
  "illuminate",
  "jubilee",
  "kindred",
  "luminous",
  "nocturne",
  "opulent",
  "radiant",
  "serendipity",
  "transcendent",
  "vernal",
  "whimsy",
  "zenithal",
  "alluring",
  "bounteous"
};
        List<char> charList = new List<char>();
        string TheChosenOne;
        List<string> NewTextOnLabel = new List<string>();
        int totalGuesses = 0;
        private void resetTheList()
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
            charList.Clear();
            NewTextOnLabel.Clear();
            for (int i = 0; i < guessedLettersTotal.Length; i++)
            {
                guessedLettersTotal[i] = " ";
            }
            totalGuesses = 0;

            foreach (char c in TheChosenOne)
            {
                charList.Add(c);
            }
            Console.WriteLine("Original String: " + TheChosenOne);
            Console.WriteLine("List of Characters: " + string.Join(" ", charList));
            LettersUsed.Text = "";
            for (int i = 0; i < TheChosenOne.Length; i++)
            {
                NewTextOnLabel.Add("_");
            }
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

        private void GuessedLetter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool continueLoop = true;
                string guessZaLettah = GuessedLetter.Text;

                bool alreadyOwned = guessedLettersTotal.Contains(guessZaLettah);
                bool InAlph = alphabet.Contains(guessZaLettah);

                if (continueLoop && !alreadyOwned && InAlph)
                {
                    continueLoop = false;
                    /*if (charList.Contains(guessZaLettah)) {
                        Console.WriteLine("TheChosenOne contains " + guessZaLettah);
                    } 
    */
                    if (charList.Contains(guessZaLettah[0]))
                    {
                        Console.WriteLine("TheChosenOne contains " + guessZaLettah);
                        for (int i = 0; i < charList.Count; i++)
                        {
                            if (charList[i] == guessZaLettah[0])
                            {
                                Console.WriteLine("charList[i] == guessZaLettah[0]");
                                NewTextOnLabel[i] = guessZaLettah;
                            }
                            else if (charList[i] != guessZaLettah[0] && NewTextOnLabel[i] == "_")
                            {
                                NewTextOnLabel[i] = "_";
                            }
                        }
                        label1.Text = string.Join(" ", NewTextOnLabel);
                        LettersUsed.Text = string.Join(" ", guessedLettersTotal);
                    }
                    else
                    {
                        Console.WriteLine("TheChosenOne does not contain " + guessZaLettah);
                        huidigeAfbeelding++;
                        Hangman.Image = Image.FromFile("images\\" + afbeeldingen[huidigeAfbeelding]);
                    }

                    if (totalGuesses < guessedLettersTotal.Length)
                    {
                        guessedLettersTotal[totalGuesses] = guessZaLettah;
                        totalGuesses++;
                        LettersUsed.Text = string.Join(" ", guessedLettersTotal);
                        Console.WriteLine(string.Join(" + ", guessedLettersTotal));
                    }

                    if (huidigeAfbeelding == 10)
                    {
                        MessageBox.Show("You lose.");
                        resetTheList();
                    } else if (!NewTextOnLabel.Contains("_"))
                    {
                        MessageBox.Show("You win!");
                        resetTheList();
                    }
                    // sure
                }
                GuessedLetter.Text = "";
            
            }
           
        }
    }
}
