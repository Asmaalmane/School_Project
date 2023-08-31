using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace School_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create neccessary objects
            Student newStudent = new Student();
            Teacher newTeacher=new Teacher();
            Executive newExecutive = new Executive();

            List<Student> StudentList = new List<Student>();
            List<Employee> EmployeesList = new List<Employee>();
            List<Grading> CourseList = new List<Grading>();
            

            //the Main courses in the school
            string[] SchoolCourses = new string[5];

            Console.WriteLine("\t\t\t-------------------------------------------------\n");
            Console.WriteLine("\t\t\t\t   MetaWolves Educational system\n");
            Console.WriteLine("\t\t\t-------------------------------------------------\n\n");
            Console.WriteLine("To start the setup, you need to create a manager account");

            Console.WriteLine("\n\t\tSTEP 1\n");
            Console.WriteLine("Please enter the following data:");
            Console.WriteLine("Natinal ID");
            string SSN = Console.ReadLine();
            Console.WriteLine("First Name:");
            string Fname = Console.ReadLine();
            Console.WriteLine("Last Name:");
            string Lname = Console.ReadLine();
            Console.WriteLine("Date of birth:");
            string DOB = Console.ReadLine();
            Console.WriteLine("Gender (M/F):");
            char Gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Salary:");
            decimal salary = decimal.Parse(Console.ReadLine());

            Gender = char.ToUpper(Gender);
            Executive executive = new Executive(Fname, Lname, DOB, Gender, SSN, "manager", salary, "School");
            EmployeesList.Add(executive);

            Console.WriteLine("Your account is Successfully added...");

            Console.Clear();

            Console.WriteLine("\t\t   ---------------------------------------------------------\n");
            Console.WriteLine("\t\t\tWelcome " + Fname + " " + Lname + " to the MetaWolves educational system\n");
            Console.WriteLine("\t\t   ---------------------------------------------------------\n");


            Console.WriteLine("\t\tSTEP 2\n");
            Console.WriteLine("What is the name of the school?");
            string name = Console.ReadLine();
            Console.WriteLine("Where is your location?");
            string location = Console.ReadLine();
            
            Console.WriteLine("How many students are registered in your school so far?");
            int num_of_students = int.Parse(Console.ReadLine());
            for(int j=1;j<=num_of_students;j++)
            {
                Console.WriteLine("Student No. " + j+" :");
                Console.WriteLine("National ID:");
                SSN=Console.ReadLine();
                newStudent = newStudent.StudentRegistration(SSN);
                StudentList.Add(newStudent);
                Console.WriteLine("----------------------");
            }
            
            Console.WriteLine("How many employees are working at your school excluding you?");
            int num_of_employees = int.Parse(Console.ReadLine());
            for(int i=0;i<num_of_employees;i++)
            {
                Console.WriteLine("Employees No. " + j + " :");
                Console.WriteLine("National ID:");
                SSN = Console.ReadLine();
                newStudent = newStudent.StudentRegistration(SSN);
                StudentList.Add(newStudent);
                Console.WriteLine("----------------------");
            }
            
            Console.WriteLine("How many working spaces (rooms) are at your school?");
            int num_of_rooms = int.Parse(Console.ReadLine());

            School school = new School(name, location, num_of_students, num_of_employees, num_of_rooms);
            Console.WriteLine("Your School information is Successfully added to the system...");

            Console.Clear();

            Console.WriteLine("\t\t   ---------------------------------------------------------\n");
            Console.WriteLine("\t\t\tWelcome " + Fname + " " + Lname + " to the MetaWolves educational system\n");
            Console.WriteLine("\t\t   ---------------------------------------------------------\n");

            Console.WriteLine("\t\tSTEP 3\n");
            Console.WriteLine("Please enter 5 course names to the system making sure that each course begins with a capital letter:");
            for (int i = 0; i < SchoolCourses.Length; i++)
            {
                SchoolCourses[i] = Console.ReadLine();
            }

            Console.WriteLine("You have added " + SchoolCourses.Length + " of courses successfully...");

            Console.Clear();


            Console.WriteLine("\t\t-----------------------------------------------------------------\n");
            Console.WriteLine("\t\t\t          Welcome to " + name + " School        \n");
            Console.WriteLine("\t\t\t  supported by the MetaWolves educational system       \n");
            Console.WriteLine("\t\t-----------------------------------------------------------------\n\n");
            Console.WriteLine("Are you a student or an employee?");
            Console.WriteLine("(1) a student");
            Console.WriteLine("(2) an employee\n");

            Console.WriteLine("Your choice is :");
            int choice = int.Parse(Console.ReadLine());

            int choice2 = 0;

            switch (choice)
            {
                case 1:
                    do
                    {
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("What would you like to do:");
                        Console.WriteLine("1. Enroll into this school.");
                        Console.WriteLine("2. Register to a new course.");
                        Console.WriteLine("3. Display my data.");
                        Console.WriteLine("4. Exit.");
                        Console.WriteLine("------------------------------");

                        Console.WriteLine("Your choice is :");
                        choice2 = int.Parse(Console.ReadLine());

                        SSN = null;
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

                                newStudent = newStudent.StudentRegistration(SSN);
                                StudentList.Add(newStudent);
                                school.Num_of_students=+1;
                                Console.WriteLine("You are successfully registered in this school...");
                                Console.WriteLine("Please choose number 2 from the menu to register your course");

                                break;

                            case 2:

                                if (index >= 0)
                                {
                                    //Display the courses
                                    Console.WriteLine("Our courses are:");
                                    for (int j = 0; j < SchoolCourses.Length; j++)
                                        Console.WriteLine(SchoolCourses[j].First() + " --> " + SchoolCourses[j]);

                                    Console.WriteLine("\nPlease enter the letter of the course in which you would like to attend:");
                                    Console.WriteLine("Hint: you can only register to 5 courses in each level and you have to register one course at a time");
                                    char Stcourse = char.Parse(Console.ReadLine());

                                    Stcourse = char.ToUpper(Stcourse);

                                    if (StudentList[index].StudentCourses.Count < 5)
                                    {
                                        for (int i = 0; i < SchoolCourses.Length; i++)
                                        {
                                            if (SchoolCourses[i].First() == Stcourse)
                                            {
                                                StudentList[index].StudentCourses.Add(SchoolCourses[i]);
                                                break;
                                            }

                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("Sorry you can not register more that 5 courses");
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("You are not registered at this school");
                                }

                                break;
                            case 3:
                                for (int i = 0; i < StudentList.Count; i++)
                                {
                                    if (SSN.Equals(StudentList[i].GetSSN()))
                                    {
                                        StudentList[i].Display();
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

        public static int FindTheStudent(List<Student> StudentList, string SSN)
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
