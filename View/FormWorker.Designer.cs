
namespace View
{
    partial class FormWorker
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
            this.components = new System.ComponentModel.Container();
            this.labelWages = new System.Windows.Forms.Label();
            this.textBoxWages = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.componentAdapter = new ClassLibraryControl.Patterns.ComponentAdapter(this.components);
            this.SuspendLayout();
            // 
            // labelWages
            // 
            this.labelWages.AutoSize = true;
            this.labelWages.Location = new System.Drawing.Point(21, 118);
            this.labelWages.Name = "labelWages";
            this.labelWages.Size = new System.Drawing.Size(58, 13);
            this.labelWages.TabIndex = 35;
            this.labelWages.Text = "Зарплата:";
            // 
            // textBoxWages
            // 
            this.textBoxWages.Location = new System.Drawing.Point(24, 134);
            this.textBoxWages.Name = "textBoxWages";
            this.textBoxWages.Size = new System.Drawing.Size(210, 20);
            this.textBoxWages.TabIndex = 34;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(123, 177);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(71, 22);
            this.buttonCancel.TabIndex = 33;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(46, 177);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(71, 22);
            this.buttonSave.TabIndex = 32;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(24, 84);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(210, 20);
            this.textBoxEmail.TabIndex = 31;
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(24, 35);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(210, 20);
            this.textBoxFIO.TabIndex = 29;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(21, 68);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(107, 13);
            this.labelEmail.TabIndex = 28;
            this.labelEmail.Text = "Электронная почта:";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(21, 19);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(37, 13);
            this.labelFIO.TabIndex = 26;
            this.labelFIO.Text = "ФИО:";
            // 
            // FormWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 217);
            this.Controls.Add(this.labelWages);
            this.Controls.Add(this.textBoxWages);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelFIO);
            this.Name = "FormWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудник";
            this.Load += new System.EventHandler(this.FormWorker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWages;
        private System.Windows.Forms.TextBox textBoxWages;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelFIO;
        private ClassLibraryControl.Patterns.ComponentAdapter componentAdapter;
    }
}