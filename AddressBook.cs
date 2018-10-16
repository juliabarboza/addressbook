using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _addressbookpg2
{
    class AddressBook
    {
        List<Entries> addressbook = new List<Entries>();
        string saveFile;
        string removeEntryfirst;
        string removeEntrylast;
        string fileResponse;
        bool swap;
        Entries temp;
        string l, f, sn, c, z, s;
        bool duplicatefound;

        public void Display()
        {
            for (int i = 0; i < addressbook.Count; i++)
            {
                
                addressbook[i].Display();
                Console.WriteLine("----------------");
               
            }
        }
        public void Add(Entries e)
        {
            addressbook.Add(e);

        }
        public void Remove(Entries e)
        {
            addressbook.Remove(e);
        }
        public void AddEntry()
        {
            Entries entry = new Entries();
            entry.AddEntry();
            addressbook.Add(entry);
        }
        public void Save(string file)
        {
            StreamWriter txtFile = new StreamWriter("data\\" + file + ".txt");
            
            for (int i = 0; i < addressbook.Count; i++)
            {
                l = addressbook[i].GetLast();
                f = addressbook[i].GetFirst();
                sn = addressbook[i].GetStreet();
                c =addressbook[i].GetCity();
                s = addressbook[i].GetState();
                z = addressbook[i].GetZipCode();

                string e = l + "|" + f + "|" + sn + "|" + c + "|"
                     + s + "|" + z;
                txtFile.WriteLine(e);
            }
            txtFile.Close();
        }
        public void RemoveEntry()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition((Console.WindowWidth / 2) - 11,
                Console.WindowHeight / 2 - 5);
            Console.WriteLine("WHICH ENTRY TO REMOVE?");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 10,
                Console.WindowHeight / 2 - 4);
            Console.WriteLine("--------------------");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 8,
                Console.WindowHeight / 2 - 3);
            Console.WriteLine("ENTER FIRST NAME:");
            Console.SetCursorPosition((Console.WindowWidth / 2),
                Console.WindowHeight / 2 - 2);
            removeEntryfirst = Console.ReadLine();
            Console.SetCursorPosition((Console.WindowWidth / 2) - 7,
                Console.WindowHeight / 2 - 1);
            Console.WriteLine("ENTER LAST NAME:");
            Console.SetCursorPosition((Console.WindowWidth / 2),
                Console.WindowHeight / 2);
            removeEntrylast = Console.ReadLine().ToLower();

            for (int i = addressbook.Count - 1; i >= 0; i--)
            {
                if (addressbook[i].GetFirst() == removeEntryfirst
                    && addressbook[i].GetLast() == removeEntrylast)
                {
                    addressbook.RemoveAt(i);
                    Console.SetCursorPosition((Console.WindowWidth / 2) - 6,
                Console.WindowHeight / 2 + 4);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Entry Removed");
                }
                else
                {
                    Console.SetCursorPosition((Console.WindowWidth / 2) - 6,
                      Console.WindowHeight / 2 + 4);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Entry does not exist.");
                }
            }
        }
        public void SortEntries()
        {
            do
            {
                swap = false;
                for (int i = 0; i < addressbook.Count - 1; i++)
                {
                    if (string.Compare(addressbook[i].GetLast(),
                        addressbook[i + 1].GetLast()) > 0)
                    {
                        temp = addressbook[i];
                        addressbook[i] = addressbook[i + 1];
                        addressbook[i + 1] = temp;
                        swap = true;
                    }
                }
            }
            while (swap == true);
            Display();          
        }

        public void saveBook()
        {
            if (addressbook.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is nothing to save");
                
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("File name?");
                saveFile = Console.ReadLine();
                StreamWriter txtFile = new StreamWriter("data\\" + saveFile + ".txt");
                for (int i = 0; i <addressbook.Count; i++)
                {
                    l = addressbook[i].GetLast();
                    f = addressbook[i].GetFirst();
                    sn = addressbook[i].GetStreet();
                    c = addressbook[i].GetCity();
                    s = addressbook[i].GetState();
                    z = addressbook[i].GetZipCode();

                    string e = l + "|" + f + "|" + sn + "|" + c + "|"
                         + s + "|" + z;
                    txtFile.WriteLine(e);
                 }
                txtFile.Close();
            }
        }
        public void openBook()
        {
            Console.ForegroundColor = ConsoleColor.White;  
            Console.WriteLine("Which File?");
            fileResponse = Console.ReadLine();
            addressbook.Clear();

            StreamReader reader = new StreamReader(@"data\\" + fileResponse + ".txt");
            while (!reader.EndOfStream)
            {

                string linefromfile = reader.ReadLine();
                char[] delimiters = new char[] { '|' };
                string[] split = linefromfile.Split(delimiters);
                Entries x = new Entries();
                x.SetEntries(split[0], split[1], split[2], split[3], split[4], split[5]);
                addressbook.Add(x);

            }

            reader.Close();
        }
        public void openBooktest(string file)
        {
            
            addressbook.Clear();

            StreamReader reader = new StreamReader(@"data\\" + file + ".txt");
            while (!reader.EndOfStream)
            {

                string linefromfile = reader.ReadLine();
                char[] delimiters = new char[] { '|' };
                string[] split = linefromfile.Split(delimiters);
                Entries x = new Entries();
                x.SetEntries(split[0], split[1], split[2], split[3], split[4], split[5]);
                addressbook.Add(x);

            }

            reader.Close();
        }
        public void Import()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Which File?");
            fileResponse = Console.ReadLine();

            StreamReader reader = new StreamReader(@"data\\" + fileResponse + ".txt");
            while (!reader.EndOfStream)
            {

                string linefromfile = reader.ReadLine();
                char[] delimiters = new char[] { '|' };
                string[] split = linefromfile.Split(delimiters);
                Entries E = new Entries();

                duplicatefound = false;
                for (int i = 0; i < addressbook.Count; i++)
                {
                    if (split[0] == addressbook[i].GetLast() && split[1] == addressbook[i].GetFirst())
                    {
                        duplicatefound = true;
                        break;
                    }
                }
                if (duplicatefound == false)
                {
                    E.SetEntries(split[0], split[1], split[2], split[3], split[4], split[5]);
                    addressbook.Add(E);
                }               
            }
            reader.Close();
        }
        public void ImportTest(string file)
        {           

            StreamReader reader = new StreamReader(@"data\\" + file + ".txt");
            while (!reader.EndOfStream)
            {

                string linefromfile = reader.ReadLine();
                char[] delimiters = new char[] { '|' };
                string[] split = linefromfile.Split(delimiters);
                Entries E = new Entries();

                duplicatefound = false;
                for (int i = 0; i < addressbook.Count; i++)
                {
                    if (split[0] == addressbook[i].GetLast() && split[1] == addressbook[i].GetFirst())
                    {
                        duplicatefound = true;
                        break;
                    }
                }
                if (duplicatefound == false)
                {
                    E.SetEntries(split[0], split[1], split[2], split[3], split[4], split[5]);
                    addressbook.Add(E);
                }
            }
            reader.Close();
        }
    }
}
