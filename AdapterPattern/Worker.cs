namespace AdapterPattern
{
    /// <summary>
    /// Сотрудник университета
    /// </summary>
    public class Worker
    {
        public int? Id { get; set; }

        /// <summary>
        /// ФИО
        /// </summary>
        public string FIO { get; set; }

        /// <summary>
        /// Электронная почта
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Заработная плата
        /// </summary>
        public double Wages { get; set; }
    }
}
