using LibraryCheckout.Classes;
using System;
using System.Collections.Generic;
using System.Text;

/***************************************************************
* Name        : MyLinkedList
* Author      : Ricky Sears
* Created     : 4/21/2020
***************************************************************/

namespace LibraryCheckout
{
    // This is a singly linked-list created from an array. It does have size limits, but I dound this way to fit my needs much better.
    class MyLinkedList
    {
        // Declarations
        private Book[] arr;
        private int size;

        // No-arg, default constructor
        // Sets size and initializes the array
        public MyLinkedList()
        {
            size = 10;
            arr = new Book[size];
        }

        // Function: Insert()
        // Arguments: a Book object (b)
        // Description: Steps through our list to find the first null value it can, and then inserts the book at that position.
        public void Insert(Book b)
        {
            // Check if array is full first, throw exception
            if (isFull())
            {
                throw new ArgumentException("List is full.");
            }
            else
            {
                // Steps through each index of the array and checks if it's null (empty).
                for (int i = 0; i < Size(); i++)
                {
                    // Find first null position and put the book there
                    if (arr[i] == null)
                    {
                        arr[i] = b;

                        // Run our sort method so the list is up-to-date
                        Sort();

                        // Should it be done, break the sequence. We're done here.
                        break;
                    }
                }
            }
        }

        // Function: Delete()
        // Arguments: integer for array position
        // Description: Searches the array for an element at the matching index, pushes everything at that point in the array back by one.
        // This deletes the book we want to delete AND updates the positions of everything after
        public void Delete(int index)
        {
            // This is a little check so we know when to start pushing the elements of the array backwards
            bool isReady = false;

            // If we reach the index we're looking for, then set the flag to start pushing backwards
            for (int i = 0; i < Size(); i++)
            {
                if (i == index)
                {
                    isReady = true;
                }

                // Set every element from the deletion point forward to the next element
                if (isReady && arr[i] != null)
                {
                    // If we reach the end, just set the end point to null
                    if (i == Size() - 1)
                    {
                        arr[i] = null;
                    } else
                    {
                        arr[i] = arr[i + 1];
                    }
                }
            }
        }

        // Function: GetAtIndex()
        // Arguments: integer for index position
        // Description: A little function that grabs and returns the book object at the specified index.
        public Book GetAtIndex(int i)
        {
            // If the book at this position exists and isn't over the size limit, grab it
            if (arr[i] != null && i < Size())
            {
                return arr[i];
            }
            // This assumes that you tried grabbing something outside the size limit, so just grabs the end of the array
            return arr[Size() - 1];
        }

        // Function: Search()
        // Arguments: a number of type integer
        // Description: Return the title value of the book at the passed "index" of the array if it exists
        // --This is not used, this is only for testing purposes--
        public String Search(int i)
        {
            return arr[i].getTitle();
        }

        // Function: Size()
        // Arguments: N/A
        // Description: Gets the size of the array and returns it
        public int Size()
        {
            return arr.Length;
        }

        // Function: isFull()
        // Arguments: N/A
        // Description: Checks if the the last value in the list is null.
        // If it isn't, then we are full, because sorting should put null values last
        public bool isFull()
        {
            if (arr[Size() -1] != null)
            {
                return true;
            }

            return false;
        }

        // Function: isEmpty()
        // Arguments: N/A
        // Description: The inverse of isFull, it checks if the "beginning" is empty/ , because sort always sorts left.
        public bool isEmpty()
        {
            if (arr[0] == null)
            {
                return true;
            }

            return false;
        }

        // Function: Sort()
        // Arguments: N/A
        // Description: Selection Sort algorithm that compares each last name of each book object to the next last name
        // If a last name precedes another last name, it becomes the "minimum"/ first alphabetically
        void Sort()
        {
            // Length/ size value
            int n = Size();

            // For each (i) index in the list, compare the the next index (j)
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    // Make sure neither of them are null, or we get an error
                    if(arr[j] != null && arr[min] != null)
                    {
                        // Compare the last names. If the "next" is lower, then we set it to the new min
                        if (arr[j].getLast().CompareTo(arr[min].getLast()) < 0)
                        {
                            min = j;
                        // If we have the same authors, but different books, now we compare titles for who goes first
                        } else if (arr[j].getLast().CompareTo(arr[min].getLast()) == 0)
                        {
                            if (arr[j].getTitle().CompareTo(arr[min].getTitle()) < 0)
                            {
                                min = j;
                            }
                        }
                    }
                    
                }

                // Swap the positions
                Book temp = this.arr[min];
                this.arr[min] = this.arr[i];
                this.arr[i] = temp;
            }
        }

        // Function: Print()
        // Description: Gets each item from the list and concatonates it to a string that is eventually returned.
        // This is pretty much only for testing purposes.
        public string Print()
        {
            string arrayList = "List printed: ";

            foreach (Book b in arr)
            {
                if (b != null)
                {
                    arrayList += b.getTitle() + " ";
                }
            }

            return arrayList;
        }
    }
}
