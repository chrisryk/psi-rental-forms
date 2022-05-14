namespace CarRental.Forms
{
    partial class CarAddEdit
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
            this.tableCarAdd = new System.Windows.Forms.TableLayoutPanel();
            this.btnCarSave = new System.Windows.Forms.Button();
            this.lbCarManufacturer = new System.Windows.Forms.Label();
            this.lbCarModel = new System.Windows.Forms.Label();
            this.lbCarYear = new System.Windows.Forms.Label();
            this.lbCarInsurance = new System.Windows.Forms.Label();
            this.lbCarVin = new System.Windows.Forms.Label();
            this.lbCarRate = new System.Windows.Forms.Label();
            this.tbCarManufacturer = new System.Windows.Forms.TextBox();
            this.tbCarModel = new System.Windows.Forms.TextBox();
            this.tbVIN = new System.Windows.Forms.TextBox();
            this.dtpCarInsurance = new System.Windows.Forms.DateTimePicker();
            this.btnCarCancel = new System.Windows.Forms.Button();
            this.nudCarRate = new System.Windows.Forms.NumericUpDown();
            this.nudCarYear = new System.Windows.Forms.NumericUpDown();
            this.tableCarAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarYear)).BeginInit();
            this.SuspendLayout();
            // 
            // tableCarAdd
            // 
            this.tableCarAdd.ColumnCount = 2;
            this.tableCarAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableCarAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableCarAdd.Controls.Add(this.btnCarSave, 1, 6);
            this.tableCarAdd.Controls.Add(this.lbCarManufacturer, 0, 0);
            this.tableCarAdd.Controls.Add(this.lbCarModel, 0, 1);
            this.tableCarAdd.Controls.Add(this.lbCarYear, 0, 2);
            this.tableCarAdd.Controls.Add(this.lbCarInsurance, 0, 3);
            this.tableCarAdd.Controls.Add(this.lbCarVin, 0, 4);
            this.tableCarAdd.Controls.Add(this.lbCarRate, 0, 5);
            this.tableCarAdd.Controls.Add(this.tbCarManufacturer, 1, 0);
            this.tableCarAdd.Controls.Add(this.tbCarModel, 1, 1);
            this.tableCarAdd.Controls.Add(this.tbVIN, 1, 4);
            this.tableCarAdd.Controls.Add(this.dtpCarInsurance, 1, 3);
            this.tableCarAdd.Controls.Add(this.btnCarCancel, 0, 6);
            this.tableCarAdd.Controls.Add(this.nudCarRate, 1, 5);
            this.tableCarAdd.Controls.Add(this.nudCarYear, 1, 2);
            this.tableCarAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableCarAdd.Location = new System.Drawing.Point(0, 0);
            this.tableCarAdd.Name = "tableCarAdd";
            this.tableCarAdd.RowCount = 7;
            this.tableCarAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableCarAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableCarAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableCarAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableCarAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableCarAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableCarAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableCarAdd.Size = new System.Drawing.Size(662, 540);
            this.tableCarAdd.TabIndex = 0;
            // 
            // btnCarSave
            // 
            this.btnCarSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCarSave.Location = new System.Drawing.Point(368, 482);
            this.btnCarSave.Name = "btnCarSave";
            this.btnCarSave.Size = new System.Drawing.Size(123, 38);
            this.btnCarSave.TabIndex = 16;
            this.btnCarSave.Text = "SAVE";
            this.btnCarSave.UseVisualStyleBackColor = true;
            this.btnCarSave.Click += new System.EventHandler(this.btnCarSave_Click);
            // 
            // lbCarManufacturer
            // 
            this.lbCarManufacturer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbCarManufacturer.AutoSize = true;
            this.lbCarManufacturer.Location = new System.Drawing.Point(91, 28);
            this.lbCarManufacturer.Name = "lbCarManufacturer";
            this.lbCarManufacturer.Size = new System.Drawing.Size(104, 20);
            this.lbCarManufacturer.TabIndex = 0;
            this.lbCarManufacturer.Text = "Manufacturer";
            // 
            // lbCarModel
            // 
            this.lbCarModel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbCarModel.AutoSize = true;
            this.lbCarModel.Location = new System.Drawing.Point(143, 105);
            this.lbCarModel.Name = "lbCarModel";
            this.lbCarModel.Size = new System.Drawing.Size(52, 20);
            this.lbCarModel.TabIndex = 1;
            this.lbCarModel.Text = "Model";
            // 
            // lbCarYear
            // 
            this.lbCarYear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbCarYear.AutoSize = true;
            this.lbCarYear.Location = new System.Drawing.Point(152, 182);
            this.lbCarYear.Name = "lbCarYear";
            this.lbCarYear.Size = new System.Drawing.Size(43, 20);
            this.lbCarYear.TabIndex = 2;
            this.lbCarYear.Text = "Year";
            // 
            // lbCarInsurance
            // 
            this.lbCarInsurance.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbCarInsurance.AutoSize = true;
            this.lbCarInsurance.Location = new System.Drawing.Point(115, 259);
            this.lbCarInsurance.Name = "lbCarInsurance";
            this.lbCarInsurance.Size = new System.Drawing.Size(80, 20);
            this.lbCarInsurance.TabIndex = 3;
            this.lbCarInsurance.Text = "Insurance";
            // 
            // lbCarVin
            // 
            this.lbCarVin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbCarVin.AutoSize = true;
            this.lbCarVin.Location = new System.Drawing.Point(159, 336);
            this.lbCarVin.Name = "lbCarVin";
            this.lbCarVin.Size = new System.Drawing.Size(36, 20);
            this.lbCarVin.TabIndex = 4;
            this.lbCarVin.Text = "VIN";
            // 
            // lbCarRate
            // 
            this.lbCarRate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbCarRate.AutoSize = true;
            this.lbCarRate.Location = new System.Drawing.Point(113, 413);
            this.lbCarRate.Name = "lbCarRate";
            this.lbCarRate.Size = new System.Drawing.Size(82, 20);
            this.lbCarRate.TabIndex = 5;
            this.lbCarRate.Text = "Daily Rate";
            // 
            // tbCarManufacturer
            // 
            this.tbCarManufacturer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbCarManufacturer.Location = new System.Drawing.Point(201, 25);
            this.tbCarManufacturer.Name = "tbCarManufacturer";
            this.tbCarManufacturer.Size = new System.Drawing.Size(325, 26);
            this.tbCarManufacturer.TabIndex = 6;
            // 
            // tbCarModel
            // 
            this.tbCarModel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbCarModel.Location = new System.Drawing.Point(201, 102);
            this.tbCarModel.Name = "tbCarModel";
            this.tbCarModel.Size = new System.Drawing.Size(325, 26);
            this.tbCarModel.TabIndex = 7;
            // 
            // tbVIN
            // 
            this.tbVIN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbVIN.Location = new System.Drawing.Point(201, 333);
            this.tbVIN.MaxLength = 17;
            this.tbVIN.Name = "tbVIN";
            this.tbVIN.Size = new System.Drawing.Size(325, 26);
            this.tbVIN.TabIndex = 10;
            // 
            // dtpCarInsurance
            // 
            this.dtpCarInsurance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpCarInsurance.Location = new System.Drawing.Point(201, 256);
            this.dtpCarInsurance.Name = "dtpCarInsurance";
            this.dtpCarInsurance.Size = new System.Drawing.Size(325, 26);
            this.dtpCarInsurance.TabIndex = 12;
            // 
            // btnCarCancel
            // 
            this.btnCarCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCarCancel.Location = new System.Drawing.Point(37, 482);
            this.btnCarCancel.Name = "btnCarCancel";
            this.btnCarCancel.Size = new System.Drawing.Size(123, 38);
            this.btnCarCancel.TabIndex = 15;
            this.btnCarCancel.Text = "CANCEL";
            this.btnCarCancel.UseVisualStyleBackColor = true;
            this.btnCarCancel.Click += new System.EventHandler(this.btnCarCancel_Click);
            // 
            // nudCarRate
            // 
            this.nudCarRate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudCarRate.Location = new System.Drawing.Point(201, 410);
            this.nudCarRate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCarRate.Name = "nudCarRate";
            this.nudCarRate.Size = new System.Drawing.Size(325, 26);
            this.nudCarRate.TabIndex = 17;
            // 
            // nudCarYear
            // 
            this.nudCarYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudCarYear.Location = new System.Drawing.Point(201, 179);
            this.nudCarYear.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.nudCarYear.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudCarYear.Name = "nudCarYear";
            this.nudCarYear.Size = new System.Drawing.Size(120, 26);
            this.nudCarYear.TabIndex = 18;
            this.nudCarYear.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            // 
            // CarAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 540);
            this.Controls.Add(this.tableCarAdd);
            this.Name = "CarAddEdit";
            this.Text = "CarAddEdit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CarAddEdit_FormClosed);
            this.tableCarAdd.ResumeLayout(false);
            this.tableCarAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableCarAdd;
        private System.Windows.Forms.Label lbCarManufacturer;
        private System.Windows.Forms.Label lbCarModel;
        private System.Windows.Forms.Label lbCarYear;
        private System.Windows.Forms.Label lbCarInsurance;
        private System.Windows.Forms.Label lbCarVin;
        private System.Windows.Forms.Label lbCarRate;
        private System.Windows.Forms.TextBox tbCarManufacturer;
        private System.Windows.Forms.TextBox tbCarModel;
        private System.Windows.Forms.TextBox tbVIN;
        private System.Windows.Forms.DateTimePicker dtpCarInsurance;
        private System.Windows.Forms.Button btnCarSave;
        private System.Windows.Forms.Button btnCarCancel;
        private System.Windows.Forms.NumericUpDown nudCarRate;
        private System.Windows.Forms.NumericUpDown nudCarYear;
    }
}