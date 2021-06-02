using System;
using System.Collections.Generic;
using System.Linq;

namespace firstLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>();
            double sumOfGrades = 0;
            Console.WriteLine("How many classes?: ");
            string classes = Console.ReadLine();
            double classesNum = Convert.ToDouble(classes);

            for (int i = 1; i < classesNum + 1; i++)
            {
                Console.WriteLine($"Grade for Class {i}");
                string currentGradeString = Console.ReadLine();
                double currentGrade = Convert.ToDouble(currentGradeString);
                sumOfGrades += currentGrade;
                grades.Add(currentGrade);
            }

            int classNumber = 0;
            foreach (var grade in grades)
            {
                classNumber++;
                Console.WriteLine($"Class {classNumber}: {grade}");

            }

            double averageGrade = sumOfGrades / grades.Count;
            Console.WriteLine($"Average: {averageGrade}");

            if (averageGrade < 3.0)
            {
                Console.WriteLine("Try harder!");
            }

            if (averageGrade >= 3.0 && averageGrade <= 4.0)
            {
                Console.WriteLine("Good job!");
            }

            if (averageGrade > 4.0)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}