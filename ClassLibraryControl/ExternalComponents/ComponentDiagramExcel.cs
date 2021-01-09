using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ClassLibraryControl.ExternalComponents
{
    public partial class ComponentDiagramExcel : Component
    {
        public ComponentDiagramExcel()
        {
            InitializeComponent();
        }

        public ComponentDiagramExcel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void CreateDiagram(string fileName, Dictionary<string, int> dict)
        {
            Application excel_report = new Application { SheetsInNewWorkbook = 1 };
            // добавить книгу
            Workbook workBook = excel_report.Workbooks.Add(Type.Missing);
            // получаем первый лист документа
            Worksheet worksheet = (Worksheet)excel_report.Worksheets.get_Item(1);
            ChartObjects chartObjs = (ChartObjects)worksheet.ChartObjects();
            int row = 0;
            foreach (var pair in dict)
            {
                row++;
                worksheet.Cells[row, 1] = pair.Key;
                worksheet.Cells[row, 2] = pair.Value;
            }
            ChartObjects xlCharts = (ChartObjects)worksheet.ChartObjects(Type.Missing);
            ChartObject myChart = xlCharts.Add(110, 0, 350, 250);
            Chart chart = myChart.Chart;
            SeriesCollection seriesCollection = (SeriesCollection)chart.SeriesCollection(Type.Missing);
            Series series = seriesCollection.NewSeries();
            series.XValues = worksheet.get_Range("A1", "A" + row);
            series.Values = worksheet.get_Range("B1", "B" + row);
            chart.ChartType = XlChartType.xlPie;
            excel_report.Application.ActiveWorkbook.SaveAs(fileName, Type.Missing,
               Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlNoChange,
               Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }
    }
}
