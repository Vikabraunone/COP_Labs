
namespace FormingOrderPlugin
{
    partial class FormFormingOrder
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
            this.textBoxNewFIO = new System.Windows.Forms.TextBox();
            this.labelNewFIO = new System.Windows.Forms.Label();
            this.labelOrderNumber = new System.Windows.Forms.Label();
            this.textBoxOrderNumber = new System.Windows.Forms.TextBox();
            this.labelDateOrder = new System.Windows.Forms.Label();
            this.dateTimePickerOrder = new System.Windows.Forms.DateTimePicker();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.labelGroup = new System.Windows.Forms.Label();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxNewFIO
            // 
            this.textBoxNewFIO.Location = new System.Drawing.Point(25, 141);
            this.textBoxNewFIO.Name = "textBoxNewFIO";
            this.textBoxNewFIO.Size = new System.Drawing.Size(287, 20);
            this.textBoxNewFIO.TabIndex = 0;
            // 
            // labelNewFIO
            // 
            this.labelNewFIO.AutoSize = true;
            this.labelNewFIO.Location = new System.Drawing.Point(22, 125);
            this.labelNewFIO.Name = "labelNewFIO";
            this.labelNewFIO.Size = new System.Drawing.Size(72, 13);
            this.labelNewFIO.TabIndex = 1;
            this.labelNewFIO.Text = "Новое ФИО:";
            // 
            // labelOrderNumber
            // 
            this.labelOrderNumber.AutoSize = true;
            this.labelOrderNumber.Location = new System.Drawing.Point(22, 27);
            this.labelOrderNumber.Name = "labelOrderNumber";
            this.labelOrderNumber.Size = new System.Drawing.Size(89, 13);
            this.labelOrderNumber.TabIndex = 2;
            this.labelOrderNumber.Text = "Номер приказа:";
            // 
            // textBoxOrderNumber
            // 
            this.textBoxOrderNumber.Location = new System.Drawing.Point(25, 43);
            this.textBoxOrderNumber.Name = "textBoxOrderNumber";
            this.textBoxOrderNumber.Size = new System.Drawing.Size(287, 20);
            this.textBoxOrderNumber.TabIndex = 3;
            // 
            // labelDateOrder
            // 
            this.labelDateOrder.AutoSize = true;
            this.labelDateOrder.Location = new System.Drawing.Point(22, 73);
            this.labelDateOrder.Name = "labelDateOrder";
            this.labelDateOrder.Size = new System.Drawing.Size(81, 13);
            this.labelDateOrder.TabIndex = 4;
            this.labelDateOrder.Text = "Дата приказа:";
            // 
            // dateTimePickerOrder
            // 
            this.dateTimePickerOrder.Location = new System.Drawing.Point(25, 89);
            this.dateTimePickerOrder.Name = "dateTimePickerOrder";
            this.dateTimePickerOrder.Size = new System.Drawing.Size(287, 20);
            this.dateTimePickerOrder.TabIndex = 5;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(97, 216);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(139, 31);
            this.buttonShow.TabIndex = 6;
            this.buttonShow.Text = "Показать";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(97, 253);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(139, 31);
            this.buttonPrint.TabIndex = 7;
            this.buttonPrint.Text = "Отправить на печать";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(22, 174);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(45, 13);
            this.labelGroup.TabIndex = 9;
            this.labelGroup.Text = "Группа:";
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(25, 190);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(287, 20);
            this.textBoxGroup.TabIndex = 8;
            // 
            // FormFormingOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 293);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.textBoxGroup);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.dateTimePickerOrder);
            this.Controls.Add(this.labelDateOrder);
            this.Controls.Add(this.textBoxOrderNumber);
            this.Controls.Add(this.labelOrderNumber);
            this.Controls.Add(this.labelNewFIO);
            this.Controls.Add(this.textBoxNewFIO);
            this.Name = "FormFormingOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Формирование приказа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNewFIO;
        private System.Windows.Forms.Label labelNewFIO;
        private System.Windows.Forms.Label labelOrderNumber;
        private System.Windows.Forms.TextBox textBoxOrderNumber;
        private System.Windows.Forms.Label labelDateOrder;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrder;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.TextBox textBoxGroup;
    }
}