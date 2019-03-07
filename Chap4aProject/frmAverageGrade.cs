using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap4aProject
{
    public partial class frmAverageGrade : Form
    {
        public frmAverageGrade()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // declare variables and constants...
                decimal decTest1, decTest2, decTest3, decAvg;
                const decimal decHighScore = 90, decLowScore = 70;
                // erase old feedback
                lblFeedback.Text = "";
                // parse content of textboxes
                decTest1 = decimal.Parse(txtScore1.Text);
                decTest2 = decimal.Parse(txtScore2.Text);
                decTest3 = decimal.Parse(txtScore3.Text);
                // calculate average score
                decAvg = (decTest1 + decTest2 + decTest3) / 3;
                // determine letter grade
                if (decAvg < 60)
                {
                    lblGrade.Text = "F";
                }
                else if (decAvg < 70)
                {
                    lblGrade.Text = "D";
                }
                else if (decAvg < 80)
                {
                    lblGrade.Text = "C";
                }
                else if (decAvg < 90)
                {
                    lblGrade.Text = "B";
                }
                else if (decAvg <= 100)
                {
                    lblGrade.Text = "A";
                }
                else // average is over 100
                {
                    lblGrade.Text = "Err";
                }
                // give feedback
                if (decAvg >= decHighScore)
                {
                    lblFeedback.Text = "Good job!";
                }
                else if (decAvg >= decLowScore)
                {
                    lblFeedback.Text = "Keep trying!"; 
                }
                else // average is below decLowScore
                {
                    lblFeedback.Text = "Ask your instructor for help.";
                }
                // Check for possible TA position
                if (decTest1 >= 90 && decTest2 >= 90 && decTest3 >= 90)
                {
                    MessageBox.Show("See instructor for possible TA position.");
                }
                // Ask student to see instructor about low score
                if (decTest1 < 60 || decTest2 <60 || decTest3 < 60)
                {
                    MessageBox.Show("See instructor about your lowest score.");
                }
                // display output
                lblAverage.Text = decAvg.ToString("n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Test scores must be numeric." + "\n" + ex.Message);
            }
        }
    }
}
