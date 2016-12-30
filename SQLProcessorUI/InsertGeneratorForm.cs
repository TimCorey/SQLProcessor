using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLProcessorUI
{
    public partial class InsertGeneratorForm : Form
    {
        List<string> connectionStrings = new List<string>();
        BindingSource connectionStringsBinding = new BindingSource();

        public InsertGeneratorForm()
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
            resultsText.Text = $"First line of text { Environment.NewLine }";
            int position = resultsText.TextLength;
            string errorMessage = "Error: did not work!";
            resultsText.Text += errorMessage + Environment.NewLine;

            resultsText.SelectionStart = position;
            resultsText.SelectionLength = errorMessage.Length;
            resultsText.SelectionColor = Color.Red;
        }
    }
}
