using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.OfficeChart;

namespace ChartsTest
{
    class Program
    {

        static void Main(string[] args)
        {

            CreateDemoChart();

        }


        static void CreateDemoChart()
        {

            //Creates a new Word document
            WordDocument document = new WordDocument();
            //Adds section to the document
            IWSection sec = document.AddSection();
            //Adds paragraph to the section
            IWParagraph paragraph = sec.AddParagraph();
            
            //Inputs data for chart
            object[][] data = new object[5][];
            for (int i = 0; i < 5; i++)
                data[i] = new object[3];
            data[0][0] = "";
            data[1][0] = "Apples";
            data[2][0] = "Oranges";
            data[3][0] = "Onions";
            data[4][0] = "Cakes";
            data[0][1] = "Sales";
            data[1][1] = 50;
            data[2][1] = 70;
            data[3][1] = 45;
            data[4][1] = 97;
            data[0][2] = "Purchases";
            data[1][2] = 70;
            data[2][2] = 100;
            data[3][2] = 50;
            data[4][2] = 100;

            //Creates and Appends chart to the paragraph
            WChart chart = paragraph.AppendChart(data, 470, 300);
            
            //Sets chart type and title
            chart.ChartTitle = "Sales Details";
            chart.ChartTitleArea.FontName = "Calibri";
            chart.ChartTitleArea.Size = 14;
            chart.ChartArea.Border.LinePattern = OfficeChartLinePattern.None;

            // set chart type
            chart.ChartType = OfficeChartType.Line;
            
            //Sets position of legend
            chart.Legend.Position = OfficeLegendPosition.Bottom;
            
            //Saves the document
            document.Save("Sample.docx", FormatType.Docx);
            
            //Closes the document
            document.Close();

            var p = new Process();
            p.StartInfo = new ProcessStartInfo("Sample.docx")
            {
                UseShellExecute = true
            };
            p.Start();

        }

    }
}
