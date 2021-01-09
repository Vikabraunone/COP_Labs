using BusinessLogic.BindingModels;
using BusinessLogic.Interfaces;
using Plugin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class FormPlagins : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IStudentLogic studentLogic;

        private List<IPlugin> plugins;

        public FormPlagins(IStudentLogic studentLogic)
        {
            InitializeComponent();
            this.studentLogic = studentLogic;
        }

        private void FormPlagins_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadPlugins(Application.StartupPath);
            LoadPluginsComboBox();
        }

        private void LoadStudents()
        {
            try
            {
                var list = studentLogic.Read(null);
                if (list != null)
                {
                    dataGridViewStudents.DataSource = list;
                    dataGridViewStudents.Columns[0].Visible = false; //id
                    dataGridViewStudents.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //FIO
                    dataGridViewStudents.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //FormEducation
                    dataGridViewStudents.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //Email
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPlugins(string path)
        {
            string[] pluginFiles = Directory.GetFiles(path, "*.dll");
            plugins = new List<IPlugin>();

            foreach (string pluginPath in pluginFiles)
            {
                try
                {
                    Type objType = null;
                    // пытаемся загрузить библиотеку
                    Assembly assembly = Assembly.LoadFrom(pluginPath);
                    if (assembly != null)
                    {
                        var x = Path.GetFileNameWithoutExtension(pluginPath) + ".Plugin";
                        var t = assembly.GetType(x);
                        objType = assembly.GetType(Path.GetFileNameWithoutExtension(pluginPath) + ".Plugin");
                        if (objType != null)
                            plugins.Add((IPlugin)Activator.CreateInstance(objType));
                    }
                }
                catch
                {
                    continue;
                }
            }
        }

        private void LoadPluginsComboBox()
        {
            comboBoxPlugins.Items.Clear();
            if (plugins != null)
            {
                comboBoxPlugins.DisplayMember = "PluginName";
                comboBoxPlugins.DataSource = plugins;
                comboBoxPlugins.SelectedItem = null;
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (comboBoxPlugins.SelectedItem != null && dataGridViewStudents.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridViewStudents.SelectedRows[0].Cells[0].Value);
                IPlugin plugin = ((IPlugin)comboBoxPlugins.SelectedValue);
                plugin.Call(new StudentBindingModel
                {
                    Id = id,
                    FIO = (string)dataGridViewStudents.SelectedRows[0].Cells[1].Value,
                    Email = (string)dataGridViewStudents.SelectedRows[0].Cells[3].Value
                });
                var st = studentLogic.Read(new BusinessLogic.BindingModels.StudentBindingModel { Id = id });
                dataGridViewStudents.SelectedRows[0].Cells[1].Value = st[0].FIO;
                dataGridViewStudents.SelectedRows[0].Cells[2].Value = st[0].FormEducation;
                dataGridViewStudents.SelectedRows[0].Cells[3].Value = st[0].Email;
            }
        }

        private void buttonUpdateStudents_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }
    }
}
