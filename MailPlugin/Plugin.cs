using BusinessLogic.BindingModels;
using Plugin;

namespace MailPlugin
{
    public class Plugin : IPlugin
    {
        public string PluginName => "Плагин отправки уведомлений на почту";

        public void Call(StudentBindingModel model)
        {
            var form = new FormSendMail(model);
            form.Show();
        }
    }
}
