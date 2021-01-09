using BusinessLogic.BindingModels;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class FormStudents : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IStudentLogic studentLogic;

        public FormStudents(IStudentLogic studentLogic)
        {
            InitializeComponent();
            this.studentLogic = studentLogic;
        }

        private void FormStudents_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                controlDataGridViewOutput.Clear();
                var list = studentLogic.Read(null);
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
            var form = Container.Resolve<FormStudent>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    studentLogic.CreateOrUpdate(new StudentBindingModel
                    {
                        FIO = form.FIO,
                        FormEducation = form.FormEducation,
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
            if (controlDataGridViewOutput.CountSelectedRows() == 1)
            {
                var form = Container.Resolve<FormStudent>();
                form.Id = Convert.ToInt32(controlDataGridViewOutput.SelectedText);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        studentLogic.CreateOrUpdate(new StudentBindingModel
                        {
                            Id = form.Id,
                            FIO = form.FIO,
                            FormEducation = form.FormEducation,
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
                        studentLogic.Delete(new StudentBindingModel
                        {
                            Id = int.Parse(controlDataGridViewOutput.SelectedText)
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

        private void controlDataGridViewOutput_DataGridViewSelectionChanged(object sender, EventArgs e)
        {
            textBoxCurrentId.Text = controlDataGridViewOutput.SelectedIndex.ToString();
        }

        private void загрузитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog od = new OpenFileDialog { Filter = "all|*.*" })
                {
                    if (od.ShowDialog() == DialogResult.OK)
                    {
                        var list = componentRestore.DownloadBackUp<StudentViewModel>(od.FileName);
                        foreach (var item in list)
                            studentLogic.CreateOrUpdate(new StudentBindingModel
                            {
                                Id = item.Id,
                                Email = item.Email,
                                FIO = item.FIO,
                                FormEducation = item.FormEducation
                            });
                        LoadData();
                        MessageBox.Show("Данные успешно загружены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void сохранитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog fd = new SaveFileDialog { Filter = "all|*.json" })
                {
                    if (fd.ShowDialog() == DialogResult.OK)
                    {
                        componentBackUp.CreateBackUp(studentLogic.Read(null), fd.FileName);
                        MessageBox.Show("Данные успешно сохранены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void диаграммаПоФормамОбученияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog fd = new SaveFileDialog { Filter = "xlsx|*.xlsx" })
                {
                    if (fd.ShowDialog() == DialogResult.OK)
                    {
                        var groupStudents = studentLogic.Read(null).GroupBy(x => x.FormEducation.ToString());
                        var dictionary = new Dictionary<string, int>();
                        foreach (var group in groupStudents)
                            dictionary.Add(group.Key, group.Count());
                        componentDiagramExcel.CreateDiagram(fd.FileName, dictionary);
                        MessageBox.Show("Диаграмма создана", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void отчетПоСтудентамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                componentExcelReport = new ClassLibraryExcelReport.ExcelComponent();
                using (SaveFileDialog fd = new SaveFileDialog { Filter = "xlsx|*.xlsx" })
                {
                    if (fd.ShowDialog() == DialogResult.OK)
                    {
                        var students = studentLogic.Read(null);
                        var report = students.Select(x => new { x.FIO, x.Email }).ToArray(); ;
                        componentExcelReport.CreateExcelReport(fd.FileName, true, report, new int[] { 1, 3 }, new string[] { "ФИО", "Email" });
                        MessageBox.Show("Отчет сохранен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void abstractFactoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAbstractFactory().ShowDialog();
        }

        private void adapterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormWorkers().ShowDialog();
        }

        /// <summary>
        /// Зачислить студента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnroll_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormStudent>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var student =
                        new StudentBindingModel
                        {
                            FIO = form.FIO,
                            FormEducation = form.FormEducation,
                            AverageRating = form.AverageRating,
                            Email = form.Email
                        };
                    componentCommand.LoadCommand(this.studentLogic, student);
                    componentCommand.Enroll();
                    MessageBox.Show("Студент зачислен");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Обновить студента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInfoUpdateStudent_Click(object sender, EventArgs e)
        {
            if (controlDataGridViewOutput.CountSelectedRows() == 1)
            {
                var form = Container.Resolve<FormStudent>();
                form.Id = Convert.ToInt32(controlDataGridViewOutput.SelectedText);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var student =
                            new StudentBindingModel
                            {
                                Id = form.Id,
                                FIO = form.FIO,
                                FormEducation = form.FormEducation,
                                AverageRating = form.AverageRating,
                                Email = form.Email
                            };
                        componentCommand.LoadCommand(this.studentLogic, student);
                        componentCommand.Change();
                        MessageBox.Show("Запись о студенте изменена");
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Отчислить студента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeduct_Click(object sender, EventArgs e)
        {
            if (controlDataGridViewOutput.CountSelectedRows() == 1)
            {
                try
                {
                    var student = new StudentBindingModel
                    {
                        Id = Convert.ToInt32(controlDataGridViewOutput.SelectedText)
                    };
                    componentCommand.LoadCommand(this.studentLogic, student);
                    componentCommand.Deduct();
                    MessageBox.Show("Студент отчислен");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Выбрать строку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetId_Click(object sender, EventArgs e)
        {
            try
            {
                controlDataGridViewOutput.SelectedLinkDataGridView(int.Parse(textBoxSetId.Text));
                textBoxCurrentId.Text = controlDataGridViewOutput.SelectedIndex.ToString();
            }
            catch { }
        }
    }
}