/*
   Name of Programmer: Karna Johnson
   Company: Tuliva.com
   Project: Animal Kingdom
   Description: Demonstrating the form for the Animal Kingdom. 
   Class: This is the FormClient class.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tuliva.com.AK.Utilities;

namespace AK_One
{
    public partial class FormClient : Form
    {
        //private fields
        private string lastName;
        private string firstName;
        private string password;

        //constructor
        public FormClient()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //setting the fields to the text in the textbox
            lastName = txtLastName.Text;
            firstName = txtFirstName.Text;
            password = txtPassword.Text;

            //logging what the user entered
            Utilities.LogIt("The user entered for last name:" + lastName +
                "\nThe user entered for first name: " + firstName +
                "\nThe user entered for their password: " + password + "\n",
                Utilities.MessageSeverity.INFORMATIONAL, true);

            //setting the textboxes to not be enabled
            //because the user has logged in
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtPassword.Enabled = false;

            //setting the submit button to not be enabled
            //because the user has logged in
            btnSubmit.Enabled = false;

            //makeing the listbox and label to be visible
            lblAnimalToCreate.Enabled = true;
            lstAnimalToCreate.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //closing the form
            this.Close();
            //logging that the user exited the menu.
            Utilities.LogIt("FormClient::The user exited the FormClient's menu.\n",
                   Utilities.MessageSeverity.INFORMATIONAL, true);
        }

        private void lstAnimalToCreate_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch statement for the picture box
            switch (this.lstAnimalToCreate.SelectedIndex)
            {
                case 0:
                    //A Duck image appears in the picture box
                    picAnimal.Image = global::AK_One.Properties.Resources.daffyduck;
                    //logging what the user did
                    Utilities.LogIt("FormClient::The user chose a duck in the list box.\n",
                    Utilities.MessageSeverity.INFORMATIONAL, true);
                    break;
                case 1:
                    //A Trout image appears in the picture box
                    picAnimal.Image = global::AK_One.Properties.Resources.trout;
                    //logging what the user did
                    Utilities.LogIt("FormClient::The user chose a trout in the list box.\n",
                    Utilities.MessageSeverity.INFORMATIONAL, true);
                    break;
                case 2:
                    //A Human image appears in the picture box
                    picAnimal.Image = global::AK_One.Properties.Resources.Human;
                    //logging what the user did
                    Utilities.LogIt("FormClient::The user chose a human in the list box.\n",
                    Utilities.MessageSeverity.INFORMATIONAL, true);
                    break;
                default:
                    break;
            }
        }
    }
}
