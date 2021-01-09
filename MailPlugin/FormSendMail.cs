using BusinessLogic.BindingModels;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Windows.Forms;

namespace MailPlugin
{
    public partial class FormSendMail : Form
    {
        private MailSendInfo mailSendInfo = new MailSendInfo();

        private StudentBindingModel student;

        public FormSendMail(StudentBindingModel student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(textBoxMailConfig.Text))
                {
                    var text = File.ReadAllText(textBoxMailConfig.Text);
                    dynamic json = JObject.Parse(text);
                    mailSendInfo.SmtpClientHost = json.Config.SmtpClientHost;
                    mailSendInfo.SmtpClientPort = json.Config.SmtpClientPort;
                    mailSendInfo.SenderMailLogin = json.Config.MailLogin;
                    mailSendInfo.SenderMailPassword = json.Config.MailPassword;
                    mailSendInfo.RecieverMailAddress = student.Email;
                    mailSendInfo.Subject = textBoxSubject.Text;
                    mailSendInfo.Text = textBoxMessage.Text;
                    MailSend.Send(mailSendInfo);
                    MessageBox.Show("Сообщение отправлено успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Сообщение не удалось отправить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxMailConfig_DoubleClick(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog { Filter = "json|*.json" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxMailConfig.Text = dialog.FileName;
                }
            }
        }
    }
}
