namespace CommandPattern
{
    /// <summary>
    /// Отчислить студента
    /// </summary>
    public class DeductStudentCommand : ICommand
    {
        StudentCommand student;

        public DeductStudentCommand(StudentCommand student)
        {
            this.student = student;
        }

        public void Execute()
        {
            student.Delete();
        }
    }
}
