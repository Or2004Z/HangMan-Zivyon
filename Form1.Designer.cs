namespace HangMan_Dudi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.a_btn = new System.Windows.Forms.Button();
            this.b_btn = new System.Windows.Forms.Button();
            this.c_btn = new System.Windows.Forms.Button();
            this.d_btn = new System.Windows.Forms.Button();
            this.man_pict = new System.Windows.Forms.PictureBox();
            this.turn_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.player2con = new System.Windows.Forms.Label();
            this.button21 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.e_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reset_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Word = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.TextBox();
            this.player1 = new System.Windows.Forms.GroupBox();
            this.player1con = new System.Windows.Forms.Label();
            this.playercon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.man_pict)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.player1.SuspendLayout();
            this.SuspendLayout();
            // 
            // a_btn
            // 
            this.a_btn.Location = new System.Drawing.Point(6, 13);
            this.a_btn.Name = "a_btn";
            this.a_btn.Size = new System.Drawing.Size(29, 23);
            this.a_btn.TabIndex = 1;
            this.a_btn.Text = "A";
            this.a_btn.UseVisualStyleBackColor = true;
            this.a_btn.Click += new System.EventHandler(this.Guess_Click);
            // 
            // b_btn
            // 
            this.b_btn.Location = new System.Drawing.Point(41, 13);
            this.b_btn.Name = "b_btn";
            this.b_btn.Size = new System.Drawing.Size(29, 23);
            this.b_btn.TabIndex = 2;
            this.b_btn.Text = "B";
            this.b_btn.UseVisualStyleBackColor = true;
            this.b_btn.Click += new System.EventHandler(this.Guess_Click);
            // 
            // c_btn
            // 
            this.c_btn.Location = new System.Drawing.Point(76, 13);
            this.c_btn.Name = "c_btn";
            this.c_btn.Size = new System.Drawing.Size(29, 23);
            this.c_btn.TabIndex = 3;
            this.c_btn.Text = "C";
            this.c_btn.UseVisualStyleBackColor = true;
            this.c_btn.Click += new System.EventHandler(this.Guess_Click);
            // 
            // d_btn
            // 
            this.d_btn.Location = new System.Drawing.Point(111, 13);
            this.d_btn.Name = "d_btn";
            this.d_btn.Size = new System.Drawing.Size(29, 23);
            this.d_btn.TabIndex = 4;
            this.d_btn.Text = "D";
            this.d_btn.UseVisualStyleBackColor = true;
            this.d_btn.Click += new System.EventHandler(this.Guess_Click);
            // 
            // man_pict
            // 
            this.man_pict.Image = global::HangMan_Dudi.Properties.Resources.hangman_1;
            this.man_pict.Location = new System.Drawing.Point(23, 25);
            this.man_pict.Name = "man_pict";
            this.man_pict.Size = new System.Drawing.Size(277, 191);
            this.man_pict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.man_pict.TabIndex = 0;
            this.man_pict.TabStop = false;
            // 
            // turn_lbl
            // 
            this.turn_lbl.AutoSize = true;
            this.turn_lbl.Location = new System.Drawing.Point(256, 219);
            this.turn_lbl.Name = "turn_lbl";
            this.turn_lbl.Size = new System.Drawing.Size(44, 13);
            this.turn_lbl.TabIndex = 5;
            this.turn_lbl.Text = "Turn : 1";
            this.turn_lbl.Click += new System.EventHandler(this.Turn_lbl_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.player2con);
            this.groupBox1.Controls.Add(this.button21);
            this.groupBox1.Controls.Add(this.button19);
            this.groupBox1.Controls.Add(this.button20);
            this.groupBox1.Controls.Add(this.button18);
            this.groupBox1.Controls.Add(this.button17);
            this.groupBox1.Controls.Add(this.button16);
            this.groupBox1.Controls.Add(this.button15);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.e_btn);
            this.groupBox1.Controls.Add(this.a_btn);
            this.groupBox1.Controls.Add(this.b_btn);
            this.groupBox1.Controls.Add(this.d_btn);
            this.groupBox1.Controls.Add(this.c_btn);
            this.groupBox1.Location = new System.Drawing.Point(23, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 125);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player2";
            // 
            // player2con
            // 
            this.player2con.AutoSize = true;
            this.player2con.Location = new System.Drawing.Point(6, 106);
            this.player2con.Name = "player2con";
            this.player2con.Size = new System.Drawing.Size(41, 13);
            this.player2con.TabIndex = 22;
            this.player2con.Text = "label10";
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(146, 102);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(29, 23);
            this.button21.TabIndex = 26;
            this.button21.Text = "Z";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.Guess_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(248, 71);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(29, 23);
            this.button19.TabIndex = 24;
            this.button19.Text = "X";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.Guess_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(111, 102);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(29, 23);
            this.button20.TabIndex = 25;
            this.button20.Text = "Y";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.Guess_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(216, 71);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(29, 23);
            this.button18.TabIndex = 23;
            this.button18.Text = "W";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.Guess_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(216, 42);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(29, 23);
            this.button17.TabIndex = 22;
            this.button17.Text = "O";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.Guess_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(181, 71);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(29, 23);
            this.button16.TabIndex = 21;
            this.button16.Text = "V";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.Guess_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(146, 71);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(29, 23);
            this.button15.TabIndex = 20;
            this.button15.Text = "U";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Guess_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(111, 71);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(29, 23);
            this.button14.TabIndex = 19;
            this.button14.Text = "T";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Guess_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(76, 71);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(29, 23);
            this.button13.TabIndex = 18;
            this.button13.Text = "S";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Guess_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(41, 71);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(29, 23);
            this.button12.TabIndex = 17;
            this.button12.Text = "R";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Guess_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(6, 71);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(29, 23);
            this.button11.TabIndex = 16;
            this.button11.Text = "Q";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Guess_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(248, 42);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(29, 23);
            this.button10.TabIndex = 15;
            this.button10.Text = "P";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Guess_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(181, 42);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(29, 23);
            this.button9.TabIndex = 14;
            this.button9.Text = "N";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Guess_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(146, 42);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(29, 23);
            this.button8.TabIndex = 13;
            this.button8.Text = "M";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Guess_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(111, 42);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(29, 23);
            this.button7.TabIndex = 12;
            this.button7.Text = "L";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Guess_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(76, 42);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(29, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "K";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Guess_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(41, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(29, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "J";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Guess_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "I";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Guess_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(248, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "H";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Guess_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "G";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Guess_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "F";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Guess_Click);
            // 
            // e_btn
            // 
            this.e_btn.Location = new System.Drawing.Point(146, 13);
            this.e_btn.Name = "e_btn";
            this.e_btn.Size = new System.Drawing.Size(29, 23);
            this.e_btn.TabIndex = 5;
            this.e_btn.Text = "E";
            this.e_btn.UseVisualStyleBackColor = true;
            this.e_btn.Click += new System.EventHandler(this.Guess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(250, 349);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(50, 19);
            this.reset_btn.TabIndex = 8;
            this.reset_btn.Text = "restart";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // Word
            // 
            this.Word.Location = new System.Drawing.Point(60, 37);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(66, 20);
            this.Word.TabIndex = 10;
            this.Word.Text = "Insert Word";
            this.Word.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 16;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(70, 63);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(47, 21);
            this.submit.TabIndex = 17;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.Button22_Click);
            // 
            // help
            // 
            this.help.Location = new System.Drawing.Point(309, 145);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(191, 20);
            this.help.TabIndex = 18;
            this.help.TextChanged += new System.EventHandler(this.Fuck_TextChanged);
            // 
            // player1
            // 
            this.player1.Controls.Add(this.player1con);
            this.player1.Controls.Add(this.Word);
            this.player1.Controls.Add(this.submit);
            this.player1.Location = new System.Drawing.Point(306, 25);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(194, 88);
            this.player1.TabIndex = 19;
            this.player1.TabStop = false;
            this.player1.Text = "Player1 ";
            this.player1.Enter += new System.EventHandler(this.Player1_Enter);
            // 
            // player1con
            // 
            this.player1con.AutoSize = true;
            this.player1con.Location = new System.Drawing.Point(6, 16);
            this.player1con.Name = "player1con";
            this.player1con.Size = new System.Drawing.Size(0, 13);
            this.player1con.TabIndex = 18;
            this.player1con.Click += new System.EventHandler(this.Label9_Click);
            // 
            // playercon
            // 
            this.playercon.AutoSize = true;
            this.playercon.Location = new System.Drawing.Point(312, 116);
            this.playercon.Name = "playercon";
            this.playercon.Size = new System.Drawing.Size(136, 13);
            this.playercon.TabIndex = 20;
            this.playercon.Text = "Choose Word With 6 Chars";
            this.playercon.Click += new System.EventHandler(this.Label9_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playercon);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.help);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.turn_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.man_pict);
            this.Name = "Form1";
            this.Text = "OrZivyon HungMan";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.man_pict)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.player1.ResumeLayout(false);
            this.player1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox man_pict;
        private System.Windows.Forms.Button a_btn;
        private System.Windows.Forms.Button b_btn;
        private System.Windows.Forms.Button c_btn;
        private System.Windows.Forms.Button d_btn;
        private System.Windows.Forms.Label turn_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button e_btn;
        private System.Windows.Forms.TextBox Word;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox help;
        private System.Windows.Forms.GroupBox player1;
        private System.Windows.Forms.Label player1con;
        private System.Windows.Forms.Label playercon;
        private System.Windows.Forms.Label player2con;
    }
}

