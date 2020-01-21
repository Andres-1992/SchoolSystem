namespace SchoolSystem
{
    public interface IStudent
    {
        int GetID();
        string[] ListToPrint();
        void AddCourse(Course c);
    }
}