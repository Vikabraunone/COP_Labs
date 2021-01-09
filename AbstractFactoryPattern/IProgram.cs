namespace AbstractFactoryPattern
{
    /// <summary>
    /// Образовательная программа
    /// </summary>
    public interface IProgram
    {
        ICourse CreateCourse();

        IForm CreateFormEducation();
    }
}
