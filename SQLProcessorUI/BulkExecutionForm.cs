using SQLProcessor.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLProcessorUI
{
    public partial class BulkExecutionForm : Form
    {
        List<string> connectionStrings = new List<string>();
        BindingSource connectionStringsBinding = new BindingSource();

        public BulkExecutionForm()
        {
            InitializeComponent();

            LoadConnectionStrings();

            InitializeBindings();
        }

        private void InitializeBindings()
        {
            connectionStringsBinding.DataSource = connectionStrings;
            databaseConnectionDropDown.DataSource = connectionStringsBinding;
        }

        private void LoadConnectionStrings()
        {
            ConnectionStringSettingsCollection connections = ConfigurationManager.ConnectionStrings;

            foreach (ConnectionStringSettings item in connections)
            {
                if (item.ElementInformation.IsPresent)
                {
                    connectionStrings.Add(item.Name);
                }
            }

            connectionStringsBinding.ResetBindings(false);
        }


        private void selectFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    folderPathText.Text = dialog.SelectedPath;
                }
            }
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            resultsText.Text = "";
            
            var results = FileCommands.ProcessFolder(folderPathText.Text, includeSubdirectoriesCheckbox.Checked);

            foreach (var result in results)
            {
                string output = "";
                string fileName = System.IO.Path.GetFileName(result.FileName);
                int startPosition = resultsText.TextLength;
                Color textColor = Color.Green;

                var errors = result.CommandResults.Where(x => x.StatusId == Enums.ResultStatus.Error);

                if (errors.Count() > 0)
                {
                    // There was an error somewhere
                    output = $"{ fileName }: Error{ Environment.NewLine }";

                    foreach (var err in errors)
                    {
                        output += $"{ err.StatusMessage }{ Environment.NewLine }";
                    }

                    textColor = Color.Red;
                }
                else
                {
                    // There were no errors
                    output = $"{ fileName }: Success{ Environment.NewLine }";

                    textColor = Color.Green;
                }

                // Adds a spacer line
                output += Environment.NewLine;

                // Color the text
                resultsText.SelectionColor = textColor;

                // Adds the text to the text box
                resultsText.AppendText(output);

            }
        }
    }
}
