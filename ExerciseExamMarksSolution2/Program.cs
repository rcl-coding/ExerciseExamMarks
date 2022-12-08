/*
Exercise description:

In a school course, 3 exams (each marked out of 100) are carried out during the school term. 
The average of the exam marks is calculated for a student at the end of the term.
The student passes the course if the average mark is more than 50.

Write a C# console application to :

(i) 	Enter a student name
(ii) 	Enter the student's exam marks
(iii)   Calculate the student's average mark at the end of the term
(iv) 	Send a message in the output window if the student passes or fails the course and state the average mark
 

===================================================================================================================

The solution below was developed by DeSean Ellis a member of the Trinidad and Tobago .NET Developers Group

===================================================================================================================

*/

// Declare Variables
int[] marks = new int[3];

// Get Student's Name
Console.WriteLine("Enter the student's name:");
string? name = Console.ReadLine();

// Get Student's Marks
for (int i = 0; i < marks.Length; i++)
{
    Console.WriteLine($"Enter the student's exam marks for Exam {i + 1}");
    string? mark = Console.ReadLine();

    try
    {
        marks[i] = string.IsNullOrEmpty(mark) ? 0 : Convert.ToInt32(mark);
    }
    catch 
    {
        Console.WriteLine("Input was invalid, exiting the application.");
        Environment.Exit(0);
    }
}

// Claculate Sum of Marks and Find Average
int averageMark = marks.Sum() / marks.Length;

// Display Message
Console.WriteLine($"{(string.IsNullOrEmpty(name) ? "Undefined" : name)} has {(averageMark >= 50 ? "PASSED" : "FAILED")} the course with an average mark of : {averageMark}");

