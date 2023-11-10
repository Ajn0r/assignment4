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

        // Method to clear all textboxes
        private void ClearTextBoxes()
        {
            txtMaxNumGuest.Clear();
            txtCostPerPers.Clear();
            txtFeePerPers.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
        }

        private void btnCreateList_Click(object sender, EventArgs e)
        {
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
            if (double.TryParse(txtFeePerPers.Text, out fee) && (fee > 0))
            {
                party.FeePerPerson = fee;
            }
            else
            {
                MessageBox.Show("Invalid value for fee per person, please try again", "Error");
                ok = false;
            }
            return ok;
        }
        private void ReadAndSaveGuest()
        {
            bool fNameOk = ValidateName(txtFirstName.Text, "Invalid value for first name, please try again");
            bool lNameOk = ValidateName(txtLastName.Text, "Invalid value for last name, please try again");
        }

        private bool ValidateName(string text, string errMsg)
        {
            text = text.Trim();

            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show(errMsg, "Error");
                return false;
            }
            return true;
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            
        }
    }
}