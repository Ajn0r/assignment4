using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyOrganizer
{
    internal class PartyManager
    {
        // Instance variables
        private string[] guestList;
        private double costPerPerson;
        private double feePerPerson;

        // Constructor that takes the maximum number of guests as a parameter
        // and creates a new array of strings with that size.
        public PartyManager(int maxNumOfGuest)
        {
            guestList = new string[maxNumOfGuest];
        }

        // --------------------------------------------------------------
        //                           Properties
        // --------------------------------------------------------------

        // Property with read and write access to the cost per person. 
        public double CostPerPerson
        {
            get
            {
                return costPerPerson;
            }
            set
            {
                if (value >= 0.0)
                    costPerPerson = value;
            }
        }

        // Property with read and write access to the fee per person.
        public double FeePerPerson
        {
            get
            {
                return feePerPerson;
            }
            set
            {
                if (value >= 0.0)
                    feePerPerson = value;
            }
        }

        // Property with read access to the maximum number of guests.
        public int MaxNumOfGuests
        {
            get
            {
                int numGuests = 0;
                foreach (string guest in guestList)
                {
                    if (guest != null)
                    {
                        numGuests++;
                    }
                }
                return numGuests;
            }
        }

        // --------------------------------------------------------------
        //                           Methods
        // --------------------------------------------------------------
        // Method to add a new guest to the guest list
        public bool AddNewGuest(string firstName, string lastName)
        {
            return false;
        }

        // Method to calculate the total cost of the party
        public double CalculateTotalCost()
        {
            return 0.0;
        }

        // Method to calculate the total fee of the party
        public double CalculateTotalFee()
        {
               return 0.0;
        }

        // Method to change the name of a guest at a given index
        public bool ChangeAt(int index, string firstName, string lastName)
        {
            return false;
        }

        // Method to check if a given index is valid
        public bool CheckIndex(int index)
        {
            return false;
        }

        // Method to delete a guest at a given index
        public bool DeleteAt(int index)
        {
            return false;
        }

        // Method to find a vacant position in the array
        private int FindVacantPosition()
        {
            return 0;
        }

        // Method to return the full name of a guest formated with last name first
        // in upper case, a comma and then the first name.
        private string FullName(string firstName, string lastName)
        {
            return string.Format(lastName.ToUpper() + ", " + firstName);
        }

        // Method to get the guest list
        public string[] GetGuestList()
        {
            return null;
        }

        // Method to get an item(guest) at a given index
        public string GetItemAt(int index)
        {
            return null;
        }

        // Method to move all elements one step to the left from a given index
        private void MoveElementsOneStepLeft(int index)
        {

        }

        // Method that returns the number of guests
        private int NumberOfGuests()
        {
            return guestList.Length;
        }

    }
}
