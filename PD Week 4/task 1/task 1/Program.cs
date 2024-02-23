using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Student student = new Student();
            student.fscMarks = 1029;
            student.ecatMarks = 251;
            student.scholarshipStatus = true;
            student.isHostelite = false;
            Console.WriteLine(student.calculateMerit());
            if(student.scholarshipStatus ) 
            {
                Console.WriteLine("Eligible for Scholarship");
            }
            else
            {
                Console.WriteLine("Not elifilble");
            }
            
            Console.Read();
        }
       
    }
}
