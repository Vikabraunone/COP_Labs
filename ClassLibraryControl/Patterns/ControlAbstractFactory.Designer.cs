
namespace ClassLibraryControl.Patterns
{
    partial class ControlAbstractFactory
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxCourse = new System.Windows.Forms.GroupBox();
            this.radioButtonISE = new System.Windows.Forms.RadioButton();
            this.radioButtonPI = new System.Windows.Forms.RadioButton();
            this.groupBoxForm = new System.Windows.Forms.GroupBox();
            this.radioButtonPartForm = new System.Windows.Forms.RadioButton();
            this.radioButtonFullAndPartForm = new System.Windows.Forms.RadioButton();
            this.radioButtonFullForm = new System.Windows.Forms.RadioButton();
            this.groupBoxCourse.SuspendLayout();
            this.groupBoxForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCourse
            // 
            this.groupBoxCourse.Controls.Add(this.radioButtonISE);
            this.groupBoxCourse.Controls.Add(this.radioButtonPI);
            this.groupBoxCourse.Location = new System.Drawing.Point(13, 15);
            this.groupBoxCourse.Name = "groupBoxCourse";
            this.groupBoxCourse.Size = new System.Drawing.Size(200, 117);
            this.groupBoxCourse.TabIndex = 3;
            this.groupBoxCourse.TabStop = false;
            this.groupBoxCourse.Text = "Направление";
            // 
            // radioButtonISE
            // 
            this.radioButtonISE.AutoSize = true;
            this.radioButtonISE.Location = new System.Drawing.Point(17, 83);
            this.radioButtonISE.Name = "radioButtonISE";
            this.radioButtonISE.Size = new System.Drawing.Size(47, 17);
            this.radioButtonISE.TabIndex = 1;
            this.radioButtonISE.TabStop = true;
            this.radioButtonISE.Text = "ИСЭ";
            this.radioButtonISE.UseVisualStyleBackColor = true;
            // 
            // radioButtonPI
            // 
            this.radioButtonPI.AutoSize = true;
            this.radioButtonPI.Location = new System.Drawing.Point(17, 41);
            this.radioButtonPI.Name = "radioButtonPI";
            this.radioButtonPI.Size = new System.Drawing.Size(41, 17);
            this.radioButtonPI.TabIndex = 0;
            this.radioButtonPI.TabStop = true;
            this.radioButtonPI.Text = "ПИ";
            this.radioButtonPI.UseVisualStyleBackColor = true;
            // 
            // groupBoxForm
            // 
            this.groupBoxForm.Controls.Add(this.radioButtonPartForm);
            this.groupBoxForm.Controls.Add(this.radioButtonFullAndPartForm);
            this.groupBoxForm.Controls.Add(this.radioButtonFullForm);
            this.groupBoxForm.Location = new System.Drawing.Point(219, 15);
            this.groupBoxForm.Name = "groupBoxForm";
            this.groupBoxForm.Size = new System.Drawing.Size(222, 156);
            this.groupBoxForm.TabIndex = 2;
            this.groupBoxForm.TabStop = false;
            this.groupBoxForm.Text = "Форма обучения";
            // 
            // radioButtonPartForm
            // 
            this.radioButtonPartForm.AutoSize = true;
            this.radioButtonPartForm.Location = new System.Drawing.Point(18, 123);
            this.radioButtonPartForm.Name = "radioButtonPartForm";
            this.radioButtonPartForm.Size = new System.Drawing.Size(153, 17);
            this.radioButtonPartForm.TabIndex = 2;
            this.radioButtonPartForm.TabStop = true;
            this.radioButtonPartForm.Text = "Заочная форма обучения";
            this.radioButtonPartForm.UseVisualStyleBackColor = true;
            // 
            // radioButtonFullAndPartForm
            // 
            this.radioButtonFullAndPartForm.AutoSize = true;
            this.radioButtonFullAndPartForm.Location = new System.Drawing.Point(18, 82);
            this.radioButtonFullAndPartForm.Name = "radioButtonFullAndPartForm";
            this.radioButtonFullAndPartForm.Size = new System.Drawing.Size(180, 17);
            this.radioButtonFullAndPartForm.TabIndex = 1;
            this.radioButtonFullAndPartForm.TabStop = true;
            this.radioButtonFullAndPartForm.Text = "Очно-заочная форма обучения";
            this.radioButtonFullAndPartForm.UseVisualStyleBackColor = true;
            // 
            // radioButtonFullForm
            // 
            this.radioButtonFullForm.AutoSize = true;
            this.radioButtonFullForm.Location = new System.Drawing.Point(18, 40);
            this.radioButtonFullForm.Name = "radioButtonFullForm";
            this.radioButtonFullForm.Size = new System.Drawing.Size(142, 17);
            this.radioButtonFullForm.TabIndex = 0;
            this.radioButtonFullForm.TabStop = true;
            this.radioButtonFullForm.Text = "Очная форма обучения";
            this.radioButtonFullForm.UseVisualStyleBackColor = true;
            // 
            // ControlAbstractFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxCourse);
            this.Controls.Add(this.groupBoxForm);
            this.Name = "ControlAbstractFactory";
            this.Size = new System.Drawing.Size(451, 180);
            this.groupBoxCourse.ResumeLayout(false);
            this.groupBoxCourse.PerformLayout();
            this.groupBoxForm.ResumeLayout(false);
            this.groupBoxForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCourse;
        private System.Windows.Forms.RadioButton radioButtonISE;
        private System.Windows.Forms.RadioButton radioButtonPI;
        private System.Windows.Forms.GroupBox groupBoxForm;
        private System.Windows.Forms.RadioButton radioButtonPartForm;
        private System.Windows.Forms.RadioButton radioButtonFullAndPartForm;
        private System.Windows.Forms.RadioButton radioButtonFullForm;
    }
}
