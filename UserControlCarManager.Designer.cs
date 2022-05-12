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
            this.carWorkspace = new System.Windows.Forms.Panel();
            this.carSearchButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ratePanel = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.carRateToLabel = new System.Windows.Forms.Label();
            this.carRateFromLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.carTypeTextBox = new System.Windows.Forms.TextBox();
            this.carModelTextBox = new System.Windows.Forms.TextBox();
            this.carRateabel = new System.Windows.Forms.Label();
            this.carSeatsLabel = new System.Windows.Forms.Label();
            this.carTypeLabel = new System.Windows.Forms.Label();
            this.carModelLabel = new System.Windows.Forms.Label();
            this.carManufacturerlabel = new System.Windows.Forms.Label();
            this.carManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.seatsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.carSeatsToTextBox = new System.Windows.Forms.TextBox();
            this.carSeatsToLabel = new System.Windows.Forms.Label();
            this.carSeatsFromLabel = new System.Windows.Forms.Label();
            this.carSeatsFromTextBox = new System.Windows.Forms.TextBox();
            this.carWorkspace.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ratePanel.SuspendLayout();
            this.seatsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // carWorkspace
            // 
            this.carWorkspace.Controls.Add(this.carSearchButton);
            this.carWorkspace.Controls.Add(this.tableLayoutPanel1);
            this.carWorkspace.Dock = System.Windows.Forms.DockStyle.Top;
            this.carWorkspace.Location = new System.Drawing.Point(0, 0);
            this.carWorkspace.Name = "carWorkspace";
            this.carWorkspace.Size = new System.Drawing.Size(978, 258);
            this.carWorkspace.TabIndex = 4;
            // 
            // carSearchButton
            // 
            this.carSearchButton.Location = new System.Drawing.Point(7, 137);
            this.carSearchButton.Name = "carSearchButton";
            this.carSearchButton.Size = new System.Drawing.Size(170, 41);
            this.carSearchButton.TabIndex = 1;
            this.carSearchButton.Text = "SEARCH";
            this.carSearchButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ratePanel, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.carTypeTextBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.carModelTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.carRateabel, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.carSeatsLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.carTypeLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.carModelLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.carManufacturerlabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.carManufacturerTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.seatsPanel, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(978, 128);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ratePanel
            // 
            this.ratePanel.ColumnCount = 2;
            this.ratePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ratePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ratePanel.Controls.Add(this.textBox1, 1, 1);
            this.ratePanel.Controls.Add(this.carRateToLabel, 0, 1);
            this.ratePanel.Controls.Add(this.carRateFromLabel, 0, 0);
            this.ratePanel.Controls.Add(this.textBox2, 1, 0);
            this.ratePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ratePanel.Location = new System.Drawing.Point(783, 41);
            this.ratePanel.Name = "ratePanel";
            this.ratePanel.RowCount = 2;
            this.ratePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ratePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ratePanel.Size = new System.Drawing.Size(192, 84);
            this.ratePanel.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(99, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 26);
            this.textBox1.TabIndex = 9;
            // 
            // carRateToLabel
            // 
            this.carRateToLabel.AutoSize = true;
            this.carRateToLabel.Location = new System.Drawing.Point(3, 47);
            this.carRateToLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.carRateToLabel.Name = "carRateToLabel";
            this.carRateToLabel.Size = new System.Drawing.Size(30, 20);
            this.carRateToLabel.TabIndex = 11;
            this.carRateToLabel.Text = "TO";
            // 
            // carRateFromLabel
            // 
            this.carRateFromLabel.AutoSize = true;
            this.carRateFromLabel.Location = new System.Drawing.Point(3, 5);
            this.carRateFromLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.carRateFromLabel.Name = "carRateFromLabel";
            this.carRateFromLabel.Size = new System.Drawing.Size(56, 20);
            this.carRateFromLabel.TabIndex = 10;
            this.carRateFromLabel.Text = "FROM";
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(99, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 26);
            this.textBox2.TabIndex = 8;
            // 
            // carTypeTextBox
            // 
            this.carTypeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carTypeTextBox.Location = new System.Drawing.Point(393, 41);
            this.carTypeTextBox.Name = "carTypeTextBox";
            this.carTypeTextBox.Size = new System.Drawing.Size(189, 26);
            this.carTypeTextBox.TabIndex = 7;
            // 
            // carModelTextBox
            // 
            this.carModelTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carModelTextBox.Location = new System.Drawing.Point(198, 41);
            this.carModelTextBox.Name = "carModelTextBox";
            this.carModelTextBox.Size = new System.Drawing.Size(189, 26);
            this.carModelTextBox.TabIndex = 6;
            // 
            // carRateabel
            // 
            this.carRateabel.AutoSize = true;
            this.carRateabel.Location = new System.Drawing.Point(783, 5);
            this.carRateabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.carRateabel.Name = "carRateabel";
            this.carRateabel.Size = new System.Drawing.Size(104, 20);
            this.carRateabel.TabIndex = 4;
            this.carRateabel.Text = "DAILY RATE";
            // 
            // carSeatsLabel
            // 
            this.carSeatsLabel.AutoSize = true;
            this.carSeatsLabel.Location = new System.Drawing.Point(588, 5);
            this.carSeatsLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.carSeatsLabel.Name = "carSeatsLabel";
            this.carSeatsLabel.Size = new System.Drawing.Size(62, 20);
            this.carSeatsLabel.TabIndex = 3;
            this.carSeatsLabel.Text = "SEATS";
            // 
            // carTypeLabel
            // 
            this.carTypeLabel.AutoSize = true;
            this.carTypeLabel.Location = new System.Drawing.Point(393, 5);
            this.carTypeLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.carTypeLabel.Name = "carTypeLabel";
            this.carTypeLabel.Size = new System.Drawing.Size(50, 20);
            this.carTypeLabel.TabIndex = 2;
            this.carTypeLabel.Text = "TYPE";
            // 
            // carModelLabel
            // 
            this.carModelLabel.AutoSize = true;
            this.carModelLabel.Location = new System.Drawing.Point(198, 5);
            this.carModelLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.carModelLabel.Name = "carModelLabel";
            this.carModelLabel.Size = new System.Drawing.Size(66, 20);
            this.carModelLabel.TabIndex = 0;
            this.carModelLabel.Text = "MODEL";
            // 
            // carManufacturerlabel
            // 
            this.carManufacturerlabel.AutoSize = true;
            this.carManufacturerlabel.Location = new System.Drawing.Point(3, 5);
            this.carManufacturerlabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.carManufacturerlabel.Name = "carManufacturerlabel";
            this.carManufacturerlabel.Size = new System.Drawing.Size(144, 20);
            this.carManufacturerlabel.TabIndex = 1;
            this.carManufacturerlabel.Text = "MANUFACTURER";
            // 
            // carManufacturerTextBox
            // 
            this.carManufacturerTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carManufacturerTextBox.Location = new System.Drawing.Point(3, 41);
            this.carManufacturerTextBox.Name = "carManufacturerTextBox";
            this.carManufacturerTextBox.Size = new System.Drawing.Size(189, 26);
            this.carManufacturerTextBox.TabIndex = 5;
            // 
            // seatsPanel
            // 
            this.seatsPanel.ColumnCount = 2;
            this.seatsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.seatsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.seatsPanel.Controls.Add(this.carSeatsToTextBox, 1, 1);
            this.seatsPanel.Controls.Add(this.carSeatsToLabel, 0, 1);
            this.seatsPanel.Controls.Add(this.carSeatsFromLabel, 0, 0);
            this.seatsPanel.Controls.Add(this.carSeatsFromTextBox, 1, 0);
            this.seatsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seatsPanel.Location = new System.Drawing.Point(588, 41);
            this.seatsPanel.Name = "seatsPanel";
            this.seatsPanel.RowCount = 2;
            this.seatsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.seatsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.seatsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.seatsPanel.Size = new System.Drawing.Size(189, 84);
            this.seatsPanel.TabIndex = 8;
            // 
            // carSeatsToTextBox
            // 
            this.carSeatsToTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carSeatsToTextBox.Location = new System.Drawing.Point(97, 45);
            this.carSeatsToTextBox.Name = "carSeatsToTextBox";
            this.carSeatsToTextBox.Size = new System.Drawing.Size(89, 26);
            this.carSeatsToTextBox.TabIndex = 9;
            // 
            // carSeatsToLabel
            // 
            this.carSeatsToLabel.AutoSize = true;
            this.carSeatsToLabel.Location = new System.Drawing.Point(3, 47);
            this.carSeatsToLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.carSeatsToLabel.Name = "carSeatsToLabel";
            this.carSeatsToLabel.Size = new System.Drawing.Size(30, 20);
            this.carSeatsToLabel.TabIndex = 11;
            this.carSeatsToLabel.Text = "TO";
            // 
            // carSeatsFromLabel
            // 
            this.carSeatsFromLabel.AutoSize = true;
            this.carSeatsFromLabel.Location = new System.Drawing.Point(3, 5);
            this.carSeatsFromLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.carSeatsFromLabel.Name = "carSeatsFromLabel";
            this.carSeatsFromLabel.Size = new System.Drawing.Size(56, 20);
            this.carSeatsFromLabel.TabIndex = 10;
            this.carSeatsFromLabel.Text = "FROM";
            // 
            // carSeatsFromTextBox
            // 
            this.carSeatsFromTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carSeatsFromTextBox.Location = new System.Drawing.Point(97, 3);
            this.carSeatsFromTextBox.Name = "carSeatsFromTextBox";
            this.carSeatsFromTextBox.Size = new System.Drawing.Size(89, 26);
            this.carSeatsFromTextBox.TabIndex = 8;
            // 
            // UserControlCarManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.carWorkspace);
            this.Name = "UserControlCarManager";
            this.Size = new System.Drawing.Size(978, 608);
            this.carWorkspace.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ratePanel.ResumeLayout(false);
            this.ratePanel.PerformLayout();
            this.seatsPanel.ResumeLayout(false);
            this.seatsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel carWorkspace;
        private System.Windows.Forms.Button carSearchButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel ratePanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label carRateToLabel;
        private System.Windows.Forms.Label carRateFromLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox carTypeTextBox;
        private System.Windows.Forms.TextBox carModelTextBox;
        private System.Windows.Forms.Label carRateabel;
        private System.Windows.Forms.Label carSeatsLabel;
        private System.Windows.Forms.Label carTypeLabel;
        private System.Windows.Forms.Label carModelLabel;
        private System.Windows.Forms.Label carManufacturerlabel;
        private System.Windows.Forms.TextBox carManufacturerTextBox;
        private System.Windows.Forms.TableLayoutPanel seatsPanel;
        private System.Windows.Forms.TextBox carSeatsToTextBox;
        private System.Windows.Forms.Label carSeatsToLabel;
        private System.Windows.Forms.Label carSeatsFromLabel;
        private System.Windows.Forms.TextBox carSeatsFromTextBox;
    }
}
