using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> students;
        public int Capacity { get; set; }
        public int Count => this.students.Count;

        public Classroom(int capacity)
        {
            this.Capacity = capacity;
            students = new List<Student>();
        }

        public string RegisterStudent(Student student)
        {
            if (this.Capacity > this.Count)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }

            return "No seats in the classroom";

        }

        public string DismissStudent(string firstName, string lastName)
        {
            Student current = this.students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

            if (current != null)
            {
                students.Remove(current);
                return $"Dismissed student {current.FirstName} {current.LastName}";
            }
            return "Student not found";


        }

        public string GetSubjectInfo(string subject)
        {


            StringBuilder sb = new StringBuilder();
            if (students.FirstOrDefault(x => x.Subject == subject) != null)
            {
                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine("Students:");

                foreach (var item in students.Where(x => x.Subject == subject).ToList())
                {
                    sb.AppendLine($"{item.FirstName} {item.LastName}");
                }

                return sb.ToString().Trim();
            }

            return "No students enrolled for the subject";
        }
        public int GetStudentsCount()
        {
            return this.Count;
        }
        public Student GetStudent(string firstName, string lastName)
        {
            return this.students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
        }
    }
}
