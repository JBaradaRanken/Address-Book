using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
        private string IsPresent(string valStr, string term, Control ctrl)
        {//Verify that the text box is not empty
            string msg = "";
            if (valStr == "")
            {
                msg = term + " is a required field.\n";
                ClearAll();
                txtFLS.Focus();
            }
            IsInt32(valStr, term, txtFLS);
            return msg;   
        }  
        private string IsInt32(string valStr, string term, Control ctrl) 
        {
            string msg = "";
            int id = 0;
            if (!Int32.TryParse(valStr, out id))
            {
                if ((id < MINSAL) || (id > MAXSAL)) ;
                msg = id + " must be an Integer Amount\n";
                ClearAll();
            }
            IsInRange(valStr, term, txtFLS);
            return msg;
        }
        private string IsInRange(string valStr,
                                 string term, txtFLS)
        {
            string msg = "";
            if (!Int32.TryParse(valStr, out int ret))
            {
                if ((ret < MINSAL) || (ret > MAXSAL)) ;
                msg = term + " must be between " + MINSAL + "and " + MAXSAL + "\n";
                return msg;
            }
            for (int i = 0; i < term.Length; i++)
            {
                if (term[i].ToString().Contains(valStr))
                {
                    PrintData(i);
                }
            }
            return msg;
        }
        //private void ClearAndSetFocusToCorrectControl(Control crtl)
        //{
           
        //}

        private void btnSearchFirst_Click(object sender, EventArgs e)
        {
            //CheckAllBoxes();
            SearchForFirst();
        }
        private void SearchForFirst()
        {
            string term = txtFLS.Text;

            string errMsg = IsPresent("firstName",term, Control ctrl);

            DisplayError(errMsg);

        }
        private void SearchForLast()
        {
            string term = txtFLS.Text;

            string errMsg = IsPresent("firstName", term, Control ctrl); ;

            DisplayError(errMsg);
        }
        private void SearchForSalary()
        {
            string term = txtFLS.Text;

            string errMsg = IsPresent("firstName", term, Control ctrl);

            DisplayError(errMsg);
        }
        private void PrintData(int i)
        {
            txtFirstName.Text = fir[i].ToString();
            txtLastName.Text = las[i].ToString();
            txtSalary.Text = sal[i].ToString();
        }//should produce answers. does nothing instead. Why????????????

        //
        private void DisplayError(string errMsg)
        {
            if (errMsg != "")
            {
                ShowMessage(errMsg, "ERROR");
            }
        }
        private void PrintError()
        {
            txtFirstName.Text = "ERROR";
            txtLastName.Text = "ERROR";
            txtSalary.Text = "ERROR";
            txtFLS.Text = "";
            txtFLS.Focus();

        }
        private void ShowMessage(string msg, string title)
        {//Show Message
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Question);
        }
        private void btnSearchLast_Click(object sender, EventArgs e)
        {
            SearchForLast();
        }

        private void btnSearchSalary_Click(object sender, EventArgs e)
        {
            SearchForSalary();
        }
    }
}
