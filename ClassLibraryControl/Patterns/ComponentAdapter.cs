using AdapterPattern;
using BusinessLogic.BindingModels;
using BusinessLogic.ViewModels;
using System.Collections.Generic;
using System.ComponentModel;

namespace ClassLibraryControl.Patterns
{
    public partial class ComponentAdapter : Component
    {
        Adapter adapter;

        WorkerLogic workerLogic;

        public ComponentAdapter()
        {
            InitializeComponent();
        }

        public ComponentAdapter(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void LoadPattern()
        {
            workerLogic = new WorkerLogic();
            adapter = new Adapter(workerLogic);
        }

        /// <summary>
        /// Уволить сотрудника
        /// </summary>
        /// <param name="model"></param>
        public void Dissmiss(StudentBindingModel model)
        {
            adapter.Delete(model);
        }

        /// <summary>
        /// Принять на работу сотрудника
        /// </summary>
        /// <param name="model"></param>
        public void Hire(StudentBindingModel model)
        {
            adapter.CreateOrUpdate(model);
        }

        /// <summary>
        /// Вернуть список сотрудников
        /// </summary>
        /// <param name="model"></param>
        public List<StudentViewModel> Read(StudentBindingModel model)
        {
            return adapter.Read(model);
        }
    }
}
