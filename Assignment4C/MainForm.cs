namespace PartyOrganizer
{
    public partial class MainForm : Form
    {
        // Instance variables
        private PartyManager party;

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            // Set title text to the window
            this.Text = "Party Organizer by Ronja Sjögren";
            //set the groupbox with invite guest to disabled when the program starts
            gBoxInviteGuest.Enabled = false;

            // Clear all textboxes
            ClearTextBoxes();

        }

        // Method to clear the name textboxes
        private void ClearTextBoxes()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
        }

        private void btnCreateList_Click(object sender, EventArgs e)
        {
            // First check if there is a party list already
            if (!CheckExistingParty())
                return;

            // Create a new party list with the maximum number of guests
            // if CreateParty returns true
            bool maxNumOk = CreateParty();
            if (!maxNumOk)
                return;
            // Read the cost per person and the fee per person
            // and save the return value in a bool variable
            bool amountOk = ReadCost() && ReadFee();

            // If both values are ok, enable the groupbox with invite guest
            if (maxNumOk && amountOk)
            {
                gBoxInviteGuest.Enabled = true;
                // Put this here instead of in the CreateParty method
                MessageBox.Show($"Party list created, invite some guests!", "Success");
                ClearTextBoxes();
            }
        }

        // Method to check if there is a party list already
        // To make sure the user doesn't create a new list by mistake
        // since the old list will be overwritten with a new empty list
        private bool CheckExistingParty()
        {
            // check if there is a party list already
            if (party != null)
            {
                // Ask the user if they want to create a new list
                DialogResult result = MessageBox.Show("There is already a party list, do you want to create a new one?", "Warning", MessageBoxButtons.YesNo);
                // If the user clicks no, return false and do nothing
                if (result == DialogResult.No)
                {
                    return false;
                }
            }
            // if the list is empty or the user clicks yes, return true
            return true;
        }

        // Method to check that the maximum number of guests value is valid
        // and create a new party list if it is.
        private bool CreateParty()
        {
            int maxNum = 0;
            bool ok = true;

            if (int.TryParse(txtMaxNumGuest.Text, out maxNum) && (maxNum > 0))
            {
                party = new PartyManager(maxNum);
            }
            else
            {
                MessageBox.Show("Invalid value for maximum number of guest, please try again", "Error");
                ok = false;
            }
            return ok;
        }

        // Method to read, validate and save the cost per person
        private bool ReadCost()
        {
            double cost = 0.0;
            bool ok = true;
            // Check if the input is a valid double and if it is larger than 0
            if (double.TryParse(txtCostPerPers.Text, out cost) && (cost > 0))
            {
                party.CostPerPerson = cost;
            }
            else
            {
                MessageBox.Show("Invalid value for cost per person, please try again", "Error");
                ok = false;
            }

            return ok;
        }

        // Method to read, validate and save the fee per person
        private bool ReadFee()
        {
            double fee = 0.0;
            bool ok = true;
            // Check if the input is a valid double and if it is larger than 0
            if (double.TryParse(txtFeePerPers.Text, out fee) && (fee > 0))
            {
                // Save the fee per person in the party object
                party.FeePerPerson = fee;
            }
            else
            {
                MessageBox.Show("Invalid value for fee per person, please try again", "Error");
                ok = false;
            }
            return ok;
        }

        // Method to read the names and pass them to the ValidateName method for validation
        private bool ReadGuestName()
        {
            // Validate the first name and last name inputs
            bool fNameOk = ValidateName(txtFirstName.Text, "Invalid value for first name, please try again");
            bool lNameOk = ValidateName(txtLastName.Text, "Invalid value for last name, please try again");

            // Return the outcome of the validation
            return fNameOk && lNameOk;
        }

        // Method to validate the first name and last name inputs
        private bool ValidateName(string text, string errMsg)
        {
            // Trim the input
            text = text.Trim();

            // Check if the input is empty or null
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show(errMsg, "Error");
                return false;
            }
            return true;
        }

        // Method to add a new guest to the list when the "Add" button is clicked
        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            // Read and save the first name and last name if they are valid
            if (ReadGuestName())
            {
                // Try to add the guest to the list
                bool guestAdded = party.AddNewGuest(txtFirstName.Text, txtLastName.Text);
                // If the guest was added, show a message box and clear the textboxes
                if (guestAdded)
                {
                    MessageBox.Show("Guest added to the list", "Success");
                    ClearTextBoxes();
                }
                // If the guest was not added, show a message box
                else
                {
                    MessageBox.Show("The list is full, no more guests can be added", "Error");
                }
            }
            FillListBox();
            FillCostFeeResults();
        }

        // Method to fill the listbox with the guest list
        private void FillListBox()
        {
            // Clear the listbox
            lBoxGuestList.Items.Clear();
            // Loop through the guest list and add each guest to the listbox
            foreach (string guest in party.GetGuestList())
            {
                // Only add the guest if it is not null (empty)
                if (guest != null)
                {
                    // add the guest to the listbox
                    lBoxGuestList.Items.Add(guest);
                }
            }
        }

        // Method to fill the cost and fee labels with the total cost and fee
        private void FillCostFeeResults()
        {
            // Calculate the total cost and fee
            double totalCost = party.CalculateTotalCost();
            double totalFee = party.CalculateTotalFee();

            // Fill the labels with the total cost and fee and the surplus/deficit
            lblResTotalCost.Text = totalCost.ToString("0.00");
            lblResTotalFees.Text = totalFee.ToString("0.00");
            lblResSurpDef.Text = (totalFee - totalCost).ToString("0.00");
            lblResNumGuest.Text = party.NumberOfGuests().ToString();
        }

    }
}