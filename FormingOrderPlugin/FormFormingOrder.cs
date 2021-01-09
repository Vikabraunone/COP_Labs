using BusinessLogic.BindingModels;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace FormingOrderPlugin
{
    public partial class FormFormingOrder : Form
    {
        private StudentBindingModel student;

        public FormFormingOrder(StudentBindingModel student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            // обработчик события печати
            printDocument.PrintPage += PrintPageHandler;
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            // объект для печати
            PrintDocument printDocument = new PrintDocument();

            // обработчик события печати
            printDocument.PrintPage += PrintPageHandler;

            // диалог настройки печати
            PrintDialog printDialog = new PrintDialog();

            // установка объекта печати для его настройки
            printDialog.Document = printDocument;

            // если в диалоге было нажато ОК
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); // печатаем
        }

        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            string fio = student.FIO;
            string group = textBoxGroup.Text;
            string newFio = textBoxNewFIO.Text;
            string date = dateTimePickerOrder.Value.ToShortDateString();
            string numberOrder = textBoxOrderNumber.Text;

            if (string.IsNullOrEmpty(fio) || string.IsNullOrEmpty(group) || string.IsNullOrEmpty(newFio) || string.IsNullOrEmpty(numberOrder))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            string text = $"\r{fio}, студенту группы {group}, в связи с переменой ФИО на {newFio} внести изменения в студенческий билет, " +
                    $"зачетную книжку, личное дело.\n\rОснование: заявление студента, копия свидетельства о заключении брака.";
            Font font = new Font("Arial", 14);
            e.Graphics.MeasureString(text, font,
               e.MarginBounds.Size, StringFormat.GenericTypographic);

            //печатаем приказ
            var width = e.MarginBounds.Size.Width;
            var center = width / 2;
            string header = "";
            int i = 0;
            while (i < center - 3)
            {
                header += " ";
                i++;
            }
            header += "Приказ N" + numberOrder + " от " + date + "\n\r";

            e.Graphics.DrawString(header + text, font, Brushes.Black,
                e.MarginBounds, StringFormat.GenericTypographic);
        }
    }
}
