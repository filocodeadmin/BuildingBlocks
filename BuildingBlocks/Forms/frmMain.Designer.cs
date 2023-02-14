namespace BuildingBlocks {
    partial class frmMain {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.lstvwCustomerList = new System.Windows.Forms.ListView();
            this.clmnRowUID = new System.Windows.Forms.ColumnHeader();
            this.clmnFirstName = new System.Windows.Forms.ColumnHeader();
            this.clmnLastName = new System.Windows.Forms.ColumnHeader();
            this.clmnUpdatedBy = new System.Windows.Forms.ColumnHeader();
            this.clmnUpdatedStamp = new System.Windows.Forms.ColumnHeader();
            this.cmdCommands = new System.Windows.Forms.GroupBox();
            this.cmdDeleteCustomer = new System.Windows.Forms.Button();
            this.cmdUpdateCustomer = new System.Windows.Forms.Button();
            this.cmdGetCustomer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.grpOutput.SuspendLayout();
            this.cmdCommands.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.lstvwCustomerList);
            this.grpOutput.Location = new System.Drawing.Point(18, 135);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Padding = new System.Windows.Forms.Padding(12, 6, 12, 12);
            this.grpOutput.Size = new System.Drawing.Size(489, 311);
            this.grpOutput.TabIndex = 2;
            this.grpOutput.TabStop = false;
            // 
            // lstvwCustomerList
            // 
            this.lstvwCustomerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnRowUID,
            this.clmnFirstName,
            this.clmnLastName,
            this.clmnUpdatedBy,
            this.clmnUpdatedStamp});
            this.lstvwCustomerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvwCustomerList.FullRowSelect = true;
            this.lstvwCustomerList.GridLines = true;
            this.lstvwCustomerList.Location = new System.Drawing.Point(12, 22);
            this.lstvwCustomerList.MultiSelect = false;
            this.lstvwCustomerList.Name = "lstvwCustomerList";
            this.lstvwCustomerList.Size = new System.Drawing.Size(465, 277);
            this.lstvwCustomerList.TabIndex = 0;
            this.lstvwCustomerList.UseCompatibleStateImageBehavior = false;
            this.lstvwCustomerList.View = System.Windows.Forms.View.Details;
            // 
            // clmnRowUID
            // 
            this.clmnRowUID.Text = "";
            this.clmnRowUID.Width = 0;
            // 
            // clmnFirstName
            // 
            this.clmnFirstName.Text = "First Name";
            this.clmnFirstName.Width = 100;
            // 
            // clmnLastName
            // 
            this.clmnLastName.Text = "Last Name";
            this.clmnLastName.Width = 100;
            // 
            // clmnUpdatedBy
            // 
            this.clmnUpdatedBy.Text = "Updated By";
            this.clmnUpdatedBy.Width = 100;
            // 
            // clmnUpdatedStamp
            // 
            this.clmnUpdatedStamp.Text = "Updated Stamp";
            this.clmnUpdatedStamp.Width = 120;
            // 
            // cmdCommands
            // 
            this.cmdCommands.Controls.Add(this.cmdDeleteCustomer);
            this.cmdCommands.Controls.Add(this.cmdUpdateCustomer);
            this.cmdCommands.Controls.Add(this.cmdGetCustomer);
            this.cmdCommands.Location = new System.Drawing.Point(410, 15);
            this.cmdCommands.Name = "cmdCommands";
            this.cmdCommands.Size = new System.Drawing.Size(97, 114);
            this.cmdCommands.TabIndex = 1;
            this.cmdCommands.TabStop = false;
            // 
            // cmdDeleteCustomer
            // 
            this.cmdDeleteCustomer.Location = new System.Drawing.Point(8, 78);
            this.cmdDeleteCustomer.Name = "cmdDeleteCustomer";
            this.cmdDeleteCustomer.Size = new System.Drawing.Size(80, 27);
            this.cmdDeleteCustomer.TabIndex = 2;
            this.cmdDeleteCustomer.Text = "&Delete";
            this.cmdDeleteCustomer.UseVisualStyleBackColor = true;
            this.cmdDeleteCustomer.Click += new System.EventHandler(this.cmdDeleteCustomer_Click);
            // 
            // cmdUpdateCustomer
            // 
            this.cmdUpdateCustomer.Location = new System.Drawing.Point(8, 47);
            this.cmdUpdateCustomer.Name = "cmdUpdateCustomer";
            this.cmdUpdateCustomer.Size = new System.Drawing.Size(80, 27);
            this.cmdUpdateCustomer.TabIndex = 1;
            this.cmdUpdateCustomer.Text = "&Update";
            this.cmdUpdateCustomer.UseVisualStyleBackColor = true;
            this.cmdUpdateCustomer.Click += new System.EventHandler(this.cmdUpdateCustomer_Click);
            // 
            // cmdGetCustomer
            // 
            this.cmdGetCustomer.Location = new System.Drawing.Point(8, 15);
            this.cmdGetCustomer.Name = "cmdGetCustomer";
            this.cmdGetCustomer.Size = new System.Drawing.Size(80, 27);
            this.cmdGetCustomer.TabIndex = 0;
            this.cmdGetCustomer.Text = "&Get";
            this.cmdGetCustomer.UseVisualStyleBackColor = true;
            this.cmdGetCustomer.Click += new System.EventHandler(this.cmdGetCustomer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Location = new System.Drawing.Point(18, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(24, 54);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(66, 15);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(24, 22);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(67, 15);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(132, 48);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(155, 23);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(132, 19);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(155, 23);
            this.txtFirstName.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdCommands);
            this.Controls.Add(this.grpOutput);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpOutput.ResumeLayout(false);
            this.cmdCommands.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox grpOutput;
        private GroupBox cmdCommands;
        private Button cmdGetCustomer;
        private Button cmdUpdateCustomer;
        private ListView lstvwCustomerList;
        private GroupBox groupBox1;
        private Label lblLastName;
        private Label lblFirstName;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private ColumnHeader clmnRowUID;
        private ColumnHeader clmnFirstName;
        private ColumnHeader clmnLastName;
        private ColumnHeader clmnUpdatedBy;
        private ColumnHeader clmnUpdatedStamp;
        private Button cmdDeleteCustomer;
    }
}