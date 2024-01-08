namespace WindowsFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelPrompt = new System.Windows.Forms.Label();
            this.textBoxGuess = new System.Windows.Forms.TextBox();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.labelHint = new System.Windows.Forms.Label();
            this.buttonPlayAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPrompt
            // 
            this.labelPrompt.AutoSize = true;
            this.labelPrompt.Location = new System.Drawing.Point(37, 32);
            this.labelPrompt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(550, 38);
            this.labelPrompt.TabIndex = 0;
            this.labelPrompt.Text = "I have a number between 1 and 1000--can you guess my number? \r\nPlease enter your " +
    "first guess";
            // 
            // textBoxGuess
            // 
            this.textBoxGuess.Location = new System.Drawing.Point(41, 113);
            this.textBoxGuess.Name = "textBoxGuess";
            this.textBoxGuess.Size = new System.Drawing.Size(119, 27);
            this.textBoxGuess.TabIndex = 1;
            // 
            // buttonGuess
            // 
            this.buttonGuess.Location = new System.Drawing.Point(236, 113);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(106, 27);
            this.buttonGuess.TabIndex = 2;
            this.buttonGuess.Text = "Guess";
            this.buttonGuess.UseVisualStyleBackColor = true;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // labelHint
            // 
            this.labelHint.Location = new System.Drawing.Point(41, 154);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(119, 37);
            this.labelHint.TabIndex = 3;
            // 
            // buttonPlayAgain
            // 
            this.buttonPlayAgain.Location = new System.Drawing.Point(236, 185);
            this.buttonPlayAgain.Name = "buttonPlayAgain";
            this.buttonPlayAgain.Size = new System.Drawing.Size(106, 40);
            this.buttonPlayAgain.TabIndex = 4;
            this.buttonPlayAgain.Text = "Play Again";
            this.buttonPlayAgain.UseVisualStyleBackColor = true;
            this.buttonPlayAgain.Click += new System.EventHandler(this.buttonPlayAgain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 256);
            this.Controls.Add(this.buttonPlayAgain);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.buttonGuess);
            this.Controls.Add(this.textBoxGuess);
            this.Controls.Add(this.labelPrompt);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Guess game";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrompt;
        private System.Windows.Forms.TextBox textBoxGuess;
        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.Button buttonPlayAgain;
    }
}

