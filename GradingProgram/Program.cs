using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingProgram
{
    class Grading
    {
        public double
    }
    class Program
    {
        static void Main(string[] args)
        {
            Grading g = Grading(7, 6, 8, 85, 95); //q1, q2, q3, midterm, final
            Console.WriteLine(g.overall_grade);
            Console.WriteLine(g.letter);
            Console.WriteLine(g.midterm);
            Console.ReadLine();
        }
    }
}
