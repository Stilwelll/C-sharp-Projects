using System;
using System.Linq.Expressions;

namespace Library_App
{
    class Program
    {
        static void Main(string[] args)
        {
            bool state = true;
            string answer;
            int answerNum;
            int bookCount = 3;

            Book book1 = new Book("Test1", "Action", 243, false);
            Book book2 = new Book("Test2", "Adventure", 523, false);
            Book book3 = new Book("Test3", "Comedy", 103, false);

            List<Book> books = new List<Book>{ book1, book2, book3 };

            while (state)
            {
                Console.WriteLine("Welcome to my Primitive Library App.");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Please pick from the options below.");
                Console.WriteLine("1). Check Inventory");
                Console.WriteLine("2). Book Entry");
                Console.WriteLine("3). Check out a book");
                Console.WriteLine();
                Console.WriteLine("4). Exit");
                Console.WriteLine();

                answer = Console.ReadLine();

                switch (answer)
                {
                    // different cases to select inventory check
                    case "1": InventoryCheck(); break;
                    case "inventory": InventoryCheck(); break;
                    case "Inventory": InventoryCheck(); break;
                    case "Check": InventoryCheck(); break;
                    case "check": InventoryCheck(); break;
                    case "check inventory": InventoryCheck(); break;

                    // different cases to select book entry
                    case "2": BookEntry(); break;
                    case "book entry": BookEntry(); break;
                    case "Book Entry": BookEntry(); break;
                    case "book": BookEntry(); break;
                    case "Book": BookEntry(); break;
                    case "entry": BookEntry(); break;
                    case "Entry": BookEntry(); break;
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
                    Console.WriteLine($"The Library Currently Has {bookCount} books in storage");
                    Console.WriteLine("1). Look at Books in Storage");
                    Console.WriteLine("2). Back to Main Menu");
                    Console.WriteLine();

                    answer1 = Console.ReadLine();

                    if (string.Equals(answer1, "Look at Books in Storage", StringComparison.OrdinalIgnoreCase) || string.Equals(answer1, "Look at Books", StringComparison.OrdinalIgnoreCase) || string.Equals(answer1, "Look", StringComparison.OrdinalIgnoreCase) || answer1 == "1")
                    {
                        Console.Clear();

                        foreach(Book book in books)
                        {
                            Console.WriteLine($"Title: {book.title}");
                            Console.WriteLine($"Category: {book.category}");
                            Console.WriteLine($"Page Count: {book.pageCount}");
                            Console.WriteLine(book.CheckedOutStatus());
                            Console.WriteLine();
                        }

                        Console.WriteLine("Press Enter to go back.");
                        Console.ReadLine();
                        Console.Clear();   
                    }
                    else
                    {
                        Console.WriteLine("Invalid Entry. Try Again");
                        Console.Clear();
                    }

                    if (answer1 == "2" || string.Equals(answer1, "Back", StringComparison.OrdinalIgnoreCase))
                    {
                        state = false;
                        Console.WriteLine("Sending you back to the Main Menu. Press Enter to Continue.");
                    }
                }

                Console.ReadLine();
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
                    Console.WriteLine("Please Select an Option");
                    Console.WriteLine("1). Book Entry");
                    Console.WriteLine("2). Back to the Main Menu");
                    Console.WriteLine();

                    answer2 = Console.ReadLine();

                    if (answer2 == "1" || string.Equals(answer2, "Book", StringComparison.OrdinalIgnoreCase) || string.Equals(answer2, "Book Entry", StringComparison.OrdinalIgnoreCase))
                    {
                        string titleAnswer;
                        string categoryAnswer;
                        int pageAnswer = 1905113515;

                        Console.WriteLine();
                        Console.Write("What is the title of your book?: ");
                        titleAnswer = Console.ReadLine();
                        Console.WriteLine(titleAnswer);
                        
                        // implement a list of categories that can only be chosen from

                        Console.WriteLine();
                        Console.Write("What is the Genre of your book?: ");
                        categoryAnswer = Console.ReadLine();
                        Console.WriteLine();

                        while (state1)
                        {
                            Console.Write("How many pages does your book have?: ");
                            
                            try
                            {
                                pageAnswer = Convert.ToInt32(Console.ReadLine());
                            } 
                            catch (Exception ex)
                            {
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("Invalid Input. Try Again.");
                                pageAnswer = 1905113515;
                            }

                            if (pageAnswer == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("You cannot have Zero Pages");
                            }
                            else if (pageAnswer < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("You cannot have Negative Pages");                         
                            }
                            else if (pageAnswer != 1905113515)
                            {
                                state1 = false;
                            }
                        }
                        state1 = true;

                        bookCount++;
                        Book nBook = new Book(titleAnswer, categoryAnswer, pageAnswer, false);
                        books.Add(nBook);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Entry. Try Again");
                        Console.Clear();
                    }

                    if (answer2 == "2" || string.Equals(answer2, "Back", StringComparison.OrdinalIgnoreCase))
                    {
                        state = false;
                        Console.WriteLine("Sending you back to the Main Menu. Press Enter to Continue.");
                    }
                    Console.ReadLine();
                    Console.Clear();
                }

            }

            void BookCheckout()
            {

            }
        }
    }
}
