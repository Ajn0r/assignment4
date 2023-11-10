using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    internal class PhoneBook
    {
        private string[] names = { "Kalle", "Lisa", "Anna", "Peter", "Maria" };
        private string[] phones = { "070-1234567", "070-7654321", "070-1111111", "070-2222222", "070-3333333" };

        private string[,] phoneList;

        public PhoneBook()
        {
            // Clear the console
            Console.Clear();
            // Display the list
            DisplayList();
            // Sort the list and display the result
            SortList();
            Console.WriteLine("\n\nSorted List:\n");
            DisplayList();
            // using a 2d array instead
            int count = names.Length;
            phoneList = new string[count, 2];
            // fill the table and display the result
            FillTable();
            Console.WriteLine("\n\nUsing a 2d array instead of two 1d arrays:\n");
            DisplayTable();
        }

        private void DisplayList()
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("{0, -10} {1, -10}", names[i], phones[i]);
            }
        }

        private void SortList()
        {
            int length = names.Length;
            // sort using bubble sort
            for (int pos = 0; pos < length - 1; pos++)
            {
                for (int i = 0; i < length - pos - 1; i++)
                {
                    // if current value compared to the next value is larger than 0
                    if (names[i].CompareTo(names[i + 1]) > 0)
                    {
                        // swap values
                        SwapValues(i);
                    }
                }
            }   
        }
        private void SwapValues(int pos)
        {
            // create a temporary variable to hold the value of the current position
            string temp = names[pos];
            // set the value of the current position to the value of the next position
            names[pos] = names[pos + 1];
            // set the value of the next position to the value of the temporary variable
            names[pos + 1] = temp;

            // Do the same with phonenumbers to keep the correct nr to correct person
            temp = phones[pos];
            phones[pos] = phones[pos + 1];
            phones[pos + 1] = temp;
        }

        private void FillTable()
        {
            int row = phoneList.GetLength(0);

            for (int i = 0; i < row; i++)
            {
                phoneList[i, 0] = names[i];
                phoneList[i, 1] = phones[i];
            }
        }

        private void DisplayTable()
        {
            int rows = phoneList.GetLength(0);
            int cols = phoneList.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                Console.Write(string.Format("{0, -8}", "Row " + row.ToString()));
                
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(string.Format("{0, -15}", phoneList[row, col]));
                }
                Console.WriteLine();
            }
        }
    }
}
