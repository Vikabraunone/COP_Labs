namespace View
{
    partial class FormStudents
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.бекапToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоСтудентамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диаграммаПоФормамОбученияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.паттерныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abstractFactoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adapterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componentExcelReport = new ClassLibraryExcelReport.ExcelComponent();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRef = new System.Windows.Forms.Button();
            this.groupBoxPatternCommand = new System.Windows.Forms.GroupBox();
            this.buttonEnroll = new System.Windows.Forms.Button();
            this.buttonDeduct = new System.Windows.Forms.Button();
            this.buttonInfoUpdateStudent = new System.Windows.Forms.Button();
            this.groupBoxCRUD = new System.Windows.Forms.GroupBox();
            this.controlDataGridViewOutput = new ClassLibraryControl.ExternalComponents.ControlDataGridViewOutput();
            this.componentRestore = new ClassLibraryControl.ExternalComponents.ComponentRestore(this.components);
            this.componentBackUp = new ClassLibraryControl.Components.ComponentBackUp(this.components);
            this.componentDiagramExcel = new ClassLibraryControl.ExternalComponents.ComponentDiagramExcel(this.components);
            this.componentCommand = new ClassLibraryControl.Patterns.ComponentCommand(this.components);
            this.groupBoxDataGridView = new System.Windows.Forms.GroupBox();
            this.textBoxSetId = new System.Windows.Forms.TextBox();
            this.buttonSetId = new System.Windows.Forms.Button();
            this.textBoxCurrentId = new System.Windows.Forms.TextBox();
            this.labelCurrentId = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.groupBoxPatternCommand.SuspendLayout();
            this.groupBoxCRUD.SuspendLayout();
            this.groupBoxDataGridView.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.бекапToolStripMenuItem,
            this.отчетПоСтудентамToolStripMenuItem,
            this.диаграммаПоФормамОбученияToolStripMenuItem,
            this.паттерныToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(843, 24);
            this.menuStrip.TabIndex = 12;
            this.menuStrip.Text = "menuStrip";
            // 
            // бекапToolStripMenuItem
            // 
            this.бекапToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьДанныеToolStripMenuItem,
            this.сохранитьДанныеToolStripMenuItem});
            this.бекапToolStripMenuItem.Name = "бекапToolStripMenuItem";
            this.бекапToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.бекапToolStripMenuItem.Text = "Бекап";
            // 
            // загрузитьДанныеToolStripMenuItem
            // 
            this.загрузитьДанныеToolStripMenuItem.Name = "загрузитьДанныеToolStripMenuItem";
            this.загрузитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.загрузитьДанныеToolStripMenuItem.Text = "Загрузить данные";
            this.загрузитьДанныеToolStripMenuItem.Click += new System.EventHandler(this.загрузитьДанныеToolStripMenuItem_Click);
            // 
            // сохранитьДанныеToolStripMenuItem
            // 
            this.сохранитьДанныеToolStripMenuItem.Name = "сохранитьДанныеToolStripMenuItem";
            this.сохранитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.сохранитьДанныеToolStripMenuItem.Text = "Сохранить данные";
            this.сохранитьДанныеToolStripMenuItem.Click += new System.EventHandler(this.сохранитьДанныеToolStripMenuItem_Click);
            // 
            // отчетПоСтудентамToolStripMenuItem
            // 
            this.отчетПоСтудентамToolStripMenuItem.Name = "отчетПоСтудентамToolStripMenuItem";
            this.отчетПоСтудентамToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.отчетПоСтудентамToolStripMenuItem.Text = "Отчет по студентам";
            this.отчетПоСтудентамToolStripMenuItem.Click += new System.EventHandler(this.отчетПоСтудентамToolStripMenuItem_Click);
            // 
            // диаграммаПоФормамОбученияToolStripMenuItem
            // 
            this.диаграммаПоФормамОбученияToolStripMenuItem.Name = "диаграммаПоФормамОбученияToolStripMenuItem";
            this.диаграммаПоФормамОбученияToolStripMenuItem.Size = new System.Drawing.Size(205, 20);
            this.диаграммаПоФормамОбученияToolStripMenuItem.Text = "Диаграмма по формам обучения";
            this.диаграммаПоФормамОбученияToolStripMenuItem.Click += new System.EventHandler(this.диаграммаПоФормамОбученияToolStripMenuItem_Click);
            // 
            // паттерныToolStripMenuItem
            // 
            this.паттерныToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abstractFactoryToolStripMenuItem,
            this.adapterToolStripMenuItem});
            this.паттерныToolStripMenuItem.Name = "паттерныToolStripMenuItem";
            this.паттерныToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.паттерныToolStripMenuItem.Text = "Паттерны";
            // 
            // abstractFactoryToolStripMenuItem
            // 
            this.abstractFactoryToolStripMenuItem.Name = "abstractFactoryToolStripMenuItem";
            this.abstractFactoryToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.abstractFactoryToolStripMenuItem.Text = "AbstractFactory";
            this.abstractFactoryToolStripMenuItem.Click += new System.EventHandler(this.abstractFactoryToolStripMenuItem_Click);
            // 
            // adapterToolStripMenuItem
            // 
            this.adapterToolStripMenuItem.Name = "adapterToolStripMenuItem";
            this.adapterToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.adapterToolStripMenuItem.Text = "Adapter";
            this.adapterToolStripMenuItem.Click += new System.EventHandler(this.adapterToolStripMenuItem_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(15, 32);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(83, 32);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(130, 32);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(83, 32);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(130, 83);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(83, 32);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonRef
            // 
            this.buttonRef.Location = new System.Drawing.Point(15, 83);
            this.buttonRef.Name = "buttonRef";
            this.buttonRef.Size = new System.Drawing.Size(83, 32);
            this.buttonRef.TabIndex = 15;
            this.buttonRef.Text = "Обновить";
            this.buttonRef.UseVisualStyleBackColor = true;
            this.buttonRef.Click += new System.EventHandler(this.buttonRef_Click);
            // 
            // groupBoxPatternCommand
            // 
            this.groupBoxPatternCommand.Controls.Add(this.buttonEnroll);
            this.groupBoxPatternCommand.Controls.Add(this.buttonDeduct);
            this.groupBoxPatternCommand.Controls.Add(this.buttonInfoUpdateStudent);
            this.groupBoxPatternCommand.Location = new System.Drawing.Point(27, 362);
            this.groupBoxPatternCommand.Name = "groupBoxPatternCommand";
            this.groupBoxPatternCommand.Size = new System.Drawing.Size(152, 161);
            this.groupBoxPatternCommand.TabIndex = 18;
            this.groupBoxPatternCommand.TabStop = false;
            this.groupBoxPatternCommand.Text = "Паттерн Command";
            // 
            // buttonEnroll
            // 
            this.buttonEnroll.Location = new System.Drawing.Point(6, 23);
            this.buttonEnroll.Name = "buttonEnroll";
            this.buttonEnroll.Size = new System.Drawing.Size(141, 40);
            this.buttonEnroll.TabIndex = 14;
            this.buttonEnroll.Text = "Зачислить студента";
            this.buttonEnroll.UseVisualStyleBackColor = true;
            this.buttonEnroll.Click += new System.EventHandler(this.buttonEnroll_Click);
            // 
            // buttonDeduct
            // 
            this.buttonDeduct.Location = new System.Drawing.Point(6, 115);
            this.buttonDeduct.Name = "buttonDeduct";
            this.buttonDeduct.Size = new System.Drawing.Size(141, 40);
            this.buttonDeduct.TabIndex = 16;
            this.buttonDeduct.Text = "Отчислить студента";
            this.buttonDeduct.UseVisualStyleBackColor = true;
            this.buttonDeduct.Click += new System.EventHandler(this.buttonDeduct_Click);
            // 
            // buttonInfoUpdateStudent
            // 
            this.buttonInfoUpdateStudent.Location = new System.Drawing.Point(6, 69);
            this.buttonInfoUpdateStudent.Name = "buttonInfoUpdateStudent";
            this.buttonInfoUpdateStudent.Size = new System.Drawing.Size(141, 40);
            this.buttonInfoUpdateStudent.TabIndex = 15;
            this.buttonInfoUpdateStudent.Text = "Обновить информацию о студенте";
            this.buttonInfoUpdateStudent.UseVisualStyleBackColor = true;
            this.buttonInfoUpdateStudent.Click += new System.EventHandler(this.buttonInfoUpdateStudent_Click);
            // 
            // groupBoxCRUD
            // 
            this.groupBoxCRUD.Controls.Add(this.buttonAdd);
            this.groupBoxCRUD.Controls.Add(this.buttonUpdate);
            this.groupBoxCRUD.Controls.Add(this.buttonDelete);
            this.groupBoxCRUD.Controls.Add(this.buttonRef);
            this.groupBoxCRUD.Location = new System.Drawing.Point(204, 371);
            this.groupBoxCRUD.Name = "groupBoxCRUD";
            this.groupBoxCRUD.Size = new System.Drawing.Size(234, 152);
            this.groupBoxCRUD.TabIndex = 19;
            this.groupBoxCRUD.TabStop = false;
            this.groupBoxCRUD.Text = "Работа со студентами";
            // 
            // controlDataGridViewOutput
            // 
            this.controlDataGridViewOutput.Location = new System.Drawing.Point(12, 27);
            this.controlDataGridViewOutput.Name = "controlDataGridViewOutput";
            this.controlDataGridViewOutput.SelectedIndex = 0;
            this.controlDataGridViewOutput.Size = new System.Drawing.Size(825, 329);
            this.controlDataGridViewOutput.TabIndex = 13;
            this.controlDataGridViewOutput.DataGridViewSelectionChanged += new System.EventHandler(this.controlDataGridViewOutput_DataGridViewSelectionChanged);
            // 
            // groupBoxDataGridView
            // 
            this.groupBoxDataGridView.Controls.Add(this.textBoxSetId);
            this.groupBoxDataGridView.Controls.Add(this.buttonSetId);
            this.groupBoxDataGridView.Controls.Add(this.textBoxCurrentId);
            this.groupBoxDataGridView.Controls.Add(this.labelCurrentId);
            this.groupBoxDataGridView.Location = new System.Drawing.Point(465, 362);
            this.groupBoxDataGridView.Name = "groupBoxDataGridView";
            this.groupBoxDataGridView.Size = new System.Drawing.Size(136, 161);
            this.groupBoxDataGridView.TabIndex = 20;
            this.groupBoxDataGridView.TabStop = false;
            this.groupBoxDataGridView.Text = "Работа с таблицей";
            // 
            // textBoxSetId
            // 
            this.textBoxSetId.Location = new System.Drawing.Point(6, 19);
            this.textBoxSetId.Name = "textBoxSetId";
            this.textBoxSetId.Size = new System.Drawing.Size(115, 20);
            this.textBoxSetId.TabIndex = 5;
            // 
            // buttonSetId
            // 
            this.buttonSetId.Location = new System.Drawing.Point(6, 45);
            this.buttonSetId.Name = "buttonSetId";
            this.buttonSetId.Size = new System.Drawing.Size(115, 41);
            this.buttonSetId.TabIndex = 6;
            this.buttonSetId.Text = "Выбрать номер строки";
            this.buttonSetId.UseVisualStyleBackColor = true;
            this.buttonSetId.Click += new System.EventHandler(this.buttonSetId_Click);
            // 
            // textBoxCurrentId
            // 
            this.textBoxCurrentId.Location = new System.Drawing.Point(6, 135);
            this.textBoxCurrentId.Name = "textBoxCurrentId";
            this.textBoxCurrentId.Size = new System.Drawing.Size(115, 20);
            this.textBoxCurrentId.TabIndex = 7;
            // 
            // labelCurrentId
            // 
            this.labelCurrentId.AutoSize = true;
            this.labelCurrentId.Location = new System.Drawing.Point(3, 119);
            this.labelCurrentId.Name = "labelCurrentId";
            this.labelCurrentId.Size = new System.Drawing.Size(64, 13);
            this.labelCurrentId.TabIndex = 8;
            this.labelCurrentId.Text = "Текущий Id";
            // 
            // FormStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 545);
            this.Controls.Add(this.groupBoxDataGridView);
            this.Controls.Add(this.groupBoxCRUD);
            this.Controls.Add(this.groupBoxPatternCommand);
            this.Controls.Add(this.controlDataGridViewOutput);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список студентов";
            this.Load += new System.EventHandler(this.FormStudents_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBoxPatternCommand.ResumeLayout(false);
            this.groupBoxCRUD.ResumeLayout(false);
            this.groupBoxDataGridView.ResumeLayout(false);
            this.groupBoxDataGridView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem бекапToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетПоСтудентамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диаграммаПоФормамОбученияToolStripMenuItem;
        private ClassLibraryControl.ExternalComponents.ControlDataGridViewOutput controlDataGridViewOutput;
        private ClassLibraryControl.ExternalComponents.ComponentRestore componentRestore;
        private ClassLibraryControl.Components.ComponentBackUp componentBackUp;
        private ClassLibraryControl.ExternalComponents.ComponentDiagramExcel componentDiagramExcel;
        private ClassLibraryExcelReport.ExcelComponent componentExcelReport;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRef;
        private System.Windows.Forms.ToolStripMenuItem паттерныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abstractFactoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adapterToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxPatternCommand;
        private System.Windows.Forms.Button buttonEnroll;
        private System.Windows.Forms.Button buttonDeduct;
        private System.Windows.Forms.Button buttonInfoUpdateStudent;
        private System.Windows.Forms.GroupBox groupBoxCRUD;
        private ClassLibraryControl.Patterns.ComponentCommand componentCommand;
        private System.Windows.Forms.GroupBox groupBoxDataGridView;
        private System.Windows.Forms.TextBox textBoxSetId;
        private System.Windows.Forms.Button buttonSetId;
        private System.Windows.Forms.TextBox textBoxCurrentId;
        private System.Windows.Forms.Label labelCurrentId;
    }
}