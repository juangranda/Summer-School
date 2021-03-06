﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SummerSchool
{
    class Program
    {
        static double[] StudentFees = new double[15];
        static string[] Students = new string[15];
        static int GetNextAvailableSpot() // finds next available spot in student array
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i] == null)
                {
                    return i;
                }
            }
            return -1;
        } 
        static int StudentCount() ////Counts enrolled students
        {
            int Count = 0;
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i] != null)
                {
                    Count++;
                }
            }
            return Count;
        } 
        static string Menu() //// MENU
        {
            string MenuChoice = "0";
            if (StudentCount() == 0)
            {
                Console.Clear();
                Console.WriteLine("MAIN MENU\n");
                Console.WriteLine("1. Enroll Student");
                Console.WriteLine("3. Print out the list of enrolled students");
                Console.WriteLine("4. Exit\n");
                Console.WriteLine("ENTER A NUMBER THAT CORRESPONDS TO YOUR CHOICE IN THE MENU:\n");
                MenuChoice = Console.ReadLine();
            }
            else if (StudentCount() > 14)
            {
                Console.Clear();
                Console.WriteLine("MAIN MENU\n");
                Console.WriteLine("2. Unenroll Student");
                Console.WriteLine("3. Print out the list of enrolled students");
                Console.WriteLine("4. Exit\n");
                Console.WriteLine("ENTER A NUMBER THAT CORRESPONDS TO YOUR CHOICE IN THE MENU:\n");
                MenuChoice = Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("MAIN MENU\n");
                Console.WriteLine("1. Enroll Student");
                Console.WriteLine("2. Unenroll Student");
                Console.WriteLine("3. Print out the list of enrolled students");
                Console.WriteLine("4. Exit\n");
                Console.WriteLine("ENTER A NUMBER THAT CORRESPONDS TO YOUR CHOICE IN THE MENU:\n");
                MenuChoice = Console.ReadLine();
            }
            return MenuChoice;
        } 
        static void Enroll() // enroll a student
        {
            if (StudentCount() < 15)
            {
                double fee = 200;
                Console.WriteLine(" ");
                Console.WriteLine("Please enter the name of the student you want to enroll\n");
                string newStudent = Console.ReadLine();
                string[] splitNames = newStudent.Split(' ');
                string firstName = splitNames[0];
                string lastName = splitNames[splitNames.Length - 1];

                int spot = GetNextAvailableSpot();
                if ((newStudent.ToLower()).Contains("malfoy"))
                {
                    Console.WriteLine("                   ****** ERROR ******                   ");
                    Console.WriteLine();
                    Console.WriteLine("Students with the last name Malfoy are not to be admitted\n");
                    Console.WriteLine("Press any key to get back to the Main Menu");
                }
                //Checks for Last name Potter
                else if (newStudent.Contains("Potter"))
                {
                    Students[spot] = newStudent;
                    StudentFees[spot] = fee * 0.5; //CalculateEnrollmentCost(newStudent);
                    Console.WriteLine(Students[spot] + " is now enrolled and will need to pay £" + (fee * 0.5));
                    Console.WriteLine("\nPress any key to get back to the Main Menu");
                }
                //Starts checking for Tom, Riddle, Voldemort and displaying Red Alert message
                else if (lastName.ToLower() == "tom" || firstName.ToLower() == "tom")
                {
                    Students[spot] = newStudent;
                    StudentFees[spot] = fee;
                    Console.WriteLine("RED ALERT!!! HE WHO MUST NOT BE NAMED!!!\n");
                    Console.WriteLine("Press any key to get back to the Main Menu");
                }
                else if (lastName.ToLower() == "riddle" || firstName.ToLower() == "riddle")
                {
                    Students[spot] = newStudent;
                    StudentFees[spot] = fee;
                    Console.WriteLine("RED ALERT!!! HE WHO MUST NOT BE NAMED!!!\n");
                    Console.WriteLine("Press any key to get back to the Main Menu");
                }
                else if (lastName.ToLower() == "voldemort" || firstName.ToLower() == "voldemort")
                {
                    Students[spot] = newStudent;
                    StudentFees[spot] = fee;
                    Console.WriteLine("RED ALERT!!! HE WHO MUST NOT BE NAMED!!!\n");
                    Console.WriteLine("Press any key to get back to the Main Menu");
                }
                //Checks for Longbottom discount if less than 10 students are enrolled
                else if ((newStudent.ToLower()).Contains("longbottom"))
                {
                    if (StudentCount() < 10)
                    {
                        Students[spot] = newStudent;
                        StudentFees[spot] = fee * 0;
                        Console.WriteLine(Students[spot] + " is now enrolled and will need to pay £" + (fee * 0));
                        Console.WriteLine("Press any key to get back to the Main Menu");
                    }
                    else
                    {
                        Students[spot] = newStudent;
                        StudentFees[spot] = fee;
                        Console.WriteLine(Students[spot] + " is now enrolled and will need to pay £" + fee);
                        Console.WriteLine("Press any key to get back to the Main Menu");
                    }

                    // Starts checking for students with same last names as English National Quidditch Team
                }
                else if (newStudent.Contains("Frisby"))
                {
                    Students[spot] = newStudent;
                    StudentFees[spot] = fee * 0.7;
                    Console.WriteLine(Students[spot] + " is now enrolled and will need to pay £" + fee * 0.7);
                    Console.WriteLine("\nPress any key to get back to the Main Menu");
                }
                else if (newStudent.Contains("Choudry"))
                {
                    Students[spot] = newStudent;
                    StudentFees[spot] = fee * 0.7;
                    Console.WriteLine(Students[spot] + " is now enrolled and will need to pay £" + fee * 0.7);
                    Console.WriteLine("\nPress any key to get back to the Main Menu");
                }
                else if (newStudent.Contains("Withey"))
                {
                    Students[spot] = newStudent;
                    StudentFees[spot] = fee * 0.7;
                    Console.WriteLine(Students[spot] + " is now enrolled and will need to pay £" + fee * 0.7);
                    Console.WriteLine("\nPress any key to get back to the Main Menu");
                }
                else if (newStudent.Contains("Flitney"))
                {
                    Students[spot] = newStudent;
                    StudentFees[spot] = fee * 0.7;
                    Console.WriteLine(Students[spot] + " is now enrolled and will need to pay £" + fee * 0.7);
                    Console.WriteLine("\nPress any key to get back to the Main Menu");
                }
                else if (newStudent.Contains("Avery"))
                {
                    Students[spot] = newStudent;
                    StudentFees[spot] = fee * 0.7;
                    Console.WriteLine(Students[spot] + " is now enrolled and will need to pay £" + fee * 0.7);
                    Console.WriteLine("\nPress any key to get back to the Main Menu");
                }
                else if (newStudent.Contains("Vosper"))
                {
                    Students[spot] = newStudent;
                    StudentFees[spot] = fee * 0.7;
                    Console.WriteLine(Students[spot] + " is now enrolled and will need to pay £" + fee * 0.7);
                    Console.WriteLine("\nPress any key to get back to the Main Menu");
                }
                else if (newStudent.Contains("Parkin"))
                {
                    Students[spot] = newStudent;
                    StudentFees[spot] = fee * 0.7;
                    Console.WriteLine(Students[spot] + " is now enrolled and will need to pay £" + fee * 0.7);
                    Console.WriteLine("\nPress any key to get back to the Main Menu");
                }
                //Checks for matching first letters in last name and first name.
                else if (firstName.ToLower()[0] == lastName.ToLower()[0])
                //else if (FirstLetterFirstName() == FisrtCharLastName()) // tried to use this method but didn't work
                {
                    Students[spot] = newStudent;
                    StudentFees[spot] = fee * 0.9;
                    Console.WriteLine(Students[spot] + " is now enrolled and will need to pay £" + fee * 0.9);
                    Console.WriteLine("Press any key to get back to the Main Menu");
                }

                else
                {
                    Students[spot] = newStudent;
                    StudentFees[spot] = fee;
                    Console.WriteLine(Students[spot] + " is now enrolled and will need to pay £" + fee);
                    Console.WriteLine("Press any key to get back to the Main Menu");
                }
            }
            else
            {
                Console.WriteLine("\nStudent admission is closed");
                Console.WriteLine("\nPress any key to get back to the Main Menu");
            }
        } 
        static void Unenroll()  // unenroll a student
        {
            if (StudentCount() > 0)
            {
                PrintStudentList();
                Console.WriteLine("\nPlease enter the number that corresponds to the student you want to unenroll\n");
                int studentNumber = Convert.ToInt32(Console.ReadLine());
                studentNumber = studentNumber - 1;
                Console.WriteLine(Students[studentNumber] + " has been unenrolled");
                Students[studentNumber] = null;
                StudentFees[studentNumber] = 0;
                Console.WriteLine("Press any key to get back to the Main Menu");
            }
            else
            {
                Console.WriteLine("\n*** Invalid Choice ***\n");
                Console.WriteLine("Please select options from the menu. (Valid choices are 1, 3, 4)\n");
                Console.WriteLine("Press any key to get back to the Main Menu");
            }
        } 
        static char FirstLetterFirstName() //Pulls the first letter in name //Not being used
        {
            char firstLetter = 'a';
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i] != null)
                {
                    string SpotName = Students[i];
                    firstLetter = SpotName[0];
                }
            }
            return firstLetter;
        }
        static int SpaceIndex() //pulls index of "space" in a name // Not being used
        {
            int space = 0;
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i] != null)
                {
                    string SpotName = Students[i];
                    space = SpotName.IndexOf(" ");
                }
            }
            return space;
        }
        static char FisrtCharLastName() // pulls first letter in last name // Not being used
        {
            char firstLetterLastName = 'a';
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i] != null)
                {
                    string SpotName = Students[i];
                    firstLetterLastName = SpotName[SpaceIndex()+1];
                }
            }
            return firstLetterLastName;

        }
        static void PrintStudentList() //prints List of Students
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ENROLLED STUDENTS");
            Console.ResetColor();
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i] != null)
                    if (StudentFees[i] < 200)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(i + 1 + ". " + Students[i] + " (£" + StudentFees[i] + ")");
                        Console.ResetColor();
                        Console.WriteLine();
                    }
                else
                {
                        Console.WriteLine();
                        Console.WriteLine(i + 1 + ". " + Students[i] + " (£" + StudentFees[i] + ")");
                }
            }
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Total: £" + FeesTotal());
            Console.ResetColor();
           // Console.WriteLine("\nPress any key to get back to the Main Menu");
        }
        static double FeesTotal()//Gets Total
        {
            double totalFirst5 = StudentFees[0] + StudentFees[1] + StudentFees[2] + StudentFees[3] + StudentFees[4];
            double totalMid5 = StudentFees[5] + StudentFees[6] + StudentFees[7] + StudentFees[8] + StudentFees[9];
            double totalLast5 = StudentFees[10] + StudentFees[11] + StudentFees[12] + StudentFees[13] + StudentFees[14];
            double total = totalFirst5 + totalMid5 + totalLast5;
            return total;
        }
        static void Main(string[] args)
        {
            string Choice = "0";
            while (Choice != "4")
            {
                Choice = Menu();
                if (Choice == "1")
                {
                    Enroll();
                }
                else if (Choice == "2")
                {
                    Unenroll();
                }
                else if (Choice == "3")
                {
                    PrintStudentList();
                }
          
                //Invalid menu choice message
                else if (!(Choice == "1" || Choice == "2" || Choice == "3" || Choice == "4"))
                {
                    Console.WriteLine("\n*** Invalid Choice ***\n");
                    Console.WriteLine("Please select options from the menu. (Valid choices are 1, 2, 3, 4)\n");
                    Console.WriteLine("Press any key to get back to the Main Menu");
                }
                //exit
                else
                {
                    Console.WriteLine("\nThank you for using the Enrollment System\n");
                    Console.WriteLine("Press any key to exit");
                }
                Console.ReadKey();
            }
        }
    }
}


