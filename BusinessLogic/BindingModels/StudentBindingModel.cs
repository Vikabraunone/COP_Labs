using BusinessLogic.Enums;

namespace BusinessLogic.BindingModels
{
    public class StudentBindingModel
    {
        public int? Id { get; set; }

        public string FIO { get; set; }

        public FormEducation? FormEducation { get; set; }

        public string Email { get; set; }
    }
}