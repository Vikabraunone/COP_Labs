using BusinessLogic.BindingModels;

namespace Plugin
{
    public interface IPlugin
    {
        string PluginName { get; }

        void Call(StudentBindingModel model);
    }
}
