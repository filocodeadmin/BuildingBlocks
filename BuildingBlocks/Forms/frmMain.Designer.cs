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
            this.cmdCommands = new System.Windows.Forms.GroupBox();
            this.cmdGetCustomer = new System.Windows.Forms.Button();
            this.cmdUpdateCustomer = new System.Windows.Forms.Button();
            this.cmdCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOutput
            // 
            this.grpOutput.Location = new System.Drawing.Point(18, 15);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(386, 280);
            this.grpOutput.TabIndex = 1;
            this.grpOutput.TabStop = false;
            // 
            // cmdCommands
            // 
            this.cmdCommands.Controls.Add(this.cmdUpdateCustomer);
            this.cmdCommands.Controls.Add(this.cmdGetCustomer);
            this.cmdCommands.Location = new System.Drawing.Point(410, 15);
            this.cmdCommands.Name = "cmdCommands";
            this.cmdCommands.Size = new System.Drawing.Size(97, 83);
            this.cmdCommands.TabIndex = 4;
            this.cmdCommands.TabStop = false;
            // 
            // cmdGetCustomer
            // 
            this.cmdGetCustomer.Location = new System.Drawing.Point(8, 15);
            this.cmdGetCustomer.Name = "cmdGetCustomer";
            this.cmdGetCustomer.Size = new System.Drawing.Size(80, 27);
            this.cmdGetCustomer.TabIndex = 1;
            this.cmdGetCustomer.Text = "&Get";
            this.cmdGetCustomer.UseVisualStyleBackColor = true;
            this.cmdGetCustomer.Click += new System.EventHandler(this.cmdGetCustomer_Click);
            // 
            // cmdUpdateCustomer
            // 
            this.cmdUpdateCustomer.Location = new System.Drawing.Point(8, 48);
            this.cmdUpdateCustomer.Name = "cmdUpdateCustomer";
            this.cmdUpdateCustomer.Size = new System.Drawing.Size(80, 27);
            this.cmdUpdateCustomer.TabIndex = 5;
            this.cmdUpdateCustomer.Text = "&Update";
            this.cmdUpdateCustomer.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 311);
            this.Controls.Add(this.cmdCommands);
            this.Controls.Add(this.grpOutput);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.cmdCommands.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox grpOutput;
        private GroupBox cmdCommands;
        private Button cmdGetCustomer;
        private Button cmdUpdateCustomer;
    }
}