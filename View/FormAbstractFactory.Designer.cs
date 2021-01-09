
namespace View
{
    partial class FormAbstractFactory
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
            this.controlAbstractFactory = new ClassLibraryControl.Patterns.ControlAbstractFactory();
            this.buttonShowProgram = new System.Windows.Forms.Button();
            this.buttonShowForm = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonShowCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // controlAbstractFactory
            // 
            this.controlAbstractFactory.Location = new System.Drawing.Point(12, 12);
            this.controlAbstractFactory.Name = "controlAbstractFactory";
            this.controlAbstractFactory.Size = new System.Drawing.Size(451, 180);
            this.controlAbstractFactory.TabIndex = 0;
            // 
            // buttonShowProgram
            // 
            this.buttonShowProgram.Location = new System.Drawing.Point(639, 118);
            this.buttonShowProgram.Name = "buttonShowProgram";
            this.buttonShowProgram.Size = new System.Drawing.Size(142, 63);
            this.buttonShowProgram.TabIndex = 9;
            this.buttonShowProgram.Text = "Показать образовательную  программу";
            this.buttonShowProgram.UseVisualStyleBackColor = true;
            this.buttonShowProgram.Click += new System.EventHandler(this.buttonShowProgram_Click);
            // 
            // buttonShowForm
            // 
            this.buttonShowForm.Location = new System.Drawing.Point(639, 76);
            this.buttonShowForm.Name = "buttonShowForm";
            this.buttonShowForm.Size = new System.Drawing.Size(142, 36);
            this.buttonShowForm.TabIndex = 8;
            this.buttonShowForm.Text = "Показать форму обучения";
            this.buttonShowForm.UseVisualStyleBackColor = true;
            this.buttonShowForm.Click += new System.EventHandler(this.buttonShowForm_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(469, 33);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(164, 148);
            this.textBox.TabIndex = 7;
            // 
            // buttonShowCourse
            // 
            this.buttonShowCourse.Location = new System.Drawing.Point(639, 33);
            this.buttonShowCourse.Name = "buttonShowCourse";
            this.buttonShowCourse.Size = new System.Drawing.Size(142, 37);
            this.buttonShowCourse.TabIndex = 6;
            this.buttonShowCourse.Text = "Показать направление";
            this.buttonShowCourse.UseVisualStyleBackColor = true;
            this.buttonShowCourse.Click += new System.EventHandler(this.buttonShowCourse_Click);
            // 
            // FormAbstractFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 195);
            this.Controls.Add(this.buttonShowProgram);
            this.Controls.Add(this.buttonShowForm);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.buttonShowCourse);
            this.Controls.Add(this.controlAbstractFactory);
            this.Name = "FormAbstractFactory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AbstractFactory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClassLibraryControl.Patterns.ControlAbstractFactory controlAbstractFactory;
        private System.Windows.Forms.Button buttonShowProgram;
        private System.Windows.Forms.Button buttonShowForm;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonShowCourse;
    }
}