namespace SQLProcessorUI
{
    partial class MenuForm
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
            this.bulkExecutionButton = new System.Windows.Forms.Button();
            this.sqlInsertGeneratorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bulkExecutionButton
            // 
            this.bulkExecutionButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bulkExecutionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.bulkExecutionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.bulkExecutionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bulkExecutionButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bulkExecutionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.bulkExecutionButton.Location = new System.Drawing.Point(37, 48);
            this.bulkExecutionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bulkExecutionButton.Name = "bulkExecutionButton";
            this.bulkExecutionButton.Size = new System.Drawing.Size(172, 117);
            this.bulkExecutionButton.TabIndex = 18;
            this.bulkExecutionButton.Text = "Bulk SQL Execution";
            this.bulkExecutionButton.UseVisualStyleBackColor = true;
            this.bulkExecutionButton.Click += new System.EventHandler(this.bulkExecutionButton_Click);
            // 
            // sqlInsertGeneratorButton
            // 
            this.sqlInsertGeneratorButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.sqlInsertGeneratorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.sqlInsertGeneratorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.sqlInsertGeneratorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqlInsertGeneratorButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlInsertGeneratorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.sqlInsertGeneratorButton.Location = new System.Drawing.Point(243, 48);
            this.sqlInsertGeneratorButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sqlInsertGeneratorButton.Name = "sqlInsertGeneratorButton";
            this.sqlInsertGeneratorButton.Size = new System.Drawing.Size(172, 117);
            this.sqlInsertGeneratorButton.TabIndex = 19;
            this.sqlInsertGeneratorButton.Text = "SQL Insert Generator";
            this.sqlInsertGeneratorButton.UseVisualStyleBackColor = true;
            this.sqlInsertGeneratorButton.Click += new System.EventHandler(this.sqlInsertGeneratorButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(471, 206);
            this.Controls.Add(this.sqlInsertGeneratorButton);
            this.Controls.Add(this.bulkExecutionButton);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "MenuForm";
            this.Text = "SQL Processor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bulkExecutionButton;
        private System.Windows.Forms.Button sqlInsertGeneratorButton;
    }
}