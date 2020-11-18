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
        public Form1()
        {
            InitializeComponent();
            GenerateWord();
            groupBox1.Enabled = false;
            help.Visible = false;
            player2con.Text = "";
        }

        private void GenerateWord()
        {
            label1.Text = Word.Text;
            label2.Text = "_" ;
            label3.Text = "_";
            label4.Text = "_";
            label5.Text = "_";
            label6.Text = "_";
            label7.Text = "_";
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            help.Text = (Word.Text).ToUpper();
            if ((help.Text).Length != 6)
            {
                playercon.Text = "Invaild Word Choose Again";
            }
            else
            {
                playercon.Text = "You Choose Great Word";
                Word.Text = String.Empty;
                groupBox1.Enabled = true;
                player1.Enabled = false;
                player2con.Text = "Choose A Letter";
            }
        }

        private void Guess_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (char.Parse(btn.Text) == help.Text[0])
            {
                label2.Text = (help.Text[0]).ToString();
                player2con.Text = "Nice Countine";
            }
            if (char.Parse(btn.Text) == help.Text[1])
            {
                label3.Text = (help.Text[1]).ToString();
                player2con.Text = "Cool Countine";
            }
            if (char.Parse(btn.Text) == help.Text[2])
            {
                label4.Text = (help.Text[2]).ToString();
                player2con.Text = "Crazy Countine";
            }
            if (char.Parse(btn.Text) == help.Text[3])
            {
                label5.Text = (help.Text[3]).ToString();
                player2con.Text = "WellDone Countine";
            }
            if (char.Parse(btn.Text) == help.Text[4])
            {
                label6.Text = (help.Text[4]).ToString();
                player2con.Text = "Dam Countine";
            }
            if (char.Parse(btn.Text) == help.Text[5])
            {
                label7.Text = (help.Text[5]).ToString();
                player2con.Text = "Good Countine";
            }

            if ((char.Parse(btn.Text) != help.Text[0]) && (char.Parse(btn.Text) != help.Text[1]) && (char.Parse(btn.Text) != help.Text[2]) && (char.Parse(btn.Text) != help.Text[3]) && (char.Parse(btn.Text) != help.Text[4]) && (char.Parse(btn.Text) != help.Text[5]))
            {
                worgGuess++;
                turn_lbl.Text = "turn : " + (worgGuess + 1);
                player2con.Text = "Nooo Try Again";
                if (worgGuess < 7)
                {
                    man_pict.Image = images[worgGuess];
                }
                else
                {
                    player2con.Text = "";
                    turn_lbl.Text = "YOU LOSE";
                    playercon.Text = "YOU WON";
                    groupBox1.Enabled = false;
                }
                
            
            }
            if ((label2.Text == (help.Text[0]).ToString()) && (label3.Text == (help.Text[1]).ToString()) && (label4.Text == (help.Text[2]).ToString()) && (label5.Text == (help.Text[3]).ToString()) && (label6.Text == (help.Text[4]).ToString()) && (label7.Text == (help.Text[5]).ToString()))
            {
                {
                    turn_lbl.Text = "YOU WON";
                    playercon.Text = "YOU LOSE";
                    player2con.Text = "";
                    groupBox1.Enabled = false;
                }
            }
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            playercon.Text = "Choose Word With 6 Chars";
            worgGuess = 0;
            man_pict.Image = images[worgGuess];
            turn_lbl.Text = "turn : " + (worgGuess + 1);
            player1.Enabled = true;
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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Button18_Click(object sender, EventArgs e)
        {

        }

        private void Button16_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Player1_Enter(object sender, EventArgs e)
        {

        }

        private void Label9_Click_1(object sender, EventArgs e)
        {

        }

        private void Fuck_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
