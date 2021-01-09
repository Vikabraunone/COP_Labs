using BusinessLogic.BindingModels;
using BusinessLogic.Enums;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModels;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class FormStudent : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IStudentLogic studentLogic;

        public int? Id { get; set; }

        public string FIO { get; private set; }

        public FormEducation FormEducation { get; private set; }

        public string Email { get; private set; }

        public FormStudent(IStudentLogic studentLogic)
        {
            InitializeComponent();
            this.studentLogic = studentLogic;
            comboBoxFormEducation.DataSource = Enum.GetValues(typeof(FormEducation))
                            .Cast<FormEducation>()
                            .Select(x => x.ToString())
                            .ToList();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            if (Id.HasValue)
            {
                try
                {
                    StudentViewModel view = studentLogic.Read(new StudentBindingModel { Id = this.Id })?[0];
                    if (view != null)
                    {
                        textBoxFIO.Text = view.FIO;
                        textBoxEmail.Text = view.Email;
                        comboBoxFormEducation.SelectedIndex = (int)view.FormEducation;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                comboBoxFormEducation.SelectedItem = null;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFIO.Text))
            {
                MessageBox.Show("Заполните ФИО", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxEmail.Text))
            {
                MessageBox.Show("Заполните электронную почту", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxFormEducation.SelectedValue == null)
            {
                MessageBox.Show("Укажите форму обучения", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                FIO = textBoxFIO.Text;
                FormEducation = (FormEducation)Enum.Parse(typeof(FormEducation), comboBoxFormEducation.SelectedItem.ToString());
                Email = textBoxEmail.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}