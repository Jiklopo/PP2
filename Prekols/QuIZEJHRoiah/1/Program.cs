using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace _1
{
    public class Mark
    {
        public char mark;
        public double gpa;
        public Mark()
        {
        }
        public Mark(double gpa)
        {
            this.gpa = gpa;
            if (gpa >= 4)
                mark = 'A';
            else if (gpa > 3)
                mark = 'B';
            else if (gpa > 2)
                mark = 'C';
        }
        public override string ToString()
        {
            return "GPA: " + gpa + " " + mark;
        }
    }
    public class Student
    {
        public string name;
        public Mark mark;
        public Student()
        {

        }
        public Student(string name, double gpa)
        {
            this.name = name;
            mark = new Mark(gpa);
        }

        public override string ToString()
        {
            return name + ", " + mark;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string name = a.Split(' ')[0];
            double gpa = double.Parse(a.Split(' ')[1]);
            Student student = new Student(name, gpa);
            FileStream fs = new FileStream(name + ".xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            xs.Serialize(fs, student);
            fs.Close();
            FileStream deser = new FileStream(Console.ReadLine() + ".xml", FileMode.OpenOrCreate);
            Student student1 = (Student)xs.Deserialize(deser);
            Console.WriteLine(student1);
            Console.ReadKey();
        }
    }
}
