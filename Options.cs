using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisabledComputerFixAndReport {
    public partial class Options : Form {
        public Options() {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e) {

            //Load options into the textboxes
            globalPrefixTextBox.Text = Properties.Settings.Default.globalWildcard;

        }

        private void saveButton_Click(object sender, EventArgs e) {

            //Set the Global Prefix/Wildcard to what's been changed & save the changes
            Properties.Settings.Default.globalWildcard = globalPrefixTextBox.Text;
            Properties.Settings.Default.Save();

            //Close out the form
            this.Close();

        }
    }
}
