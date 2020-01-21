namespace SchoolSystem
{
    public interface ILab
    {

        Course GetCourse();
        Student GetStudent();
        void GradeStudent(Student s, string grade);
        string[] ListAllLabs();
        string PrintInfo();
    }
}