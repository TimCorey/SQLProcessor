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
    public partial class BulkExecuteForm : Form
    {
        List<string> connectionStrings = new List<string>();
        BindingSource connectionStringsBinding = new BindingSource();

        public BulkExecuteForm()
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

        private void createSQLStatementButton_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings[databaseConnectionDropDown.SelectedItem.ToString()].ConnectionString;
            StringBuilder insertStatement = new StringBuilder();
            IDictionary<string, object> columns = new Dictionary<string, object>();

            if (turnOnIdentityCheckbox.Checked)
            {
                insertStatement.Append($"set identity_insert { tableNameText.Text } on;{ Environment.NewLine }");
            }

            // Starts off the insert statement
            insertStatement.Append($"insert into { tableNameText.Text } (");

            using (IDbConnection cnn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                IEnumerable<dynamic> rows;

                try
                {
                    rows = cnn.Query<dynamic>(sqlStatementText.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"There was an error accessing your data: { ex.Message }", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (rows.Count() > 0)
                {
                    columns = (IDictionary<string,object>)rows.First();

                    int i = 0;

                    foreach (var item in columns)
                    {
                        if (i > 0)
                        {
                            insertStatement.Append(", ");
                        }

                        insertStatement.Append(item.Key);

                        i += 1;
                    }

                    if (i == 0)
                    {
                        throw new DataException("No valid columns");
                    }

                    insertStatement.Append($"){ Environment.NewLine }values ");
                }

                int rowCount = 0;

                // Inserts the actual data
                foreach (var row in rows)
                {
                    var rowVal = (IDictionary<string, object>)row;
                    int i = 0;

                    if (rowCount > 0)
                    {
                        insertStatement.Append(",");
                    }

                    foreach (var item in columns)
                    {
                        if (i == 0)
                        {
                            insertStatement.Append($"{ Environment.NewLine }(");
                        }
                        else
                        {
                            insertStatement.Append(", ");
                        }

                        insertStatement.Append($"'{ rowVal[item.Key].NullSafeString().Replace("'", "''") }'");

                        i += 1;
                    }

                    insertStatement.Append($")");

                    rowCount += 1;
                }
            }

            insertStatement.Append($";{ Environment.NewLine }");

            if (turnOnIdentityCheckbox.Checked)
            {
                insertStatement.Append($"set identity_insert { tableNameText.Text } off;{ Environment.NewLine }");
            }

            File.WriteAllText(outputPathText.Text, insertStatement.ToString());

            MessageBox.Show("Complete");
        }

        private void selectOutputFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "sql files (*.sql)|*.sql";
                dialog.FilterIndex = 0;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    outputPathText.Text = dialog.FileName;
                }
            }
        }
    }
}
