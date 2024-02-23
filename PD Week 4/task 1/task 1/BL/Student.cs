using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    internal class Student
    {
        public string name ;
        public string rollNumber;
        public float cgpa;
        public int matricMarks;
        public int fscMarks;
        public int ecatMarks;
        public string homeTown;
        public bool isHostelite;
        public bool scholarshipStatus;

        public Student()
        {
            
        }
        public double calculateMerit()
        {
            double merit = (0.6 * (fscMarks/11)) + (0.4 * (ecatMarks/ 4));
            return merit;

        }
        public bool scholarship(double meritpercentage)
        {
           if (meritpercentage < 80 && isHostelite)
            {
                scholarshipStatus = true;
                return scholarshipStatus;
            }
           else
            {
                scholarshipStatus = false;
                return scholarshipStatus;
            }



        }
    }
   
    
}
