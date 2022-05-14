namespace CarRental.Forms
{
    partial class CustomerAddEdit
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
            this.tableCustomerAdd = new System.Windows.Forms.TableLayoutPanel();
            this.btnCustSave = new System.Windows.Forms.Button();
            this.lbCustName = new System.Windows.Forms.Label();
            this.lbCustSurname = new System.Windows.Forms.Label();
            this.lbCustEmail = new System.Windows.Forms.Label();
            this.lbCustPhone = new System.Windows.Forms.Label();
            this.lbCustlicence = new System.Windows.Forms.Label();
            this.tbCustName = new System.Windows.Forms.TextBox();
            this.tbCustSurname = new System.Windows.Forms.TextBox();
            this.tbCustLicence = new System.Windows.Forms.TextBox();
            this.btnCustCancel = new System.Windows.Forms.Button();
            this.tbCustEmail = new System.Windows.Forms.TextBox();
            this.tbCustPhone = new System.Windows.Forms.TextBox();
            this.tableCustomerAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableCustomerAdd
            // 
            this.tableCustomerAdd.ColumnCount = 2;
            this.tableCustomerAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableCustomerAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableCustomerAdd.Controls.Add(this.btnCustSave, 1, 5);
            this.tableCustomerAdd.Controls.Add(this.lbCustName, 0, 0);
            this.tableCustomerAdd.Controls.Add(this.lbCustSurname, 0, 1);
            this.tableCustomerAdd.Controls.Add(this.lbCustEmail, 0, 2);
            this.tableCustomerAdd.Controls.Add(this.lbCustPhone, 0, 3);
            this.tableCustomerAdd.Controls.Add(this.lbCustlicence, 0, 4);
            this.tableCustomerAdd.Controls.Add(this.tbCustName, 1, 0);
            this.tableCustomerAdd.Controls.Add(this.tbCustSurname, 1, 1);
            this.tableCustomerAdd.Controls.Add(this.tbCustLicence, 1, 4);
            this.tableCustomerAdd.Controls.Add(this.btnCustCancel, 0, 5);
            this.tableCustomerAdd.Controls.Add(this.tbCustEmail, 1, 2);
            this.tableCustomerAdd.Controls.Add(this.tbCustPhone, 1, 3);
            this.tableCustomerAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableCustomerAdd.Location = new System.Drawing.Point(0, 0);
            this.tableCustomerAdd.Name = "tableCustomerAdd";
            this.tableCustomerAdd.RowCount = 6;
            this.tableCustomerAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableCustomerAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableCustomerAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableCustomerAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableCustomerAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableCustomerAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableCustomerAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableCustomerAdd.Size = new System.Drawing.Size(662, 540);
            this.tableCustomerAdd.TabIndex = 1;
            // 
            // btnCustSave
            // 
            this.btnCustSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCustSave.Location = new System.Drawing.Point(368, 475);
            this.btnCustSave.Name = "btnCustSave";
            this.btnCustSave.Size = new System.Drawing.Size(123, 38);
            this.btnCustSave.TabIndex = 16;
            this.btnCustSave.Text = "SAVE";
            this.btnCustSave.UseVisualStyleBackColor = true;
            this.btnCustSave.Click += new System.EventHandler(this.btnCustSave_Click);
            // 
            // lbCustName
            // 
            this.lbCustName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbCustName.AutoSize = true;
            this.lbCustName.Location = new System.Drawing.Point(144, 34);
            this.lbCustName.Name = "lbCustName";
            this.lbCustName.Size = new System.Drawing.Size(51, 20);
            this.lbCustName.TabIndex = 0;
            this.lbCustName.Text = "Name";
            // 
            // lbCustSurname
            // 
            this.lbCustSurname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbCustSurname.AutoSize = true;
            this.lbCustSurname.Location = new System.Drawing.Point(121, 124);
            this.lbCustSurname.Name = "lbCustSurname";
            this.lbCustSurname.Size = new System.Drawing.Size(74, 20);
            this.lbCustSurname.TabIndex = 1;
            this.lbCustSurname.Text = "Surname";
            // 
            // lbCustEmail
            // 
            this.lbCustEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbCustEmail.AutoSize = true;
            this.lbCustEmail.Location = new System.Drawing.Point(147, 214);
            this.lbCustEmail.Name = "lbCustEmail";
            this.lbCustEmail.Size = new System.Drawing.Size(48, 20);
            this.lbCustEmail.TabIndex = 2;
            this.lbCustEmail.Text = "Email";
            // 
            // lbCustPhone
            // 
            this.lbCustPhone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbCustPhone.AutoSize = true;
            this.lbCustPhone.Location = new System.Drawing.Point(140, 304);
            this.lbCustPhone.Name = "lbCustPhone";
            this.lbCustPhone.Size = new System.Drawing.Size(55, 20);
            this.lbCustPhone.TabIndex = 3;
            this.lbCustPhone.Text = "Phone";
            // 
            // lbCustlicence
            // 
            this.lbCustlicence.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbCustlicence.AutoSize = true;
            this.lbCustlicence.Location = new System.Drawing.Point(131, 394);
            this.lbCustlicence.Name = "lbCustlicence";
            this.lbCustlicence.Size = new System.Drawing.Size(64, 20);
            this.lbCustlicence.TabIndex = 4;
            this.lbCustlicence.Text = "Licence";
            // 
            // tbCustName
            // 
            this.tbCustName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbCustName.Location = new System.Drawing.Point(201, 31);
            this.tbCustName.Name = "tbCustName";
            this.tbCustName.Size = new System.Drawing.Size(325, 26);
            this.tbCustName.TabIndex = 6;
            // 
            // tbCustSurname
            // 
            this.tbCustSurname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbCustSurname.Location = new System.Drawing.Point(201, 121);
            this.tbCustSurname.Name = "tbCustSurname";
            this.tbCustSurname.Size = new System.Drawing.Size(325, 26);
            this.tbCustSurname.TabIndex = 7;
            // 
            // tbCustLicence
            // 
            this.tbCustLicence.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbCustLicence.Location = new System.Drawing.Point(201, 391);
            this.tbCustLicence.MaxLength = 17;
            this.tbCustLicence.Name = "tbCustLicence";
            this.tbCustLicence.Size = new System.Drawing.Size(325, 26);
            this.tbCustLicence.TabIndex = 10;
            // 
            // btnCustCancel
            // 
            this.btnCustCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCustCancel.Location = new System.Drawing.Point(37, 475);
            this.btnCustCancel.Name = "btnCustCancel";
            this.btnCustCancel.Size = new System.Drawing.Size(123, 38);
            this.btnCustCancel.TabIndex = 15;
            this.btnCustCancel.Text = "CANCEL";
            this.btnCustCancel.UseVisualStyleBackColor = true;
            this.btnCustCancel.Click += new System.EventHandler(this.btnCustCancel_Click);
            // 
            // tbCustEmail
            // 
            this.tbCustEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbCustEmail.Location = new System.Drawing.Point(201, 211);
            this.tbCustEmail.Name = "tbCustEmail";
            this.tbCustEmail.Size = new System.Drawing.Size(325, 26);
            this.tbCustEmail.TabIndex = 17;
            // 
            // tbCustPhone
            // 
            this.tbCustPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbCustPhone.Location = new System.Drawing.Point(201, 301);
            this.tbCustPhone.Name = "tbCustPhone";
            this.tbCustPhone.Size = new System.Drawing.Size(325, 26);
            this.tbCustPhone.TabIndex = 18;
            // 
            // CustomerAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 540);
            this.Controls.Add(this.tableCustomerAdd);
            this.Name = "CustomerAddEdit";
            this.Text = "CustomerAddEdit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerAddEdit_FormClosed);
            this.tableCustomerAdd.ResumeLayout(false);
            this.tableCustomerAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableCustomerAdd;
        private System.Windows.Forms.Button btnCustSave;
        private System.Windows.Forms.Label lbCustName;
        private System.Windows.Forms.Label lbCustSurname;
        private System.Windows.Forms.Label lbCustEmail;
        private System.Windows.Forms.Label lbCustPhone;
        private System.Windows.Forms.Label lbCustlicence;
        private System.Windows.Forms.TextBox tbCustName;
        private System.Windows.Forms.TextBox tbCustSurname;
        private System.Windows.Forms.TextBox tbCustLicence;
        private System.Windows.Forms.Button btnCustCancel;
        private System.Windows.Forms.TextBox tbCustEmail;
        private System.Windows.Forms.TextBox tbCustPhone;
    }
}