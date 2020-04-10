using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMR_System
{
    public partial class BugReport : Form
    {
        public BugReport()
        {
            InitializeComponent();
        }

        private void ButtonSubmitBug_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BugReport_Load(object sender, EventArgs e)
        {
            comboBoxBugFrequency.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBugSeverity.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
