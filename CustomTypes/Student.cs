using System;

namespace CustomTypes
{
    public class Student : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double GPA { get; set; }

        public Student()
        {

        }
        public Student(int id, string name, double gpa)
        {
            Id = id;
            Name = name;
            GPA = gpa;
        }

        public int CompareTo(object obj)
        {
            var other = (Student)obj;
            // İsme göre karşılaştırma yapıyoruz
            //return string.Compare(this.Name, other.Name);

            // Ortalamaya göre karşılaştırma yapıyoruz.
            //if (this.GPA < other.GPA)
            //    return -1;
            //else if (this.GPA.Equals(other.GPA))
            //    return 0;
            //else
            //    return 1;

            //return this.GPA.CompareTo(other.GPA);

            // Id'ye göre karşılaştırma yapıyoruz.
            return this.Id.CompareTo(other.Id);
        }

        public override string ToString()
        {
            return $"{Id,-5} {Name,-15} {GPA,-5}";
        }
    }
}
