namespace CarRental
{
    partial class UserControlCustomerManager
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
            this.customerWorkspace = new System.Windows.Forms.Panel();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbUserSurname = new System.Windows.Forms.TextBox();
            this.tbUserPhone = new System.Windows.Forms.TextBox();
            this.tbUserEmail = new System.Windows.Forms.TextBox();
            this.lbUserLicence = new System.Windows.Forms.Label();
            this.lbUserPhone = new System.Windows.Forms.Label();
            this.lbUserEmail = new System.Windows.Forms.Label();
            this.lbUserSurname = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbUserLicence = new System.Windows.Forms.TextBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.customerWorkspace.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // customerWorkspace
            // 
            this.customerWorkspace.Controls.Add(this.btnDeleteCustomer);
            this.customerWorkspace.Controls.Add(this.btnEditCustomer);
            this.customerWorkspace.Controls.Add(this.btnAddCustomer);
            this.customerWorkspace.Controls.Add(this.btnSearchCustomer);
            this.customerWorkspace.Controls.Add(this.tableLayoutPanel2);
            this.customerWorkspace.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customerWorkspace.Location = new System.Drawing.Point(0, 349);
            this.customerWorkspace.Name = "customerWorkspace";
            this.customerWorkspace.Size = new System.Drawing.Size(978, 259);
            this.customerWorkspace.TabIndex = 3;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Location = new System.Drawing.Point(7, 137);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(91, 47);
            this.btnSearchCustomer.TabIndex = 1;
            this.btnSearchCustomer.Text = "SEARCH";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tbUserSurname, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbUserPhone, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbUserEmail, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbUserLicence, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbUserPhone, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbUserEmail, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbUserSurname, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbUserName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbUserName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbUserLicence, 4, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(978, 128);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tbUserSurname
            // 
            this.tbUserSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUserSurname.Location = new System.Drawing.Point(198, 41);
            this.tbUserSurname.MaxLength = 20;
            this.tbUserSurname.Name = "tbUserSurname";
            this.tbUserSurname.Size = new System.Drawing.Size(189, 26);
            this.tbUserSurname.TabIndex = 8;
            // 
            // tbUserPhone
            // 
            this.tbUserPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUserPhone.Location = new System.Drawing.Point(588, 41);
            this.tbUserPhone.MaxLength = 15;
            this.tbUserPhone.Name = "tbUserPhone";
            this.tbUserPhone.Size = new System.Drawing.Size(189, 26);
            this.tbUserPhone.TabIndex = 7;
            // 
            // tbUserEmail
            // 
            this.tbUserEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUserEmail.Location = new System.Drawing.Point(393, 41);
            this.tbUserEmail.MaxLength = 30;
            this.tbUserEmail.Name = "tbUserEmail";
            this.tbUserEmail.Size = new System.Drawing.Size(189, 26);
            this.tbUserEmail.TabIndex = 6;
            // 
            // lbUserLicence
            // 
            this.lbUserLicence.AutoSize = true;
            this.lbUserLicence.Location = new System.Drawing.Point(783, 5);
            this.lbUserLicence.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbUserLicence.Name = "lbUserLicence";
            this.lbUserLicence.Size = new System.Drawing.Size(78, 20);
            this.lbUserLicence.TabIndex = 4;
            this.lbUserLicence.Text = "LICENCE";
            // 
            // lbUserPhone
            // 
            this.lbUserPhone.AutoSize = true;
            this.lbUserPhone.Location = new System.Drawing.Point(588, 5);
            this.lbUserPhone.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbUserPhone.Name = "lbUserPhone";
            this.lbUserPhone.Size = new System.Drawing.Size(65, 20);
            this.lbUserPhone.TabIndex = 3;
            this.lbUserPhone.Text = "PHONE";
            // 
            // lbUserEmail
            // 
            this.lbUserEmail.AutoSize = true;
            this.lbUserEmail.Location = new System.Drawing.Point(393, 5);
            this.lbUserEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbUserEmail.Name = "lbUserEmail";
            this.lbUserEmail.Size = new System.Drawing.Size(58, 20);
            this.lbUserEmail.TabIndex = 2;
            this.lbUserEmail.Text = "EMAIL";
            // 
            // lbUserSurname
            // 
            this.lbUserSurname.AutoSize = true;
            this.lbUserSurname.Location = new System.Drawing.Point(198, 5);
            this.lbUserSurname.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbUserSurname.Name = "lbUserSurname";
            this.lbUserSurname.Size = new System.Drawing.Size(90, 20);
            this.lbUserSurname.TabIndex = 0;
            this.lbUserSurname.Text = "SURNAME";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(3, 5);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(55, 20);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "NAME";
            // 
            // tbUserName
            // 
            this.tbUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUserName.Location = new System.Drawing.Point(3, 41);
            this.tbUserName.MaxLength = 20;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(189, 26);
            this.tbUserName.TabIndex = 5;
            // 
            // tbUserLicence
            // 
            this.tbUserLicence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUserLicence.Location = new System.Drawing.Point(783, 41);
            this.tbUserLicence.MaxLength = 15;
            this.tbUserLicence.Name = "tbUserLicence";
            this.tbUserLicence.Size = new System.Drawing.Size(192, 26);
            this.tbUserLicence.TabIndex = 9;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCustomers.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 62;
            this.dgvCustomers.RowTemplate.Height = 28;
            this.dgvCustomers.Size = new System.Drawing.Size(978, 346);
            this.dgvCustomers.TabIndex = 4;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(880, 209);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(91, 47);
            this.btnDeleteCustomer.TabIndex = 7;
            this.btnDeleteCustomer.Text = "DELETE";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(783, 209);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(91, 47);
            this.btnEditCustomer.TabIndex = 6;
            this.btnEditCustomer.Text = "EDIT";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(686, 209);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(91, 47);
            this.btnAddCustomer.TabIndex = 5;
            this.btnAddCustomer.Text = "ADD";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // UserControlCustomerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.customerWorkspace);
            this.Name = "UserControlCustomerManager";
            this.Size = new System.Drawing.Size(978, 608);
            this.customerWorkspace.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel customerWorkspace;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tbUserSurname;
        private System.Windows.Forms.TextBox tbUserPhone;
        private System.Windows.Forms.TextBox tbUserEmail;
        private System.Windows.Forms.Label lbUserLicence;
        private System.Windows.Forms.Label lbUserPhone;
        private System.Windows.Forms.Label lbUserEmail;
        private System.Windows.Forms.Label lbUserSurname;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbUserLicence;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
    }
}
