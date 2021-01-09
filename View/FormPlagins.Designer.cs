
namespace View
{
	partial class FormPlagins
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
			this.buttonRun = new System.Windows.Forms.Button();
			this.comboBoxPlugins = new System.Windows.Forms.ComboBox();
			this.labelPlugins = new System.Windows.Forms.Label();
			this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
			this.labelStudents = new System.Windows.Forms.Label();
			this.buttonUpdateStudents = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonRun
			// 
			this.buttonRun.Location = new System.Drawing.Point(12, 421);
			this.buttonRun.Name = "buttonRun";
			this.buttonRun.Size = new System.Drawing.Size(75, 23);
			this.buttonRun.TabIndex = 1;
			this.buttonRun.Text = "Запустить";
			this.buttonRun.UseVisualStyleBackColor = true;
			this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
			// 
			// comboBoxPlugins
			// 
			this.comboBoxPlugins.FormattingEnabled = true;
			this.comboBoxPlugins.Location = new System.Drawing.Point(12, 394);
			this.comboBoxPlugins.Name = "comboBoxPlugins";
			this.comboBoxPlugins.Size = new System.Drawing.Size(322, 21);
			this.comboBoxPlugins.TabIndex = 2;
			// 
			// labelPlugins
			// 
			this.labelPlugins.AutoSize = true;
			this.labelPlugins.Location = new System.Drawing.Point(9, 366);
			this.labelPlugins.Name = "labelPlugins";
			this.labelPlugins.Size = new System.Drawing.Size(92, 13);
			this.labelPlugins.TabIndex = 3;
			this.labelPlugins.Text = "Выбрать плагин:";
			// 
			// dataGridViewStudents
			// 
			this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewStudents.Location = new System.Drawing.Point(12, 49);
			this.dataGridViewStudents.Name = "dataGridViewStudents";
			this.dataGridViewStudents.Size = new System.Drawing.Size(708, 275);
			this.dataGridViewStudents.TabIndex = 4;
			// 
			// labelStudents
			// 
			this.labelStudents.AutoSize = true;
			this.labelStudents.Location = new System.Drawing.Point(12, 20);
			this.labelStudents.Name = "labelStudents";
			this.labelStudents.Size = new System.Drawing.Size(58, 13);
			this.labelStudents.TabIndex = 5;
			this.labelStudents.Text = "Студенты:";
			// 
			// buttonUpdateStudents
			// 
			this.buttonUpdateStudents.Location = new System.Drawing.Point(581, 7);
			this.buttonUpdateStudents.Name = "buttonUpdateStudents";
			this.buttonUpdateStudents.Size = new System.Drawing.Size(139, 39);
			this.buttonUpdateStudents.TabIndex = 8;
			this.buttonUpdateStudents.Text = "Обновить список";
			this.buttonUpdateStudents.UseVisualStyleBackColor = true;
			this.buttonUpdateStudents.Click += new System.EventHandler(this.buttonUpdateStudents_Click);
			// 
			// FormPlagins
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(742, 491);
			this.Controls.Add(this.buttonUpdateStudents);
			this.Controls.Add(this.labelStudents);
			this.Controls.Add(this.dataGridViewStudents);
			this.Controls.Add(this.labelPlugins);
			this.Controls.Add(this.comboBoxPlugins);
			this.Controls.Add(this.buttonRun);
			this.Name = "FormPlagins";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Плагины";
			this.Load += new System.EventHandler(this.FormPlagins_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonRun;
		private System.Windows.Forms.ComboBox comboBoxPlugins;
		private System.Windows.Forms.Label labelPlugins;
		private System.Windows.Forms.DataGridView dataGridViewStudents;
		private System.Windows.Forms.Label labelStudents;
		private System.Windows.Forms.Button buttonUpdateStudents;
	}
}