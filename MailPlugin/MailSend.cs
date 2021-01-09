using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MailPlugin
{
    public static class MailSend
    {
        public static async void Send(MailSendInfo info)
        {
            if (string.IsNullOrEmpty(info.SmtpClientHost) || info.SmtpClientPort == 0)
                return;
            if (string.IsNullOrEmpty(info.SenderMailLogin) || string.IsNullOrEmpty(info.SenderMailPassword))
                return;
            if (string.IsNullOrEmpty(info.RecieverMailAddress) || string.IsNullOrEmpty(info.Subject) || string.IsNullOrEmpty(info.Text))
                return;
            using (var objMailMessage = new MailMessage())
            {
                using (var objSmtpClient = new SmtpClient(info.SmtpClientHost, info.SmtpClientPort))
                {
                    try
                    {
                        objMailMessage.From = new MailAddress(info.SenderMailLogin);
                        objMailMessage.To.Add(new MailAddress(info.RecieverMailAddress));
                        objMailMessage.Subject = info.Subject;
                        objMailMessage.Body = info.Text;
                        objMailMessage.SubjectEncoding = Encoding.UTF8;
                        objMailMessage.BodyEncoding = Encoding.UTF8;
                        objSmtpClient.UseDefaultCredentials = false;
                        objSmtpClient.EnableSsl = true; objSmtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                        objSmtpClient.Credentials = new NetworkCredential(info.SenderMailLogin, info.SenderMailPassword);
                        await Task.Run(() => objSmtpClient.Send(objMailMessage));
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }
    }
}
