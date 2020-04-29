using System;
using System.Collections.Generic;
using System.Text;
/***************************************************************
* Name        : Stack
* Author      : Ricky Sears
* Created     : 4/7/2020
***************************************************************/

namespace LibraryCheckout.Classes
{
    // This is a stack created with a linked-list
    class Stack
    {
        public LinkedList<Book> stack;

        // Default no-arg Constructor
        public Stack()
        {
            // Initialize "stack"
            stack = new LinkedList<Book>();
        }

        // Function: push()
        // Args: book (book)
        // Description: Call the AddFirst() function of linked list
        // and pass it the book to "push" it to the "top" of the stack
        public void Push(Book book)
        {
            stack.AddFirst(book);
        }

        // Function: pop()
        // Args: none
        // Description: Call the RemoveFirst() function of linked list to remove the "top" of the stack.
        // Returns the popped book
        public Book Pop()
        {
                Book before = stack.First.Value;
                stack.RemoveFirst();
                return before;
        }

        // Function: isEmpty()
        // Args: none
        // Description: Uses the First property of linked list to check if the first book is null (returns true)
        // or not (returns false)
        public bool IsEmpty()
        {
            if (stack.First == null)
            {
                return true;
            }

            return false;
        }

        // Linked Lists cannot be full, so there is no isFull() :)

        // Function: peek()
        // Args: none
        // Description: Return the linked list's First book (top of stack) 
        public Book Peek()
        {
            return stack.First.Value;
        }

        // Function: size()
        // Args: none
        // Description: Return the Count property of linked list to get the number of elements in the "stack"
        public int Size()
        {
            return stack.Count;
        }

        // Function: print()
        // Args: none
        // Description: Return a concatonated string of each book's title in the list
        public string Print()
        {
            string str = "";

            foreach (Book b in stack)
            {
                str += b.getTitle() + " ";
            }

            return str;
        }
    }
}
