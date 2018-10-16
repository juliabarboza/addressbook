using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _addressbookpg2
{
    class Entries
    {
        //List<string> entries = new List<string>();
        string firstName, lastName, streetName, city,
            state, zipcode;

        
        public void AddEntry()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition((Console.WindowWidth / 2) - 3,
                Console.WindowHeight / 2 - 13);
            Console.WriteLine("ENTRY:");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 6,
                Console.WindowHeight / 2 - 12);
            Console.WriteLine("------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition((Console.WindowWidth / 2) - 4,
                Console.WindowHeight / 2 - 10);
            Console.WriteLine("LAST NAME?"); 
            Console.SetCursorPosition((Console.WindowWidth / 2) ,
                Console.WindowHeight / 2 - 9);
            lastName = Console.ReadLine().ToLower();
          //  entries.Add(lastName);
            Console.SetCursorPosition((Console.WindowWidth / 2) - 5,
                Console.WindowHeight / 2 - 8);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("FIRST NAME");
            Console.SetCursorPosition((Console.WindowWidth / 2) ,
                Console.WindowHeight / 2 - 7 );
            firstName = Console.ReadLine().ToLower();
           // entries.Add(firstName);
            Console.SetCursorPosition((Console.WindowWidth / 2) - 6,
                Console.WindowHeight / 2 - 6);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("STREET NAME?");
            Console.SetCursorPosition((Console.WindowWidth / 2) ,
                Console.WindowHeight / 2 - 5);
            streetName = Console.ReadLine().ToLower();
           // entries.Add(streetName);
            Console.SetCursorPosition((Console.WindowWidth / 2) - 2,
                Console.WindowHeight / 2 - 4);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("CITY?");
            Console.SetCursorPosition((Console.WindowWidth / 2) ,
                Console.WindowHeight / 2 - 3);
            city = Console.ReadLine().ToLower();
          //  entries.Add(city);
            Console.SetCursorPosition((Console.WindowWidth / 2) - 3,
                Console.WindowHeight / 2 - 2);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("STATE?");
            Console.SetCursorPosition((Console.WindowWidth / 2) ,
                Console.WindowHeight / 2 - 1);
            state = Console.ReadLine().ToLower();
         //   entries.Add(state);
            Console.SetCursorPosition((Console.WindowWidth / 2) - 4,
                Console.WindowHeight / 2);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("ZIP CODE?");
            Console.SetCursorPosition((Console.WindowWidth / 2) ,
                Console.WindowHeight / 2 + 1);
            zipcode = Console.ReadLine().ToLower();
          //  entries.Add(zipcode);
            
        }

        public void SetEntries(string last, string first, string street, string _city,
            string _state, string _zip)
        {
            lastName = last;
            firstName = first;
            streetName = street;
            city = _city;
            state = _state;
            zipcode = _zip;

            /*entries.Add(last);
            entries.Add(first);
            entries.Add(street);
            entries.Add(city);
            entries.Add(state);
            entries.Add(zip); */
        }

        public string GetFirst()
        {
            return firstName;

        }
        public string GetLast()
        {
            return lastName;
        }
        public string GetStreet()
        {
            return streetName;
        }
        public string GetCity()
        {
            return city;

        }
        public string GetState()
        {
            return state;
        }
        public string GetZipCode()
        {
            return zipcode;
        }
        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(lastName + ", " + firstName);
            Console.WriteLine(streetName + ", " + city);
            Console.WriteLine(state + ", " + zipcode);
        }





        public void SetFirst(string f)
        {
            firstName = f;
        }
        public void SetLast(string l)
        {
            lastName = l;
        }
        public void SetStreet(string sn)
        {
            streetName = sn;
        }
        public void SetCity(string c)
        {
            city = c;
        }
        public void SetState(string s)
        {
            state = s;
        }
        public void SetZip(string z)
        {
            zipcode = z;
        }
        
    }
}
