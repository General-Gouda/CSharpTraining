using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();

            float average = new float();

            book.AddGrade(98);
            book.AddGrade(86);
            book.AddGrade(96);

            foreach (float grade in book.grades)
            {
                average += grade;
                Console.WriteLine("{0}",grade.ToString());
            }

            Console.WriteLine("Average: {0}", average / (book.grades.Count));

            Console.ReadLine();
        }
    }
}
