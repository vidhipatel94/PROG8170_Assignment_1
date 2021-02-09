using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = GetRectLengthFromUser();
            int width = GetRectWidthFromUser();
            Rectangle rectangle = new Rectangle(length, width);

            // show menu and get option
            int option = GetMenuOptionFromUser();
            while (option != 7)
            {
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Rectangle Length: {0}", rectangle.GetLength());
                        break;
                    case 2:
                        length = GetRectLengthFromUser();
                        rectangle.SetLength(length);
                        Console.WriteLine("New Rectangle Length: {0}", rectangle.GetLength());
                        break;
                    case 3:
                        Console.WriteLine("Rectangle Width: {0}", rectangle.GetWidth());
                        break;
                    case 4:
                        width = GetRectWidthFromUser();
                        rectangle.SetWidth(width);
                        Console.WriteLine("New Rectangle Width: {0}", rectangle.GetWidth());
                        break;
                    case 5:
                        Console.WriteLine("Rectangle Perimeter: {0}", rectangle.GetPerimeter());
                        break;
                    case 6:
                        Console.WriteLine("Rectangle Area: {0}", rectangle.GetArea());
                        break;
                    case 7:
                        return;
                }
                option = GetMenuOptionFromUser();
            }
        }

        private static int GetRectLengthFromUser()
        {
            Console.Write("Please enter length of rectangle: ");
            String lengthStr = Console.ReadLine();
            try
            {
                int length = Int16.Parse(lengthStr);
                if(length > 0)
                {
                    return length;
                } else
                {
                    Console.WriteLine("Length should be more than 0");
                    return GetRectLengthFromUser();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input!");
            }

            return GetRectLengthFromUser();
        }

        private static int GetRectWidthFromUser()
        {
            Console.Write("Please enter width of rectangle: ");
            String widthStr = Console.ReadLine();
            try
            {
                int width = Int16.Parse(widthStr);
                if (width > 0)
                {
                    return width;
                }
                else
                {
                    Console.WriteLine("Width should be more than 0");
                    return GetRectWidthFromUser();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input!");
            }

            return GetRectWidthFromUser();
        }

        private static int GetMenuOptionFromUser()
        {
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("Select one option from below menu:");
            Console.WriteLine("1. Get Rectangle Length");
            Console.WriteLine("2. Change Rectangle Length");
            Console.WriteLine("3. Get Rectangle Width");
            Console.WriteLine("4. Change Rectangle Width");
            Console.WriteLine("5. Get Rectangle Perimeter");
            Console.WriteLine("6. Get Rectangle Area");
            Console.WriteLine("7. Exit");

            Console.Write("\nEnter option number:");
            String optionStr = Console.ReadLine();

            try
            {
                int option = Int16.Parse(optionStr);
                if (option >= 1 && option <= 7)
                {
                    return option;
                }
                else
                {
                    Console.WriteLine("Please select option from 1 to 7");
                    return GetMenuOptionFromUser();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Option!");
            }

            return GetMenuOptionFromUser();
        }
    }
}
