using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOT3_2JOHNBARADA
{
    public partial class frmAdressBook2 : Form
    {
        public frmAdressBook2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitPrompt();
        }
        private void ExitPrompt()
        {
            DialogResult dialog = MessageBox.Show(

        "Do You Really Want To Exit The Program?",

        "EXIT NOW?",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)

            {

                Application.Exit();
            }
        }
        private void ClearAll()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtSalary.Text = string.Empty;
            txtFLS.Text = string.Empty;
            txtFLS.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnSearchFirst_Click(object sender, EventArgs e)
        {
            SearchFirst("val", "firstName", txtFLS);
        }
        private void SearchFirst(string val, string term, Control ctrl)
        {
            string msg = "";
            try
            {//PLEASE HELP ME. The Exclamation ! goes somewhere but Where? Cannot conver string to bool. cannot convert bool to int.
                //I am going crazy over this Please help
                term = txtFirstName.Text;
                //string firstName = txtFirstName.Text;
                //string lastName = txtLastName.Text;
                //decimal salary = Decimal.Parse(txtSalary.Text);
                //if (salary<=0)
                //{
                //    throw new Exception("Value must be greater than Zero")
                //}
            }
            catch (FormatException fe)
            {
                MessageBox.Show(
                    "Format Exception Occurred. Check all Entries", "Entry Error");
            }
            catch (OverflowException oe)
            {
                MessageBox.Show(
                    "An Overflow Exception occurred. Enter a smaller value",
                    "Entry Error");
            }
        }
        private void SearchLast(string val, string term, Control ctrl)
        {
            string msg = "";
            try
            {
                term = txtFirstName.Text;
            }
            catch (FormatException fe)
            {
                MessageBox.Show(
                    "Format Exception Occurred. Check all Entries", "Entry Error");
            }
            catch (OverflowException oe)
            {
                MessageBox.Show(
                    "An Overflow Exception occurred. Enter a smaller value",
                    "Entry Error");
            }
        }
        private void DisplayError()
        {
            txtFirstName.Text = "ERROR";
            txtLastName.Text = "ERROR";
            txtSalary.Text = "ERROR";
            txtFLS.Text = "";
            txtFLS.Focus();

        }
        const int LEN = 5;
        const int MAXSAL = 100000;
        const int MINSAL = 25000;
        //fill arrays

        string[] sal =
        {
        "54321", "99732" , "66778",  "33445", "99883"
        };
        string[] fir =
        {
        "Markel","Luiza","Byrony","Giraldo", "Lowri"
        };
        string[] las =
        {
        "Diggory", "Gunnar", "Byrony", "Giraldo", "Hari"
        };

        private void btnSearchLast_Click(object sender, EventArgs e)
        {
            string term = txtFLS.Text;

            string errMsg = IsPresent("lastName", term, Control ctrl); ;

            DisplayError(errMsg);
        }

        private void btnSearchSalary_Click(object sender, EventArgs e)
        {
            string term = txtFLS.Text;

            string errMsg = IsPresent("firstName", term, Control ctrl); ;

            DisplayError(errMsg);
        }
    }
}
