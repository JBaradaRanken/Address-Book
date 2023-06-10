using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AddressBookHOT3JohnBarada
{
    public partial class frmAddressBook1 : Form
    {
        public frmAddressBook1()
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
        public decimal[] sal = new decimal[LEN];
        public string[] fir = new string[LEN];
        public string[] las = new string[LEN];
        //useless arrays. NOT INDEXED RIGHT OR SOMETHING>????????
        static void FillArray()
        {//fill arrays

            //I am Stuck. The System cannot find the arrays no matter where i put them? Even defining the array only on the oustide of 
            //the void causes an error.
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
        }
        private string IsPresent(string valStr, string name, Control ctrl)
        {//Verify that the text box is not empty
            string msg = "";
            if (valStr == "")
            {
                msg = name + " is a required field.\n";
                ClearAll();
                txtFLS.Focus();
            }
            IsInt(valStr, name, ctrl);//jump to ISINT
            return msg;   
        }  
        private void IsWithinRange(string valStr, string name, Control ctrl)
        {//verify any decimal range is in range
            bool result = true;
            int value;
            //try
            //{
            result = Int32.TryParse(valStr, out value);
            value = Array.BinarySearch(sal, value);

            if ((value < MINSAL) || (value > MAXSAL))
                {
                //throw new ArgumentOutOfRangeException();
                PrintError();
                }
            //}
            //catch (ArgumentOutOfRangeException aoore)
            //{
            //    ShowMessage("Out of Range Search Value\n" + aoore.Message,
            //                "SEARCH VALUE OUT OF RANGE OR NON-NUMERIC");
            //    PrintError();
            //    //h between 25000 and 100000
            //}
            return;
        }
        private string IsInt(string valStr, string name, Control ctrl)
        {
            string msg = "";
            int id = 0 ;
           if (!Int32.TryParse(valStr, out _))
            {
                if ((id < MINSAL) || (id > MAXSAL));
                msg = name + " must be between " + MINSAL + "and " + MAXSAL + "\n";
                ClearAll();
            }
            IsWithinRange(valStr, name, ctrl);//JUMP TO ISWITHINRANGE
            return msg;

        }
        private void SearchAll()
        {//Function When the Search Buttons are pressed
            string term = txtFLS.Text;
            string errMsg = IsPresent(term, "employeeID", txtFLS);

            if (errMsg != "")
            {
                ShowMessage(errMsg, "ERROR");
                return;
            }
            //FillArray();
            //IsPresent(valStr, name, ctrl);
        }
    
        private void ShowMessage(string msg, string title)
        {//Show Message
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Question);
        }
        private void PrintError()
        {//Print  Error
            txtFirstName.Text = "ERROR";
            txtLastName.Text = "ERROR";
            txtSalary.Text = "ERROR";
            txtFLS.Focus();
            return;
        }

        private void btnSearchFirst_Click(object sender, EventArgs e)
        {
            SearchAll();
            SearchFirst();
        }
        private void SearchFirst()
        {//search by first name
            string name = txtFLS.Text;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i].ToString().Contains(name))
                {
                    ReturnCorrect(i);
                    return;
                }
                else { 
                PrintError(); }
            }
        }
        private void SearchLast()
        {//search by last name
            string name = txtFLS.Text.ToString();
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i].ToString().Contains(name))
                {
                    ReturnCorrect(i);
                    return;
                }
                else
                {
                    PrintError();
                }
            }
        }
        private void SearchSal()
        {//search by salary
            string name = txtFLS.Text.ToString();
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i].ToString().Contains(name))
                {
                    ReturnCorrect(i);
                    return;
                }
                else
                {
                    PrintError();
                }
            }
        }
        private void ReturnCorrect(int offset)
        {
            txtFirstName.Text = fir[offset].ToString();
            txtLastName.Text = las[offset].ToString();
            txtSalary.Text = sal[offset].ToString();
            txtFLS.Focus();
        }

        private void btnSearchLast_Click(object sender, EventArgs e)
        {
            SearchAll();
        }

        private void btnSearchSalary_Click(object sender, EventArgs e)
        {
            SearchAll();
        }
    }
}
