using BusinessLogic.BindingModels;
using BusinessLogic.Interfaces;
using CommandPattern;
using System.ComponentModel;

namespace ClassLibraryControl.Patterns
{
    public partial class ComponentCommand : Component
    {
        User user;

        StudentCommand studentCommand;

        public ComponentCommand()
        {
            InitializeComponent();
        }

        public ComponentCommand(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        /// <summary>
        /// Инициализация команд над студентом
        /// </summary>
        /// <param name="logic">Бизнес-логика работы со студентом</param>
        /// <param name="student">Студент</param>
        public void LoadCommand(IStudentLogic logic, StudentBindingModel student)
        {
            studentCommand = new StudentCommand(logic, student);
            user = new User(new EnrollStudentCommand(studentCommand), new ChangeInfoStudentCommand(studentCommand),
                new DeductStudentCommand(studentCommand));
        }

        /// <summary>
        /// Зачислить
        /// </summary>
        public void Enroll()
        {
            if (user != null)
                user.Enroll();
        }

        /// <summary>
        /// Изменить
        /// </summary>
        public void Change()
        {
            if (user != null)
                user.Change();
        }

        /// <summary>
        /// Отчислить
        /// </summary>
        public void Deduct()
        {
            if (user != null)
                user.Deduct();
        }
    }
}
