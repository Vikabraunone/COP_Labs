using BusinessLogic.BindingModels;
using Plugin;

namespace FormingOrderPlugin
{
    public class Plugin : IPlugin
    {
        public string PluginName => "Формирование приказа на смену фамилии студента";

        public void Call(StudentBindingModel model)
        {
            var form = new FormFormingOrder(model);
            form.Show();
        }
    }
}
