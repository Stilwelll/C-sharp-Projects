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

            Book book1 = new Book("Test1", "Action", 243);
            Book book2 = new Book("Test2", "Adventure", 523);
            Book book3 = new Book("Test3", "Comedy", 103);

            Book[] books = { book1, book2, book3 };

            while (state)
            {
                Console.WriteLine("Welcome to my Primitive Library App.");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Please pick from the options below.");
                Console.WriteLine("1). Check Inventory");
                Console.WriteLine("2). Enter a new book");
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
                }
                

            }

            void InventoryCheck()
            {
                bool state = true;
                string answer1;

                Console.Clear();

                while (state)
                {
                    Console.WriteLine("The Library Currently Has " + bookCount + " books in storage");
                    Console.WriteLine("1). Look at Books in Storage");
                    Console.WriteLine("2). Back to Main Menu");
                    Console.WriteLine();

                    answer1 = Console.ReadLine();

                    if (string.Equals(answer1, "Look at Books in Storage", StringComparison.OrdinalIgnoreCase) || string.Equals(answer1, "Look at Books", StringComparison.OrdinalIgnoreCase) || string.Equals(answer1, "Look", StringComparison.OrdinalIgnoreCase) || answer1 == "1")
                    {
                        Console.Clear();
                        foreach(Book book in books)
                        {
                            Console.WriteLine(book.title);
                            Console.WriteLine(book.category);
                            Console.WriteLine(book.pageCount);
                            Console.WriteLine();
                        }
                        
                        Console.ReadLine();
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

            }

            void BookCheckout()
            {

            }
        }
    }
}
