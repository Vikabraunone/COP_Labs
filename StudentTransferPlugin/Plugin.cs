using BusinessLogic.BindingModels;
using BusinessLogic.Implements;
using BusinessLogic.Interfaces;
using Plugin;

namespace StudentTransferPlugin
{
    public class Plugin : IPlugin
    {
        public string PluginName => "Плагин перевода на иную форму обучения";

        IStudentLogic _studentLogic = new StudentLogic();

        public void Call(StudentBindingModel model)
        {
            var form = new FormStudent();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                _studentLogic.CreateOrUpdate(new StudentBindingModel { Id = model.Id, FormEducation = form.FormEducation });
        }
    }
}