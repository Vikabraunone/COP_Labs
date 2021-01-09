using BusinessLogic.BindingModels;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace AdapterPattern
{
    public class Adapter : IStudentLogic
    {
        WorkerLogic workerLogic;

        public Adapter(WorkerLogic workerLogic)
        {
            this.workerLogic = workerLogic;
        }

        public void CreateOrUpdate(StudentBindingModel model)
        {
            //вызываем метод сотрудника
            workerLogic.Hire(new Worker
            {
                Id = model.Id,
                FIO = model.FIO,
                Email = model.Email,
                Wages = model.AverageRating.Value
            });
        }

        public void Delete(StudentBindingModel model)
        {
            //вызываем метод сотрудника
            workerLogic.Dismiss(new Worker { Id = model.Id });
        }

        public List<StudentViewModel> Read(StudentBindingModel model)
        {
            //вызываем метод сотрудника и выбираем студентов, у которых оценка > 5
            return workerLogic.Read(model == null ? null : new Worker { Id = model.Id })
                .Where(rec => rec.Wages > 5)
                .Select(rec => new StudentViewModel
                {
                    Id = rec.Id.Value,
                    FIO = rec.FIO,
                    FormEducation = null,
                    Email = rec.Email,
                    AverageRating = rec.Wages
                })
                .ToList();
        }
    }
}
