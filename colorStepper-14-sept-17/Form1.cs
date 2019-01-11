using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colorStepper_14_sept_17 {

    public partial class Form1 : Form {

        // Declare a variable that holds the step
        int stepCounterDSte = 0;

        public Form1() {
            // This loads the components in the forms
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // When the form gets loaded we will put the number into the label
            lblStepDSte.Text = Convert.ToString(stepCounterDSte);
        }

        private void BtnStepDSte_Click(object sender, EventArgs e) {
            // When we click the button we want to add one to the counter and display it in the label
            //stepCounterDSte++; // We can do it on two lines, but why do we want that when we can do it on one line
            lblStepDSte.Text = Convert.ToString( stepCounterDSte+=1 ); // Add one to the counter, convert it to a string and display it in the label

            int currentStepDSte = stepCounterDSte % 3;

            if (currentStepDSte == 0) {
                ptbColorDSte.BackColor = Color.Red;
            } else if(currentStepDSte == 1) {
                ptbColorDSte.BackColor = Color.Green;
            } else if (currentStepDSte == 2) {
                ptbColorDSte.BackColor = Color.Blue;
            }
        }

        // When we click the button that says green, we chenge the color of ptbColorDSte to green
        private void btnGreenDSte_Click(object sender, EventArgs e) {
            ptbColorDSte.BackColor = Color.Green;
        }

        // When we click the button that says red, we chenge the color of ptbColorDSte to red
        private void btnRedDSte_Click(object sender, EventArgs e) {
            ptbColorDSte.BackColor = Color.Red;
        }

        // When we click the button that says blue, we chenge the color of ptbColorDSte to blue
        private void btnBlueDSte_Click(object sender, EventArgs e) {
            ptbColorDSte.BackColor = Color.Blue;
        }
    }
}
