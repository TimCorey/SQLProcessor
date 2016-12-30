using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLProcessorUI
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void bulkExecutionButton_Click(object sender, EventArgs e)
        {
            BulkExecutionForm frm = new BulkExecutionForm();
            frm.Show();
        }

        private void sqlInsertGeneratorButton_Click(object sender, EventArgs e)
        {
            SqlGeneratorForm frm = new SqlGeneratorForm();
            frm.Show();
        }
    }
}
