namespace MailPlugin
{
    partial class FormSendMail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMessage = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.labelSubject = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelMailConfig = new System.Windows.Forms.Label();
            this.textBoxMailConfig = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(12, 122);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(68, 13);
            this.labelMessage.TabIndex = 0;
            this.labelMessage.Text = "Сообщение:";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(12, 138);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(436, 163);
            this.textBoxMessage.TabIndex = 1;
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(12, 86);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(432, 20);
            this.textBoxSubject.TabIndex = 6;
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(9, 70);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(64, 13);
            this.labelSubject.TabIndex = 7;
            this.labelSubject.Text = "Заголовок:";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(156, 307);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(157, 43);
            this.buttonSend.TabIndex = 13;
            this.buttonSend.Text = "Отправить уведомление";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelMailConfig
            // 
            this.labelMailConfig.AutoSize = true;
            this.labelMailConfig.Location = new System.Drawing.Point(9, 18);
            this.labelMailConfig.Name = "labelMailConfig";
            this.labelMailConfig.Size = new System.Drawing.Size(159, 13);
            this.labelMailConfig.TabIndex = 15;
            this.labelMailConfig.Text = "Путь до файла конфигурации:";
            // 
            // textBoxMailConfig
            // 
            this.textBoxMailConfig.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBoxMailConfig.Location = new System.Drawing.Point(12, 34);
            this.textBoxMailConfig.Name = "textBoxMailConfig";
            this.textBoxMailConfig.ReadOnly = true;
            this.textBoxMailConfig.Size = new System.Drawing.Size(432, 20);
            this.textBoxMailConfig.TabIndex = 14;
            this.textBoxMailConfig.Text = "Кликните два раза...";
            this.textBoxMailConfig.DoubleClick += new System.EventHandler(this.textBoxMailConfig_DoubleClick);
            // 
            // FormSendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 362);
            this.Controls.Add(this.labelMailConfig);
            this.Controls.Add(this.textBoxMailConfig);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.labelMessage);
            this.Name = "FormSendMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отправить уведомление студенту";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelMailConfig;
        private System.Windows.Forms.TextBox textBoxMailConfig;
    }
}