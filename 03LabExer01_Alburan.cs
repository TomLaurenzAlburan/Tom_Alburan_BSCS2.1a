using System;

namespace SimpleGradeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // user inputted na name of student
            Console.Write("Enter your name: ");
            string studentName = Console.ReadLine();
            
            Console.WriteLine("_______________________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Grades");
            Console.WriteLine("_______________________________________________________________________________________________________");
            Console.WriteLine();

            // nag create ng array para mapag s-store-ran ng grades and subjects
            double[] grades = new double[5];
            string[] subjects = { "English", "Math", "Science", "Filipino", "History" };

            //  Loop para sa user inputted na grades para ilagay sa bawat subject na nasa array
            for (int q = 0; q < grades.Length; q++) // sinet ang q to 0 para po kung mas mataas po sa 0 or number of grades na nasa array.Length mag a-add po siya bale magiging 1<grades.Length so on so so forth, hanggang maging 5
            {
                double grade; // ginawang double yung grade kasi in case na may decimal points po yung grade mare-read parin siya
                bool isValidGrade = false;

                while (!isValidGrade)
                {
                    Console.Write($"Enter grade for {subjects[q]}: ");
                    string input = Console.ReadLine();

                    if (double.TryParse(input, out grade) && grade >= 0 && grade <= 100) 
                    {
                        grades[q] = grade;
                        isValidGrade = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid grade between 0 and 100.");
                    }
                }
            }

            // dito na magca-calculate ng average grade
            double sum = 0;
            for (int q = 0; q < grades.Length; q++)
            {
                sum += grades[q];
            }
            double average = sum / grades.Length;

            // dito ide-determine kung passed ba ang student or failed 
            string result = average >= 75 ? "The student passed." : "The student failed.";

            // print out ng result after maca-culate and ma-determine kung passed ba or failed ang student
            Console.WriteLine("_______________________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine($"{result} The general average of {studentName} is {average:F2}.");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
