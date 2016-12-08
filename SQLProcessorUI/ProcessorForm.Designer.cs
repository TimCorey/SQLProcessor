namespace SQLProcessorUI
{
    partial class ProcessorForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.sqlStatementText = new System.Windows.Forms.TextBox();
            this.createSQLStatementButton = new System.Windows.Forms.Button();
            this.sqlStatementLabel = new System.Windows.Forms.Label();
            this.tableNameText = new System.Windows.Forms.TextBox();
            this.tableNameLabel = new System.Windows.Forms.Label();
            this.turnOnIdentityCheckbox = new System.Windows.Forms.CheckBox();
            this.turnOnIdentityLabel = new System.Windows.Forms.Label();
            this.outputPathLabel = new System.Windows.Forms.Label();
            this.outputPathText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(22, 31);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(234, 37);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "SQL Processor";
            // 
            // sqlStatementText
            // 
            this.sqlStatementText.Location = new System.Drawing.Point(29, 125);
            this.sqlStatementText.Multiline = true;
            this.sqlStatementText.Name = "sqlStatementText";
            this.sqlStatementText.Size = new System.Drawing.Size(461, 218);
            this.sqlStatementText.TabIndex = 1;
            // 
            // createSQLStatementButton
            // 
            this.createSQLStatementButton.Location = new System.Drawing.Point(163, 498);
            this.createSQLStatementButton.Name = "createSQLStatementButton";
            this.createSQLStatementButton.Size = new System.Drawing.Size(185, 70);
            this.createSQLStatementButton.TabIndex = 5;
            this.createSQLStatementButton.Text = "Create Statement";
            this.createSQLStatementButton.UseVisualStyleBackColor = true;
            this.createSQLStatementButton.Click += new System.EventHandler(this.createSQLStatementButton_Click);
            // 
            // sqlStatementLabel
            // 
            this.sqlStatementLabel.AutoSize = true;
            this.sqlStatementLabel.Location = new System.Drawing.Point(25, 98);
            this.sqlStatementLabel.Name = "sqlStatementLabel";
            this.sqlStatementLabel.Size = new System.Drawing.Size(135, 24);
            this.sqlStatementLabel.TabIndex = 3;
            this.sqlStatementLabel.Text = "SQL Statement";
            // 
            // tableNameText
            // 
            this.tableNameText.Location = new System.Drawing.Point(163, 363);
            this.tableNameText.Name = "tableNameText";
            this.tableNameText.Size = new System.Drawing.Size(327, 29);
            this.tableNameText.TabIndex = 2;
            // 
            // tableNameLabel
            // 
            this.tableNameLabel.AutoSize = true;
            this.tableNameLabel.Location = new System.Drawing.Point(25, 366);
            this.tableNameLabel.Name = "tableNameLabel";
            this.tableNameLabel.Size = new System.Drawing.Size(114, 24);
            this.tableNameLabel.TabIndex = 5;
            this.tableNameLabel.Text = "Table Name";
            // 
            // turnOnIdentityCheckbox
            // 
            this.turnOnIdentityCheckbox.AutoSize = true;
            this.turnOnIdentityCheckbox.Checked = true;
            this.turnOnIdentityCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.turnOnIdentityCheckbox.Location = new System.Drawing.Point(163, 413);
            this.turnOnIdentityCheckbox.Name = "turnOnIdentityCheckbox";
            this.turnOnIdentityCheckbox.Size = new System.Drawing.Size(15, 14);
            this.turnOnIdentityCheckbox.TabIndex = 3;
            this.turnOnIdentityCheckbox.UseVisualStyleBackColor = true;
            // 
            // turnOnIdentityLabel
            // 
            this.turnOnIdentityLabel.AutoSize = true;
            this.turnOnIdentityLabel.Location = new System.Drawing.Point(25, 407);
            this.turnOnIdentityLabel.Name = "turnOnIdentityLabel";
            this.turnOnIdentityLabel.Size = new System.Drawing.Size(118, 24);
            this.turnOnIdentityLabel.TabIndex = 7;
            this.turnOnIdentityLabel.Text = "Identity Insert";
            // 
            // outputPathLabel
            // 
            this.outputPathLabel.AutoSize = true;
            this.outputPathLabel.Location = new System.Drawing.Point(25, 448);
            this.outputPathLabel.Name = "outputPathLabel";
            this.outputPathLabel.Size = new System.Drawing.Size(102, 24);
            this.outputPathLabel.TabIndex = 8;
            this.outputPathLabel.Text = "Output File";
            // 
            // outputPathText
            // 
            this.outputPathText.Location = new System.Drawing.Point(163, 445);
            this.outputPathText.Name = "outputPathText";
            this.outputPathText.Size = new System.Drawing.Size(327, 29);
            this.outputPathText.TabIndex = 4;
            // 
            // ProcessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 611);
            this.Controls.Add(this.outputPathText);
            this.Controls.Add(this.outputPathLabel);
            this.Controls.Add(this.turnOnIdentityLabel);
            this.Controls.Add(this.turnOnIdentityCheckbox);
            this.Controls.Add(this.tableNameLabel);
            this.Controls.Add(this.tableNameText);
            this.Controls.Add(this.sqlStatementLabel);
            this.Controls.Add(this.createSQLStatementButton);
            this.Controls.Add(this.sqlStatementText);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ProcessorForm";
            this.Text = "SQL Processor by Tim Corey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox sqlStatementText;
        private System.Windows.Forms.Button createSQLStatementButton;
        private System.Windows.Forms.Label sqlStatementLabel;
        private System.Windows.Forms.TextBox tableNameText;
        private System.Windows.Forms.Label tableNameLabel;
        private System.Windows.Forms.CheckBox turnOnIdentityCheckbox;
        private System.Windows.Forms.Label turnOnIdentityLabel;
        private System.Windows.Forms.Label outputPathLabel;
        private System.Windows.Forms.TextBox outputPathText;
    }
}

