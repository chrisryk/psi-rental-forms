namespace CarRental
{
    partial class FormRental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRental));
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.controlsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.invoiceButton = new System.Windows.Forms.Button();
            this.rentButton = new System.Windows.Forms.Button();
            this.customerButton = new System.Windows.Forms.Button();
            this.carButton = new System.Windows.Forms.Button();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.workspacePanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.controlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(71, 32);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(55, 32);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1169, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // controlsPanel
            // 
            this.controlsPanel.ColumnCount = 1;
            this.controlsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.controlsPanel.Controls.Add(this.invoiceButton, 0, 3);
            this.controlsPanel.Controls.Add(this.rentButton, 0, 2);
            this.controlsPanel.Controls.Add(this.customerButton, 0, 1);
            this.controlsPanel.Controls.Add(this.carButton, 0, 0);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsPanel.Location = new System.Drawing.Point(0, 0);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.RowCount = 4;
            this.controlsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.controlsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.controlsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.controlsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.controlsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.controlsPanel.Size = new System.Drawing.Size(179, 618);
            this.controlsPanel.TabIndex = 0;
            // 
            // invoiceButton
            // 
            this.invoiceButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.invoiceButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.invoiceButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("invoiceButton.BackgroundImage")));
            this.invoiceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.invoiceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.invoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invoiceButton.Location = new System.Drawing.Point(29, 482);
            this.invoiceButton.Margin = new System.Windows.Forms.Padding(20);
            this.invoiceButton.MaximumSize = new System.Drawing.Size(120, 120);
            this.invoiceButton.MinimumSize = new System.Drawing.Size(120, 120);
            this.invoiceButton.Name = "invoiceButton";
            this.invoiceButton.Size = new System.Drawing.Size(120, 120);
            this.invoiceButton.TabIndex = 3;
            this.invoiceButton.Tag = "Invoice";
            this.invoiceButton.UseVisualStyleBackColor = false;
            this.invoiceButton.Click += new System.EventHandler(this.controlButton_Click);
            // 
            // rentButton
            // 
            this.rentButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rentButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rentButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rentButton.BackgroundImage")));
            this.rentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentButton.Location = new System.Drawing.Point(29, 328);
            this.rentButton.Margin = new System.Windows.Forms.Padding(20);
            this.rentButton.MaximumSize = new System.Drawing.Size(120, 120);
            this.rentButton.MinimumSize = new System.Drawing.Size(120, 120);
            this.rentButton.Name = "rentButton";
            this.rentButton.Size = new System.Drawing.Size(120, 120);
            this.rentButton.TabIndex = 2;
            this.rentButton.Tag = "Rent";
            this.rentButton.UseVisualStyleBackColor = false;
            this.rentButton.Click += new System.EventHandler(this.controlButton_Click);
            // 
            // customerButton
            // 
            this.customerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customerButton.BackgroundImage")));
            this.customerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.customerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerButton.Location = new System.Drawing.Point(29, 174);
            this.customerButton.Margin = new System.Windows.Forms.Padding(20);
            this.customerButton.MaximumSize = new System.Drawing.Size(120, 120);
            this.customerButton.MinimumSize = new System.Drawing.Size(120, 120);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(120, 120);
            this.customerButton.TabIndex = 1;
            this.customerButton.Tag = "Customer";
            this.customerButton.UseVisualStyleBackColor = false;
            this.customerButton.Click += new System.EventHandler(this.controlButton_Click);
            // 
            // carButton
            // 
            this.carButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.carButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.carButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("carButton.BackgroundImage")));
            this.carButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.carButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carButton.Location = new System.Drawing.Point(29, 20);
            this.carButton.Margin = new System.Windows.Forms.Padding(20);
            this.carButton.MaximumSize = new System.Drawing.Size(120, 120);
            this.carButton.MinimumSize = new System.Drawing.Size(120, 120);
            this.carButton.Name = "carButton";
            this.carButton.Size = new System.Drawing.Size(120, 120);
            this.carButton.TabIndex = 0;
            this.carButton.Tag = "Car";
            this.carButton.UseVisualStyleBackColor = false;
            this.carButton.Click += new System.EventHandler(this.controlButton_Click);
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 36);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.controlsPanel);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.workspacePanel);
            this.mainContainer.Size = new System.Drawing.Size(1169, 618);
            this.mainContainer.SplitterDistance = 179;
            this.mainContainer.TabIndex = 0;
            // 
            // workspacePanel
            // 
            this.workspacePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workspacePanel.Location = new System.Drawing.Point(0, 0);
            this.workspacePanel.Name = "workspacePanel";
            this.workspacePanel.Size = new System.Drawing.Size(986, 618);
            this.workspacePanel.TabIndex = 0;
            // 
            // FormRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1169, 654);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormRental";
            this.Text = "Car Rental";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRental_FormClosing);
            this.Load += new System.EventHandler(this.Rental_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.controlsPanel.ResumeLayout(false);
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel controlsPanel;
        private System.Windows.Forms.Button invoiceButton;
        private System.Windows.Forms.Button rentButton;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button carButton;
        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.Panel workspacePanel;
    }
}

