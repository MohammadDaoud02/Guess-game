using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private int randomNumber;
        private readonly Color defaultColor;
        public Form1()
        {
            InitializeComponent();
            defaultColor = this.BackColor;
            GenerateRandomNumber();
        }
        private void GenerateRandomNumber()
        {
            Random random = new Random();
            randomNumber = random.Next(1, 1001);
        }

        private void CheckGuess()
        {
            int userGuess = int.Parse(textBoxGuess.Text);

            if (userGuess == randomNumber)
            {
                MessageBox.Show("Correct!");
                this.BackColor = Color.Green;
                textBoxGuess.Enabled = false;
            }
            else if (userGuess < randomNumber)
            {
                labelHint.Text = "Too Low";
                this.BackColor = Color.Blue;
            }
            else
            {
                labelHint.Text = "Too High";
                this.BackColor = Color.Red;
            }

            textBoxGuess.Text = "";
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            CheckGuess();

        }

        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            GenerateRandomNumber();
            this.BackColor = defaultColor;
            textBoxGuess.Enabled = true;
        }
    }
}
