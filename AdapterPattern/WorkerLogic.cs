using BusinessLogic.BindingModels;
using BusinessLogic.Implements;
using System.Collections.Generic;
using System.Linq;

namespace AdapterPattern
{
    /// <summary>
    /// Логика работы с сотрудником
    /// </summary>
    public class WorkerLogic : IWorkerLogic
    {
        StudentLogic logic = new StudentLogic();

        /// <summary>
        /// Уволить
        /// </summary>
        /// <param name="model"></param>
        public void Dismiss(Worker model)
        {
            logic.Delete(new StudentBindingModel
            {
                Id = model.Id
            });
        }

        /// <summary>
        /// Нанять/обновить
        /// </summary>
        /// <param name="model"></param>
        public void Hire(Worker model)
        {
            logic.CreateOrUpdate(new StudentBindingModel
            {
                Id = model.Id,
                FIO = model.FIO,
                FormEducation = null,
                AverageRating = model.Wages,
                Email = model.Email
            });
        }

        public List<Worker> Read(Worker model)
        {
            return logic.Read(model == null ? null : new StudentBindingModel { Id = model.Id })
                .Select(rec => new Worker
                {
                    Id = rec.Id,
                    Email = rec.Email,
                    FIO = rec.FIO,
                    Wages = rec.AverageRating
                })
                .ToList();
        }
    }
}
