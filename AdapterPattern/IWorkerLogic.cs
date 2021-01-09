using System.Collections.Generic;

namespace AdapterPattern
{
    /// <summary>
    /// Интерфейс бизнес-логики сотрудника
    /// </summary>
    public interface IWorkerLogic
    {
        /// <summary>
        /// Нанять сотрудника
        /// </summary>
        void Hire(Worker model);

        /// <summary>
        /// Уволить сотрудника
        /// </summary>
        /// <param name="model"></param>
        void Dismiss(Worker model);

        /// <summary>
        /// Считать сотрудников
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<Worker> Read(Worker model);
    }
}
