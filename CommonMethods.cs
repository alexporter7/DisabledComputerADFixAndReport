using System;
using System.Collections;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisabledComputerFixAndReport {
    class CommonMethods {

        public static List<List<string>> getADComputer(ArrayList properties) {

            //Search using the global wildcard defined in application settings
            string computerNameString = DisabledComputerFixAndReport.Properties.Settings.Default.globalWildcard;
            //computerNameString = "DTC6GZW0X2";

            //Set the AD Path to search in (using the entire directory)
            //Setup the Directory Entry to search the defined path
            string adPath = "LDAP://net.ucf.edu";
            DirectoryEntry directoryEntry = new DirectoryEntry(adPath);

            //Set the filter string to filter results
            string filterString = "(&(objectCategory=computer)(name=" + computerNameString + "))";

            //Search Active Directory & Execute Search
            DirectorySearcher directorySearch = new DirectorySearcher(directoryEntry, filterString);
            SearchResultCollection directorySearchResultList = directorySearch.FindAll();

            //Initialize the arraylist that will be returning
            List<List<string>> computerList = new List<List<string>>();

            //Enumerate through results & add to arraylist
            if (null != directorySearchResultList) {
                foreach(SearchResult result in directorySearchResultList) {

                    //Append property results to the ArrayList & clear ArrayList
                    List<string> propertyList = new List<string>();

                    //Search through the directory result
                    DirectoryEntry computerResult = result.GetDirectoryEntry();

                    foreach(string property in properties) {
                        propertyList.Add(computerResult.Properties[property].Value.ToString());
                    }//end of property enumeration

                    //Add the arraylist to the list of computers
                    computerList.Add(propertyList); //CAUSING ISSUES

                }//end of search result enumeration
            }//end of !null directory search result list

            //return the computer list
            return computerList;

        }

        public static void populateListView(ListView outputListView, ArrayList columns, List<List<string>> information) {

            //Initialize the List View
            outputListView.View = View.Details;

            foreach(string column in columns) {
                outputListView.Columns.Add(column, -2, HorizontalAlignment.Center);
            }

            //Resize Columns Automatically
            outputListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            outputListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            
            //Populate information
            foreach(List<string> items in information) {
                
                //Add the first bit of information for the first column
                ListViewItem item = new ListViewItem(Convert.ToString(items[0]));

                //Go through ArrayList starting at index 1
                for (int i = 1; i < items.Count; i++) {
                    item.SubItems.Add(Convert.ToString(items[1]));
                }

                //Add the item in the ListView
                outputListView.Items.Add(item);

            }

        }

    }
}
