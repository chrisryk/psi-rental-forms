namespace CarRental
{
    partial class UserControlCarManager
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
            this.btnSearchCar = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.btnShowCars = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbCarYear = new System.Windows.Forms.Label();
            this.tbCarModel = new System.Windows.Forms.TextBox();
            this.lbCarModel = new System.Windows.Forms.Label();
            this.lbCarManufacturer = new System.Windows.Forms.Label();
            this.tbCarManufacturer = new System.Windows.Forms.TextBox();
            this.panelCarYear = new System.Windows.Forms.TableLayoutPanel();
            this.lbCarYearTo = new System.Windows.Forms.Label();
            this.lbCarFrom = new System.Windows.Forms.Label();
            this.cbYearFrom = new System.Windows.Forms.ComboBox();
            this.cbYearTo = new System.Windows.Forms.ComboBox();
            this.panelCarRate = new System.Windows.Forms.TableLayoutPanel();
            this.cbRateTo = new System.Windows.Forms.NumericUpDown();
            this.lbCarRateTo = new System.Windows.Forms.Label();
            this.cbRateFrom = new System.Windows.Forms.NumericUpDown();
            this.lbCarRateFrom = new System.Windows.Forms.Label();
            this.lbCarRate = new System.Windows.Forms.Label();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelCarYear.SuspendLayout();
            this.panelCarRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbRateTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRateFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchCar
            // 
            this.btnSearchCar.Location = new System.Drawing.Point(7, 485);
            this.btnSearchCar.Name = "btnSearchCar";
            this.btnSearchCar.Size = new System.Drawing.Size(91, 47);
            this.btnSearchCar.TabIndex = 1;
            this.btnSearchCar.Text = "SEARCH";
            this.btnSearchCar.UseVisualStyleBackColor = true;
            this.btnSearchCar.Click += new System.EventHandler(this.btnSearchCar_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(687, 558);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(91, 47);
            this.btnAddCar.TabIndex = 2;
            this.btnAddCar.Text = "ADD";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnEditCar
            // 
            this.btnEditCar.Location = new System.Drawing.Point(784, 558);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(91, 47);
            this.btnEditCar.TabIndex = 3;
            this.btnEditCar.Text = "EDIT";
            this.btnEditCar.UseVisualStyleBackColor = true;
            this.btnEditCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Location = new System.Drawing.Point(881, 558);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(91, 47);
            this.btnDeleteCar.TabIndex = 4;
            this.btnDeleteCar.Text = "DELETE";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // btnShowCars
            // 
            this.btnShowCars.Location = new System.Drawing.Point(525, 558);
            this.btnShowCars.Name = "btnShowCars";
            this.btnShowCars.Size = new System.Drawing.Size(156, 47);
            this.btnShowCars.TabIndex = 5;
            this.btnShowCars.Text = "SHOW ALL";
            this.btnShowCars.UseVisualStyleBackColor = true;
            this.btnShowCars.Click += new System.EventHandler(this.btnShowCars_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lbCarYear, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbCarModel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbCarModel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbCarManufacturer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbCarManufacturer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelCarYear, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelCarRate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbCarRate, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 351);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(978, 128);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lbCarYear
            // 
            this.lbCarYear.AutoSize = true;
            this.lbCarYear.Location = new System.Drawing.Point(735, 5);
            this.lbCarYear.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbCarYear.Name = "lbCarYear";
            this.lbCarYear.Size = new System.Drawing.Size(54, 20);
            this.lbCarYear.TabIndex = 8;
            this.lbCarYear.Text = "YEAR";
            // 
            // tbCarModel
            // 
            this.tbCarModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCarModel.Location = new System.Drawing.Point(247, 41);
            this.tbCarModel.MaxLength = 20;
            this.tbCarModel.Name = "tbCarModel";
            this.tbCarModel.Size = new System.Drawing.Size(238, 26);
            this.tbCarModel.TabIndex = 6;
            // 
            // lbCarModel
            // 
            this.lbCarModel.AutoSize = true;
            this.lbCarModel.Location = new System.Drawing.Point(247, 5);
            this.lbCarModel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbCarModel.Name = "lbCarModel";
            this.lbCarModel.Size = new System.Drawing.Size(66, 20);
            this.lbCarModel.TabIndex = 0;
            this.lbCarModel.Text = "MODEL";
            // 
            // lbCarManufacturer
            // 
            this.lbCarManufacturer.AutoSize = true;
            this.lbCarManufacturer.Location = new System.Drawing.Point(3, 5);
            this.lbCarManufacturer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbCarManufacturer.Name = "lbCarManufacturer";
            this.lbCarManufacturer.Size = new System.Drawing.Size(144, 20);
            this.lbCarManufacturer.TabIndex = 1;
            this.lbCarManufacturer.Text = "MANUFACTURER";
            // 
            // tbCarManufacturer
            // 
            this.tbCarManufacturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCarManufacturer.Location = new System.Drawing.Point(3, 41);
            this.tbCarManufacturer.MaxLength = 20;
            this.tbCarManufacturer.Name = "tbCarManufacturer";
            this.tbCarManufacturer.Size = new System.Drawing.Size(238, 26);
            this.tbCarManufacturer.TabIndex = 5;
            // 
            // panelCarYear
            // 
            this.panelCarYear.ColumnCount = 2;
            this.panelCarYear.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCarYear.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCarYear.Controls.Add(this.lbCarYearTo, 0, 1);
            this.panelCarYear.Controls.Add(this.lbCarFrom, 0, 0);
            this.panelCarYear.Controls.Add(this.cbYearFrom, 1, 0);
            this.panelCarYear.Controls.Add(this.cbYearTo, 1, 1);
            this.panelCarYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCarYear.Location = new System.Drawing.Point(735, 41);
            this.panelCarYear.Name = "panelCarYear";
            this.panelCarYear.RowCount = 2;
            this.panelCarYear.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCarYear.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCarYear.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelCarYear.Size = new System.Drawing.Size(240, 84);
            this.panelCarYear.TabIndex = 8;
            // 
            // lbCarYearTo
            // 
            this.lbCarYearTo.AutoSize = true;
            this.lbCarYearTo.Location = new System.Drawing.Point(3, 47);
            this.lbCarYearTo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbCarYearTo.Name = "lbCarYearTo";
            this.lbCarYearTo.Size = new System.Drawing.Size(30, 20);
            this.lbCarYearTo.TabIndex = 12;
            this.lbCarYearTo.Text = "TO";
            // 
            // lbCarFrom
            // 
            this.lbCarFrom.AutoSize = true;
            this.lbCarFrom.Location = new System.Drawing.Point(3, 5);
            this.lbCarFrom.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbCarFrom.Name = "lbCarFrom";
            this.lbCarFrom.Size = new System.Drawing.Size(56, 20);
            this.lbCarFrom.TabIndex = 11;
            this.lbCarFrom.Text = "FROM";
            // 
            // cbYearFrom
            // 
            this.cbYearFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbYearFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYearFrom.FormattingEnabled = true;
            this.cbYearFrom.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cbYearFrom.Location = new System.Drawing.Point(123, 3);
            this.cbYearFrom.Name = "cbYearFrom";
            this.cbYearFrom.Size = new System.Drawing.Size(114, 28);
            this.cbYearFrom.TabIndex = 13;
            // 
            // cbYearTo
            // 
            this.cbYearTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbYearTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYearTo.FormattingEnabled = true;
            this.cbYearTo.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cbYearTo.Location = new System.Drawing.Point(123, 45);
            this.cbYearTo.Name = "cbYearTo";
            this.cbYearTo.Size = new System.Drawing.Size(114, 28);
            this.cbYearTo.TabIndex = 14;
            // 
            // panelCarRate
            // 
            this.panelCarRate.ColumnCount = 2;
            this.panelCarRate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCarRate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCarRate.Controls.Add(this.cbRateTo, 1, 1);
            this.panelCarRate.Controls.Add(this.lbCarRateTo, 0, 1);
            this.panelCarRate.Controls.Add(this.cbRateFrom, 1, 0);
            this.panelCarRate.Controls.Add(this.lbCarRateFrom, 0, 0);
            this.panelCarRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCarRate.Location = new System.Drawing.Point(491, 41);
            this.panelCarRate.Name = "panelCarRate";
            this.panelCarRate.RowCount = 2;
            this.panelCarRate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCarRate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCarRate.Size = new System.Drawing.Size(238, 84);
            this.panelCarRate.TabIndex = 12;
            // 
            // cbRateTo
            // 
            this.cbRateTo.Location = new System.Drawing.Point(122, 45);
            this.cbRateTo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cbRateTo.Name = "cbRateTo";
            this.cbRateTo.Size = new System.Drawing.Size(113, 26);
            this.cbRateTo.TabIndex = 8;
            // 
            // lbCarRateTo
            // 
            this.lbCarRateTo.AutoSize = true;
            this.lbCarRateTo.Location = new System.Drawing.Point(3, 47);
            this.lbCarRateTo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbCarRateTo.Name = "lbCarRateTo";
            this.lbCarRateTo.Size = new System.Drawing.Size(30, 20);
            this.lbCarRateTo.TabIndex = 11;
            this.lbCarRateTo.Text = "TO";
            // 
            // cbRateFrom
            // 
            this.cbRateFrom.Location = new System.Drawing.Point(122, 3);
            this.cbRateFrom.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cbRateFrom.Name = "cbRateFrom";
            this.cbRateFrom.Size = new System.Drawing.Size(113, 26);
            this.cbRateFrom.TabIndex = 7;
            // 
            // lbCarRateFrom
            // 
            this.lbCarRateFrom.AutoSize = true;
            this.lbCarRateFrom.Location = new System.Drawing.Point(3, 5);
            this.lbCarRateFrom.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbCarRateFrom.Name = "lbCarRateFrom";
            this.lbCarRateFrom.Size = new System.Drawing.Size(56, 20);
            this.lbCarRateFrom.TabIndex = 10;
            this.lbCarRateFrom.Text = "FROM";
            // 
            // lbCarRate
            // 
            this.lbCarRate.AutoSize = true;
            this.lbCarRate.Location = new System.Drawing.Point(491, 5);
            this.lbCarRate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbCarRate.Name = "lbCarRate";
            this.lbCarRate.Size = new System.Drawing.Size(104, 20);
            this.lbCarRate.TabIndex = 4;
            this.lbCarRate.Text = "DAILY RATE";
            // 
            // dgvCars
            // 
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCars.Location = new System.Drawing.Point(0, 0);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.RowHeadersWidth = 62;
            this.dgvCars.RowTemplate.Height = 28;
            this.dgvCars.Size = new System.Drawing.Size(978, 351);
            this.dgvCars.TabIndex = 0;
            // 
            // UserControlCarManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnShowCars);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnEditCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.btnSearchCar);
            this.Controls.Add(this.dgvCars);
            this.Name = "UserControlCarManager";
            this.Size = new System.Drawing.Size(978, 608);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelCarYear.ResumeLayout(false);
            this.panelCarYear.PerformLayout();
            this.panelCarRate.ResumeLayout(false);
            this.panelCarRate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbRateTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRateFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearchCar;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.Button btnShowCars;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbCarYear;
        private System.Windows.Forms.TextBox tbCarModel;
        private System.Windows.Forms.Label lbCarModel;
        private System.Windows.Forms.Label lbCarManufacturer;
        private System.Windows.Forms.TextBox tbCarManufacturer;
        private System.Windows.Forms.TableLayoutPanel panelCarYear;
        private System.Windows.Forms.Label lbCarYearTo;
        private System.Windows.Forms.Label lbCarFrom;
        private System.Windows.Forms.TableLayoutPanel panelCarRate;
        private System.Windows.Forms.Label lbCarRateTo;
        private System.Windows.Forms.Label lbCarRateFrom;
        private System.Windows.Forms.Label lbCarRate;
        private System.Windows.Forms.ComboBox cbYearFrom;
        private System.Windows.Forms.ComboBox cbYearTo;
        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.NumericUpDown cbRateTo;
        private System.Windows.Forms.NumericUpDown cbRateFrom;
    }
}
