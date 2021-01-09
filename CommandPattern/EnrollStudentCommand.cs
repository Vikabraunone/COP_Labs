namespace CommandPattern
{
    /// <summary>
    /// Зачислить студента
    /// </summary>
    public class EnrollStudentCommand : ICommand
    {
        StudentCommand student;

        public EnrollStudentCommand(StudentCommand student)
        {
            this.student = student;
        }

        public void Execute()
        {
            student.CreateOrUpdate();
        }
    }
}
