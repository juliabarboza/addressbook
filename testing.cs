using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _addressbookpg2
{
    class testing
    {
        AddressBook testBook = new AddressBook();

        AddressBook testBook2 = new AddressBook();
        AddressBook testBook3 = new AddressBook();

        public void test()
        {
            Entries testE = new Entries();
            testE.SetLast("macaroni");
            testE.SetFirst("talent");
            testE.SetStreet("67 macaroni lane");
            testE.SetCity("pasta");
            testE.SetState("florida");
            testE.SetZip("32817");
            testBook.Add(testE);

            Entries testE2 = new Entries();
            testE2.SetLast("barboza");
            testE2.SetFirst("julia");
            testE2.SetStreet("99 whowhat street");
            testE2.SetCity("swansea");
            testE2.SetState("massachusetts");
            testE2.SetZip("02777");
            testBook.Add(testE2);


            Entries testE3 = new Entries();
            testE3.SetLast("royds");
            testE3.SetFirst("spencer");
            testE3.SetStreet("23 noodle way");
            testE3.SetCity("winter park");
            testE3.SetState("ohio");
            testE3.SetZip("32792");
            testBook.Add(testE3);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ENTRIES (add/show):");
            Console.WriteLine();
            testBook.Display();
            Console.WriteLine();
            Console.WriteLine("oooooooooooooooooooo");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("SORTED (sort):");
            Console.WriteLine();         
            testBook.SortEntries();
            testBook.Remove(testE);
            Console.WriteLine();
            Console.WriteLine("oooooooooooooooooooo");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("REMOVED (remove):");
            Console.WriteLine();
            testBook.Display();
            testBook.Save("test");
            Console.WriteLine();
            Console.WriteLine("oooooooooooooooooooo");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("SAVED AS test (save)");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("oooooooooooooooooooo");
            Console.WriteLine();
            Entries testE4 = new Entries();
            testE4.SetLast("doe");
            testE4.SetFirst("jon");
            testE4.SetStreet("34 whatever street");
            testE4.SetCity("dallas");
            testE4.SetState("texas");
            testE4.SetZip("44792");
            testBook2.Add(testE4);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("NEW ADDRESS BOOK:");
            Console.WriteLine();
            testBook2.Display();
            Console.WriteLine();
            Console.WriteLine("oooooooooooooooooooo");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("test IMPORTED INTO NEW ADRESS BOOK (import):");
            Console.WriteLine();
            testBook2.ImportTest("test");
            testBook2.Display();
            Console.WriteLine();
            Console.WriteLine("oooooooooooooooooooo");
            Console.WriteLine();

            Entries testE5 = new Entries();
            testE5.SetLast("random");
            testE5.SetFirst("man");
            testE5.SetStreet("23 lala land");
            testE5.SetCity("winter park");
            testE5.SetState("florida");
            testE5.SetZip("32809");
            testBook3.Add(testE5);
            testBook3.Save("test2");
            testBook3.openBooktest("test2");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("OPEN ADDRESS BOOK NAMED test2 (open) :");
            Console.WriteLine();
            testBook3.Display();
            Console.ReadLine();







        }
    }
}
