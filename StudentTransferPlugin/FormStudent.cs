using BusinessLogic.Enums;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StudentTransferPlugin
{
    public partial class FormStudent : Form
    {
		public FormEducation FormEducation => (FormEducation)Enum.Parse(typeof(FormEducation), comboBox.SelectedItem.ToString());

		public FormStudent()
		{
			InitializeComponent();
			comboBox.DataSource = Enum.GetValues(typeof(FormEducation))
							.Cast<FormEducation>()
							.Select(x => x.ToString())
							.ToList();
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			if (comboBox.SelectedValue == null)
				MessageBox.Show("Выберите форму обучения");
			DialogResult = DialogResult.OK;
			Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
