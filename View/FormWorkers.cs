using BusinessLogic.BindingModels;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class FormWorkers : Form
    {
        public FormWorkers()
        {
            InitializeComponent();
            componentAdapter.LoadPattern();
        }

        private void FormWorkers_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                controlDataGridViewOutput.Clear();
                var list = componentAdapter.Read(null);
                if (list != null)
                    controlDataGridViewOutput.FillDataGrid(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = new FormWorker();
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    componentAdapter.Hire(new StudentBindingModel
                    {
                        FIO = form.FIO,
                        AverageRating = form.Wages,
                        Email = form.Email
                    });
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var form = new FormWorker
            {
                Id = Convert.ToInt32(controlDataGridViewOutput.SelectedText)
            };
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    componentAdapter.Hire(new StudentBindingModel
                    {
                        Id = form.Id,
                        FIO = form.FIO,
                        AverageRating = form.Wages,
                        Email = form.Email
                    });
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (controlDataGridViewOutput.CountSelectedRows() == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        componentAdapter.Dissmiss(new StudentBindingModel
                        {
                            Id = int.Parse(controlDataGridViewOutput.SelectedText),
                        });
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
