namespace CarRental.Forms
{
    partial class RentBack
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
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lbRentBack = new System.Windows.Forms.Label();
            this.tableCarAdd = new System.Windows.Forms.TableLayoutPanel();
            this.btnCarSave = new System.Windows.Forms.Button();
            this.btnCarCancel = new System.Windows.Forms.Button();
            this.tableCarAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpReturnDate.Location = new System.Drawing.Point(310, 55);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(200, 26);
            this.dtpReturnDate.TabIndex = 0;
            // 
            // lbRentBack
            // 
            this.lbRentBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRentBack.AutoSize = true;
            this.lbRentBack.Location = new System.Drawing.Point(55, 58);
            this.lbRentBack.Name = "lbRentBack";
            this.lbRentBack.Size = new System.Drawing.Size(162, 20);
            this.lbRentBack.TabIndex = 1;
            this.lbRentBack.Text = "Select car return date";
            // 
            // tableCarAdd
            // 
            this.tableCarAdd.ColumnCount = 2;
            this.tableCarAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableCarAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableCarAdd.Controls.Add(this.btnCarSave, 1, 1);
            this.tableCarAdd.Controls.Add(this.lbRentBack, 0, 0);
            this.tableCarAdd.Controls.Add(this.btnCarCancel, 0, 1);
            this.tableCarAdd.Controls.Add(this.dtpReturnDate, 1, 0);
            this.tableCarAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableCarAdd.Location = new System.Drawing.Point(0, 0);
            this.tableCarAdd.Name = "tableCarAdd";
            this.tableCarAdd.RowCount = 2;
            this.tableCarAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableCarAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableCarAdd.Size = new System.Drawing.Size(547, 273);
            this.tableCarAdd.TabIndex = 2;
            // 
            // btnCarSave
            // 
            this.btnCarSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCarSave.Location = new System.Drawing.Point(348, 185);
            this.btnCarSave.Name = "btnCarSave";
            this.btnCarSave.Size = new System.Drawing.Size(123, 38);
            this.btnCarSave.TabIndex = 16;
            this.btnCarSave.Text = "SAVE";
            this.btnCarSave.UseVisualStyleBackColor = true;
            this.btnCarSave.Click += new System.EventHandler(this.btnCarSave_Click);
            // 
            // btnCarCancel
            // 
            this.btnCarCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCarCancel.Location = new System.Drawing.Point(75, 185);
            this.btnCarCancel.Name = "btnCarCancel";
            this.btnCarCancel.Size = new System.Drawing.Size(123, 38);
            this.btnCarCancel.TabIndex = 15;
            this.btnCarCancel.Text = "CANCEL";
            this.btnCarCancel.UseVisualStyleBackColor = true;
            this.btnCarCancel.Click += new System.EventHandler(this.btnCarCancel_Click);
            // 
            // RentBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 273);
            this.Controls.Add(this.tableCarAdd);
            this.Name = "RentBack";
            this.Text = "CAR RETURN";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RentBack_FormClosed);
            this.tableCarAdd.ResumeLayout(false);
            this.tableCarAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label lbRentBack;
        private System.Windows.Forms.TableLayoutPanel tableCarAdd;
        private System.Windows.Forms.Button btnCarSave;
        private System.Windows.Forms.Button btnCarCancel;
    }
}