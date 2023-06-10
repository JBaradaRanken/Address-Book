using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace HOT3GUIArrayJohnBarada
{
    public partial class frmAdressBook1 : Form
    {
        public frmAdressBook1()
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtSalary.Text = string.Empty;
            txtFLS.Text = string.Empty;
            txtFLS.Focus();
        }
        //Constants
        const string NIIT = "NO INPUT IN TEXTBOX";
        const int LEN = 5;
        const int MAXSAL = 100000;
        const int MINSAL = 25000;
        decimal[] sal = new decimal[LEN];
        string[] fir = new string[LEN];
        string[] las = new string[LEN];
        //
        static void FillArray(string[] n)
        {//fill arrays
            decimal[] sal = new decimal[LEN];
            sal[0] = 54321.00M;
            sal[1] = 99732.00M;
            sal[2] = 66778.00M;
            sal[3] = 33445.00M;
            sal[4] = 99883.00M;
            string[] fir = new string[LEN];
            fir[0] = "Markel";
            fir[1] = "Luiza";
            fir[2] = "Byrony";
            fir[3] = "Giraldo";
            fir[4] = "Lowri";
            string[] las = new string[LEN];
            las[0] = "Diggory";
            las[1] = "Gunnar";
            las[2] = "Byrony";
            las[3] = "Giraldo";
            las[4] = "Hari";
            //n[0] = "Markel Diggory 54321";
            //n[1] = "Luiza Gunnar 88732";
            //n[2] = "Byrony Hester 66778";
            //n[3] = "Giraldo Addy 33445";
            //n[4] = "Lowri Hari 99883";
        }
        private void ValidateString()
        {//validate text input
            try
            {
                string valStr = txtFLS.Text;

                int value = Convert.ToInt32(valStr);
                IsPresent(valStr);//
                IsWithinRange(value);//
            }
            catch
            { }
        }
        private void IsPresent(string valStr)
        {//Verify that the text box is not empty
            try
            {
                if (valStr == "")
                {
                    ShowMessage("The Value Was NOT Found In The Array",
                                "VALUE NOT FOUND");
                    PrintError();
                    return;
                }
            }
            catch (FormatException fe)
            {
                ShowMessage("Ilegal Search Value\n" + fe.Message,
                            "SEARCH VALUE BLANK OR NON-NUMERIC");
                txtFLS.Focus();
                return;
            }
        }


            private void Search()
            {
            }
            private void IsDecimal()
            {
                bool result;
                decimal decVal;
                result = Decimal.TryParse(txtFLS.Text, out decVal);
            }
            private void IsWithinRange(int value)
            {//verify any decimal range is in range
                try
                {
                    if ((value < MINSAL) || (value > MAXSAL))
                    {
                        throw new ArgumentOutOfRangeException();

                    }
                    int result = Array.BinarySearch(sal, value);

                    if (result < 0)
                    {
                        ShowMessage("The Value " + value.ToString() +
                                    "Was NOT Found In The Array",
                                    "VALUE NOT FOUND");
                    }
                }
                catch (ArgumentOutOfRangeException aoore)
                {
                    ShowMessage("Out of Range Search Value\n" + aoore.Message,
                                "SEARCH VALUE BLANK OR NON-NUMERIC");
                    return;
                    //h between 25000 and 100000
               }
            
        
        private void ShowMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Question);
        }
        private void PrintError()
        {
            txtFirstName.Text = "ERROR";
            txtLastName.Text = "ERROR";
            txtSalary.Text = "ERROR";
            txtFLS.Focus();
        }
    }
}
