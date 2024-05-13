namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string day;
            int result;

            Console.Write("What Day of the Week is it?: ");
            day = Console.ReadLine();
            
            result = DayNumber(day);

            if (result == -1)
            {
                Console.WriteLine();
                Console.WriteLine("You Did Not Enter a Valid Day");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("You have survived " + result + " day(s) of torture, congratulations!");
            }
            

            Console.ReadLine();
        }

        static int DayNumber(string day)
        {
            int result = -1;
            switch (day)
            {
                case "sunday":
                    result = 0;
                    break;

                case "monday":
                    result = 1;
                    break;

                case "tuesday":
                    result = 2;
                    break;

                case "wednesday":
                    result = 3;
                    break;

                case "thursday":
                    result = 4;
                    break;

                case "friday":
                    result = 5;
                    break;

                case "saturday":
                    result = 6;
                    break;
            }

            return result;
        }
    }
}
