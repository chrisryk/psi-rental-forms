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
            this.invoiceSearchSurnameTextBox = new System.Windows.Forms.TextBox();
            this.invoiceSearchModelTextBox = new System.Windows.Forms.TextBox();
            this.invoiceSearchManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.invoiceSearchRentLabel = new System.Windows.Forms.Label();
            this.invoiceSearchModelLabel = new System.Windows.Forms.Label();
            this.invoiceSearchManufacturerLabel = new System.Windows.Forms.Label();
            this.invoiceSearchSurnameLabel = new System.Windows.Forms.Label();
            this.invoiceSearchIdLabel = new System.Windows.Forms.Label();
            this.invoiceIdTextBox = new System.Windows.Forms.TextBox();
            this.invoiceSearchDateFromPickerLabel = new System.Windows.Forms.Label();
            this.invoiceSearchDateToPickerLabel = new System.Windows.Forms.Label();
            this.invoiceSearchRentTextBox = new System.Windows.Forms.TextBox();
            this.invoiceSearchDateFromPicker = new System.Windows.Forms.DateTimePicker();
            this.invoiceSearchDateToPicker = new System.Windows.Forms.DateTimePicker();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.invoiceWorkspace.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
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
            this.btnSearchInvoice.TabIndex = 1;
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
            this.tableLayoutPanel4.Controls.Add(this.invoiceSearchSurnameTextBox, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.invoiceSearchModelTextBox, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.invoiceSearchManufacturerTextBox, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.invoiceSearchRentLabel, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.invoiceSearchModelLabel, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.invoiceSearchManufacturerLabel, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.invoiceSearchSurnameLabel, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.invoiceSearchIdLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.invoiceIdTextBox, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.invoiceSearchDateFromPickerLabel, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.invoiceSearchDateToPickerLabel, 6, 0);
            this.tableLayoutPanel4.Controls.Add(this.invoiceSearchRentTextBox, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.invoiceSearchDateFromPicker, 5, 1);
            this.tableLayoutPanel4.Controls.Add(this.invoiceSearchDateToPicker, 6, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(978, 128);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // invoiceSearchSurnameTextBox
            // 
            this.invoiceSearchSurnameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoiceSearchSurnameTextBox.Location = new System.Drawing.Point(143, 41);
            this.invoiceSearchSurnameTextBox.Name = "invoiceSearchSurnameTextBox";
            this.invoiceSearchSurnameTextBox.Size = new System.Drawing.Size(134, 26);
            this.invoiceSearchSurnameTextBox.TabIndex = 8;
            // 
            // invoiceSearchModelTextBox
            // 
            this.invoiceSearchModelTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoiceSearchModelTextBox.Location = new System.Drawing.Point(423, 41);
            this.invoiceSearchModelTextBox.Name = "invoiceSearchModelTextBox";
            this.invoiceSearchModelTextBox.Size = new System.Drawing.Size(134, 26);
            this.invoiceSearchModelTextBox.TabIndex = 7;
            // 
            // invoiceSearchManufacturerTextBox
            // 
            this.invoiceSearchManufacturerTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoiceSearchManufacturerTextBox.Location = new System.Drawing.Point(283, 41);
            this.invoiceSearchManufacturerTextBox.Name = "invoiceSearchManufacturerTextBox";
            this.invoiceSearchManufacturerTextBox.Size = new System.Drawing.Size(134, 26);
            this.invoiceSearchManufacturerTextBox.TabIndex = 6;
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
            // invoiceIdTextBox
            // 
            this.invoiceIdTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoiceIdTextBox.Location = new System.Drawing.Point(3, 41);
            this.invoiceIdTextBox.Name = "invoiceIdTextBox";
            this.invoiceIdTextBox.Size = new System.Drawing.Size(134, 26);
            this.invoiceIdTextBox.TabIndex = 5;
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
            // invoiceSearchRentTextBox
            // 
            this.invoiceSearchRentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoiceSearchRentTextBox.Location = new System.Drawing.Point(563, 41);
            this.invoiceSearchRentTextBox.Name = "invoiceSearchRentTextBox";
            this.invoiceSearchRentTextBox.Size = new System.Drawing.Size(134, 26);
            this.invoiceSearchRentTextBox.TabIndex = 9;
            // 
            // invoiceSearchDateFromPicker
            // 
            this.invoiceSearchDateFromPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoiceSearchDateFromPicker.Location = new System.Drawing.Point(703, 41);
            this.invoiceSearchDateFromPicker.Name = "invoiceSearchDateFromPicker";
            this.invoiceSearchDateFromPicker.Size = new System.Drawing.Size(134, 26);
            this.invoiceSearchDateFromPicker.TabIndex = 11;
            // 
            // invoiceSearchDateToPicker
            // 
            this.invoiceSearchDateToPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoiceSearchDateToPicker.Location = new System.Drawing.Point(843, 41);
            this.invoiceSearchDateToPicker.Name = "invoiceSearchDateToPicker";
            this.invoiceSearchDateToPicker.Size = new System.Drawing.Size(132, 26);
            this.invoiceSearchDateToPicker.TabIndex = 13;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel invoiceWorkspace;
        private System.Windows.Forms.Button btnSearchInvoice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox invoiceSearchSurnameTextBox;
        private System.Windows.Forms.TextBox invoiceSearchModelTextBox;
        private System.Windows.Forms.TextBox invoiceSearchManufacturerTextBox;
        private System.Windows.Forms.Label invoiceSearchRentLabel;
        private System.Windows.Forms.Label invoiceSearchModelLabel;
        private System.Windows.Forms.Label invoiceSearchManufacturerLabel;
        private System.Windows.Forms.Label invoiceSearchSurnameLabel;
        private System.Windows.Forms.Label invoiceSearchIdLabel;
        private System.Windows.Forms.TextBox invoiceIdTextBox;
        private System.Windows.Forms.Label invoiceSearchDateFromPickerLabel;
        private System.Windows.Forms.Label invoiceSearchDateToPickerLabel;
        private System.Windows.Forms.TextBox invoiceSearchRentTextBox;
        private System.Windows.Forms.DateTimePicker invoiceSearchDateFromPicker;
        private System.Windows.Forms.DateTimePicker invoiceSearchDateToPicker;
        private System.Windows.Forms.DataGridView dgvInvoices;
    }
}
