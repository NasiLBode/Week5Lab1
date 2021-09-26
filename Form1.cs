/*File Name: Week5Lab1
 * Programmer: Nasi Bode
 * Problem Statement: Create a GUI that takes in a speed limit and your speed. Add a Canvas element that
 * changes color, green (legal speed), yellow (speeding no penalty), red (speeding with penalty). Add
 * a label that in addition to the color, prints out the status as well. 
 * 
 * Overall Plan: 
 * 1. Create GUI platform
 * 2. Create two  labels for user (1 for user speed, 1 for speed limit)
 * 3. Create two text boxes for user input (1 for user speed, 1 for speed limit)
 * 4. Creaet Button to start calculation
 * 5. Create empty label to display result
 * 6. Convert string input from text box to int
 * 7. Define the variable for fine and penalty 
 * 8. Create multi if-else statment
 * 8. If user is above 25 speed limit - output result to the empty string
 * 9. If user is above speed limit but under 25 - output result to the empty string
 * 10. If user is legal - output result to empty string
 *

*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //initialize variables from user input
            int speed = int.Parse(speedInput.Text);
            int limit = int.Parse(limitInput.Text);
            int fine = 7;
            int penalty = 250;
            int result;
            int difference = speed - limit;

            //create multi if-else statement to determine if user gets a penalty
            if (speed > limit + 25) //if user is over 25 mph the speed limit
            {    
                result = penalty + 60 + (fine * difference);
                resultOutput.Text = "Your Speed is ILLEGAL. You have a fine of: $" + result.ToString(); 
                resultOutput.ForeColor = Color.Red;
            }
            else if (speed > limit) //if user is over speed limit but under 25 
            {
                result = 60 + (fine * difference);
                resultOutput.Text = difference.ToString();
                resultOutput.Text = "Your Speed is illegal. You have no penalty, but a fine of: $" + result.ToString();
                resultOutput.ForeColor = Color.Yellow;
            }
            else //if user is within the speed limit
            {
                resultOutput.Text = "Your speed is legal";
                resultOutput.ForeColor = Color.Green;
            }
        }
    }
}
