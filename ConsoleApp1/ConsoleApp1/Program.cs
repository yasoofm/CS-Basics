// See https://aka.ms/new-console-template for more information

//C# Primitive Types
using ConsoleApp1;

Console.WriteLine("C# Primitive Types");
string name = "yousef";
int age = 28;
double gpa = 3.02;
bool isGraduate = true;

Console.WriteLine($"name: {name}\nage: {age}\ngpa: {gpa}\nGraduate: {isGraduate}");

int number = 5;
double result = Convert.ToDouble(number);
Console.WriteLine($"int converted to double: {result}");

char letter = 'h';
char letter2 = 'i';

char[] word = [letter, letter2];
Console.Write("a string is an array of letters: ");
Console.WriteLine(word);
Console.WriteLine();

//C# Variables
Console.WriteLine("C# Variables");
string studentName = "yousef";
double gradePointAvg = 2.5;
string favoriteSubject = "PE";

double width = 5.5;
double height = 3.2;
double area = width * height;

const double PI = 3.14159265359;

Console.WriteLine($"student {studentName}'s grade is {gradePointAvg} and his favorite subject is {favoriteSubject}");
Console.WriteLine($"this value is unchangeable {PI}");
Console.WriteLine();

//C# Control Flow
Console.WriteLine("C# Control Flow");

DateTime dateTime = DateTime.Now;

if(dateTime.Hour >= 11 && dateTime.Hour < 14)
{
    Console.WriteLine("Time for lunch!");
}

for(int i = 0; i < 10; i++)
{
    Console.Write($"{i + 1} ");
}
Console.WriteLine();

int count = 5;
while (count > 0)
{
    Console.Write($"{count} ");
    count--;
}
Console.WriteLine("\n");

//C# Arrays
Console.WriteLine("C# Arrays");

string[] daysOfWeek = ["Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"];
foreach (var day in daysOfWeek)
{
    Console.Write($"{day} ");
}

int[] numbers = [1, 3, 4, 2, 1, 4, 5, 2];
int sum = 0;
foreach(var num in numbers)
{
    sum += num;
}
Console.WriteLine(sum);

Console.WriteLine();

int[][] matrix = [
    [1, 2, 3, 4, 5],
    [1, 2, 3, 4, 5],
    [1, 2, 3, 4, 5]
    ];

for(int i = 0;i < matrix.Length; i++)
{
    for(int j = 0; j < matrix[i].Length; j++)
    {
        Console.Write(matrix[i][j]);
    }
    Console.WriteLine();
}

//C# LINQ
Console.WriteLine();
Console.WriteLine("C# LINQ");

var even = numbers.Where(x => x % 2 == 0);
foreach(int x in even)
{
    Console.Write($"{x} ");
}

int[] grades = [90, 88, 70, 45, 69, 77];
Console.WriteLine("numbers");
foreach(int x in grades)
{
    Console.Write($"{x} ");
}
var average = grades.Average();
Console.WriteLine($"\naverage: {average}");
Console.WriteLine("sorted grades");

var sortedGrades = grades.OrderBy(x => x);
foreach (int x in sortedGrades)
{
    Console.Write($"{x} ");
}
Console.WriteLine();
Console.WriteLine();

//C# OOP
Console.WriteLine("C# OOP");
GraduateStudent student = new GraduateStudent();
student.name = "Yousef";
student.major = "Computer Engineer";
student.GPA = 3.0;
student.isGraduate = true;
Console.WriteLine(student.print());

Console.WriteLine();

//C# Functions
Console.WriteLine("C# Functions");
Greet("yousef");
Console.WriteLine($"volume with no parameters: {a.Volume()}");
Console.WriteLine($"volume with parameters: {a.Volume(2, 2, 2)}");

void Greet(string name)
{
    Console.WriteLine($"Hello {name}");
}

class a
{
    public static double Volume(double length, double height, double width)
    {
        return width * length * height;
    }

    public static double Volume()
    {
        return 5 * 5 * 5;
    }
}
