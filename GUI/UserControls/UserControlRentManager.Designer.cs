namespace CarRental
{
    partial class UserControlRentManager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rentWorkspace = new System.Windows.Forms.Panel();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnGiveBack = new System.Windows.Forms.Button();
            this.rentSearchButton = new System.Windows.Forms.Button();
            this.btnNewRent = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tbRentSurname = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.rentSearchLicenceLabel = new System.Windows.Forms.Label();
            this.rentSearchPhoneLabel = new System.Windows.Forms.Label();
            this.rentSearchEmailLabel = new System.Windows.Forms.Label();
            this.rentSearchCustomerSurameLabel = new System.Windows.Forms.Label();
            this.rentSearchIdLabel = new System.Windows.Forms.Label();
            this.rentSearchDateFromLabel = new System.Windows.Forms.Label();
            this.rentSearchDateToPickerLabel = new System.Windows.Forms.Label();
            this.tbLicence = new System.Windows.Forms.TextBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dgvRent = new System.Windows.Forms.DataGridView();
            this.nudRentId = new System.Windows.Forms.NumericUpDown();
            this.rentWorkspace.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRentId)).BeginInit();
            this.SuspendLayout();
            // 
            // rentWorkspace
            // 
            this.rentWorkspace.Controls.Add(this.btnInvoice);
            this.rentWorkspace.Controls.Add(this.btnGiveBack);
            this.rentWorkspace.Controls.Add(this.rentSearchButton);
            this.rentWorkspace.Controls.Add(this.btnNewRent);
            this.rentWorkspace.Controls.Add(this.tableLayoutPanel3);
            this.rentWorkspace.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rentWorkspace.Location = new System.Drawing.Point(0, 315);
            this.rentWorkspace.Name = "rentWorkspace";
            this.rentWorkspace.Size = new System.Drawing.Size(978, 293);
            this.rentWorkspace.TabIndex = 4;
            // 
            // btnInvoice
            // 
            this.btnInvoice.Location = new System.Drawing.Point(486, 231);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(139, 47);
            this.btnInvoice.TabIndex = 8;
            this.btnInvoice.Text = "NEW INVOICE";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnGiveBack
            // 
            this.btnGiveBack.Location = new System.Drawing.Point(821, 231);
            this.btnGiveBack.Name = "btnGiveBack";
            this.btnGiveBack.Size = new System.Drawing.Size(139, 47);
            this.btnGiveBack.TabIndex = 10;
            this.btnGiveBack.Text = "GIVE BACK";
            this.btnGiveBack.UseVisualStyleBackColor = true;
            this.btnGiveBack.Click += new System.EventHandler(this.btnGiveBack_Click);
            // 
            // rentSearchButton
            // 
            this.rentSearchButton.Location = new System.Drawing.Point(7, 134);
            this.rentSearchButton.Name = "rentSearchButton";
            this.rentSearchButton.Size = new System.Drawing.Size(170, 41);
            this.rentSearchButton.TabIndex = 7;
            this.rentSearchButton.Text = "SEARCH";
            this.rentSearchButton.UseVisualStyleBackColor = true;
            this.rentSearchButton.Click += new System.EventHandler(this.rentSearchButton_Click);
            // 
            // btnNewRent
            // 
            this.btnNewRent.Location = new System.Drawing.Point(654, 231);
            this.btnNewRent.Name = "btnNewRent";
            this.btnNewRent.Size = new System.Drawing.Size(139, 47);
            this.btnNewRent.TabIndex = 9;
            this.btnNewRent.Text = "NEW RENT";
            this.btnNewRent.UseVisualStyleBackColor = true;
            this.btnNewRent.Click += new System.EventHandler(this.btnNewRent_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.33315F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.33314F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.33314F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.33314F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.33314F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.33314F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.00115F));
            this.tableLayoutPanel3.Controls.Add(this.rentSearchLicenceLabel, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.rentSearchPhoneLabel, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.rentSearchEmailLabel, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.rentSearchCustomerSurameLabel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.rentSearchIdLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.rentSearchDateFromLabel, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.rentSearchDateToPickerLabel, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbLicence, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.dtpFrom, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.dtpTo, 6, 1);
            this.tableLayoutPanel3.Controls.Add(this.tbPhone, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.tbEmail, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.tbRentSurname, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.nudRentId, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.96875F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.03125F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(978, 128);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tbRentSurname
            // 
            this.tbRentSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRentSurname.Location = new System.Drawing.Point(143, 58);
            this.tbRentSurname.Name = "tbRentSurname";
            this.tbRentSurname.Size = new System.Drawing.Size(134, 26);
            this.tbRentSurname.TabIndex = 1;
            // 
            // tbPhone
            // 
            this.tbPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPhone.Location = new System.Drawing.Point(423, 58);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(134, 26);
            this.tbPhone.TabIndex = 3;
            // 
            // tbEmail
            // 
            this.tbEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEmail.Location = new System.Drawing.Point(283, 58);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(134, 26);
            this.tbEmail.TabIndex = 2;
            // 
            // rentSearchLicenceLabel
            // 
            this.rentSearchLicenceLabel.AutoSize = true;
            this.rentSearchLicenceLabel.Location = new System.Drawing.Point(563, 5);
            this.rentSearchLicenceLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.rentSearchLicenceLabel.Name = "rentSearchLicenceLabel";
            this.rentSearchLicenceLabel.Size = new System.Drawing.Size(78, 20);
            this.rentSearchLicenceLabel.TabIndex = 4;
            this.rentSearchLicenceLabel.Text = "LICENCE";
            // 
            // rentSearchPhoneLabel
            // 
            this.rentSearchPhoneLabel.AutoSize = true;
            this.rentSearchPhoneLabel.Location = new System.Drawing.Point(423, 5);
            this.rentSearchPhoneLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.rentSearchPhoneLabel.Name = "rentSearchPhoneLabel";
            this.rentSearchPhoneLabel.Size = new System.Drawing.Size(65, 20);
            this.rentSearchPhoneLabel.TabIndex = 3;
            this.rentSearchPhoneLabel.Text = "PHONE";
            // 
            // rentSearchEmailLabel
            // 
            this.rentSearchEmailLabel.AutoSize = true;
            this.rentSearchEmailLabel.Location = new System.Drawing.Point(283, 5);
            this.rentSearchEmailLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.rentSearchEmailLabel.Name = "rentSearchEmailLabel";
            this.rentSearchEmailLabel.Size = new System.Drawing.Size(58, 20);
            this.rentSearchEmailLabel.TabIndex = 2;
            this.rentSearchEmailLabel.Text = "EMAIL";
            // 
            // rentSearchCustomerSurameLabel
            // 
            this.rentSearchCustomerSurameLabel.AutoSize = true;
            this.rentSearchCustomerSurameLabel.Location = new System.Drawing.Point(143, 5);
            this.rentSearchCustomerSurameLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.rentSearchCustomerSurameLabel.Name = "rentSearchCustomerSurameLabel";
            this.rentSearchCustomerSurameLabel.Size = new System.Drawing.Size(90, 20);
            this.rentSearchCustomerSurameLabel.TabIndex = 0;
            this.rentSearchCustomerSurameLabel.Text = "SURNAME";
            // 
            // rentSearchIdLabel
            // 
            this.rentSearchIdLabel.AutoSize = true;
            this.rentSearchIdLabel.Location = new System.Drawing.Point(3, 5);
            this.rentSearchIdLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.rentSearchIdLabel.Name = "rentSearchIdLabel";
            this.rentSearchIdLabel.Size = new System.Drawing.Size(126, 20);
            this.rentSearchIdLabel.TabIndex = 1;
            this.rentSearchIdLabel.Text = "RENT NUMBER";
            // 
            // rentSearchDateFromLabel
            // 
            this.rentSearchDateFromLabel.AutoSize = true;
            this.rentSearchDateFromLabel.Location = new System.Drawing.Point(703, 5);
            this.rentSearchDateFromLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.rentSearchDateFromLabel.Name = "rentSearchDateFromLabel";
            this.rentSearchDateFromLabel.Size = new System.Drawing.Size(112, 40);
            this.rentSearchDateFromLabel.TabIndex = 10;
            this.rentSearchDateFromLabel.Text = "DATE START FROM";
            // 
            // rentSearchDateToPickerLabel
            // 
            this.rentSearchDateToPickerLabel.AutoSize = true;
            this.rentSearchDateToPickerLabel.Location = new System.Drawing.Point(843, 5);
            this.rentSearchDateToPickerLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.rentSearchDateToPickerLabel.Name = "rentSearchDateToPickerLabel";
            this.rentSearchDateToPickerLabel.Size = new System.Drawing.Size(112, 40);
            this.rentSearchDateToPickerLabel.TabIndex = 12;
            this.rentSearchDateToPickerLabel.Text = "DATE START TO";
            // 
            // tbLicence
            // 
            this.tbLicence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLicence.Location = new System.Drawing.Point(563, 58);
            this.tbLicence.Name = "tbLicence";
            this.tbLicence.Size = new System.Drawing.Size(134, 26);
            this.tbLicence.TabIndex = 4;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFrom.Location = new System.Drawing.Point(703, 58);
            this.dtpFrom.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(134, 26);
            this.dtpFrom.TabIndex = 5;
            this.dtpFrom.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            // 
            // dtpTo
            // 
            this.dtpTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpTo.Location = new System.Drawing.Point(843, 58);
            this.dtpTo.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(132, 26);
            this.dtpTo.TabIndex = 6;
            // 
            // dgvRent
            // 
            this.dgvRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRent.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvRent.Location = new System.Drawing.Point(0, 0);
            this.dgvRent.Name = "dgvRent";
            this.dgvRent.RowHeadersWidth = 62;
            this.dgvRent.RowTemplate.Height = 28;
            this.dgvRent.Size = new System.Drawing.Size(978, 312);
            this.dgvRent.TabIndex = 5;
            // 
            // nudRentId
            // 
            this.nudRentId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudRentId.Location = new System.Drawing.Point(3, 58);
            this.nudRentId.Name = "nudRentId";
            this.nudRentId.Size = new System.Drawing.Size(134, 26);
            this.nudRentId.TabIndex = 0;
            // 
            // UserControlRentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvRent);
            this.Controls.Add(this.rentWorkspace);
            this.Name = "UserControlRentManager";
            this.Size = new System.Drawing.Size(978, 608);
            this.rentWorkspace.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRentId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel rentWorkspace;
        private System.Windows.Forms.Button rentSearchButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox tbRentSurname;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label rentSearchLicenceLabel;
        private System.Windows.Forms.Label rentSearchPhoneLabel;
        private System.Windows.Forms.Label rentSearchEmailLabel;
        private System.Windows.Forms.Label rentSearchCustomerSurameLabel;
        private System.Windows.Forms.Label rentSearchIdLabel;
        private System.Windows.Forms.Label rentSearchDateFromLabel;
        private System.Windows.Forms.Label rentSearchDateToPickerLabel;
        private System.Windows.Forms.TextBox tbLicence;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnGiveBack;
        private System.Windows.Forms.Button btnNewRent;
        private System.Windows.Forms.DataGridView dgvRent;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.NumericUpDown nudRentId;
    }
}
