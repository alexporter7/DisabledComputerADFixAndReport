using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ActiveDirectory.Management.Commands;

namespace DisabledComputerFixAndReport {
    public partial class Form1 : Form {

        static ArrayList propertiesToSearch = new ArrayList();

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {


        }

        private void runScanButton_Click(object sender, EventArgs e) {

            //Init the array of properties that need to be collected
            if(propertiesToSearchRichTextbox.Text.Equals("")) {
                foreach(string property in DisabledComputerFixAndReport.Properties.Settings.Default.defaultSearchProperties) {
                    propertiesToSearch.Add(property);
                }
            }
            else {
                foreach(string property in propertiesToSearch) {

                }
            }

            //Setup the array list for the results
            List<List<string>> results = new List<List<string>>();

            //Reach out to the ADMethods class to return into Array List
            results = CommonMethods.getADComputer(propertiesToSearch);

            //Populate the List View
            CommonMethods.populateListView(outputListView, propertiesToSearch, results);

        }

        private void addToListButton_Click(object sender, EventArgs e) {

            //Add the property to the display box & array
            string propertyToAppend = propertyTextbox.Text;
            propertiesToSearchRichTextbox.AppendText(propertyToAppend + "\n");
            propertiesToSearch.Add(propertyToAppend);

            //Clear the textbox
            propertyTextbox.Text = "";

        }

        private void clearAllButton_Click(object sender, EventArgs e) {

            //Clear all textboxs/rich textboxes/list views/arrays
            propertyTextbox.Text = "";
            propertiesToSearchRichTextbox.Text = "";
            propertiesToSearch.Clear();
            outputListView.Clear();

        }

        private void settingsButton_Click(object sender, EventArgs e) {

            Options options = new Options();
            options.ShowDialog();

        }

        private void propertyTextbox_KeyDown(object sender, KeyEventArgs e) {

            //Check if Enter Key is pressed
            if(e.KeyCode == Keys.Enter) {
                //Add the property to the display box & array
                string propertyToAppend = propertyTextbox.Text;
                propertiesToSearchRichTextbox.AppendText(propertyToAppend + "\n");
                propertiesToSearch.Add(propertyToAppend);

                //Clear the textbox
                propertyTextbox.Text = "";
            }

        }
    }
}
