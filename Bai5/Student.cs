using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    public class Student
    {
        public string name;
        public string ID;
        public string apartment;
        public double score;

        public Student(string ID, string name, string apartment, double score)
        {
            this.name = name;
            this.ID = ID;
            this.apartment = apartment;
            this.score = score;
        }
    }
}
