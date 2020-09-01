using System;
using System.Collections;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisabledComputerFixAndReport {
    class ADMethods {

        public static ArrayList getADComputer(ArrayList properties) {

            //Search using the global wildcard defined in application settings
            string computerNameString = DisabledComputerFixAndReport.Properties.Settings.Default.globalWildcard;

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
            IDictionary<string, string> computerDict = new Dictionary<string, string>();
            ArrayList computerList = new ArrayList();

            //Enumerate through results & add to arraylist
            if (null != directorySearchResultList) {
                foreach(SearchResult result in directorySearchResultList) {

                    //Append property results to the dictionary & clear dictionary
                    computerDict.Clear();
                    DirectoryEntry computerResult = result.GetDirectoryEntry();

                    foreach(string property in properties) {
                        computerDict.Add(property, computerResult.Properties[property].Value.ToString());
                    }//end of property enumeration

                    computerList.Add(computerDict);

                }//end of search result enumeration
            }//end of !null directory search result list

            //return the computer list
            return computerList;

        }

    }
}
