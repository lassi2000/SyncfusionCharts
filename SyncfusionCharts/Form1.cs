using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.DocIO.DLS;
using Syncfusion.OfficeChart;

namespace SyncfusionCharts
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            cChartData_GRID.Columns[1].ValueType = typeof(double);

        }


        // get data from table
        private object[][] GetData()
        {
            var rowsCount = cChartData_GRID.Rows.Count - 1;

            if (rowsCount == 1) return null;

            object[][] ret = new object[rowsCount + 1][];

            ret[0] = new object[] { "", "Sales" };

            for (int i = 1; i <= rowsCount; i++)
            {
                var gridRowCount = i - 1;

                ret[i] = new object[2];
                ret[i][0] = cChartData_GRID.Rows[gridRowCount].Cells[0].Value;
                ret[i][1] = cChartData_GRID.Rows[gridRowCount].Cells[1].Value;
            }

            return ret;
        }


        // Generate Button - Click
        private void button1_Click(object sender, EventArgs e)
        {

            string DOC_FILE = Path.Combine(Environment.CurrentDirectory, "Sample.docx");

            WordDocument doc = new();
            var para = doc.AddSection().AddParagraph();

            var data = GetData();
            var labelsCount = data.Count() - 1;
            if (data == null)
            {
                MessageBox.Show("Insert some data please");
                return;
            }
            var chart = para.AppendChart(data, 400, 600);

            try
            {
                chart.ChartType = Enum.Parse<OfficeChartType>(cChartType_CB.Text, true);
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a valid Chart Type");
                return;
            }

            chart.ChartTitle = "Custom Chart";

            var series = chart.Series[0];
            series.Values = chart.ChartData[2, 2, labelsCount + 1, 2];

            series.DataPoints.DefaultDataPoint.DataLabels.IsValue = true;
            if (chart.ChartType == OfficeChartType.Line)
                series.DataPoints.DefaultDataPoint.DataLabels.Position = OfficeDataLabelPosition.Below;
            else
                series.DataPoints.DefaultDataPoint.DataLabels.Position = OfficeDataLabelPosition.Outside;

            chart.ChartArea.Fill.ForeColor = Color.FromArgb(242, 242, 242);
            chart.PlotArea.Fill.ForeColor = Color.FromArgb(242, 242, 242);
            chart.ChartArea.Border.LinePattern = OfficeChartLinePattern.None;

            chart.PrimaryCategoryAxis.CategoryLabels = chart.ChartData[2, 1, labelsCount + 1, 1];

            doc.Save(DOC_FILE);

            doc.Close();

            using var p = new Process();
            p.StartInfo = new ProcessStartInfo(DOC_FILE)
            {
                UseShellExecute = true
            };
            p.Start();

        }

    }
}
