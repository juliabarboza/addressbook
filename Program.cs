using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _addressbookpg2
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBook book = new AddressBook();
            string response;
            int value;

            while (true)
            {
                while (true)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition((Console.WindowWidth / 2) - 13,
                        Console.WindowHeight / 2 - 10);
                    Console.WriteLine("JULIA'S ADDRESS BOOK PROJECT");
                    Console.SetCursorPosition((Console.WindowWidth / 2) - 16,
                        Console.WindowHeight / 2 - 9);
                    Console.WriteLine("---------------------------------");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition((Console.WindowWidth / 2) - 6,
                        Console.WindowHeight / 2 - 7);
                    Console.WriteLine("1. ADD ENTRY");
                    Console.SetCursorPosition((Console.WindowWidth / 2) - 7,
                        Console.WindowHeight / 2 - 6);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("2. REMOVE ENTRY");
                    Console.SetCursorPosition((Console.WindowWidth / 2) - 10,
                        Console.WindowHeight / 2 - 5);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("3. SORT BY LAST NAME");
                    Console.SetCursorPosition((Console.WindowWidth / 2) - 10,
                        Console.WindowHeight / 2 - 4);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("4. SHOW ADDRESS-BOOK");
                    Console.SetCursorPosition((Console.WindowWidth / 2) - 10,
                        Console.WindowHeight / 2 - 3);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("5. SAVE ADDRESS-BOOK");
                    Console.SetCursorPosition((Console.WindowWidth / 2) - 10,
                        Console.WindowHeight / 2 - 2);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("6. OPEN ADDRESS-BOOK");
                    Console.SetCursorPosition((Console.WindowWidth / 2) - 11,
                        Console.WindowHeight / 2 - 1);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("7. IMPORT ADDRESS-BOOK");
                    Console.SetCursorPosition((Console.WindowWidth / 2) - 2,
                        Console.WindowHeight / 2);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("8. Exit");
                    Console.SetCursorPosition((Console.WindowWidth / 2) - 2,
                        Console.WindowHeight / 2 + 1);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("9. Test");



                    try
                    {
                        response = Console.ReadLine();
                        value = int.Parse(response);

                        if (value < 1 || value > 9)
                            throw new Exception();

                        break;
                    }
                    catch
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition((Console.WindowWidth / 2) - 20,
                        Console.WindowHeight / 2);
                        Console.WriteLine("Please enter a 1, 2, 3, 4, 5, 6, 7, 8, or 9");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }
                if (value == 1)
                {
                    Console.Clear();
                    book.AddEntry();
                    Console.ReadLine();
                }
                if (value == 2)
                {
                    Console.Clear();
                    book.RemoveEntry();
                    Console.ReadLine();
                }
                if (value == 3)
                {
                    Console.Clear();
                    book.SortEntries();
                    Console.ReadLine();
                }
                if (value == 4)
                {
                    Console.Clear();
                    book.Display();
                    Console.ReadLine();
                }
                if (value == 5)
                {
                    Console.Clear();
                    book.saveBook();
                    Console.ReadLine();
                }
                if (value == 6)
                {
                    Console.Clear();
                    book.openBook();
                    Console.ReadLine();
                }
                if (value == 7)
                {
                    Console.Clear();
                    book.Import();
                    Console.ReadLine();
                }
                if (value == 8)
                {
                    Environment.Exit(0);
                }
                if (value == 9)
                {
                    testing test = new testing();
                    test.test();

                }
            }

        }
    }
}
