using System.Collections.Generic;

namespace SchoolSystem
{
    public interface ICourse
    {

        void AddLab(Lab l);
        void AddStudent(Student s);
        void AddTeacher(Teacher t);
        void DeleteStudent(Student s);
        void DeleteTeacher(Teacher t);
        int GetID();
        List<Student> GetStudents();
        List<Teacher> GetTeachers();
        string[] ListCourses();
    }
}