namespace Les2AO
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
            this.Hangman = new System.Windows.Forms.PictureBox();
            this.Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GuessedLetter = new System.Windows.Forms.TextBox();
            this.LettersUsed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Hangman)).BeginInit();
            this.SuspendLayout();
            // 
            // Hangman
            // 
            this.Hangman.Location = new System.Drawing.Point(147, 35);
            this.Hangman.Margin = new System.Windows.Forms.Padding(2);
            this.Hangman.Name = "Hangman";
            this.Hangman.Size = new System.Drawing.Size(303, 255);
            this.Hangman.TabIndex = 0;
            this.Hangman.TabStop = false;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(76, 145);
            this.Reset.Margin = new System.Windows.Forms.Padding(2);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(56, 19);
            this.Reset.TabIndex = 1;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // GuessedLetter
            // 
            this.GuessedLetter.Location = new System.Drawing.Point(292, 391);
            this.GuessedLetter.Name = "GuessedLetter";
            this.GuessedLetter.Size = new System.Drawing.Size(100, 20);
            this.GuessedLetter.TabIndex = 4;
            this.GuessedLetter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GuessedLetter_KeyDown);
            // 
            // LettersUsed
            // 
            this.LettersUsed.AutoSize = true;
            this.LettersUsed.Location = new System.Drawing.Point(312, 341);
            this.LettersUsed.Name = "LettersUsed";
            this.LettersUsed.Size = new System.Drawing.Size(35, 13);
            this.LettersUsed.TabIndex = 5;
            this.LettersUsed.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 736);
            this.Controls.Add(this.LettersUsed);
            this.Controls.Add(this.GuessedLetter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Hangman);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Hangman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Hangman;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GuessedLetter;
        private System.Windows.Forms.Label LettersUsed;
    }
}

