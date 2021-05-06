using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        // Random generator

        Random randGen = new Random();

        // Number variables

        int computerNumber, guessDistance, tries = 0;

        public Form1()
        {
            InitializeComponent();
            computerNumber = randGen.Next(1, 101);
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            // Convert your guess to a number

            int yourGuess = Convert.ToInt32(inputNumberBox.Text);

            // Figure out how far your guess is from the computer's number

            guessDistance = Math.Abs(yourGuess - computerNumber);

            // Figure out if the player guessed correctly, or too high/low

            if (yourGuess > computerNumber)
            {
                outputLabel1.Text = "Too High!";
                tries++;
            }
            else if (yourGuess < computerNumber)
            {
                outputLabel1.Text = "Too Low!";
                tries++;
            }
            else
            {
                // If they guessed correctly, figure out if they had done it in one try

                tries++;
                outputLabel1.Text = $"You got it!";
                if (tries == 1)
                {
                    warmthOutputLabel.Text = $"in {tries} try!";
                }
                else
                {
                    warmthOutputLabel.Text = $"in {tries} tries.";
                }
                
                // Stop the player from guessing

                inputNumberBox.Enabled = false;
                guessButton.Enabled = false;
                return;
            }

            // Decide on what hint should be outputted

            if(guessDistance > 50)
            {
                warmthOutputLabel.Text = "(Freezing!)";
            }
            else if (guessDistance > 25)
            {
                warmthOutputLabel.Text = "(Cold)";
            }
            else if (guessDistance > 15)
            {
                warmthOutputLabel.Text = "(Cool)";
            }
            else if (guessDistance > 10)
            {
                warmthOutputLabel.Text = "(Warm)";
            }
            else if (guessDistance > 5)
            {
                warmthOutputLabel.Text = "(Hot)";
            }
            else if (guessDistance >= 1 && guessDistance <= 4)
            {
                warmthOutputLabel.Text = "(Boiling!)";
            }

            // No need for an else statement, as if the player guesses it right, none of these if statements even run.

        }
    }
}
