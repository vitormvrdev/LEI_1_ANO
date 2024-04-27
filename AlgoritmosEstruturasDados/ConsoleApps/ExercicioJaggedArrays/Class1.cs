using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioJaggedArrays
{
    internal class Student
    {
        private struct StudentDetail
        {
            public string name;
            public double[][] grade;
        }

        private StudentDetail studentDetail;

        public string Name
        {
            get { return studentDetail.name; }
            set { studentDetail.name = value; }
        }

        public double Grade
        {
            get { return studentDetail.grade; }
            set { studentDetail.grade = value; }
        }
    }
}
