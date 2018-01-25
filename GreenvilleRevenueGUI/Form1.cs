using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace GreenvilleRevenueGUI
/* Program written by: Zach, Jeff
* Program date: 1/25/18
* Program description: you enter 2 numbers, multiplies one of them and prints out a total, then compares the 2 numbers and prints out a statement. Chatper 3 case study 1, this is now in GUI form. You click buttons and textboxes to inout data.
* Encountered issues: had a method that we couldn't delete.
* */
{
    public partial class greenvilleRevenueGUI : Form
    {
        public greenvilleRevenueGUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            string numPeopleOne, numPeopleTwo;
            int rev, num1, num2;

            numPeopleOne = lastYearInputTextBox.Text;
            num1 = Convert.ToInt32(numPeopleOne);

            numPeopleTwo = thisYearInputTextBox.Text;
            num2 = Convert.ToInt32(numPeopleTwo);

            rev = num1 * 25;
            RevenueOuput.Text = "Revenue for this year: " + rev.ToString("C");
            RevenueOuput.Visible = true;
            thisVsLastOutput.Visible = true;

            if (num1 > num2)
                thisVsLastOutput.Text = "Last year had more contestants than this year!";

            else
                thisVsLastOutput.Text = "This year has more contestants than last year";

        }
    }
}
