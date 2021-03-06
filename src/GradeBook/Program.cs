using System;
using System.Collections.Generic;

namespace GradeBook
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();

            var grades = new List<double>(){12.7, 10.3, 15.5, 44};
            grades.Add(56.1);
            book.AddGrade(89.5);            
          
            var result = 0.0;
            foreach(var number in grades)
            {
                result += number;
            }
            result /= grades.Count; 
            Console.WriteLine($"The average grade is {result:N1}");
            
        }
    }
}
