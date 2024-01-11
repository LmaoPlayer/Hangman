using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les2AO
{
    public partial class Form1 : Form
    {
        //maakt de afbeeldingen aan
        string[] afbeeldingen = { "G0.jpg", "G1.jpg", "G2.jpg", "G3.jpg", "G4.jpg", "G5.jpg", "G6.jpg", "G7.jpg", "G8.jpg", "G9.jpg", "G10.jpg"};
        int huidigeAfbeelding = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string imageName = $"images/{afbeeldingen[huidigeAfbeelding]}";
            Console.WriteLine("imageName: " + imageName);
            Hangman.Image = Image.FromFile(imageName);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("lengte afbeeldingen: " + afbeeldingen.Length);
            if (0 < huidigeAfbeelding && huidigeAfbeelding < afbeeldingen.Length)
            {
                huidigeAfbeelding--;
                Hangman.Image = Image.FromFile("images\\" + afbeeldingen[huidigeAfbeelding]);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (0 <= huidigeAfbeelding && huidigeAfbeelding < (afbeeldingen.Length-1))
            {
                huidigeAfbeelding++;
                Hangman.Image = Image.FromFile("images\\" + afbeeldingen[huidigeAfbeelding]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
