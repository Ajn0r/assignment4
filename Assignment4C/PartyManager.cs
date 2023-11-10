using System;
using System.Collections.Generic;
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

    }
}
