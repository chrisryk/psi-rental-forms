namespace CarRental
{
    partial class UserControlInvoiceManager
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
            this.invoiceWorkspace = new System.Windows.Forms.Panel();
            this.btnSearchInvoice = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.invoiceSearchRentLabel = new System.Windows.Forms.Label();
            this.invoiceSearchModelLabel = new System.Windows.Forms.Label();
            this.tbManufacturer = new System.Windows.Forms.TextBox();
            this.invoiceSearchManufacturerLabel = new System.Windows.Forms.Label();
            this.invoiceSearchSurnameLabel = new System.Windows.Forms.Label();
            this.invoiceSearchIdLabel = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.invoiceSearchDateFromPickerLabel = new System.Windows.Forms.Label();
            this.invoiceSearchDateToPickerLabel = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.nudRentId = new System.Windows.Forms.NumericUpDown();
            this.nudInvoiceId = new System.Windows.Forms.NumericUpDown();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.invoiceWorkspace.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRentId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInvoiceId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceWorkspace
            // 
            this.invoiceWorkspace.Controls.Add(this.btnSearchInvoice);
            this.invoiceWorkspace.Controls.Add(this.tableLayoutPanel4);
            this.invoiceWorkspace.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.invoiceWorkspace.Location = new System.Drawing.Point(0, 372);
            this.invoiceWorkspace.Name = "invoiceWorkspace";
            this.invoiceWorkspace.Size = new System.Drawing.Size(978, 236);
            this.invoiceWorkspace.TabIndex = 5;
            // 
            // btnSearchInvoice
            // 
            this.btnSearchInvoice.Location = new System.Drawing.Point(7, 134);
            this.btnSearchInvoice.Name = "btnSearchInvoice";
            this.btnSearchInvoice.Size = new System.Drawing.Size(170, 41);
            this.btnSearchInvoice.TabIndex = 7;
            this.btnSearchInvoice.Text = "SEARCH";
            this.btnSearchInvoice.UseVisualStyleBackColor = true;
            this.btnSearchInvoice.Click += new System.EventHandler(this.btnSearchInvoice_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 7;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.33315F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.33314F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.33314F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.33314F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.33314F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.33314F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.00115F));
            this.tableLayoutPanel4.Controls.Add(this.tbModel, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.invoiceSearchRentLabel, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.invoiceSearchModelLabel, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.tbManufacturer, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.invoiceSearchManufacturerLabel, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.invoiceSearchSurnameLabel, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.invoiceSearchIdLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tbSurname, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.invoiceSearchDateFromPickerLabel, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.invoiceSearchDateToPickerLabel, 6, 0);
            this.tableLayoutPanel4.Controls.Add(this.dtpDateFrom, 5, 1);
            this.tableLayoutPanel4.Controls.Add(this.dtpDateTo, 6, 1);
            this.tableLayoutPanel4.Controls.Add(this.nudRentId, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.nudInvoiceId, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(978, 128);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tbModel
            // 
            this.tbModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbModel.Location = new System.Drawing.Point(423, 41);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(134, 26);
            this.tbModel.TabIndex = 3;
            // 
            // invoiceSearchRentLabel
            // 
            this.invoiceSearchRentLabel.AutoSize = true;
            this.invoiceSearchRentLabel.Location = new System.Drawing.Point(563, 5);
            this.invoiceSearchRentLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.invoiceSearchRentLabel.Name = "invoiceSearchRentLabel";
            this.invoiceSearchRentLabel.Size = new System.Drawing.Size(73, 20);
            this.invoiceSearchRentLabel.TabIndex = 4;
            this.invoiceSearchRentLabel.Text = "RENT ID";
            // 
            // invoiceSearchModelLabel
            // 
            this.invoiceSearchModelLabel.AutoSize = true;
            this.invoiceSearchModelLabel.Location = new System.Drawing.Point(423, 5);
            this.invoiceSearchModelLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.invoiceSearchModelLabel.Name = "invoiceSearchModelLabel";
            this.invoiceSearchModelLabel.Size = new System.Drawing.Size(66, 20);
            this.invoiceSearchModelLabel.TabIndex = 3;
            this.invoiceSearchModelLabel.Text = "MODEL";
            // 
            // tbManufacturer
            // 
            this.tbManufacturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbManufacturer.Location = new System.Drawing.Point(283, 41);
            this.tbManufacturer.Name = "tbManufacturer";
            this.tbManufacturer.Size = new System.Drawing.Size(134, 26);
            this.tbManufacturer.TabIndex = 2;
            // 
            // invoiceSearchManufacturerLabel
            // 
            this.invoiceSearchManufacturerLabel.AutoSize = true;
            this.invoiceSearchManufacturerLabel.Location = new System.Drawing.Point(283, 5);
            this.invoiceSearchManufacturerLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.invoiceSearchManufacturerLabel.Name = "invoiceSearchManufacturerLabel";
            this.invoiceSearchManufacturerLabel.Size = new System.Drawing.Size(132, 33);
            this.invoiceSearchManufacturerLabel.TabIndex = 2;
            this.invoiceSearchManufacturerLabel.Text = "MANUFACTURER";
            // 
            // invoiceSearchSurnameLabel
            // 
            this.invoiceSearchSurnameLabel.AutoSize = true;
            this.invoiceSearchSurnameLabel.Location = new System.Drawing.Point(143, 5);
            this.invoiceSearchSurnameLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.invoiceSearchSurnameLabel.Name = "invoiceSearchSurnameLabel";
            this.invoiceSearchSurnameLabel.Size = new System.Drawing.Size(90, 20);
            this.invoiceSearchSurnameLabel.TabIndex = 0;
            this.invoiceSearchSurnameLabel.Text = "SURNAME";
            // 
            // invoiceSearchIdLabel
            // 
            this.invoiceSearchIdLabel.AutoSize = true;
            this.invoiceSearchIdLabel.Location = new System.Drawing.Point(3, 5);
            this.invoiceSearchIdLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.invoiceSearchIdLabel.Name = "invoiceSearchIdLabel";
            this.invoiceSearchIdLabel.Size = new System.Drawing.Size(96, 20);
            this.invoiceSearchIdLabel.TabIndex = 1;
            this.invoiceSearchIdLabel.Text = "INVOICE ID";
            // 
            // tbSurname
            // 
            this.tbSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSurname.Location = new System.Drawing.Point(143, 41);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(134, 26);
            this.tbSurname.TabIndex = 1;
            // 
            // invoiceSearchDateFromPickerLabel
            // 
            this.invoiceSearchDateFromPickerLabel.AutoSize = true;
            this.invoiceSearchDateFromPickerLabel.Location = new System.Drawing.Point(703, 5);
            this.invoiceSearchDateFromPickerLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.invoiceSearchDateFromPickerLabel.Name = "invoiceSearchDateFromPickerLabel";
            this.invoiceSearchDateFromPickerLabel.Size = new System.Drawing.Size(103, 20);
            this.invoiceSearchDateFromPickerLabel.TabIndex = 10;
            this.invoiceSearchDateFromPickerLabel.Text = "DATE FROM";
            // 
            // invoiceSearchDateToPickerLabel
            // 
            this.invoiceSearchDateToPickerLabel.AutoSize = true;
            this.invoiceSearchDateToPickerLabel.Location = new System.Drawing.Point(843, 5);
            this.invoiceSearchDateToPickerLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.invoiceSearchDateToPickerLabel.Name = "invoiceSearchDateToPickerLabel";
            this.invoiceSearchDateToPickerLabel.Size = new System.Drawing.Size(77, 20);
            this.invoiceSearchDateToPickerLabel.TabIndex = 12;
            this.invoiceSearchDateToPickerLabel.Text = "DATE TO";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDateFrom.Location = new System.Drawing.Point(703, 41);
            this.dtpDateFrom.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(134, 26);
            this.dtpDateFrom.TabIndex = 5;
            this.dtpDateFrom.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDateTo.Location = new System.Drawing.Point(843, 41);
            this.dtpDateTo.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(132, 26);
            this.dtpDateTo.TabIndex = 6;
            // 
            // nudRentId
            // 
            this.nudRentId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudRentId.Location = new System.Drawing.Point(563, 41);
            this.nudRentId.Name = "nudRentId";
            this.nudRentId.Size = new System.Drawing.Size(134, 26);
            this.nudRentId.TabIndex = 13;
            // 
            // nudInvoiceId
            // 
            this.nudInvoiceId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudInvoiceId.Location = new System.Drawing.Point(3, 41);
            this.nudInvoiceId.Name = "nudInvoiceId";
            this.nudInvoiceId.Size = new System.Drawing.Size(134, 26);
            this.nudInvoiceId.TabIndex = 14;
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoices.Location = new System.Drawing.Point(0, 0);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.RowHeadersWidth = 62;
            this.dgvInvoices.RowTemplate.Height = 28;
            this.dgvInvoices.Size = new System.Drawing.Size(978, 372);
            this.dgvInvoices.TabIndex = 6;
            // 
            // UserControlInvoiceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvInvoices);
            this.Controls.Add(this.invoiceWorkspace);
            this.Name = "UserControlInvoiceManager";
            this.Size = new System.Drawing.Size(978, 608);
            this.invoiceWorkspace.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRentId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInvoiceId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel invoiceWorkspace;
        private System.Windows.Forms.Button btnSearchInvoice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbManufacturer;
        private System.Windows.Forms.Label invoiceSearchRentLabel;
        private System.Windows.Forms.Label invoiceSearchModelLabel;
        private System.Windows.Forms.Label invoiceSearchManufacturerLabel;
        private System.Windows.Forms.Label invoiceSearchSurnameLabel;
        private System.Windows.Forms.Label invoiceSearchIdLabel;
        private System.Windows.Forms.Label invoiceSearchDateFromPickerLabel;
        private System.Windows.Forms.Label invoiceSearchDateToPickerLabel;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.NumericUpDown nudRentId;
        private System.Windows.Forms.NumericUpDown nudInvoiceId;
    }
}
