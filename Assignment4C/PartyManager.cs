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
            string fullName = FullName(firstName, lastName);
            // find the first vacant position in the array
            int vacantPosition = FindVacantPosition();
            // if a vacant position was found, add the guest to the list
            if (vacantPosition != -1)
            {
                guestList[vacantPosition] = fullName;
                return true;
            }
            return false;
        }

        // Method to calculate the total cost of the party
        public double CalculateTotalCost()
        {
            return costPerPerson * NumberOfGuests();
        }

        // Method to calculate the total fee of the party
        public double CalculateTotalFee()
        {
               return feePerPerson * NumberOfGuests();
        }

        // Method to change the name of a guest at a given index
        public bool ChangeAt(int index, string firstName, string lastName)
        {
            return false;
        }

        // Method to check if a given index is valid
        public bool CheckIndex(int index)
        {
            // check that the index is valid (between 0 and the length of the array)
            if (index >= 0 && index < guestList.Length)
            {
                return true;
            }
            return false;
        }

        // Method to delete a guest at a given index
        public bool DeleteAt(int index)
        {
            // check that the index is valid
            if (CheckIndex(index))
            {
                // set the value at the index to null
                guestList[index] = null;
                return true;
            }
            return false;
        }

        // Method to find a vacant position in the array
        private int FindVacantPosition()
        {
            // find the first vacant position in the array
            for (int i = 0; i < guestList.Length; i++)
            {
                // if there is a index with a null value, it is vacant
                if (guestList[i] == null)
                {
                    // return the index
                    return i;
                }
            }
            // if no vacant position was found, return -1
            return -1;
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
            return guestList;
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
        public int NumberOfGuests()
        {
            int numOfGuests = 0;
            // loop through the array and count the number of guests
            foreach (string guest in guestList)
            {
                // if the guest is not null, it is a guest
                if (guest != null)
                {
                    // increment the number of guests
                    numOfGuests++;
                }
            }
            return numOfGuests;
        }

    }
}
