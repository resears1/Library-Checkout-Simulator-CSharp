using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***************************************************************
* Name        : Book
* Author      : Ricky Sears
* Created     : 4/7/2020
***************************************************************/

namespace LibraryCheckout.Classes
{
    class Book
    {
        // Properties
        private string title;
        private string genre;
        private string authorLast;
        private string authorFirst;

        // Default no-arg constructor
        public Book()
        {
            title = "empty";
            genre = "generic";
            authorLast = "Doe";
            authorFirst = "John";
        }

        // Non-default constructor with 4 arguments
        public Book(string title, string genre, string last, string first)
        {
            this.title = title;
            this.genre = genre;
            this.authorLast = last;
            this.authorFirst = first;
        }

        // Getters and Setters

        public void setTitle(string title)
        {
            this.title = title;
        }

        public string getTitle()
        {
            return this.title;
        }

        public void setGenre(string genre)
        {
            this.genre = genre;
        }

        public string getGenre()
        {
            return this.genre;
        }

        public void setFirst(string first)
        {
            this.authorFirst = first;
        }

        public string getFirst()
        {
            return this.authorFirst;
        }

        public void setLast(string last)
        {
            this.authorLast = last;
        }

        public string getLast()
        {
            return this.authorLast;
        }
    }
}
