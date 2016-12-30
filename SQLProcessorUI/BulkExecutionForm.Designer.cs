namespace SQLProcessorUI
{
    partial class BulkExecutionForm
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
            this.resultsText = new System.Windows.Forms.RichTextBox();
            this.databaseConnectionDropDown = new System.Windows.Forms.ComboBox();
            this.selectFolderPath = new System.Windows.Forms.Button();
            this.folderPathText = new System.Windows.Forms.TextBox();
            this.folderPathLabel = new System.Windows.Forms.Label();
            this.includeSubdirectoriesCheckbox = new System.Windows.Forms.CheckBox();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.processFolderButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultsText
            // 
            this.resultsText.Location = new System.Drawing.Point(31, 387);
            this.resultsText.Name = "resultsText";
            this.resultsText.Size = new System.Drawing.Size(506, 314);
            this.resultsText.TabIndex = 21;
            this.resultsText.Text = "";
            // 
            // databaseConnectionDropDown
            // 
            this.databaseConnectionDropDown.FormattingEnabled = true;
            this.databaseConnectionDropDown.Location = new System.Drawing.Point(181, 102);
            this.databaseConnectionDropDown.Name = "databaseConnectionDropDown";
            this.databaseConnectionDropDown.Size = new System.Drawing.Size(354, 38);
            this.databaseConnectionDropDown.TabIndex = 20;
            // 
            // selectFolderPath
            // 
            this.selectFolderPath.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.selectFolderPath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.selectFolderPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.selectFolderPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFolderPath.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFolderPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.selectFolderPath.Location = new System.Drawing.Point(490, 166);
            this.selectFolderPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectFolderPath.Name = "selectFolderPath";
            this.selectFolderPath.Size = new System.Drawing.Size(47, 35);
            this.selectFolderPath.TabIndex = 19;
            this.selectFolderPath.Text = "...";
            this.selectFolderPath.UseVisualStyleBackColor = true;
            this.selectFolderPath.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // folderPathText
            // 
            this.folderPathText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderPathText.Location = new System.Drawing.Point(181, 166);
            this.folderPathText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.folderPathText.Name = "folderPathText";
            this.folderPathText.Size = new System.Drawing.Size(303, 35);
            this.folderPathText.TabIndex = 15;
            // 
            // folderPathLabel
            // 
            this.folderPathLabel.AutoSize = true;
            this.folderPathLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderPathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.folderPathLabel.Location = new System.Drawing.Point(24, 164);
            this.folderPathLabel.Name = "folderPathLabel";
            this.folderPathLabel.Size = new System.Drawing.Size(151, 37);
            this.folderPathLabel.TabIndex = 18;
            this.folderPathLabel.Text = "Folder Path";
            // 
            // includeSubdirectoriesCheckbox
            // 
            this.includeSubdirectoriesCheckbox.AutoSize = true;
            this.includeSubdirectoriesCheckbox.Checked = true;
            this.includeSubdirectoriesCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeSubdirectoriesCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.includeSubdirectoriesCheckbox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.includeSubdirectoriesCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.includeSubdirectoriesCheckbox.Location = new System.Drawing.Point(181, 223);
            this.includeSubdirectoriesCheckbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.includeSubdirectoriesCheckbox.Name = "includeSubdirectoriesCheckbox";
            this.includeSubdirectoriesCheckbox.Size = new System.Drawing.Size(252, 41);
            this.includeSubdirectoriesCheckbox.TabIndex = 13;
            this.includeSubdirectoriesCheckbox.Text = "Include Subfolders";
            this.includeSubdirectoriesCheckbox.UseVisualStyleBackColor = true;
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.resultsLabel.Location = new System.Drawing.Point(28, 347);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(99, 37);
            this.resultsLabel.TabIndex = 16;
            this.resultsLabel.Text = "Results";
            // 
            // databaseLabel
            // 
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.databaseLabel.Location = new System.Drawing.Point(39, 100);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(136, 40);
            this.databaseLabel.TabIndex = 14;
            this.databaseLabel.Text = "Database";
            // 
            // processFolderButton
            // 
            this.processFolderButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.processFolderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.processFolderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.processFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processFolderButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processFolderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.processFolderButton.Location = new System.Drawing.Point(209, 272);
            this.processFolderButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.processFolderButton.Name = "processFolderButton";
            this.processFolderButton.Size = new System.Drawing.Size(165, 52);
            this.processFolderButton.TabIndex = 17;
            this.processFolderButton.Text = "Process";
            this.processFolderButton.UseVisualStyleBackColor = true;
            this.processFolderButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(26, 17);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(319, 50);
            this.headerLabel.TabIndex = 12;
            this.headerLabel.Text = "SQL Bulk Execution";
            // 
            // BulkExecutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(566, 731);
            this.Controls.Add(this.resultsText);
            this.Controls.Add(this.databaseConnectionDropDown);
            this.Controls.Add(this.selectFolderPath);
            this.Controls.Add(this.folderPathText);
            this.Controls.Add(this.folderPathLabel);
            this.Controls.Add(this.includeSubdirectoriesCheckbox);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.databaseLabel);
            this.Controls.Add(this.processFolderButton);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "BulkExecutionForm";
            this.Text = "BulkExecutionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox resultsText;
        private System.Windows.Forms.ComboBox databaseConnectionDropDown;
        private System.Windows.Forms.Button selectFolderPath;
        private System.Windows.Forms.TextBox folderPathText;
        private System.Windows.Forms.Label folderPathLabel;
        private System.Windows.Forms.CheckBox includeSubdirectoriesCheckbox;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label databaseLabel;
        private System.Windows.Forms.Button processFolderButton;
        private System.Windows.Forms.Label headerLabel;
    }
}