namespace HOT3_2JOHNBARADA
{
    partial class frmAdressBook2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearchSalary = new System.Windows.Forms.Button();
            this.btnSearchLast = new System.Windows.Forms.Button();
            this.btnSearchFirst = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtFLS = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblFLS = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearchSalary
            // 
            this.btnSearchSalary.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSearchSalary.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSalary.Location = new System.Drawing.Point(562, 287);
            this.btnSearchSalary.Name = "btnSearchSalary";
            this.btnSearchSalary.Size = new System.Drawing.Size(150, 52);
            this.btnSearchSalary.TabIndex = 29;
            this.btnSearchSalary.Text = "Search &Salary";
            this.btnSearchSalary.UseVisualStyleBackColor = true;
            this.btnSearchSalary.Click += new System.EventHandler(this.btnSearchSalary_Click);
            // 
            // btnSearchLast
            // 
            this.btnSearchLast.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSearchLast.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchLast.Location = new System.Drawing.Point(562, 214);
            this.btnSearchLast.Name = "btnSearchLast";
            this.btnSearchLast.Size = new System.Drawing.Size(150, 52);
            this.btnSearchLast.TabIndex = 28;
            this.btnSearchLast.Text = "Search &Last Name";
            this.btnSearchLast.UseVisualStyleBackColor = true;
            this.btnSearchLast.Click += new System.EventHandler(this.btnSearchLast_Click);
            // 
            // btnSearchFirst
            // 
            this.btnSearchFirst.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSearchFirst.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFirst.Location = new System.Drawing.Point(562, 140);
            this.btnSearchFirst.Name = "btnSearchFirst";
            this.btnSearchFirst.Size = new System.Drawing.Size(150, 52);
            this.btnSearchFirst.TabIndex = 27;
            this.btnSearchFirst.Text = "Search &First Name";
            this.btnSearchFirst.UseVisualStyleBackColor = true;
            this.btnSearchFirst.Click += new System.EventHandler(this.btnSearchFirst_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(353, 272);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(181, 26);
            this.txtSalary.TabIndex = 38;
            // 
            // lblSalary
            // 
            this.lblSalary.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(157, 275);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(179, 23);
            this.lblSalary.TabIndex = 37;
            this.lblSalary.Text = "Salary:";
            this.lblSalary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(387, 326);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 52);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtFLS
            // 
            this.txtFLS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFLS.Location = new System.Drawing.Point(88, 99);
            this.txtFLS.Name = "txtFLS";
            this.txtFLS.Size = new System.Drawing.Size(553, 26);
            this.txtFLS.TabIndex = 26;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(353, 204);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(181, 26);
            this.txtFirstName.TabIndex = 34;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(353, 240);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(181, 26);
            this.txtLastName.TabIndex = 36;
            // 
            // lblLastName
            // 
            this.lblLastName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(157, 240);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(179, 23);
            this.lblLastName.TabIndex = 35;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(157, 204);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(179, 23);
            this.lblFirstName.TabIndex = 33;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFLS
            // 
            this.lblFLS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFLS.Location = new System.Drawing.Point(88, 73);
            this.lblFLS.Name = "lblFLS";
            this.lblFLS.Size = new System.Drawing.Size(553, 23);
            this.lblFLS.TabIndex = 32;
            this.lblFLS.Text = "First Name, Last Name, or Salary:";
            this.lblFLS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(186, 326);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 52);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmAdressBook2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearchSalary);
            this.Controls.Add(this.btnSearchLast);
            this.Controls.Add(this.btnSearchFirst);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtFLS);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblFLS);
            this.Controls.Add(this.btnClear);
            this.Name = "frmAdressBook2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Address Book 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchSalary;
        private System.Windows.Forms.Button btnSearchLast;
        private System.Windows.Forms.Button btnSearchFirst;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtFLS;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblFLS;
        private System.Windows.Forms.Button btnClear;
    }
}

