using System;
using System.IO; 
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace recordKeeping
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a console app that uses a list to hold student names. 
            //After adding, write out options: Add another student, Clear out all students, List all students, 
            //show count of students, save to a file, or exit. Create methods for these operations.

            Console.WriteLine("STUDENT NAME DATABASE");
            Console.WriteLine("*********************");
            Console.WriteLine(); //empty line

            //prepare list for data
            List<string> names = new List<string>(); 

            //read file
            StreamReader reader = new StreamReader("..\\..\\studentNames.txt");
            using (reader)
             {
                string line = reader.ReadLine();
                while (line != null)
                {
                    names.Add(line); //add names to List "names"
                    line = reader.ReadLine(); 
                }
             }

            var select = 0; 

            while (select != 7)
            {
                Console.WriteLine("Choose Option (Numerical Value Only)");
                Console.WriteLine(); 
                Console.WriteLine("********************************");
                Console.WriteLine("* 1 - Add Student              *");
                Console.WriteLine("* 2 - Remove Student           *");
                Console.WriteLine("* 3 - Remove All Students      *");
                Console.WriteLine("* 4 - List All Students        *");
                Console.WriteLine("* 5 - Show Student Count       *");
                Console.WriteLine("* 6 - Update Student List File *"); 
                Console.WriteLine("* 7 - Exit                     *");
                Console.WriteLine("********************************"); 
                Console.WriteLine(); //empty line
                select = int.Parse(Console.ReadLine());
                //what happens if a number is not selected, it all goes to hell YOU SHOULD FIX THAT 

                switch (select)
                {
                    case 1: //add student
                        Console.WriteLine("Enter student name:");
                        string newStudent = Console.ReadLine();
                        names.Add(newStudent);
                        Console.WriteLine("Student added succesfully.  Press enter to return to main menu.");
                        Console.ReadLine(); 
                        break;

                    case 2: //remove student
                        Console.WriteLine("Enter name of student to remove:");
                        string removedStudent = Console.ReadLine();
                        if (names.IndexOf(removedStudent) >= 0)
                        {
                            names.Remove(removedStudent);
                            Console.WriteLine("Student removed.  Press enter to return to main menu.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Student not found.  Press enter to return to main menu.");
                            Console.ReadLine();
                            break;
                        }
                        //maybe make way to see if student is on list more than once and remove all instances 
                        break;

                    case 3: //remove all students
                        Console.WriteLine("Do you really want to remove all student names from the list? Y/N");
                        string answer = Console.ReadLine().ToUpper(); 
                        if(answer == "Y")
                        {
                            names.Clear();
                            Console.WriteLine("All students removed.  Press enter to return to main menu.");
                            Console.ReadLine(); 
                        }
                        else
                        {
                            Console.WriteLine("Student names will not be removed.  Press enter to return to main menu.");
                            Console.ReadLine();
                        }
                        break;
                         
                    case 4: //list all students in alphabetical order
                        Console.WriteLine("ALL STUDENTS IN LIST:");
                        names.Sort();
                        if (names.Count > 0)
                        {
                            foreach (string name in names)
                            {
                                Console.WriteLine(name);
                            }
                            Console.WriteLine(); //empty line; 
                            Console.WriteLine("Press enter to return to main menu.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("There are no students in this list.  Press enter to return to main menu.");
                            Console.ReadLine();  
                        }
                        break;

                    case 5: //show count of total students in list
                        Console.WriteLine("There are " + names.Count() + " students in this list.");
                        Console.WriteLine(); //empty line
                        Console.WriteLine("Press enter to return to main menu.");
                        Console.ReadLine(); 
                        break; 

                    case 6: //overwrite file data 
                        Console.WriteLine("This will overwrite all previous file data.  Continue?  Y/N");
                        string yesno = Console.ReadLine().ToUpper();
                        if (yesno == "Y")
                        {
                            OverwriteFile(names);
                            Console.WriteLine("File updated.  Press enter to return to main menu.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("File not saved.  Press enter to return to main menu.");
                            Console.ReadLine(); 
                        }
                        break;

                    case 7: //exits program 
                        break;

                }//end of switch
            }//end of while loop

            Console.WriteLine();  //empty line because reasons

        }//end of main method 

        static void OverwriteFile (List<string> names)
        { //overwrite previous file 
            StreamWriter writer = new StreamWriter("..\\..\\studentNames.txt", false); //overwrite file with new data
            using (writer)
            {
                foreach (string name in names)
                {
                    writer.WriteLine(name);
                }
            }
        }//end of OverwriteFile method


    }
}
