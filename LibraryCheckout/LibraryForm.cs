using LibraryCheckout.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibraryCheckout
{
    public partial class LibraryForm : Form
    {
        // Create the stack and lists
        // MAKE SURE STACK IS THE IMPLEMENTATION, NOT A REAL STACK!!
        private Stack returnStack = new Stack();
        private MyLinkedList mysteryShelf = new MyLinkedList();
        private MyLinkedList fantasyShelf = new MyLinkedList();
        private MyLinkedList scifiShelf = new MyLinkedList();

        // Initial Return Books
        private Book book1 = new Book("Call of Cthulu", "Mystery", "Lovecraft", "Howard");
        private Book book2 = new Book("Harold Pottworth", "Fantasy", "Rolling", "Justin");
        private Book book3 = new Book("Quest for Quantum Neutrinos", "Scifi", "Farnsworth", "Hubert");
        private Book book4 = new Book("Roadside Picnic", "Scifi", "Strugatsky", "Arkady");
        private Book book5 = new Book("Lord of the Things", "Fantasy", "Token", "Jimothy");
        private Book book6 = new Book("Here to There", "Scifi", "Kleiner", "Isaac");
        private Book book7 = new Book("Dark Tower, The", "Fantasy", "King", "Stephen");
        private Book book8 = new Book("Leviathan Wakes", "Scifi", "Corey", "James");
        private Book book9 = new Book("Girl With The Dragon Tattoo, The", "Mystery", "Larsson", "Stieg");
        private Book book10 = new Book("Gone Girl", "Mystery", "Flynn", "Gillian");
        private Book book11 = new Book("In The Mouth of Madness", "Mystery", "Kane", "Sutter");
        private Book book12 = new Book("Game of Thrones, A", "Fantasy", "Martin", "George");
        private Book book13 = new Book("Time Machine, The", "Scifi", "Wells", "H.G.");
        private Book book14 = new Book("Hollywood Homicide", "Mystery", "Garrett", "Kelye");
        private Book book15 = new Book("Discworld", "Fantasy", "Pratchett", "Terry");

        public LibraryForm()
        {
            InitializeComponent();

            // Add all of the return books
            returnStack.Push(book1);
            returnStack.Push(book2);
            returnStack.Push(book3);
            returnStack.Push(book4);
            returnStack.Push(book5);
            foreach (Book b in returnStack.stack)
            {
                returnBox.Items.Add(b.getTitle());
            }

            // Add initial Mystery shelf
            mysteryShelf.Insert(book9);
            mysteryShelf.Insert(book10);
            mysteryShelf.Insert(book11);
            mysteryShelf.Insert(book14);

            for (int i = 0; i < mysteryShelf.Size(); i++)
            {
                if (mysteryShelf.GetAtIndex(i) != null)
                {
                    mysteryBox.Items.Add(mysteryShelf.GetAtIndex(i).getTitle());
                }
            }

            // Add initial Fantasy shelf
            fantasyShelf.Insert(book7);
            fantasyShelf.Insert(book12);
            fantasyShelf.Insert(book15);

            for (int i = 0; i < fantasyShelf.Size(); i++)
            {
                if (fantasyShelf.GetAtIndex(i) != null)
                {
                    fantasyBox.Items.Add(fantasyShelf.GetAtIndex(i).getTitle());
                }
            }

            // Add initial Sci-fi shelf
            scifiShelf.Insert(book6);
            scifiShelf.Insert(book8);
            scifiShelf.Insert(book13);

            for (int i = 0; i < scifiShelf.Size(); i++)
            {
                if (scifiShelf.GetAtIndex(i) != null)
                {
                    scifiBox.Items.Add(scifiShelf.GetAtIndex(i).getTitle());
                }
            }
        }

        // This took AGES to do and I hate that

        // Function: ReturnButton_Click()
        // Arguments: Event handlers
        // Description: This action fuction pulls a book from the top of the stack, checks it's genre, removes it from the stack,
        // adds it to the appropriate "genre" stack, and then then "refreshes/updates" all the listboxes with the appropriate information.
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            // This try-catch catches all of the null values, and just replaces it with a little user-friendly error.
            // If pretty much just catches all of the cases in which there are no books in the stack, or the listbox is trying to update it's list
            // with no books to pick from.
            try
            {
                // Reset error label between clicks so that if there's no more error, the message doesn't stay
                errorLabel.Text = "";

                
                // Peeks at the top of stack and checks the books genre.
                // If it matches any of the three genres I have listed here, it is inserted into it's respective list
                // and then popped from the return stack.
                if (returnStack.Peek().getGenre().ToLower() == "mystery")
                {
                    mysteryShelf.Insert(returnStack.Pop());
                }
                else if (returnStack.Peek().getGenre().ToLower() == "fantasy")
                {
                    fantasyShelf.Insert(returnStack.Pop());
                }
                else if (returnStack.Peek().getGenre().ToLower() == "scifi")
                {
                    scifiShelf.Insert(returnStack.Pop());
                }

                // Clear the return box, and then repopulate it
                returnBox.Items.Clear();
                foreach (Book b in returnStack.stack)
                {
                    returnBox.Items.Add(b.getTitle());
                }

                // Clear the mystery listbox, and then repopulate
                mysteryBox.Items.Clear();
                for (int i = 0; i < mysteryShelf.Size(); i++)
                {
                    if (mysteryShelf.GetAtIndex(i) != null)
                    {
                        mysteryBox.Items.Add(mysteryShelf.GetAtIndex(i).getTitle());
                    }
                }

                // Clear the fantasy listbox, and then repopulate
                fantasyBox.Items.Clear();
                for (int i = 0; i < fantasyShelf.Size(); i++)
                {
                    if (fantasyShelf.GetAtIndex(i) != null)
                    {
                        fantasyBox.Items.Add(fantasyShelf.GetAtIndex(i).getTitle());
                    }
                }

                // Clear the scifi listbox, and then repopulate
                scifiBox.Items.Clear();
                for (int i = 0; i < scifiShelf.Size(); i++)
                {
                    if (scifiShelf.GetAtIndex(i) != null)
                    {
                        scifiBox.Items.Add(scifiShelf.GetAtIndex(i).getTitle());
                    }
                }

            }
            catch (Exception ex)
            {
                if (ex is NullReferenceException)
                {
                    errorLabel.Text = "No books in the return stack!";
                }

                // The original-- leaving this here incase I do need these, but these might all be out of date/ not required
                // due the vast amounts of rewrites I've done to this method.

                /*
                if (ex is ArgumentNullException || ex is InvalidOperationException || ex is IndexOutOfRangeException)
                {
                    errorLabel.Text = "No books selected!";
                }
                */
            }

        }

        // Function: CheckOutButton_Click()
        // Arguments: Event handlers
        // Description: This action fuction pushes a book to the return stack where the list box selected index is the same as the 
        // list item's index. Then we delete the item from the list. Refreshing the listboxes removes it visually.
        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            // Spits out and index out of range error sometimes when nothing is selected, so we fix that here
            try
            {
                // Reset error label, because this is another action that could work
                errorLabel.Text = "";

                // If something is selected in the mystery list box, then push the book that's at the same index to the return stack
                // Once that's done, we delete it from the shelf/list
                if (mysteryBox.SelectedIndex != -1)
                {
                    returnStack.Push(mysteryShelf.GetAtIndex(mysteryBox.SelectedIndex));
                    mysteryShelf.Delete(mysteryBox.SelectedIndex);
                }

                // If something is selected in the fantasy list box, then push the book that's at the same index to the return stack
                // Once that's done, we delete it from the shelf/list
                if (fantasyBox.SelectedIndex != -1)
                {
                    returnStack.Push(fantasyShelf.GetAtIndex(fantasyBox.SelectedIndex));
                    fantasyShelf.Delete(fantasyBox.SelectedIndex);
                }

                // If something is selected in the scifi list box, then push the book that's at the same index to the return stack
                // Once that's done, we delete it from the shelf/list
                if (scifiBox.SelectedIndex != -1)
                {
                    returnStack.Push(scifiShelf.GetAtIndex(scifiBox.SelectedIndex));
                    scifiShelf.Delete(scifiBox.SelectedIndex);
                }

                // For some reason this isn't the same as the IndexOutOfRangeException
                // Infact, nothing selected sometimes just doesn't throw an error, so we have this to make a user-friendly notice that nothing is selected.
                if (mysteryBox.SelectedIndex < 0 && fantasyBox.SelectedIndex < 0 && scifiBox.SelectedIndex < 0)
                {
                    errorLabel.Text = "No books selected!";
                }

                // These are all just the little list box refreshes from before
                returnBox.Items.Clear();
                foreach (Book b in returnStack.stack)
                {
                    returnBox.Items.Add(b.getTitle());
                }

                mysteryBox.Items.Clear();
                for (int i = 0; i < mysteryShelf.Size(); i++)
                {
                    if (mysteryShelf.GetAtIndex(i) != null)
                    {
                        mysteryBox.Items.Add(mysteryShelf.GetAtIndex(i).getTitle());
                    }
                }

                fantasyBox.Items.Clear();
                for (int i = 0; i < fantasyShelf.Size(); i++)
                {
                    if (fantasyShelf.GetAtIndex(i) != null)
                    {
                        fantasyBox.Items.Add(fantasyShelf.GetAtIndex(i).getTitle());
                    }
                }

                scifiBox.Items.Clear();
                for (int i = 0; i < scifiShelf.Size(); i++)
                {
                    if (scifiShelf.GetAtIndex(i) != null)
                    {
                        scifiBox.Items.Add(scifiShelf.GetAtIndex(i).getTitle());
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex is IndexOutOfRangeException)
                {
                    errorLabel.Text = "No books selected!";
                }
            }
        }

        // These are all nearly the same so I will only describe the first one in detail, and the others briefly
        // Function: DetailButton_Click()
        // Arguments: Event handlers
        // Description: Action function that grabs the selected book (at the index, because the listbox selected index and the list's index are
        // the same values), gets all of the information from it, and then formats into into a string that is then displayed in a pop-up listbox.
        // This one is tied to the mystery listbox
        private void DetailButton_Click(object sender, EventArgs e)
        {
            try
            {
                errorLabel.Text = "";

                Book b = mysteryShelf.GetAtIndex(mysteryBox.SelectedIndex);
                string title = b.getTitle();
                string genre = b.getGenre();
                string last = b.getLast();
                string first = b.getFirst();
                MessageBox.Show("Title: " + title + "\n" + "Genre: " + genre + "\n" + "Name: " + first + " " + last + "\n", "Book Details");
            } catch (Exception ex)
            {
                if (ex is IndexOutOfRangeException)
                {
                    errorLabel.Text = "No books selected for detail view!";
                }
            }
        }

        // This one is tied to the fantasy listbox
        private void DetailButton2_Click(object sender, EventArgs e)
        {
            try
            {
                errorLabel.Text = "";

                Book b = fantasyShelf.GetAtIndex(fantasyBox.SelectedIndex);
                string title = b.getTitle();
                string genre = b.getGenre();
                string last = b.getLast();
                string first = b.getFirst();
                MessageBox.Show("Title: " + title + "\n" + "Genre: " + genre + "\n" + "Name: " + first + " " + last + "\n", "Book Details");
            }
            catch (Exception ex)
            {
                if (ex is IndexOutOfRangeException)
                {
                    errorLabel.Text = "No books selected for detail view!";;
                }
            }
        }

        // This one is tied to the scifi listbox
        private void DetailButton3_Click(object sender, EventArgs e)
        {
            try
            {
                errorLabel.Text = "";

                Book b = scifiShelf.GetAtIndex(scifiBox.SelectedIndex);
                string title = b.getTitle();
                string genre = b.getGenre();
                string last = b.getLast();
                string first = b.getFirst();
                MessageBox.Show("Title: " + title + "\n" + "Genre: " + genre + "\n" + "Name: " + first + " " + last + "\n", "Book Details");
            }
            catch (Exception ex)
            {
                if (ex is IndexOutOfRangeException)
                {
                    errorLabel.Text = "No books selected for detail view!";
                }
            }
        }
    }
}
