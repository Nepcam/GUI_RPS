namespace GUI_RPS
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
            this.buttonPlay = new System.Windows.Forms.Button();
            this.playerLabel = new System.Windows.Forms.Label();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.radioButtonRock = new System.Windows.Forms.RadioButton();
            this.radioButtonPaper = new System.Windows.Forms.RadioButton();
            this.radioButtonScissors = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(578, 60);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(122, 23);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "PLAY";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(165, 66);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(72, 13);
            this.playerLabel.TabIndex = 2;
            this.playerLabel.Text = "Player Choice";
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Location = new System.Drawing.Point(316, 125);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(118, 13);
            this.labelAnswer.TabIndex = 3;
            this.labelAnswer.Text = "Welcome to RPS game";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(275, 23);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(211, 13);
            this.labelWelcome.TabIndex = 4;
            this.labelWelcome.Text = "Please select PAPER SCISSORS or ROCK";
            // 
            // radioButtonRock
            // 
            this.radioButtonRock.AutoSize = true;
            this.radioButtonRock.Location = new System.Drawing.Point(278, 66);
            this.radioButtonRock.Name = "radioButtonRock";
            this.radioButtonRock.Size = new System.Drawing.Size(55, 17);
            this.radioButtonRock.TabIndex = 5;
            this.radioButtonRock.TabStop = true;
            this.radioButtonRock.Text = "ROCK";
            this.radioButtonRock.UseVisualStyleBackColor = true;
            // 
            // radioButtonPaper
            // 
            this.radioButtonPaper.AutoSize = true;
            this.radioButtonPaper.Location = new System.Drawing.Point(373, 66);
            this.radioButtonPaper.Name = "radioButtonPaper";
            this.radioButtonPaper.Size = new System.Drawing.Size(61, 17);
            this.radioButtonPaper.TabIndex = 6;
            this.radioButtonPaper.TabStop = true;
            this.radioButtonPaper.Text = "PAPER";
            this.radioButtonPaper.UseVisualStyleBackColor = true;
            // 
            // radioButtonScissors
            // 
            this.radioButtonScissors.AutoSize = true;
            this.radioButtonScissors.Location = new System.Drawing.Point(469, 66);
            this.radioButtonScissors.Name = "radioButtonScissors";
            this.radioButtonScissors.Size = new System.Drawing.Size(79, 17);
            this.radioButtonScissors.TabIndex = 7;
            this.radioButtonScissors.TabStop = true;
            this.radioButtonScissors.Text = "SCISSORS";
            this.radioButtonScissors.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 199);
            this.Controls.Add(this.radioButtonScissors);
            this.Controls.Add(this.radioButtonPaper);
            this.Controls.Add(this.radioButtonRock);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.buttonPlay);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.RadioButton radioButtonRock;
        private System.Windows.Forms.RadioButton radioButtonPaper;
        private System.Windows.Forms.RadioButton radioButtonScissors;
    }
}

