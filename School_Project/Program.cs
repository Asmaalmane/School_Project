using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create the school object that must be intiated by the manager
            School school = new School();
            
            List<Student> StudentList = new List<Student>();
            List<Employee> EmployeesList = new List<Employee>();
            List<Grading> CourseList = new List<Grading>();
            List<String> StudentCourses = new List<string>();

            //the Main courses in the school
            string[] SchoolCourses = new string[5];

            Console.WriteLine("MetaWolves Educational system");
            Console.WriteLine("You need to do a few setups before starting the system");
            Console.WriteLine("First of all, Enter 5 courses to the system");
            for(int i=0; i < SchoolCourses.Length;i++)
            {
                SchoolCourses[i]=Console.ReadLine();
            }

            Console.Clear();


            Console.WriteLine("\t---------------------------------------------------------\n");
            Console.WriteLine("\t|\tWelcome to the MetaWolves educational system\t|\n");
            Console.WriteLine("\t---------------------------------------------------------\n\n");
            Console.WriteLine("Are you a student or an employee?");
            Console.WriteLine("(1) a student");
            Console.WriteLine("(2) an employee\n");

            Console.WriteLine("Your choice is :");
            int choice= int.Parse(Console.ReadLine());

            int choice2 = 0;

            switch(choice)
            {
                case 1:
                    do
                    {
                        Console.WriteLine("What would you like to do:");
                        Console.WriteLine("1. Enroll into this school.");
                        Console.WriteLine("2. Register to a new course.");
                        Console.WriteLine("3. Display my data.");
                        Console.WriteLine("4. Exit.");

                        Console.WriteLine("Your choice is :");
                        choice2 = int.Parse(Console.ReadLine());

                        string SSN=null;
                        int index = -1;

                        if (choice2 < 4)
                        {
                            Console.WriteLine("Please enter your national ID:");
                            SSN = Console.ReadLine();
                            index = FindTheStudent(StudentList, SSN);
                        }

                        switch (choice2)
                        {
                            case 1:

                                if (index >= 0)
                                    {
                                        Console.WriteLine("Your are already a student in this school");
                                        break;
                                    }

                                Console.WriteLine("Please enter the following data:");
                                Console.WriteLine("FirstName:");
                                string Fname = Console.ReadLine();
                                Console.WriteLine("LastName:");
                                string Lname = Console.ReadLine();
                                Console.WriteLine("Date of birth:");
                                string DOB = Console.ReadLine();
                                Console.WriteLine("Level:");
                                int level = int.Parse(Console.ReadLine());
                                Console.WriteLine("Gender (M/F):");
                                char Gender = char.Parse(Console.ReadLine());

                                Student newStudent = new Student(Fname, Lname, DOB, Gender, SSN, level, StudentCourses);
                                //Console.WriteLine("Object is created");
                                StudentList.Add(newStudent);
                                //Console.WriteLine("Object is added");
                                //Console.WriteLine(StudentList.Count);

                                Console.ReadKey();

                                break;
                            
                            case 2:

                                if (index >= 0)
                                {
                                    //Display the courses
                                    Console.WriteLine("Our courses are:");
                                    for (int j = 0; j < SchoolCourses.Length; j++)
                                        Console.WriteLine(SchoolCourses[j].First() +" --> " + SchoolCourses[j]);

                                    Console.WriteLine("\n");

                                    //Console.WriteLine("E --> English");
                                    //Console.WriteLine("M --> Math");
                                    //Console.WriteLine("C --> Computer scinece");
                                    //Console.WriteLine("A --> Art");
                                    //Console.WriteLine("P --> Physics\n");

                                    Console.WriteLine("Which course would you like to assign to?");
                                    Console.WriteLine("Hint: you can only register to 5 courses in each level and you have to register one course at a time");
                                    char Stcourse =char.Parse (Console.ReadLine());

                                    if (StudentList[index].StudentCourses.Count < 5)
                                    {
                                        for (int i = 0; i < SchoolCourses.Length; i++)
                                        {
                                            if (SchoolCourses[i].First()==Stcourse)
                                            {
                                                StudentList[index].StudentCourses.Add(SchoolCourses[i]);
                                                break;
                                            }
                                            
                                        }

                                    }
                                    
                                }
                                
                         
                                break;
                            case 3:
                                for (int i = 0; i < StudentList.Count; i++)
                                {
                                    if (SSN.Equals(StudentList[i].GetSSN()))
                                    {
                                        Console.WriteLine("National ID:" + StudentList[i].GetSSN());
                                        Console.WriteLine("Studnet Name:"+ StudentList[i].GetFName()+ " "+ StudentList[i].GetLName());
                                        Console.WriteLine("Date of birth:" + StudentList[i].GetDOB());
                                        Console.WriteLine("Gender (M/F):" + StudentList[i].GetGender());
                                        Console.WriteLine("Level:" + StudentList[i].GetLevel());
                                        Console.WriteLine("Courses assigned:");
                                        if (StudentList[i].StudentCourses.Count > 0)
                                        {
                                            for (int j = 0; j < StudentList[i].StudentCourses.Count; j++)
                                            {
                                                Console.WriteLine("Course " + (j + 1) + " is " + StudentList[i].StudentCourses[j]);
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("No courses are assigned under this name yet");
                                        }
                                        break;
                                    }
                                }
                                break;
                            case 4:
                                break;
                            default:
                                Console.WriteLine("Invalid input.. Please try again");
                                continue;
                        }
                        
                        if (choice2 == 4)
                            break;

                    } while (choice > 0 && choice < 4);
                    break;
                
                case 2:
                    choice = 0;
                    do
                    {
                        Console.WriteLine();
                        if (choice == 4)
                            break;

                    } while (choice > 0 && choice < 4);
                    break;
                default:
                    break;
            }

        }

        public static int FindTheStudent(List<Student> StudentList,string SSN)
        {
            for (int i = 0; i < StudentList.Count; i++)
            {
                if (SSN.Equals(StudentList[i].GetSSN()))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
