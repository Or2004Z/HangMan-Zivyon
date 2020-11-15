using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan_Dudi
{
    public partial class Form1 : Form
    {
        private Image[] images = { HangMan_Dudi.Properties.Resources.hangman_1,
            HangMan_Dudi.Properties.Resources.hangman_2,
            HangMan_Dudi.Properties.Resources.hangman_3,
            HangMan_Dudi.Properties.Resources.hangman_4,
            HangMan_Dudi.Properties.Resources.hangman_5,
            HangMan_Dudi.Properties.Resources.hangman_6,
            HangMan_Dudi.Properties.Resources.hangman_7};
        private int worgGuess = 0;

        string[] words = { "thumbscrew", "numbskull", "espionage", "fluffiness", "bookworm", "boxcar", "walkway" };
        public Form1()
        {
            InitializeComponent();
            GenerateWord();
        }

        private void GenerateWord()
        {
            Random rnd = new Random();
            int x = rnd.Next(words.Length);
            label1.Text = words[x];
            string w = words[x];
            w = '_' + w.Remove(0, 1);
            w = '_' + w.Substring(1);
            label2.Text = w;


        }

        

        private void Guess_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn.Text=="A")
            {

            }

            worgGuess++;
            if (worgGuess < images.Length)
            {
                man_pict.Image = images[worgGuess];
                turn_lbl.Text = "turn : " + (worgGuess + 1);
            }
            else
            {
                turn_lbl.Text = "you loose";
                groupBox1.Enabled = false;
            }
               


        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            worgGuess = 0;
            man_pict.Image = images[worgGuess];
            turn_lbl.Text = "turn : " + (worgGuess + 1);
            groupBox1.Enabled = false;
            GenerateWord();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Turn_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
