namespace SQLProcessorUI
{
    partial class BulkExecuteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BulkExecuteForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.sqlStatementText = new System.Windows.Forms.TextBox();
            this.createSQLStatementButton = new System.Windows.Forms.Button();
            this.sqlStatementLabel = new System.Windows.Forms.Label();
            this.tableNameText = new System.Windows.Forms.TextBox();
            this.tableNameLabel = new System.Windows.Forms.Label();
            this.turnOnIdentityCheckbox = new System.Windows.Forms.CheckBox();
            this.outputPathLabel = new System.Windows.Forms.Label();
            this.outputPathText = new System.Windows.Forms.TextBox();
            this.selectOutputFile = new System.Windows.Forms.Button();
            this.databaseConnectionDropDown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(12, 29);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(243, 50);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "SQL Processor";
            // 
            // sqlStatementText
            // 
            this.sqlStatementText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlStatementText.Location = new System.Drawing.Point(33, 156);
            this.sqlStatementText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sqlStatementText.Multiline = true;
            this.sqlStatementText.Name = "sqlStatementText";
            this.sqlStatementText.Size = new System.Drawing.Size(541, 272);
            this.sqlStatementText.TabIndex = 1;
            // 
            // createSQLStatementButton
            // 
            this.createSQLStatementButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createSQLStatementButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createSQLStatementButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createSQLStatementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createSQLStatementButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSQLStatementButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createSQLStatementButton.Location = new System.Drawing.Point(206, 624);
            this.createSQLStatementButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createSQLStatementButton.Name = "createSQLStatementButton";
            this.createSQLStatementButton.Size = new System.Drawing.Size(202, 88);
            this.createSQLStatementButton.TabIndex = 5;
            this.createSQLStatementButton.Text = "Create Statement";
            this.createSQLStatementButton.UseVisualStyleBackColor = true;
            this.createSQLStatementButton.Click += new System.EventHandler(this.createSQLStatementButton_Click);
            // 
            // sqlStatementLabel
            // 
            this.sqlStatementLabel.AutoSize = true;
            this.sqlStatementLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlStatementLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.sqlStatementLabel.Location = new System.Drawing.Point(25, 112);
            this.sqlStatementLabel.Name = "sqlStatementLabel";
            this.sqlStatementLabel.Size = new System.Drawing.Size(206, 40);
            this.sqlStatementLabel.TabIndex = 3;
            this.sqlStatementLabel.Text = "SQL Statement";
            // 
            // tableNameText
            // 
            this.tableNameText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableNameText.Location = new System.Drawing.Point(218, 461);
            this.tableNameText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableNameText.Name = "tableNameText";
            this.tableNameText.Size = new System.Drawing.Size(356, 35);
            this.tableNameText.TabIndex = 2;
            // 
            // tableNameLabel
            // 
            this.tableNameLabel.AutoSize = true;
            this.tableNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tableNameLabel.Location = new System.Drawing.Point(55, 458);
            this.tableNameLabel.Name = "tableNameLabel";
            this.tableNameLabel.Size = new System.Drawing.Size(157, 37);
            this.tableNameLabel.TabIndex = 5;
            this.tableNameLabel.Text = "Table Name";
            // 
            // turnOnIdentityCheckbox
            // 
            this.turnOnIdentityCheckbox.AutoSize = true;
            this.turnOnIdentityCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.turnOnIdentityCheckbox.Checked = true;
            this.turnOnIdentityCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.turnOnIdentityCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.turnOnIdentityCheckbox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnOnIdentityCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.turnOnIdentityCheckbox.Location = new System.Drawing.Point(33, 506);
            this.turnOnIdentityCheckbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.turnOnIdentityCheckbox.Name = "turnOnIdentityCheckbox";
            this.turnOnIdentityCheckbox.Size = new System.Drawing.Size(195, 41);
            this.turnOnIdentityCheckbox.TabIndex = 3;
            this.turnOnIdentityCheckbox.Text = "Identity Insert";
            this.turnOnIdentityCheckbox.UseVisualStyleBackColor = true;
            // 
            // outputPathLabel
            // 
            this.outputPathLabel.AutoSize = true;
            this.outputPathLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputPathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.outputPathLabel.Location = new System.Drawing.Point(63, 558);
            this.outputPathLabel.Name = "outputPathLabel";
            this.outputPathLabel.Size = new System.Drawing.Size(149, 37);
            this.outputPathLabel.TabIndex = 8;
            this.outputPathLabel.Text = "Output File";
            // 
            // outputPathText
            // 
            this.outputPathText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputPathText.Location = new System.Drawing.Point(218, 562);
            this.outputPathText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.outputPathText.Name = "outputPathText";
            this.outputPathText.Size = new System.Drawing.Size(303, 35);
            this.outputPathText.TabIndex = 4;
            // 
            // selectOutputFile
            // 
            this.selectOutputFile.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.selectOutputFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.selectOutputFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.selectOutputFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectOutputFile.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectOutputFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.selectOutputFile.Location = new System.Drawing.Point(527, 562);
            this.selectOutputFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectOutputFile.Name = "selectOutputFile";
            this.selectOutputFile.Size = new System.Drawing.Size(47, 35);
            this.selectOutputFile.TabIndex = 9;
            this.selectOutputFile.Text = "...";
            this.selectOutputFile.UseVisualStyleBackColor = true;
            this.selectOutputFile.Click += new System.EventHandler(this.selectOutputFile_Click);
            // 
            // databaseConnectionDropDown
            // 
            this.databaseConnectionDropDown.FormattingEnabled = true;
            this.databaseConnectionDropDown.Location = new System.Drawing.Point(366, 111);
            this.databaseConnectionDropDown.Name = "databaseConnectionDropDown";
            this.databaseConnectionDropDown.Size = new System.Drawing.Size(208, 38);
            this.databaseConnectionDropDown.TabIndex = 10;
            // 
            // ProcessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 764);
            this.Controls.Add(this.databaseConnectionDropDown);
            this.Controls.Add(this.selectOutputFile);
            this.Controls.Add(this.outputPathText);
            this.Controls.Add(this.outputPathLabel);
            this.Controls.Add(this.turnOnIdentityCheckbox);
            this.Controls.Add(this.tableNameLabel);
            this.Controls.Add(this.tableNameText);
            this.Controls.Add(this.sqlStatementLabel);
            this.Controls.Add(this.createSQLStatementButton);
            this.Controls.Add(this.sqlStatementText);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
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
        private System.Windows.Forms.Label outputPathLabel;
        private System.Windows.Forms.TextBox outputPathText;
        private System.Windows.Forms.Button selectOutputFile;
        private System.Windows.Forms.ComboBox databaseConnectionDropDown;
    }
}

