namespace SQLProcessorUI
{
    partial class InsertGeneratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertGeneratorForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.processButton = new System.Windows.Forms.Button();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.includeSubfoldersCheckbox = new System.Windows.Forms.CheckBox();
            this.folderPathLabel = new System.Windows.Forms.Label();
            this.folderPathText = new System.Windows.Forms.TextBox();
            this.selectFolder = new System.Windows.Forms.Button();
            this.databaseConnectionDropDown = new System.Windows.Forms.ComboBox();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.resultsText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(12, 29);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(289, 50);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "SQL Bulk Execute";
            // 
            // processButton
            // 
            this.processButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.processButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.processButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.processButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.processButton.Location = new System.Drawing.Point(194, 290);
            this.processButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(167, 57);
            this.processButton.TabIndex = 5;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // databaseLabel
            // 
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.databaseLabel.Location = new System.Drawing.Point(26, 106);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(136, 40);
            this.databaseLabel.TabIndex = 3;
            this.databaseLabel.Text = "Database";
            // 
            // includeSubfoldersCheckbox
            // 
            this.includeSubfoldersCheckbox.AutoSize = true;
            this.includeSubfoldersCheckbox.Checked = true;
            this.includeSubfoldersCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeSubfoldersCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.includeSubfoldersCheckbox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.includeSubfoldersCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.includeSubfoldersCheckbox.Location = new System.Drawing.Point(168, 231);
            this.includeSubfoldersCheckbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.includeSubfoldersCheckbox.Name = "includeSubfoldersCheckbox";
            this.includeSubfoldersCheckbox.Size = new System.Drawing.Size(252, 41);
            this.includeSubfoldersCheckbox.TabIndex = 3;
            this.includeSubfoldersCheckbox.Text = "Include Subfolders";
            this.includeSubfoldersCheckbox.UseVisualStyleBackColor = true;
            // 
            // folderPathLabel
            // 
            this.folderPathLabel.AutoSize = true;
            this.folderPathLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderPathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.folderPathLabel.Location = new System.Drawing.Point(70, 169);
            this.folderPathLabel.Name = "folderPathLabel";
            this.folderPathLabel.Size = new System.Drawing.Size(92, 37);
            this.folderPathLabel.TabIndex = 8;
            this.folderPathLabel.Text = "Folder";
            // 
            // folderPathText
            // 
            this.folderPathText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderPathText.Location = new System.Drawing.Point(168, 171);
            this.folderPathText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.folderPathText.Name = "folderPathText";
            this.folderPathText.Size = new System.Drawing.Size(303, 35);
            this.folderPathText.TabIndex = 4;
            // 
            // selectFolder
            // 
            this.selectFolder.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.selectFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.selectFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.selectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.selectFolder.Location = new System.Drawing.Point(477, 171);
            this.selectFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(47, 35);
            this.selectFolder.TabIndex = 9;
            this.selectFolder.Text = "...";
            this.selectFolder.UseVisualStyleBackColor = true;
            this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // databaseConnectionDropDown
            // 
            this.databaseConnectionDropDown.FormattingEnabled = true;
            this.databaseConnectionDropDown.Location = new System.Drawing.Point(168, 108);
            this.databaseConnectionDropDown.Name = "databaseConnectionDropDown";
            this.databaseConnectionDropDown.Size = new System.Drawing.Size(303, 38);
            this.databaseConnectionDropDown.TabIndex = 10;
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.resultsLabel.Location = new System.Drawing.Point(26, 373);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(105, 40);
            this.resultsLabel.TabIndex = 11;
            this.resultsLabel.Text = "Results";
            // 
            // resultsText
            // 
            this.resultsText.Location = new System.Drawing.Point(33, 416);
            this.resultsText.Name = "resultsText";
            this.resultsText.Size = new System.Drawing.Size(491, 297);
            this.resultsText.TabIndex = 12;
            this.resultsText.Text = "";
            // 
            // InsertGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 764);
            this.Controls.Add(this.resultsText);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.databaseConnectionDropDown);
            this.Controls.Add(this.selectFolder);
            this.Controls.Add(this.folderPathText);
            this.Controls.Add(this.folderPathLabel);
            this.Controls.Add(this.includeSubfoldersCheckbox);
            this.Controls.Add(this.databaseLabel);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "InsertGeneratorForm";
            this.Text = "SQL Processor by Tim Corey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Label databaseLabel;
        private System.Windows.Forms.CheckBox includeSubfoldersCheckbox;
        private System.Windows.Forms.Label folderPathLabel;
        private System.Windows.Forms.TextBox folderPathText;
        private System.Windows.Forms.Button selectFolder;
        private System.Windows.Forms.ComboBox databaseConnectionDropDown;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.RichTextBox resultsText;
    }
}

