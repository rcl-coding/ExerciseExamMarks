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
 */

#nullable disable

// Initialize variables

string studentName = string.Empty;
int[] examMarks = new int[3];
int avg = 0;
string message = string.Empty;


// Accept user inputs and set variables

Console.WriteLine("Enter a Student Name: ");
studentName = Console.ReadLine();

Console.WriteLine("Enter Exam Mark 1 : ");
examMarks[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Exam Mark 2 : ");
examMarks[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Exam Mark 3 : ");
examMarks[2] = Convert.ToInt32(Console.ReadLine());


// Calculate average exam mark

int sumExamMarks = 0;

foreach (int examMark in examMarks)
{
    sumExamMarks = sumExamMarks + examMark;
}

avg = sumExamMarks / examMarks.Count();


// Set the user message

if (avg >= 50)
{
    message = $"{studentName} has PASSED the course with an average mark of : {avg}";
}
else
{
    message = $"{studentName} has FAILED the course with an average mark of : {avg}";
}


// Display the user message

Console.WriteLine(message);
