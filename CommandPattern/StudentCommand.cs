using BusinessLogic.BindingModels;
using BusinessLogic.Interfaces;

namespace CommandPattern
{
    /// <summary>
    /// Receiver
    /// </summary>
    public class StudentCommand
    {
        private IStudentLogic logic;

        private StudentBindingModel student;

        public StudentCommand(IStudentLogic logic, StudentBindingModel student)
        {
            this.student = student;
            this.logic = logic;
        }

        public void CreateOrUpdate()
        {
            logic.CreateOrUpdate(student);
        }

        public void Delete()
        {
            logic.Delete(student);
        }
    }
}
