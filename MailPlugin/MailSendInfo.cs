namespace MailPlugin
{
    public class MailSendInfo
    {
        public string RecieverMailAddress { get; set; }

        public string Subject { get; set; }

        public string Text { get; set; }

        public string SmtpClientHost { get; set; }

        public int SmtpClientPort { get; set; }

        public string SenderMailLogin { get; set; }

        public string SenderMailPassword { get; set; }
    }
}
