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
            this.label1 = new System.Windows.Forms.Label();
            this.reset_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.e_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.man_pict)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.e_btn);
            this.groupBox1.Controls.Add(this.a_btn);
            this.groupBox1.Controls.Add(this.b_btn);
            this.groupBox1.Controls.Add(this.d_btn);
            this.groupBox1.Controls.Add(this.c_btn);
            this.groupBox1.Location = new System.Drawing.Point(23, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 97);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "choose a letter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "word:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(225, 338);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(75, 23);
            this.reset_btn.TabIndex = 8;
            this.reset_btn.Text = "reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.turn_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.man_pict);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.man_pict)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
    }
}

