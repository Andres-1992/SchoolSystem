namespace SchoolSystem
{
    public interface ITeacher
    {
        int GetID();
        string[] ListToPrint();
        void AddCourse(Course c);
    }
}