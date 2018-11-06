using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_C.Core.Utilities
{
    static class Alert
    {
        internal static void IdTaken()
        {
            MessageBox.Show("An item with the given id already exists.");
        }

        internal static void FieldsNotFilled()
        {
            MessageBox.Show("Please fill all required fields");
        }

        internal static void CategoryAdded()
        {
            MessageBox.Show("Category added");
        }

        internal static void CategoryRemoved()
        {
            MessageBox.Show("Category removed");
        }

        internal static void FeedAdded()
        {
            MessageBox.Show("Feed added");
        }

        internal static void FeedRemoved()
        {
            MessageBox.Show("Feed removed");
        }
        
        internal static void FeedChanged()
        {
            MessageBox.Show("The selected feed has been changed");
        }

        internal static void CategoryChanged()
        {
            MessageBox.Show("The selected category has been changed");
        }

        internal static void NoItem()
        {
            MessageBox.Show("Please select an item from the list");
        }

        internal static void DependentFeeds(string[] podcastNames)
        {
            string nameList = "";
            foreach(string name in podcastNames)
            {
                nameList += "\n" + name;
            }

            MessageBox.Show("Cannot remove category. The following feeds are dependent:\n" + nameList);
        }
    }
}
