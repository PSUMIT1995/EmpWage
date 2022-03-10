// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employee Wage");

Random random = new Random();
const int present = 1,
          absent = 0;

int isPresent = random.Next(2);

if (isPresent == present)
{
    Console.WriteLine("Employee is Present");
}
else
{
    Console.WriteLine("Employee is Absent");
}
