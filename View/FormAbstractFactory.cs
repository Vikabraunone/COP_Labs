using System;
using System.Windows.Forms;

namespace View
{
    public partial class FormAbstractFactory : Form
    {
        public FormAbstractFactory()
        {
            InitializeComponent();
        }

        private void buttonShowCourse_Click(object sender, EventArgs e)
        {
            try
            {
                textBox.Text = controlAbstractFactory.SelectedCourse.Name + ", " + controlAbstractFactory.SelectedCourse.Code;
            }
            catch (Exception ex)
            {
                textBox.Text = ex.Message;
            }
        }

        private void buttonShowForm_Click(object sender, EventArgs e)
        {
            try
            {
                textBox.Text = controlAbstractFactory.SelectedForm.Name;
            }
            catch (Exception ex)
            {
                textBox.Text = ex.Message;
            }
        }

        private void buttonShowProgram_Click(object sender, EventArgs e)
        {
            try
            {
                textBox.Text = string.Join(",", controlAbstractFactory.SelectedCourse.Name, controlAbstractFactory.SelectedCourse.Code,
                    controlAbstractFactory.SelectedForm.Name);
            }
            catch (Exception ex)
            {
                textBox.Text = ex.Message;
            }
        }
    }
}
