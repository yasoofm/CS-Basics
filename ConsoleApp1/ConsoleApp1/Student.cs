using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public string name { get; set; }
        public string major {  get; set; }
        public double GPA { get; set; }

        string print()
        {
            return $"name: {name}\nmajor: {major}\nGPA: {GPA}";
        }
    }
    
    internal class GraduateStudent : Student
    {
        public bool isGraduate {  get; set; }

        public string print()
        {
            return $"name: {name}\nmajor: {major}\nGPA: {GPA}\ngraduate: {isGraduate}";
        }
    }
}
