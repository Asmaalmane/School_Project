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
            // create neccessary emplty objects
            Student newStudent = new Student();
            Teacher newTeacher=new Teacher();
            Executive newExecutive = new Executive();
            Employee newEmployee = new Employee();
            Rooms room = new Rooms();
            Course newCourse = new Course();

            //Creating the School Database
            List<Student> StudentList = new List<Student>();
            List<Employee> EmployeesList = new List<Employee>();
            List<Grading> GradingList = new List<Grading>();
            List<Rooms> RoomList = new List<Rooms>();
            List<Course> SchoolCourses = new List<Course>();
            

            //needed variables
            string course;
            Random random = new Random();

            //First step :To Setup and activate the system
            Console.WriteLine("\t\t\t-------------------------------------------------\n");
            Console.WriteLine("\t\t\t\t   MetaWolves Educational system\n");
            Console.WriteLine("\t\t\t-------------------------------------------------\n\n");
            Console.WriteLine("To start the setup, you need to create a manager account");

            //Creating Manager account
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
            char Gender = char.ToUpper(char.Parse(Console.ReadLine()));
            Console.WriteLine("Salary:");
            decimal salary = decimal.Parse(Console.ReadLine());

            Executive executive = new Executive(Fname, Lname, DOB, Gender, SSN, "manager", salary, "School");
            EmployeesList.Add(executive);

            Console.WriteLine("Your account is Successfully added...");

            Console.Clear();
            // the end of the first step


            //Second step: Creating the school object
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
            Console.WriteLine("Please add all the students' data one by one:");
            for(int j=1;j<=num_of_students;j++)
            {
                Console.WriteLine("Student No. " + j+" :");
                Console.WriteLine("National ID:");
                SSN=Console.ReadLine();
                newStudent = newStudent.StudentRegistration(SSN);
                StudentList.Add(newStudent);
                Console.WriteLine("----------------------");
            }
            
            Console.WriteLine("In general, how many employees are working at your school excluding you?");
            int num_of_employees = int.Parse(Console.ReadLine());

            for (int i = 0; i < num_of_employees; i++)
            {
                Console.WriteLine("Employee No. " + i + " :");
                Console.WriteLine("National ID:");
                SSN = Console.ReadLine();
                newEmployee=newEmployee.EmployeeRegistration(SSN);
                EmployeesList.Add(newEmployee);
                Console.WriteLine("----------------------");
            }

            Console.WriteLine("How many working spaces (rooms) are at your school?");
            int num_of_rooms = int.Parse(Console.ReadLine());
            for(int i=0;i<num_of_rooms;i++)
            {
                room = room.RoomsRegisteration();
                RoomList.Add(room); 
            }

            School school = new School(name, location, num_of_students, num_of_employees, num_of_rooms);
            Console.WriteLine("Your School information is Successfully added to the system...");

            Console.Clear();
            //end of second step

            //Third step: inserting the courses into the system
            Console.WriteLine("\t\t   ---------------------------------------------------------\n");
            Console.WriteLine("\t\t\tWelcome " + Fname + " " + Lname + " to the MetaWolves educational system\n");
            Console.WriteLine("\t\t   ---------------------------------------------------------\n");

            Console.WriteLine("\t\tSTEP 3\n");
            Console.WriteLine("Please enter 5 course names to the system making sure that each course begins with a capital letter:(null for empty)");

            for (int i = 0; i < 5; i++)
            {
                string courseName = Console.ReadLine();
                int courseID = random.Next();

                newCourse.SName = courseName;
                newCourse.SID = courseID;
                SchoolCourses.Add(newCourse);
            }

            Console.WriteLine("You have added " + SchoolCourses.Count + " of courses successfully...");

            Console.Clear();
            // end of third step


            //Starting to interact with system
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
                                    DisplayCourses(SchoolCourses);

                                    Console.WriteLine("\nPlease enter the Subject ID of the course in which you would like to attend:");
                                    Console.WriteLine("Hint: you can only register to 5 courses in each level and you have to register one course at a time");
                                    int Stcourse = int.Parse(Console.ReadLine());

                                    if (StudentList[index].StudentCourses.Count < 5)
                                    {
                                        for (int i = 0; i < SchoolCourses.Count; i++)
                                        {
                                            if (SchoolCourses[i].SID == Stcourse)
                                            {
                                                newCourse.SName = SchoolCourses[i].SName;
                                                newCourse.SID = SchoolCourses[i].SID;
                                                StudentList[index].StudentCourses.Add(newCourse);
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

                    } while (choice2 > 0 && choice2 < 4);
                    break;

                case 2:
                    choice = 0;
                    do
                    {
                        /*Menu employee:
                                1- choose the role (teacher, manger)
                                2-dispaly info
                                3-if the choice was manger then other menu let him choose what he want to do 
                                            1-add course
                                            2 _ assign teacher
                                            3 _ assign room 
                                            4_ enter the max number of room*/

                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Please choose your role in this school from the list below:");
                        Console.WriteLine("1.Manager.");
                        Console.WriteLine("2.Executive.");
                        Console.WriteLine("3.Teacher.");
                        Console.WriteLine("4.Exit");
                        Console.WriteLine("------------------------------");

                        Console.WriteLine("Your choice is:");
                        choice = int.Parse(Console.ReadLine());

                        
                        if (choice == 4)
                            break;

                        switch(choice) 
                        {
                            case 1:
                                Console.WriteLine("Enter your National ID:");
                                SSN=Console.ReadLine();
                                for(int i = 0;i<EmployeesList.Count;i++)
                                    if (EmployeesList[i].GetSSN().Equals(SSN) && EmployeesList[i].GetRole().Equals("manager"))
                                    {
                                        Console.WriteLine("What would you like to do:");
                                        Console.WriteLine("1. Assign teacher to course.");
                                        Console.WriteLine("2. Add a course");
                                        Console.WriteLine("3. Delete a course");
                                        Console.WriteLine("4. Assign class room");
                                        Console.WriteLine("5. Display All Employees");
                                        Console.WriteLine("6. Display Teachers");
                                        Console.WriteLine("7. Display Executives");
                                        Console.WriteLine("8. Display Students");
                                        Console.WriteLine("9. Exit");
                                        Console.WriteLine("Your choice is:");
                                        choice2 = int.Parse(Console.ReadLine());

                                        if(choice2 == 1)
                                        {
                                            Console.WriteLine("Enter the Teacher's National ID:");
                                            SSN= Console.ReadLine();
                                            for (int j = 0; j < EmployeesList.Count; j++)
                                            {
                                                if (EmployeesList[j].GetSSN().Equals(SSN) && EmployeesList[j].GetRole().Equals("teacher"))
                                                {
                                                    if (EmployeesList[j].GetRole().Equals(null))
                                                    {
                                                        DisplayCourses(SchoolCourses);
                                                        Console.WriteLine("Enter the the course ID:");
                                                        int CourseID=int.Parse(Console.ReadLine());
                                                        course = FindCourse(SchoolCourses, CourseID);
                                                        newCourse.SID = CourseID;
                                                        newCourse.SName = course;
                                                        newTeacher = newTeacher.AddSubjectToTeacher(EmployeesList[j], newCourse);
                                                        EmployeesList[j] = newTeacher;
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Sorry this teacher is assigned to a course");
                                                        break;
                                                    }
                                                }
                                                
                                            }
                                        }
                                        else if(choice2 == 2)
                                        {
                                            if (SchoolCourses.Count == 5)
                                                Console.WriteLine("Sorry the course list is full");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("Sorry you do not have access to this territory.");
                                    }
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                break;
                            default:
                                Console.WriteLine("Invalid input...please try again");
                                continue;
                        }


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

        public static void DisplayCourses(List<Course> SchoolCourses)
        {
            Console.WriteLine("Our courses are:");
            for (int j = 0; j < SchoolCourses.Count; j++)
                Console.WriteLine(SchoolCourses[j].SID+" --->"+SchoolCourses[j].SName);
        }

        public static string FindCourse(List<Course> SchoolCourses,int CourseID)
        {
            for (int i = 0; i < SchoolCourses.Count; i++)
            {
                if (SchoolCourses[i].SID == CourseID)
                    return SchoolCourses[i].SName;
            }
            return null;
        }
    }
}
