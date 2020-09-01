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

            //Setup properties to be displayed
            string[] propertiesToDisplay = { "cn" };

            //Setup the array list for the results
            ArrayList results = new ArrayList();

            //Reach out to the ADMethods class to return into Array List
            results = ADMethods.getADComputer(propertiesToSearch);

            //To display results, iterate through each dict in the array list and
            //display the results located in propertiesToDisplay
            foreach(IDictionary result in results) {

                string resultString = "";
                foreach(string property in propertiesToDisplay) {
                    resultString += $"{property}: {result[property].ToString()} | ";
                }
                outputRichTextBox.AppendText(resultString + "\n");
                resultString = "";
            }

        }

        private void addToListButton_Click(object sender, EventArgs e) {

            string propertyToAppend = propertyTextbox.Text;
            propertiesToSearchRichTextbox.AppendText(propertyToAppend);
            propertiesToSearch.Add(propertyToAppend);

        }

        private void clearAllButton_Click(object sender, EventArgs e) {

            propertyTextbox.Text = "";
            outputRichTextBox.Text = "";
            propertiesToSearchRichTextbox.Text = "";
            propertiesToSearch.Clear();

        }
    }
}
