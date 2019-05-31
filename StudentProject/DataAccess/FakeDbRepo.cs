using StudentProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentProject.DataAccess
{
    public class FakeDbRepo
    {
        private static List<StudentViewModel> _studentList;

        public FakeDbRepo()
        {
            if (_studentList == null)
            {
                 _studentList = new List<StudentViewModel>()
                {
                    new StudentViewModel() { Id = 1, Name = "Fırat", Grade = 90, Status = false },
                    new StudentViewModel() { Id = 2, Name = "Dido", Grade = 75, Status = true },
                    new StudentViewModel() { Id = 3, Name = "Firto", Grade = 70, Status = true },
                    new StudentViewModel() { Id = 4, Name = "Dirto", Grade = 87, Status = false }
                };
            }
        }

        public List<StudentViewModel> GetAllStudents()
        {
            return _studentList;
        }

        public int UpdateStudents(List<StudentViewModel> students)
        {
            
            var i = 0;
            foreach (var student in _studentList)
            {
                var s = students.FirstOrDefault(m => m.Id == student.Id);

                student.Id = s.Id;
                student.Name = s.Name;
                student.Grade = s.Grade;
                student.Status = s.Status;

                i++;
            }
            return i;
        }
        public StudentViewModel GetStudent(int? id)
        {
            return _studentList.FirstOrDefault(student => student.Id == id);
        }

        public int InsertStudent(StudentViewModel student)
        {
            _studentList.Add(student);
            return 1;
        }
    }
}