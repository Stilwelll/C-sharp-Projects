using System;
using System.Drawing;
using System.Globalization;
using System.IO.Pipes;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Library_App
{
    class Program
    {
        static void Main(string[] args)
        {
            bool state = true;
            string answer;
            int answerNum;

            // books checked out by the user
            int checkedOutBooksCount = 0;
            List<int> checkedOutBooks = new List<int> { };
            
            // keeping track of the books being added and adding 3 books by default
            int bookCount = 3;
            Book book1 = new Book("Test1", "Action", 243, 1, false);
            Book book2 = new Book("Test2", "Adventure", 523, 2, false);
            Book book3 = new Book("Test3", "Comedy", 103, 3, false);

            List<Book> books = new List<Book>{ book1, book2, book3 };

            while (state)
            {
                Console.ResetColor();
                Console.WriteLine("Welcome to my Primitive Library App.");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Please pick from the options below.");
                Console.WriteLine("1). Check Inventory");
                Console.WriteLine("2). Book Entry");
                Console.WriteLine("3). Take out a book");
                Console.WriteLine("4). View Books You Have");
                Console.WriteLine("5). Exit");
                Console.WriteLine();

                answer = Console.ReadLine();

                // handling user inputs
                if (answer == "1" || string.Equals(answer, "Check", StringComparison.OrdinalIgnoreCase) || string.Equals(answer, "Check Inventory", StringComparison.OrdinalIgnoreCase))
                {
                    InventoryCheck();
                }

                if (answer == "2" || string.Equals(answer, "Book", StringComparison.OrdinalIgnoreCase) || string.Equals(answer, "Book Entry", StringComparison.OrdinalIgnoreCase))
                {
                    BookEntry();
                }

                if (answer == "3" || string.Equals(answer, "Take", StringComparison.OrdinalIgnoreCase) || string.Equals(answer, "Take Out", StringComparison.OrdinalIgnoreCase) || string.Equals(answer, "Take Out a Book", StringComparison.OrdinalIgnoreCase))
                {
                    BookCheckout();
                }

                if (answer == "4" || string.Equals(answer, "View", StringComparison.OrdinalIgnoreCase) || string.Equals(answer, "View Books", StringComparison.OrdinalIgnoreCase) || string.Equals(answer, "View Books You Have", StringComparison.OrdinalIgnoreCase))
                {
                    ViewYourBooks();
                }

                if (answer == "5" || string.Equals(answer, "Exit", StringComparison.OrdinalIgnoreCase))
                {
                    state = false;
                }

                Console.Clear();
            }

            void InventoryCheck()
            {
                bool state = true;
                string answer1;

                Console.Clear();

                while (state)
                {
                    Console.ResetColor();
                    Console.WriteLine($"The Library Currently Has {bookCount} books in storage");
                    Console.WriteLine("1). Look at Books in Storage");
                    Console.WriteLine("2). Back to Main Menu");
                    Console.WriteLine();

                    answer1 = Console.ReadLine();

                    if (answer1 == "1" || string.Equals(answer1, "Look at Books in Storage", StringComparison.OrdinalIgnoreCase) || string.Equals(answer1, "Look at Books", StringComparison.OrdinalIgnoreCase) || string.Equals(answer1, "Look", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Clear();

                        foreach(Book book in books)
                        {
                            Console.WriteLine($"Title: {book.title}");
                            Console.WriteLine($"Category: {book.category}");
                            Console.WriteLine($"Page Count: {book.pageCount}");
                            Console.WriteLine($"Book Index: {book.bookIndex}");
                            Console.WriteLine(book.CheckedOutStatus());
                            Console.WriteLine();
                        }

                        Console.WriteLine("Press Enter to go back.");
                        Console.ReadLine();
                        Console.Clear();   
                    }
                    else
                    {
                        Console.Clear();
                    }

                    if (answer1 == "2" || string.Equals(answer1, "Back", StringComparison.OrdinalIgnoreCase))
                    {
                        state = false;
                    }
                }

                Console.Clear();
            }

            void BookEntry()
            {
                bool state = true;
                bool state1 = true;
                string answer2;

                Console.Clear();
                while (state)
                {
                    Console.ResetColor();
                    Console.WriteLine("Please Select an Option");
                    Console.WriteLine("1). Book Entry");
                    Console.WriteLine("2). Back to the Main Menu");
                    Console.WriteLine();

                    answer2 = Console.ReadLine();

                    if (answer2 == "1" || string.Equals(answer2, "Book", StringComparison.OrdinalIgnoreCase) || string.Equals(answer2, "Book Entry", StringComparison.OrdinalIgnoreCase))
                    {
                        string titleAnswer = "";
                        string categoryAnswer = "";
                        int pageAnswer = 1905113515;
                        string[] categoryNames = {"Action", "Adventure", "Horror", "Comedy", "Romance", "Science-Fiction", "action", "adventure", "horror", "comedy", "romance", "science-fiction" };

                        while (state1)
                        {
                            Console.ResetColor();
                            Console.Clear();
                            Console.Write("What is the title of your book?: ");
                            titleAnswer = Console.ReadLine();
                            if (titleAnswer.Length < 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("A Valid Name Cannot Be Zero Characters. Please Try Again");
                                Console.ReadLine();
                            }
                            else
                            {
                                state1 = false;
                            }

                        }
                        state1 = true;

                        Console.WriteLine();

                        while (state1)
                        {
                            Console.ResetColor();
                            Console.Clear();
                            Console.Write("The Available Genres to Choose From Are: ");

                            for (int i = 0; i < 6; i++)
                            {
                                Console.Write(categoryNames[i] + ", ");
                                
                            }

                            Console.WriteLine();
                            Console.Write("What is the Genre of your book?: ");
                            categoryAnswer = Console.ReadLine();

                            if (!categoryNames.Contains(categoryAnswer))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid Answer, please select from the available categories.");
                                Console.ReadLine();
                            }
                            else
                            {
                                state1 = false;
                            }
                        }
                        state1 = true;
                        
                        while (state1)
                        {
                            Console.ResetColor();
                            Console.Clear();
                            Console.Write("How many pages does your book have?: ");
                            
                            try
                            {
                                pageAnswer = Convert.ToInt32(Console.ReadLine());
                            } 
                            catch (Exception ex)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid Input. Try Again.");
                                pageAnswer = 1905113515;
                                Console.ReadLine();
                            }

                            if (pageAnswer == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You cannot have Zero Pages");
                                Console.ReadLine();
                            }
                            else if (pageAnswer < 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You cannot have Negative Pages");
                                Console.ReadLine();
                            }
                            else if (pageAnswer != 1905113515)
                            {
                                state1 = false;
                            }
                        }
                        state1 = true;

                        Console.Clear();
                        Console.WriteLine("A new Book has been Created.");
                        bookCount++;
                        Book nBook = new Book(titleAnswer, categoryAnswer, pageAnswer, bookCount, false);
                        books.Add(nBook);
                    }
                    else
                    {
                        //Console.ForegroundColor = ConsoleColor.Red;
                        //Console.WriteLine("Invalid Entry. Try Again");
                        Console.Clear();
                    }

                    if (answer2 == "2" || string.Equals(answer2, "Back", StringComparison.OrdinalIgnoreCase) || string.Equals(answer, "Back to Main Menu", StringComparison.OrdinalIgnoreCase))
                    {
                        state = false;
                    }

                    Console.Clear();
                }

            }

            void BookCheckout()
            {
                string answer = "";
                int answer1 = -1;
                bool state = true;
                bool state1 = true;
                bool validAns;

                while (state)
                {
                    Console.Clear();
                    Console.ResetColor();
                    Console.WriteLine("Please select an option.");
                    Console.WriteLine("(You can only Check out 3 books per person)");
                    Console.WriteLine("1). Check out a Book");
                    Console.WriteLine("2). Back to Main Menu");
                    Console.WriteLine();

                    answer = Console.ReadLine();

                    if (answer == "1" || string.Equals(answer, "Check", StringComparison.OrdinalIgnoreCase) || string.Equals(answer, "Check out", StringComparison.OrdinalIgnoreCase) || string.Equals(answer, "Check out a Book", StringComparison.OrdinalIgnoreCase) || string.Equals(answer, "Check out book", StringComparison.OrdinalIgnoreCase))
                    {
                        while (state1)
                        {
                            Console.Clear();
                            Console.WriteLine("Which Book Would you like to Checkout?");
                            Console.WriteLine("(Please Enter the Book Index to Select the Book)");
                            Console.WriteLine();

                            foreach (Book book in books)
                            {
                                Console.WriteLine($"Title: {book.title}");
                                Console.WriteLine($"Category: {book.category}");
                                Console.WriteLine($"Page Count: {book.pageCount}");
                                Console.WriteLine($"Book Index: {book.bookIndex}");
                                Console.WriteLine(book.CheckedOutStatus());
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine("Please Type 'Back' to return to the Menu");

                            answer = Console.ReadLine();

                            if (string.Equals(answer, "Back", StringComparison.OrdinalIgnoreCase))
                            {
                                break;
                            }

                            // trying to convert to an integer
                            try
                            {
                                answer1 = Convert.ToInt32(answer);
                                validAns = true;
                            } catch (Exception e)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid Answer, please try again.");
                                validAns = false;
                            }                      

                            // if the answer is higher or lower than the number of books we have. without this we'll get an OutOfRange Exception
                            if (validAns == true && (answer1 > books.Count || answer1 < 1))
                            {
                                validAns = false;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Your Selection was not Valid. Please Choose A Valid Book Index.");
                            }

                            // an if-else chain to deal with the answers
                            if (validAns == true && books[answer1 - 1].isItCheckedOut == false && checkedOutBooksCount != 3)
                            {
                                books[answer1 - 1].isItCheckedOut = true;
                                checkedOutBooks.Add(answer1 - 1);
                                checkedOutBooksCount++;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Book Has Been Successfully Checked Out.");
                            }
                            else if (validAns == true && checkedOutBooksCount == 3)
                            {
                                Console.WriteLine("You Have Checked Out Your Maximum Number of Books.");
                            }
                            else if (validAns == true && books[answer1 - 1].isItCheckedOut == true)
                            {
                                Console.WriteLine("That Book is Already Checked Out. Please Select Another One or Exit.");
                            }

                            Console.ResetColor();
                            Console.ReadLine();
                        }
                        state1 = true;
                    }
                    else if (answer == "2" || string.Equals(answer, "Back", StringComparison.OrdinalIgnoreCase) || string.Equals(answer, "Back to Main Menu", StringComparison.OrdinalIgnoreCase))
                    {
                        state = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine("Invalid Entry. Try Again");
                    }
                }

                Console.ResetColor();
            }

            void ViewYourBooks()
            {
                bool state = true, state1 = true;
                string answer;

                while (state)
                {
                    Console.Clear();
                    Console.ResetColor();

                    Console.WriteLine("Please Select an Option To Continue");
                    Console.WriteLine("1). Look at your Books");
                    Console.WriteLine("2). Return a Book");
                    Console.WriteLine("3). Back to Main Menu");

                    answer = Console.ReadLine();

                    if (answer == "1" || string.Equals(answer, "Look", StringComparison.OrdinalIgnoreCase) || string.Equals(answer, "Look at", StringComparison.OrdinalIgnoreCase) || string.Equals(answer, "Look at Books", StringComparison.OrdinalIgnoreCase) || string.Equals(answer, "Look at your Books", StringComparison.OrdinalIgnoreCase))
                    {
                        checkedOutBooks.Sort();

                        if (checkedOutBooksCount == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("You Do Not Have Any Books Checked Out.");
                        }
                        else
                        {
                            foreach (int index in checkedOutBooks)
                            {
                                Console.WriteLine($"Title: {books[index].title}");
                                Console.WriteLine($"Category: {books[index].category}");
                                Console.WriteLine($"Page Count: {books[index].pageCount}");
                                Console.WriteLine($"Book Index: {books[index].bookIndex}");
                                Console.WriteLine();
                            }

                            Console.WriteLine("Press Enter to go back.");
                        }

                        Console.ReadLine();
                    }
                    else if (answer == "2" || string.Equals(answer, "Return", StringComparison.OrdinalIgnoreCase) || string.Equals(answer, "Return a Book", StringComparison.OrdinalIgnoreCase))
                    {
                        if (checkedOutBooksCount == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("You Do Not Have Any Books Checked Out.");
                            Console.ReadLine();
                        }
                        else
                        {
                            state1 = true;

                            while (state1)
                            {
                                int answer1 = -1;
                                bool validAns;

                                Console.Clear();
                                Console.WriteLine("Please Select One Of Your Books to Return");
                                Console.WriteLine("(Please Enter The List Index to Select)");

                                checkedOutBooks.Sort();

                                foreach (int index in checkedOutBooks)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"Title: {books[index].title}");
                                    Console.WriteLine($"Category: {books[index].category}");
                                    Console.WriteLine($"Page Count: {books[index].pageCount}");
                                    Console.WriteLine($"List Index: {index}");
                                    Console.WriteLine();
                                }
                                Console.WriteLine("Please Type 'Back' to return to the Menu");
                                Console.WriteLine();

                                answer = Console.ReadLine();

                                if (string.Equals(answer, "Back", StringComparison.OrdinalIgnoreCase))
                                {
                                    break;
                                }

                                // trying to convert to an integer
                                try
                                {
                                    answer1 = Convert.ToInt32(answer);
                                    validAns = true;
                                }
                                catch (Exception e)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Invalid Answer, please try again.");
                                    validAns = false;
                                    Console.ReadLine();
                                }
                                
                                // an if-else chain to deal with the answers
                                if (validAns == true && checkedOutBooks.Contains(answer1))
                                {
                                    checkedOutBooks.Remove(checkedOutBooks[answer1 - 1]);
                                    checkedOutBooksCount--;
                                    books[answer1].isItCheckedOut = false;
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Book Has Been Successfully Returned.");
                                    Console.ReadLine();
                                }
                                else if (validAns == true)
                                {
                                    Console.WriteLine("That List Index Does Not Exist. Try Again");
                                    Console.ReadLine();
                                }

                                // if there are no more books, return the user to the menu
                                if (checkedOutBooks.Count == 0)
                                {
                                    Console.ResetColor();
                                    Console.WriteLine("There Are No More Books Left. Returning You To The Menu");
                                    Console.ReadLine();
                                    state1 = false;
                                }

                                Console.ResetColor();
                            }
                        }
                    }
                    else if (answer == "3" || string.Equals(answer, "Back", StringComparison.OrdinalIgnoreCase) || string.Equals(answer, "Back to Main Menu", StringComparison.OrdinalIgnoreCase))
                    {
                        state = false;
                    }

                }
            }
        }
    }
}
