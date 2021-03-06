namespace CarRental.Forms
{
    partial class RentAdd
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
            this.btnRentSave = new System.Windows.Forms.Button();
            this.dtpRentStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnRentCancel = new System.Windows.Forms.Button();
            this.lbRentStartDate = new System.Windows.Forms.Label();
            this.lbRentCar = new System.Windows.Forms.Label();
            this.lbRentCustomer = new System.Windows.Forms.Label();
            this.tableRentAdd = new System.Windows.Forms.TableLayoutPanel();
            this.cbCustomerSurname = new System.Windows.Forms.ComboBox();
            this.cbCarManufacturer = new System.Windows.Forms.ComboBox();
            this.cbCarModel = new System.Windows.Forms.ComboBox();
            this.cbCustomerName = new System.Windows.Forms.ComboBox();
            this.cbCustomerLicence = new System.Windows.Forms.ComboBox();
            this.cbVin = new System.Windows.Forms.ComboBox();
            this.tableRentAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRentSave
            // 
            this.btnRentSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRentSave.Location = new System.Drawing.Point(536, 499);
            this.btnRentSave.Name = "btnRentSave";
            this.btnRentSave.Size = new System.Drawing.Size(123, 38);
            this.btnRentSave.TabIndex = 9;
            this.btnRentSave.Text = "SAVE";
            this.btnRentSave.UseVisualStyleBackColor = true;
            this.btnRentSave.Click += new System.EventHandler(this.btnRentSave_Click);
            // 
            // dtpRentStartDate
            // 
            this.dtpRentStartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpRentStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpRentStartDate.Location = new System.Drawing.Point(168, 324);
            this.dtpRentStartDate.Name = "dtpRentStartDate";
            this.dtpRentStartDate.Size = new System.Drawing.Size(159, 26);
            this.dtpRentStartDate.TabIndex = 7;
            // 
            // btnRentCancel
            // 
            this.btnRentCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRentCancel.Location = new System.Drawing.Point(3, 499);
            this.btnRentCancel.Name = "btnRentCancel";
            this.btnRentCancel.Size = new System.Drawing.Size(123, 38);
            this.btnRentCancel.TabIndex = 8;
            this.btnRentCancel.Text = "CANCEL";
            this.btnRentCancel.UseVisualStyleBackColor = true;
            this.btnRentCancel.Click += new System.EventHandler(this.btnRentCancel_Click);
            // 
            // lbRentStartDate
            // 
            this.lbRentStartDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbRentStartDate.AutoSize = true;
            this.lbRentStartDate.Location = new System.Drawing.Point(79, 327);
            this.lbRentStartDate.Name = "lbRentStartDate";
            this.lbRentStartDate.Size = new System.Drawing.Size(83, 20);
            this.lbRentStartDate.TabIndex = 2;
            this.lbRentStartDate.Text = "Start Date";
            // 
            // lbRentCar
            // 
            this.lbRentCar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbRentCar.AutoSize = true;
            this.lbRentCar.Location = new System.Drawing.Point(128, 192);
            this.lbRentCar.Name = "lbRentCar";
            this.lbRentCar.Size = new System.Drawing.Size(34, 20);
            this.lbRentCar.TabIndex = 1;
            this.lbRentCar.Text = "Car";
            // 
            // lbRentCustomer
            // 
            this.lbRentCustomer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbRentCustomer.AutoSize = true;
            this.lbRentCustomer.Location = new System.Drawing.Point(84, 57);
            this.lbRentCustomer.Name = "lbRentCustomer";
            this.lbRentCustomer.Size = new System.Drawing.Size(78, 20);
            this.lbRentCustomer.TabIndex = 0;
            this.lbRentCustomer.Text = "Customer";
            // 
            // tableRentAdd
            // 
            this.tableRentAdd.ColumnCount = 4;
            this.tableRentAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableRentAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableRentAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableRentAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableRentAdd.Controls.Add(this.lbRentCustomer, 0, 0);
            this.tableRentAdd.Controls.Add(this.lbRentCar, 0, 1);
            this.tableRentAdd.Controls.Add(this.lbRentStartDate, 0, 2);
            this.tableRentAdd.Controls.Add(this.btnRentCancel, 0, 3);
            this.tableRentAdd.Controls.Add(this.dtpRentStartDate, 1, 2);
            this.tableRentAdd.Controls.Add(this.cbCustomerSurname, 1, 0);
            this.tableRentAdd.Controls.Add(this.cbCarManufacturer, 1, 1);
            this.tableRentAdd.Controls.Add(this.cbCarModel, 2, 1);
            this.tableRentAdd.Controls.Add(this.btnRentSave, 3, 3);
            this.tableRentAdd.Controls.Add(this.cbCustomerName, 2, 0);
            this.tableRentAdd.Controls.Add(this.cbCustomerLicence, 3, 0);
            this.tableRentAdd.Controls.Add(this.cbVin, 3, 1);
            this.tableRentAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableRentAdd.Location = new System.Drawing.Point(0, 0);
            this.tableRentAdd.Name = "tableRentAdd";
            this.tableRentAdd.RowCount = 4;
            this.tableRentAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableRentAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableRentAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableRentAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableRentAdd.Size = new System.Drawing.Size(662, 540);
            this.tableRentAdd.TabIndex = 1;
            // 
            // cbCustomerSurname
            // 
            this.cbCustomerSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCustomerSurname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCustomerSurname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCustomerSurname.FormattingEnabled = true;
            this.cbCustomerSurname.Location = new System.Drawing.Point(168, 53);
            this.cbCustomerSurname.Name = "cbCustomerSurname";
            this.cbCustomerSurname.Size = new System.Drawing.Size(159, 28);
            this.cbCustomerSurname.TabIndex = 1;
            this.cbCustomerSurname.SelectedValueChanged += new System.EventHandler(this.cbCustomerSurname_SelectedValueChanged);
            // 
            // cbCarManufacturer
            // 
            this.cbCarManufacturer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCarManufacturer.FormattingEnabled = true;
            this.cbCarManufacturer.Location = new System.Drawing.Point(168, 188);
            this.cbCarManufacturer.Name = "cbCarManufacturer";
            this.cbCarManufacturer.Size = new System.Drawing.Size(159, 28);
            this.cbCarManufacturer.TabIndex = 4;
            this.cbCarManufacturer.SelectedValueChanged += new System.EventHandler(this.cbCarManufacturer_SelectedValueChanged);
            // 
            // cbCarModel
            // 
            this.cbCarModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCarModel.FormattingEnabled = true;
            this.cbCarModel.Location = new System.Drawing.Point(333, 188);
            this.cbCarModel.Name = "cbCarModel";
            this.cbCarModel.Size = new System.Drawing.Size(159, 28);
            this.cbCarModel.TabIndex = 5;
            this.cbCarModel.SelectedValueChanged += new System.EventHandler(this.cbCarModel_SelectedValueChanged);
            // 
            // cbCustomerName
            // 
            this.cbCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCustomerName.FormattingEnabled = true;
            this.cbCustomerName.Location = new System.Drawing.Point(333, 53);
            this.cbCustomerName.Name = "cbCustomerName";
            this.cbCustomerName.Size = new System.Drawing.Size(159, 28);
            this.cbCustomerName.TabIndex = 2;
            this.cbCustomerName.SelectedValueChanged += new System.EventHandler(this.cbCustomerName_SelectedValueChanged);
            // 
            // cbCustomerLicence
            // 
            this.cbCustomerLicence.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCustomerLicence.FormattingEnabled = true;
            this.cbCustomerLicence.Location = new System.Drawing.Point(499, 53);
            this.cbCustomerLicence.Name = "cbCustomerLicence";
            this.cbCustomerLicence.Size = new System.Drawing.Size(159, 28);
            this.cbCustomerLicence.TabIndex = 3;
            // 
            // cbVin
            // 
            this.cbVin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbVin.FormattingEnabled = true;
            this.cbVin.Location = new System.Drawing.Point(498, 188);
            this.cbVin.Name = "cbVin";
            this.cbVin.Size = new System.Drawing.Size(161, 28);
            this.cbVin.TabIndex = 6;
            // 
            // RentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 540);
            this.Controls.Add(this.tableRentAdd);
            this.Name = "RentAdd";
            this.Text = "NEW RENT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RentAdd_FormClosed);
            this.Load += new System.EventHandler(this.RentAddEdit_Load);
            this.tableRentAdd.ResumeLayout(false);
            this.tableRentAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRentSave;
        private System.Windows.Forms.DateTimePicker dtpRentStartDate;
        private System.Windows.Forms.Button btnRentCancel;
        private System.Windows.Forms.Label lbRentStartDate;
        private System.Windows.Forms.Label lbRentCar;
        private System.Windows.Forms.Label lbRentCustomer;
        private System.Windows.Forms.TableLayoutPanel tableRentAdd;
        private System.Windows.Forms.ComboBox cbCustomerSurname;
        private System.Windows.Forms.ComboBox cbCarManufacturer;
        private System.Windows.Forms.ComboBox cbCarModel;
        private System.Windows.Forms.ComboBox cbCustomerName;
        private System.Windows.Forms.ComboBox cbCustomerLicence;
        private System.Windows.Forms.ComboBox cbVin;
    }
}