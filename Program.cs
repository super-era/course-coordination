using System;
using System.Collections.Generic;

namespace rollcall
{
    class Program
    {
        static void Main(string[] args)
        {
            // title
            Console.WriteLine("~ Rollcall ~");
            Console.WriteLine("making course coordination easy");
            Console.WriteLine();

            // setting up list for full student enrollment at the university

            var students = new List<string>{"Hannah Abbott", "Katie Bell", "Terry Boot", "Michael Corner", "Hermione Granger", "Neville Longbottom", "Luna Lovegood", "Ernest Macmillan", "Penelope Padgett", "Zacharias Smith"};

            // list of all courses available

            var courses = new List<string>{"An Introduction to Magical Thinking and Problem Solving", "Sixth-Degree Transfiguration Principles", "Advanced Magizoological Biology", "Effective Herbological Research Methods", "Extended Proofs in Arithmancy", "Pathophysiology of Common Magical Maladies", "Efficacy and Consistency of Wizarding Policy Development"};

            // list of students in "An Introduction to Magical Thinking and Problem Solving"
            
            var course1 = new List<string>{"1", "An Introduction to Magical Thinking and Problem Solving", "Hannah Abbott", "Katie Bell", "Terry Boot", "Hermione Granger", "Neville Longbottom", "Ernest Macmillan", "Penelope Padgett", "Zacharias Smith"};

            // list of students in "Sixth-Degree Transfiguration Principles"

            var course2 = new List<string>{"2", "Sixth-Degree Transfiguration Principles", "Katie Bell", "Terry Boot", "Michael Corner", "Hermione Granger", "Neville Longbottom", "Luna Lovegood", "Ernest Macmillan"};

            // list of students in "Advanced Magizoological Biology"

            var course3 = new List<string>{"3", "Advanced Magizoological Biology", "Hannah Abbott", "Michael Corner", "Hermione Granger", "Luna Lovegood", "Penelope Padgett"};

            // list of students in "Effective Herbological Research Methods"
            
            var course4 = new List<string>{"4", "Effective Herbological Research Methods", "Michael Corner", "Hermione Granger", "Neville Longbottom"};

            // list of students in "Extended Proofs in Arithmancy"

            var course5 = new List<string>{"5", "Extended Proofs in Arithmancy", "Terry Boot", "Michael Corner", "Hermione Granger", "Zacharias Smith"};

            // list of students in "Pathophysiology of Common Magical Maladies"

            var course6 = new List<string>{"6", "Pathophysiology of Common Magical Maladies", "Hannah Abbott", "Katie Bell", "Hermione Granger", "Luna Lovegood", "Ernest Macmillan"};

            // list of students in "Efficacy and Consistency of Wizarding Policy Development"

            var course7 = new List<string>{"7", "Efficacy and Consistency of Wizarding Policy Development", "Terry Boot", "Hermione Granger", "Zacharias Smith"};

            // list of lists of the courses and the students in them

            var coursesAndStudents = new List<List<string>>();

            // adding the lists to the "list of lists"

            coursesAndStudents.Add(course1);
            coursesAndStudents.Add(course2);
            coursesAndStudents.Add(course3);
            coursesAndStudents.Add(course4);
            coursesAndStudents.Add(course5);            
            coursesAndStudents.Add(course6);
            coursesAndStudents.Add(course7);
            
            // list of courses Hannah Abbott is doing

            var student1 = new List<string>{"Hannah", "Abbott", "An Introduction to Magical Thinking and Problem Solving", "Advanced Magizoological Biology", "Pathophysiology of Common Magical Maladies"};

            // list of courses Katie Bell is doing
            
            var student2 = new List<string>{"Katie", "Bell", "An Introduction to Magical Thinking and Problem Solving", "Sixth-Degree Transfiguration Principles", "Pathophysiology of Common Magical Maladies"};

            // list of courses Terry Boot is doing

            var student3 = new List<string>{"Terry", "Boot", "An Introduction to Magical Thinking and Problem Solving", "Sixth-Degree Transfiguration Principles", "Extended Proofs in Arithmancy", "Efficacy and Consistency of Wizarding Policy Development"};
            
            // list of courses Michael Corner is doing
            
            var student4 = new List<string>{"Michael", "Corner", "Sixth-Degree Transfiguration Principles", "Advanced Magizoological Biology", "Effective Herbological Research Methods", "Extended Proofs in Arithmancy"};

            // list of courses Hermione Granger is doing
            
            var student5 = new List<string>{"Hermione", "Granger", "An Introduction to Magical Thinking and Problem Solving", "Sixth-Degree Transfiguration Principles", "Advanced Magizoological Biology", "Effective Herbological Research Methods", "Extended Proofs in Arithmancy", "Pathophysiology of Common Magical Maladies", "Efficacy and Consistency of Wizarding Policy Development"};

            // list of courses Neville Longbottom is doing
            
            var student6 = new List<string>{"Neville", "Longbottom", "An Introduction to Magical Thinking and Problem Solving", "Sixth-Degree Transfiguration Principles", "Effective Herbological Research Methods"};

            // list of courses Luna Lovegood is doing
            
            var student7 = new List<string>{"Luna", "Lovegood", "Sixth-Degree Transfiguration Principles", "Advanced Magizoological Biology", "Pathophysiology of Common Magical Maladies"};

            // list of courses Ernest Macmillan is doing
            
            var student8 = new List<string>{"Ernest", "Macmillan", "An Introduction to Magical Thinking and Problem Solving", "Sixth-Degree Transfiguration Principles", "Pathophysiology of Common Magical Maladies"};

            // list of courses Penelope Padgett is doing
            
            var student9 = new List<string>{"Penelope", "Padgett", "An Introduction to Magical Thinking and Problem Solving", "Advanced Magizoological Biology"};

            // list of courses Zacharias Smith is doing
            
            var student10 = new List<string>{"Zacharias", "Smith", "An Introduction to Magical Thinking and Problem Solving", "Extended Proofs in Arithmancy", "Efficacy and Consistency of Wizarding Policy Development"};

            // list of lists of the student's names and the courses they are doing

            var studentsAndCourses = new List<List<string>>();

            // adding the lists to the "list of lists"

            studentsAndCourses.Add(student1);
            studentsAndCourses.Add(student2);
            studentsAndCourses.Add(student3);
            studentsAndCourses.Add(student4);
            studentsAndCourses.Add(student5);            
            studentsAndCourses.Add(student6);
            studentsAndCourses.Add(student7);
            studentsAndCourses.Add(student8);
            studentsAndCourses.Add(student9);
            studentsAndCourses.Add(student10);

            // setting up a program that keeps going unless the user wants to close it

            while (true)
            {
                // getting the user to pick an action in relation to course coordination
                
                Console.WriteLine();
                Console.WriteLine("Enter the number of the action you would like to complete.");
                Console.WriteLine();
                Console.WriteLine("1. View all students currently enrolled at the University");
                Console.WriteLine("2. View all courses on offer at the University");
                Console.WriteLine("3. View a student's enrolled courses");
                Console.WriteLine("4. View course enrollment lists");
                Console.WriteLine("5. Add an existing student to a course");
                Console.WriteLine("6. Remove an existing student from a course");
                Console.WriteLine("7. Add a student to the University");
                // Console.WriteLine("8. Remove a student from the University");
                Console.WriteLine("~~~");
                Console.WriteLine("X. Exit program");

                var actionSelection = Console.ReadLine().Trim();

                if (actionSelection == "x" || actionSelection == "X")
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }

                switch (actionSelection)
                {
                    case "1":
                        Console.WriteLine("~~Students enrolled at the University~~");
                        foreach (string v in students)
                        {
                            Console.WriteLine(v);
                        }
                        Console.WriteLine();
                        break;

                    case "2":
                        Console.WriteLine("~~Courses on offer at the University~~");
                        foreach (string v in courses)
                        {
                            Console.WriteLine(v);
                        }
                        Console.WriteLine();
                        break;
                        
                    case "3":

                        // getting the user to input the name they want to search for

                        // setting up a loop

                        while (true)
                        {

                            Console.WriteLine("Enter the student's first name below. Please use the correct case.");
                            var firstNameInput = Console.ReadLine().Trim();

                            Console.WriteLine("Enter the student's surname below. Please use the correct case.");
                            var lastNameInput = Console.ReadLine().Trim();

                            foreach (var courseList in studentsAndCourses)
                            {
                                // take user input of first name and check if the input matches the first item in the list
                                
                                var firstNameRecord = courseList[0];
                                if (firstNameInput == firstNameRecord)
                                {
                                    // if it does, check second item of list to see if the user input matches the surname
                                    
                                    var lastNameRecord = courseList[1];
                                    if (lastNameInput == lastNameRecord)
                                    {
                                        // if it does, writeline the courses that the students are in (that is, the courses that follow the first two items in the list)

                                        for (var i = 2; i < courseList.Count; i++)
                                        {
                                            Console.WriteLine(courseList[i]);
                                        }
                                        break;

                                    }
                                }
                            }

                            // asking the user if they want to search another student's name

                            Console.WriteLine();
                            Console.WriteLine("How do you want to proceed?");
                            Console.WriteLine();
                            Console.WriteLine("1: Perform another student search");
                            Console.WriteLine("X. Exit to previous menu");

                            var menuSelection = Console.ReadLine().Trim();
                            Console.WriteLine();

                            if (menuSelection == "x" || menuSelection == "X")
                            {
                                break;
                            }
                        }
                        break;

                    case "4":

                        // seeing individual course enrollment lists

                        // using a while loop to keep this second menu open until the user wants to return to the previous menu

                        while (true)
                        {
                            // getting the user to pick which course they want to view enrollment for

                            Console.WriteLine();
                            Console.WriteLine("Enter the number of the course you'd like to view the course enrollment list for.");
                            Console.WriteLine();
                            Console.WriteLine("1. An Introduction to Magical Thinking and Problem Solving");
                            Console.WriteLine("2. Sixth-Degree Transfiguration Principles");
                            Console.WriteLine("3. Advanced Magizoological Biology");
                            Console.WriteLine("4. Effective Herbological Research Methods");
                            Console.WriteLine("5. Extended Proofs in Arithmancy");
                            Console.WriteLine("6. Pathophysiology of Common Magical Maladies");
                            Console.WriteLine("7. Efficacy and Consistency of Wizarding Policy Development");
                            Console.WriteLine("~~~");
                            Console.WriteLine("8. Exit to previous menu");

                            // exit to first menu

                            var courseSelection = Console.ReadLine().Trim();
                            Console.WriteLine();

                            if (courseSelection == "8")
                            {
                                break;
                            }

                            // search list of enrollment lists for the student enrollment list you want

                            foreach (var studentList in coursesAndStudents)
                            {
                                // take user input of number representing course and look for a 
                                // course enrollment list whose first item matches the user input

                                var courseListName = studentList[0];
                                if (courseSelection == courseListName)
                                {
                                    // if a list's first item matches the user input, writeline the rest of
                                    // that list (i.e. course title and students in that course)


                                    // print out name of course
                                    Console.WriteLine("~~" + studentList[1] + "~~");

                                    // printing out students on course
                                    for (var j = 2; j < studentList.Count; j++)
                                    {
                                        Console.WriteLine(studentList[j]);
                                    }
                                    break;
                                }
                            }
                        }
                        break;
                    
                    case "5":

                        // getting the user to input the name of the student they want to enroll in a course

                        Console.WriteLine("Enter the student's first name below. Please use the correct case.");
                        var firstNameExistingStudentInputEnroll = Console.ReadLine().Trim();

                        Console.WriteLine("Enter the student's surname below. Please use the correct case.");
                        var lastNameExistingStudentInputEnroll = Console.ReadLine().Trim();

                        var fullStudentNameEnroll = firstNameExistingStudentInputEnroll + " " + lastNameExistingStudentInputEnroll;

                        // showing the user what courses the student is already enrolled in

                        foreach (var courseList in studentsAndCourses)
                        {
                            // take user input of first name and check if the input matches the first item in the list
                            
                            var firstNameRecordEnroll = courseList[0];
                            if (firstNameExistingStudentInputEnroll == firstNameRecordEnroll)
                            {
                                // if it does, check second item of list to see if the user input matches the surname
                                
                                var lastNameRecordEnroll = courseList[1];
                                if (lastNameExistingStudentInputEnroll == lastNameRecordEnroll)
                                {       
                                    Console.WriteLine();
                                    Console.WriteLine($"{fullStudentNameEnroll} is currently enrolled in:");

                                    // if it does, writeline the courses that the students are in (that is, the courses that follow the first two items in the list)

                                    for (var i = 2; i < courseList.Count; i++)
                                    {
                                        Console.WriteLine(courseList[i]);
                                    }
                                    break;

                                }
                            }
                        }

                        // getting the user to input the number of the course they want to enroll the student above in

                        Console.WriteLine();
                        Console.WriteLine("Enter the number of the course you'd like to enroll the student in.");
                        Console.WriteLine();
                        Console.WriteLine("1. An Introduction to Magical Thinking and Problem Solving");
                        Console.WriteLine("2. Sixth-Degree Transfiguration Principles");
                        Console.WriteLine("3. Advanced Magizoological Biology");
                        Console.WriteLine("4. Effective Herbological Research Methods");
                        Console.WriteLine("5. Extended Proofs in Arithmancy");
                        Console.WriteLine("6. Pathophysiology of Common Magical Maladies");
                        Console.WriteLine("7. Efficacy and Consistency of Wizarding Policy Development");
                        Console.WriteLine("~~~");
                        Console.WriteLine("8. Exit to previous menu");

                        var courseIdInputEnroll = Console.ReadLine().Trim();
                        Console.WriteLine();

                        foreach (var courseList in studentsAndCourses)
                        {
                            // take user input of first name and check if the input matches the first item in the list
                            
                            var firstNameExistingStudentRecordEnroll = courseList[0];
                            if (firstNameExistingStudentInputEnroll == firstNameExistingStudentRecordEnroll)
                            {
                                // if it does, check second item of list to see if the user input matches the surname
                                
                                var lastNameExistingStudentRecordEnroll = courseList[1];
                                if (lastNameExistingStudentInputEnroll == lastNameExistingStudentRecordEnroll)
                                {   

                                    foreach (var studentList in coursesAndStudents)
                                    {
                                        var courseIdEnroll = studentList[0];
                                        if (courseIdInputEnroll == courseIdEnroll)
                                        {
                                            // assigning the student's name to the course roll and
                                            // the course name to the student's course list

                                            var courseNameToEnrollStudentOn = studentList[1];
                                            courseList.Add(courseNameToEnrollStudentOn);
                                            studentList.Add(fullStudentNameEnroll);
                                        
                                        }
                                    }
                                }
                            }
                        }

                        // showing the user what courses the student is now enrolled in

                        foreach (var courseList in studentsAndCourses)
                        {
                            // take user input of first name and check if the input matches the first item in the list
                            
                            var firstNameRecordEnroll = courseList[0];
                            if (firstNameExistingStudentInputEnroll == firstNameRecordEnroll)
                            {
                                // if it does, check second item of list to see if the user input matches the surname
                                
                                var lastNameRecordEnroll = courseList[1];
                                if (lastNameExistingStudentInputEnroll == lastNameRecordEnroll)
                                {       
                                    Console.WriteLine();
                                    Console.WriteLine($"{fullStudentNameEnroll} is currently enrolled in:");

                                    // if it does, writeline the courses that the students are in (that is, the courses that follow the first two items in the list)

                                    for (var i = 2; i < courseList.Count; i++)
                                    {
                                        Console.WriteLine(courseList[i]);
                                    }
                                    break;

                                }
                            }
                        }
                        break;
                    
                    case "6":

                        // removing an existing student from a course
                        // similar to case 5

                        // getting the user to enter the name of the student they want to unenrol from a course

                        Console.WriteLine("Enter the student's first name below. Please use the correct case.");
                        var firstNameExistingStudentInputUnenroll = Console.ReadLine().Trim();

                        Console.WriteLine("Enter the student's surname below. Please use the correct case.");
                        var lastNameExistingStudentInputUnenroll = Console.ReadLine().Trim();

                        var fullStudentNameUnenroll = firstNameExistingStudentInputUnenroll + " " + lastNameExistingStudentInputUnenroll;

                        // need to show the user the courses that the student is doing so that they can be unenrolled from one of these courses

                        foreach (var courseList in studentsAndCourses)
                        {
                            // take user input of first name and check if the input matches the first item in the list
                            
                            var firstNameRecordUnenroll = courseList[0];
                            if (firstNameExistingStudentInputUnenroll == firstNameRecordUnenroll)
                            {
                                // if it does, check second item of list to see if the user input matches the surname
                                
                                var lastNameRecordUnenroll = courseList[1];
                                if (lastNameExistingStudentInputUnenroll == lastNameRecordUnenroll)
                                {   
                                    Console.WriteLine();    
                                    Console.WriteLine($"{fullStudentNameUnenroll} is currently enrolled in:");

                                    // if it does, writeline the courses that the students are in (that is, the courses that follow the first two items in the list)

                                    for (var i = 2; i < courseList.Count; i++)
                                    {
                                        Console.WriteLine(courseList[i]);
                                    }
                                    break;

                                }
                            }
                        }

                        // getting the user to input the number of the course they want to unenroll the student above from

                        Console.WriteLine();
                        Console.WriteLine("Enter the number of the course you'd like to unenrol the student from.");
                        Console.WriteLine();
                        Console.WriteLine("1. An Introduction to Magical Thinking and Problem Solving");
                        Console.WriteLine("2. Sixth-Degree Transfiguration Principles");
                        Console.WriteLine("3. Advanced Magizoological Biology");
                        Console.WriteLine("4. Effective Herbological Research Methods");
                        Console.WriteLine("5. Extended Proofs in Arithmancy");
                        Console.WriteLine("6. Pathophysiology of Common Magical Maladies");
                        Console.WriteLine("7. Efficacy and Consistency of Wizarding Policy Development");
                        Console.WriteLine("~~~");
                        Console.WriteLine("8. Exit to previous menu");

                        var courseIdInputUnenroll = Console.ReadLine().Trim();
                        Console.WriteLine();

                        foreach (var courseList in studentsAndCourses)
                        {
                            // take user input of first name and check if the input matches the first item in the list
                            
                            var firstNameExistingStudentRecordUnenroll = courseList[0];
                            if (firstNameExistingStudentInputUnenroll == firstNameExistingStudentRecordUnenroll)
                            {
                                // if it does, check second item of list to see if the user input matches the surname
                                
                                var lastNameExistingStudentRecordUnenroll = courseList[1];
                                if (lastNameExistingStudentInputUnenroll == lastNameExistingStudentRecordUnenroll)
                                {   

                                    // removing course name from list

                                    foreach (var studentList in coursesAndStudents)
                                    {
                                        var courseIdUnenroll = studentList[0];
                                        if (courseIdInputUnenroll == courseIdUnenroll)
                                        {
                                            // removing the student's name from the course roll and
                                            // removing the course name from the student's course list

                                            var courseNameToUnenrollStudentFrom = studentList[1];
                                            courseList.Remove(courseNameToUnenrollStudentFrom);
                                            studentList.Remove(fullStudentNameUnenroll);
                                        
                                        }
                                    }
                                }
                            }
                        }

                        // showing the user what courses the student is now enrolled in

                        foreach (var courseList in studentsAndCourses)
                        {
                            // take user input of first name and check if the input matches the first item in the list
                            
                            var firstNameRecordUnenroll = courseList[0];
                            if (firstNameExistingStudentInputUnenroll == firstNameRecordUnenroll)
                            {
                                // if it does, check second item of list to see if the user input matches the surname
                                
                                var lastNameRecordUnenroll = courseList[1];
                                if (lastNameExistingStudentInputUnenroll == lastNameRecordUnenroll)
                                {   
                                    Console.WriteLine();    
                                    Console.WriteLine($"{fullStudentNameUnenroll} is currently enrolled in:");

                                    // if it does, writeline the courses that the students are in (that is, the courses that follow the first two items in the list)

                                    for (var i = 2; i < courseList.Count; i++)
                                    {
                                        Console.WriteLine(courseList[i]);
                                    }
                                    break;

                                }
                            }
                        }
                        break;

                    case "7":

                        // adding a student to the University
                        // you need to add them to the list "students"
                        // and you need to create a list of their courses that can be added to the list of lists "studentsAndCourses"

                        // getting the user to input the new student's name

                        Console.WriteLine("Enter the student's first name below. Please use the correct case.");
                        var firstNameNewStudentInput = Console.ReadLine().Trim();

                        Console.WriteLine("Enter the student's surname below. Please use the correct case.");
                        var lastNameNewStudentInput = Console.ReadLine().Trim();

                        var fullNewStudentName = firstNameNewStudentInput + " " + lastNameNewStudentInput;

                        // adding student to list "students"

                        students.Add(fullNewStudentName);

                        // creating new list for the courses this student will do

                        var newUniversityStudent = new List<string>{firstNameNewStudentInput, lastNameNewStudentInput};

                        // adding this list to the list of lists "studentsAndCourses"

                        studentsAndCourses.Add(newUniversityStudent);

                        // writelining list of students at the university
                        // basically case 1 repeated - I wonder if there is a way to get one particular case to point to another case?
                        // (without methods, I mean.)

                        Console.WriteLine("~~Students enrolled at the University~~");
                        foreach (string v in students)
                        {
                            Console.WriteLine(v);
                        }
                        Console.WriteLine();
                        break;

                        // the issue here is that this only allows one new student enrollment per instance of the program running
                        // how would you get the program to name its own unique variables? 
                        // Student IDs assigned by some kind of iteration could work

                    // case "8":

                    //     // removing a student from the University
                    //     // you need to remove them from the list "students"
                    //     // and you need to remove their list from the list of lists "studentsAndCourses"
                    //     // and you need to run through the list of lists "coursesAndStudents" and delete their name each time it comes up

                    //     // getting the user to input the student's name

                    //     Console.WriteLine("Enter the student's first name below. Please use the correct case.");
                    //     var firstNameStudentInputRemove = Console.ReadLine().Trim();

                    //     Console.WriteLine("Enter the student's surname below. Please use the correct case.");
                    //     var lastNameStudentInputRemove = Console.ReadLine().Trim();

                    //     var fullStudentNameRemove = firstNameStudentInputRemove + " " + lastNameStudentInputRemove;

                    //     // removing student from list "students"

                    //     students.Remove(fullStudentNameRemove);

                    //     // searching "studentsAndCourses" for their list and removing it

                    //     foreach (var courseList in studentsAndCourses)
                    //     {
                    //         // take user input of first name and check if the input matches the first item in the list
                            
                    //         var firstNameRecordRemove = courseList[0];
                    //         if (firstNameStudentInputRemove == firstNameRecordRemove)
                    //         {
                    //             // if it does, check second item of list to see if the user input matches the surname
                                
                    //             var lastNameRecordRemove = courseList[1];
                    //             if (lastNameStudentInputRemove == lastNameRecordRemove)
                    //             {
                    //                 // searching the lists in "coursesAndStudents" for the student's name and removing it

                    //                 foreach (var studentList in coursesAndStudents)
                    //                 {
                    //                     studentList.Remove(fullStudentNameRemove);
                    //                 }

                    //                 // removing the student's courselist from the list of lists

                    //                 studentsAndCourses.Remove(courseList);
                    //             }
                    //         }
                    //     }

                    //     // writelining list of students at the university (case 1)

                    //     Console.WriteLine("~~Students enrolled at the University~~");
                    //     foreach (string v in students)
                    //     {
                    //         Console.WriteLine(v);
                    //     }
                    //     Console.WriteLine();
                    //     break;

                    //     // right, so when I ran this code i ended up with an error
                    //     // Unhandled exception. System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                    //     // I googled this and apparently it's because I can't delete things while in a foreach loop (?)
                    //     // I need to be out of the loop when I delete it.
                    //     // but then i need to know where the thing I want deleted is, outside of the loop structure
                    //     // I've commented this code out in the meantime




                        

                    

                        


                    


                    
                


                









                             
                }

            }
        
        }
    }
}
