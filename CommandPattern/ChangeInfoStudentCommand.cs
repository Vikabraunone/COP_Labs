namespace CommandPattern
{
    /// <summary>
    /// Изменить информацию о студенте
    /// </summary>
    public class ChangeInfoStudentCommand : ICommand
    {
        StudentCommand student;

        public ChangeInfoStudentCommand(StudentCommand student)
        {
            this.student = student;
        }

        public void Execute()
        {
            student.CreateOrUpdate();
        }
    }
}
