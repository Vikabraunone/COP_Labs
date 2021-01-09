using BusinessLogic.BindingModels;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class FormWorker : Form
    {
        public int? Id { get; set; }

        public string FIO { get; private set; }

        public string Email { get; private set; }

        public double Wages { get; private set; }

        public FormWorker()
        {
            InitializeComponent();
            componentAdapter.LoadPattern();
        }

        private void FormWorker_Load(object sender, EventArgs e)
        {
            if (Id.HasValue)
            {
                try
                {
                    var worker = componentAdapter.Read(new StudentBindingModel { Id = Id })?[0];
                    if (worker != null)
                    {
                        textBoxFIO.Text = worker.FIO;
                        textBoxEmail.Text = worker.Email;
                        textBoxWages.Text = worker.AverageRating.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            if (!double.TryParse(textBoxWages.Text, out double wages))
            {
                MessageBox.Show("Балл должен быть числом", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                FIO = textBoxFIO.Text;
                Email = textBoxEmail.Text;
                Wages = wages;
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
