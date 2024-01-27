namespace WindowsForms_NumberGuessing
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
            this.btn_GenerateSN = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_ll = new System.Windows.Forms.Label();
            this.lbl_ul = new System.Windows.Forms.Label();
            this.lbl_guess = new System.Windows.Forms.Label();
            this.lbl_attempts = new System.Windows.Forms.Label();
            this.txt_ul = new System.Windows.Forms.TextBox();
            this.txt_guess = new System.Windows.Forms.TextBox();
            this.btn_Play = new System.Windows.Forms.Button();
            this.lbl_number = new System.Windows.Forms.Label();
            this.txt_ll = new System.Windows.Forms.TextBox();
            this.lblwarningul = new System.Windows.Forms.Label();
            this.lblwarningll = new System.Windows.Forms.Label();
            this.lblwarningguess = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_secret_confirmation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblwarningempty_secret = new System.Windows.Forms.Label();
            this.lblwarningempty_guess = new System.Windows.Forms.Label();
            this.lblwarning = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblwinner = new System.Windows.Forms.Label();
            this.btn_PlayAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GenerateSN
            // 
            this.btn_GenerateSN.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_GenerateSN.CausesValidation = false;
            this.btn_GenerateSN.Enabled = false;
            this.btn_GenerateSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GenerateSN.ForeColor = System.Drawing.Color.White;
            this.btn_GenerateSN.Location = new System.Drawing.Point(680, 171);
            this.btn_GenerateSN.Name = "btn_GenerateSN";
            this.btn_GenerateSN.Size = new System.Drawing.Size(301, 45);
            this.btn_GenerateSN.TabIndex = 1;
            this.btn_GenerateSN.Text = "Generate a Secret Number";
            this.btn_GenerateSN.UseVisualStyleBackColor = false;
            this.btn_GenerateSN.Click += new System.EventHandler(this.btn_GenerateSN_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_title.Location = new System.Drawing.Point(232, 21);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(674, 34);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "WELCOME TO NUMBER GUESSING GAME";
            // 
            // lbl_ll
            // 
            this.lbl_ll.AutoSize = true;
            this.lbl_ll.Location = new System.Drawing.Point(83, 180);
            this.lbl_ll.Name = "lbl_ll";
            this.lbl_ll.Size = new System.Drawing.Size(89, 20);
            this.lbl_ll.TabIndex = 10;
            this.lbl_ll.Text = "Lower Limit";
            // 
            // lbl_ul
            // 
            this.lbl_ul.AutoSize = true;
            this.lbl_ul.Location = new System.Drawing.Point(409, 183);
            this.lbl_ul.Name = "lbl_ul";
            this.lbl_ul.Size = new System.Drawing.Size(90, 20);
            this.lbl_ul.TabIndex = 11;
            this.lbl_ul.Text = "Upper Limit";
            // 
            // lbl_guess
            // 
            this.lbl_guess.AutoSize = true;
            this.lbl_guess.Location = new System.Drawing.Point(86, 317);
            this.lbl_guess.Name = "lbl_guess";
            this.lbl_guess.Size = new System.Drawing.Size(112, 20);
            this.lbl_guess.TabIndex = 12;
            this.lbl_guess.Text = "Make a Guess";
            // 
            // lbl_attempts
            // 
            this.lbl_attempts.AutoSize = true;
            this.lbl_attempts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_attempts.Location = new System.Drawing.Point(715, 334);
            this.lbl_attempts.Name = "lbl_attempts";
            this.lbl_attempts.Size = new System.Drawing.Size(94, 25);
            this.lbl_attempts.TabIndex = 13;
            this.lbl_attempts.Text = "Attempts ";
            // 
            // txt_ul
            // 
            this.txt_ul.Location = new System.Drawing.Point(520, 180);
            this.txt_ul.Name = "txt_ul";
            this.txt_ul.Size = new System.Drawing.Size(121, 26);
            this.txt_ul.TabIndex = 14;
            this.txt_ul.TextChanged += new System.EventHandler(this.txt_ul_TextChanged);
            // 
            // txt_guess
            // 
            this.txt_guess.Location = new System.Drawing.Point(218, 317);
            this.txt_guess.Name = "txt_guess";
            this.txt_guess.Size = new System.Drawing.Size(121, 26);
            this.txt_guess.TabIndex = 15;
            this.txt_guess.TextChanged += new System.EventHandler(this.txt_guess_TextChanged);
            // 
            // btn_Play
            // 
            this.btn_Play.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Play.Enabled = false;
            this.btn_Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Play.ForeColor = System.Drawing.Color.White;
            this.btn_Play.Location = new System.Drawing.Point(417, 317);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(129, 54);
            this.btn_Play.TabIndex = 17;
            this.btn_Play.Text = "Play";
            this.btn_Play.UseVisualStyleBackColor = false;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_number.Location = new System.Drawing.Point(758, 384);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(137, 25);
            this.lbl_number.TabIndex = 18;
            this.lbl_number.Text = "The number is";
            this.lbl_number.Visible = false;
            // 
            // txt_ll
            // 
            this.txt_ll.Location = new System.Drawing.Point(214, 180);
            this.txt_ll.Name = "txt_ll";
            this.txt_ll.Size = new System.Drawing.Size(121, 26);
            this.txt_ll.TabIndex = 20;
            this.txt_ll.TextChanged += new System.EventHandler(this.txt_ll_TextChanged);
            // 
            // lblwarningul
            // 
            this.lblwarningul.AutoSize = true;
            this.lblwarningul.ForeColor = System.Drawing.Color.Red;
            this.lblwarningul.Location = new System.Drawing.Point(490, 213);
            this.lblwarningul.Name = "lblwarningul";
            this.lblwarningul.Size = new System.Drawing.Size(91, 20);
            this.lblwarningul.TabIndex = 22;
            this.lblwarningul.Text = "lblwarningul";
            this.lblwarningul.Visible = false;
            // 
            // lblwarningll
            // 
            this.lblwarningll.AutoSize = true;
            this.lblwarningll.ForeColor = System.Drawing.Color.Red;
            this.lblwarningll.Location = new System.Drawing.Point(210, 213);
            this.lblwarningll.Name = "lblwarningll";
            this.lblwarningll.Size = new System.Drawing.Size(85, 20);
            this.lblwarningll.TabIndex = 23;
            this.lblwarningll.Text = "lblwarningll";
            this.lblwarningll.Visible = false;
            // 
            // lblwarningguess
            // 
            this.lblwarningguess.AutoSize = true;
            this.lblwarningguess.ForeColor = System.Drawing.Color.Red;
            this.lblwarningguess.Location = new System.Drawing.Point(214, 351);
            this.lblwarningguess.Name = "lblwarningguess";
            this.lblwarningguess.Size = new System.Drawing.Size(122, 20);
            this.lblwarningguess.TabIndex = 24;
            this.lblwarningguess.Text = "lblwarningguess";
            this.lblwarningguess.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(581, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Attempts:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(581, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "The number is:";
            // 
            // lbl_secret_confirmation
            // 
            this.lbl_secret_confirmation.AutoSize = true;
            this.lbl_secret_confirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_secret_confirmation.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_secret_confirmation.Location = new System.Drawing.Point(676, 236);
            this.lbl_secret_confirmation.Name = "lbl_secret_confirmation";
            this.lbl_secret_confirmation.Size = new System.Drawing.Size(196, 20);
            this.lbl_secret_confirmation.TabIndex = 28;
            this.lbl_secret_confirmation.Text = "lbl_secret_confirmation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 29;
            // 
            // lblwarningempty_secret
            // 
            this.lblwarningempty_secret.AutoSize = true;
            this.lblwarningempty_secret.ForeColor = System.Drawing.Color.Red;
            this.lblwarningempty_secret.Location = new System.Drawing.Point(83, 236);
            this.lblwarningempty_secret.Name = "lblwarningempty_secret";
            this.lblwarningempty_secret.Size = new System.Drawing.Size(175, 20);
            this.lblwarningempty_secret.TabIndex = 30;
            this.lblwarningempty_secret.Text = "lblwarningempty_secret";
            this.lblwarningempty_secret.Visible = false;
            // 
            // lblwarningempty_guess
            // 
            this.lblwarningempty_guess.AutoSize = true;
            this.lblwarningempty_guess.ForeColor = System.Drawing.Color.Red;
            this.lblwarningempty_guess.Location = new System.Drawing.Point(87, 380);
            this.lblwarningempty_guess.Name = "lblwarningempty_guess";
            this.lblwarningempty_guess.Size = new System.Drawing.Size(174, 20);
            this.lblwarningempty_guess.TabIndex = 31;
            this.lblwarningempty_guess.Text = "lblwarningempty_guess";
            this.lblwarningempty_guess.Visible = false;
            // 
            // lblwarning
            // 
            this.lblwarning.AutoSize = true;
            this.lblwarning.ForeColor = System.Drawing.Color.Red;
            this.lblwarning.Location = new System.Drawing.Point(360, 236);
            this.lblwarning.Name = "lblwarning";
            this.lblwarning.Size = new System.Drawing.Size(79, 20);
            this.lblwarning.TabIndex = 32;
            this.lblwarning.Text = "lblwarning";
            this.lblwarning.Visible = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Black;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(805, 498);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(176, 59);
            this.btn_Exit.TabIndex = 33;
            this.btn_Exit.Text = "Exit Game";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(427, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Please enter integer limits to start the game";
            // 
            // lblwinner
            // 
            this.lblwinner.AutoSize = true;
            this.lblwinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwinner.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblwinner.Location = new System.Drawing.Point(584, 421);
            this.lblwinner.Name = "lblwinner";
            this.lblwinner.Size = new System.Drawing.Size(79, 20);
            this.lblwinner.TabIndex = 35;
            this.lblwinner.Text = "lblwinner";
            this.lblwinner.Visible = false;
            // 
            // btn_PlayAgain
            // 
            this.btn_PlayAgain.BackColor = System.Drawing.Color.Black;
            this.btn_PlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlayAgain.ForeColor = System.Drawing.Color.White;
            this.btn_PlayAgain.Location = new System.Drawing.Point(586, 498);
            this.btn_PlayAgain.Name = "btn_PlayAgain";
            this.btn_PlayAgain.Size = new System.Drawing.Size(176, 59);
            this.btn_PlayAgain.TabIndex = 36;
            this.btn_PlayAgain.Text = "Play Again?";
            this.btn_PlayAgain.UseVisualStyleBackColor = false;
            this.btn_PlayAgain.Visible = false;
            this.btn_PlayAgain.Click += new System.EventHandler(this.btn_PlayAgain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 560);
            this.ControlBox = false;
            this.Controls.Add(this.btn_PlayAgain);
            this.Controls.Add(this.lblwinner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lblwarning);
            this.Controls.Add(this.lblwarningempty_guess);
            this.Controls.Add(this.lblwarningempty_secret);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_secret_confirmation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblwarningguess);
            this.Controls.Add(this.lblwarningll);
            this.Controls.Add(this.lblwarningul);
            this.Controls.Add(this.txt_ll);
            this.Controls.Add(this.lbl_number);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.txt_guess);
            this.Controls.Add(this.txt_ul);
            this.Controls.Add(this.lbl_attempts);
            this.Controls.Add(this.lbl_guess);
            this.Controls.Add(this.lbl_ul);
            this.Controls.Add(this.lbl_ll);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_GenerateSN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_GenerateSN;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_ll;
        private System.Windows.Forms.Label lbl_ul;
        private System.Windows.Forms.Label lbl_guess;
        private System.Windows.Forms.Label lbl_attempts;
        private System.Windows.Forms.TextBox txt_ul;
        private System.Windows.Forms.TextBox txt_guess;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.TextBox txt_ll;
        private System.Windows.Forms.Label lblwarningul;
        private System.Windows.Forms.Label lblwarningll;
        private System.Windows.Forms.Label lblwarningguess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_secret_confirmation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblwarningempty_secret;
        private System.Windows.Forms.Label lblwarningempty_guess;
        private System.Windows.Forms.Label lblwarning;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblwinner;
        private System.Windows.Forms.Button btn_PlayAgain;
    }
}

