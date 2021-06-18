using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Data.SqlClient;
using PBL3REAL.Extention;
using PBL3REAL.BLL;
using PBL3REAL.DAL;
using PBL3REAL.ViewModel;
using PBL3REAL.Algorithm;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
namespace PBL3REAL.View
{
    public partial class Form_View_Statistic_Analyze : Form
    {
        /***** GLOBAL DECLARATION *****/
        QLInvoiceBLL invoiceBLL;
        List<Statistic1> listVM1;
        List<Statistic2> listVM2;

        /***** CONSTRUCTOR *****/
        public Form_View_Statistic_Analyze(int DataType, DateTime from, DateTime to, bool Statistic, bool Analyze, bool Predict)
        {
            InitializeComponent();
            invoiceBLL = new QLInvoiceBLL();
            switch(DataType)
            {
                case 0:
                    if (Statistic)
                    {
                        try
                        {
                            LoadStatisticsData(0, from, to);
                            DrawStatisticChart(0);
                        }
                        catch (Exception e1) { }
                    }
                    if (Analyze)
                    {
                        try
                        {
                            rtb_Analyze.Text = invoiceBLL.AnalyzingIncome(listVM1, from, to);
                        }
                        catch (Exception e2) { }
                    }
                    if (Predict)
                    {
                        try
                        {
                            DrawTrendlineChart(0,PredictNext7Days(0));
                        }
                        catch (Exception e3) { }
                    }    
                    break;
                case 1:
                    if (Statistic)
                    {
                        try
                        {
                            LoadStatisticsData(1, from, to);
                            DrawStatisticChart(1);
                        }
                        catch (Exception e1) { }
                    }
                    if (Analyze)
                    {
                        try
                        {
                            rtb_Analyze.Text = invoiceBLL.AnalyzingIncome(listVM1, from, to);
                        }
                        catch (Exception e2) { }
                    }
                    if (Predict)
                    {
                        try
                        {
                            DrawTrendlineChart(1,PredictNext7Days(1));
                        }
                        catch (Exception e3) { }
                    }
                    break;
                default:
                    break;
            }    
        }
        /***** STATISTIC *****/
        //-> Functions
        private void LoadStatisticsData(int DataType, DateTime from, DateTime to)
        {
            switch(DataType)
            {
                case 0:
                    listVM1 = invoiceBLL.findForStatistic(from, to);
                    dgv_Statistic.DataSource = listVM1;
                    break;
                case 1:
                    listVM2 = invoiceBLL.findForStatistic2(from, to);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt.Columns.AddRange(new DataColumn[]
                    {
                        new DataColumn("Date",typeof(DateTime)),
                        new DataColumn("String",typeof(string)),
                        new DataColumn("int",typeof(int))
                    });
                    DataRow r;
                    foreach (Statistic2 statistic2 in listVM2)
                    {
                        foreach (KeyValuePair<string, int> kvp in statistic2.TotalGroupBy)
                        {
                            r = dt.NewRow();
                            r["Date"] = statistic2.Date;
                            r["String"] = kvp.Key;
                            r["int"] = kvp.Value;
                            dt.Rows.Add(r);
                        }
                    }
                    dgv_Statistic.DataSource = dt;
                    break;
                default:
                    break;
            }    
        }
        private void DrawStatisticChart(int DataType)
        {
            switch(DataType)
            {
                case 0:
                    Dictionary<string, int> kvp = new Dictionary<string, int>();
                    foreach (Statistic1 statistic1 in listVM1)
                    {
                        kvp.Add(statistic1.Date.ToString("dd/MM/yyyy"), statistic1.TotalPriceByDate);
                    }
                    chart1.Series.Add("Income");
                    chart1.Series["Income"].XValueMember = "Date";
                    chart1.Series["Income"].YValueMembers = "TotalByDate";
                    chart1.Series["Income"].Points.DataBindXY(kvp.Keys, kvp.Values);
                    chart1.Series["Income"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    break;
                case 1:
                    break;
                default:
                    break;
            } 
        }
        private void StatisticExporttoImage()
        {
            string path = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "\\Statistic";
            this.chart1.SaveImage(path + "\\Image" + "\\" + DateTime.Now.Year.ToString() 
                + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Hour.ToString()
                + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + " --- chart.png", ChartImageFormat.Png);
            //Resize DataGridView to full height.
            int height = dgv_Statistic.Height;
            dgv_Statistic.Height = dgv_Statistic.RowCount * dgv_Statistic.RowTemplate.Height;

            //Create a Bitmap and draw the DataGridView on it.
            Bitmap bitmap = new Bitmap(this.dgv_Statistic.Width, this.dgv_Statistic.Height);
            dgv_Statistic.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, this.dgv_Statistic.Width, this.dgv_Statistic.Height));

            //Resize DataGridView back to original height.
            dgv_Statistic.Height = height;

            //Save the Bitmap to folder.
            bitmap.Save(path + "\\Image" + "\\" + DateTime.Now.Year.ToString()
                + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Hour.ToString()
                + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + " --- DataList.png");
        }
        private void StatisticExportToExcel()
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[0];
            worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dgv_Statistic.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgv_Statistic.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dgv_Statistic.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgv_Statistic.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgv_Statistic.Rows[i].Cells[j].Value.ToString();
                }
            }
            string path = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "\\Statistic & Analyze\\Excel\\output.xls";
            // save the application  
            workbook.SaveAs(path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }
        //-> Events
        private void btn_StatisticExportToImage_Click(object sender, EventArgs e)
        {
            try
            {
                StatisticExporttoImage();
                MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e1) { }
        }
        private void btn_StatisticExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                StatisticExportToExcel();
                MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e1) { }
        }
        private void btn_StatisticCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /***** ANALYZE *****/
        //-> Functions
        private Dictionary<DateTime, int> PredictNext7Days(int DataType)
        {
            Dictionary<DateTime, int> kvp = new Dictionary<DateTime, int>();
            switch (DataType)
            {
                case 0:
                    //Dictionary<DateTime, int> kvp = new Dictionary<DateTime, int>();
                    double[] xVals = new double[listVM1.Count];
                    double[] yVals = new double[listVM1.Count];
                    int i = 0;
                    foreach (Statistic1 statistic1 in listVM1)
                    {
                        xVals[i] = statistic1.TotalInvoiceByDate;
                        yVals[i] = statistic1.TotalPriceByDate;
                        i++;
                    }
                    LinearRegression linearRegression = new LinearRegression(xVals, yVals);
                    linearRegression.PredictData();
                    i = 1;
                    foreach (Statistic1 statistic11 in listVM1)
                    {
                        kvp.Add(DateTime.Now.Date.AddDays(i), Convert.ToInt32(linearRegression.yIntercept + linearRegression.slope * i));
                        i++;
                    }
                    break;
                case 1:
                    break;
                default:
                    break;
            }
            return kvp;
        }
        private void DrawTrendlineChart(int DataType, Dictionary<DateTime, int> kvp)
        {
            switch(DataType)
            {
                case 0:
                    chart2.Series.Add("Income Prediction");
                    chart2.Series["Income Prediction"].Points.DataBindXY(kvp.Keys, kvp.Values);
                    chart2.Series["Income Prediction"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    break;
                case 1:
                    break;
                default:
                    break;
            }  
        }
        private void AnalyzeExportToImage()
        {
            string path = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "\\Analyze";
            this.chart2.SaveImage(path + "\\Image" + "\\" + DateTime.Now.Year.ToString()
                + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Hour.ToString()
                + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + " --- chart.png", ChartImageFormat.Png);
        }
        private void AnalyzeExportToExcel()
        {
            
        }
        //-> Events
        private void btn_AnalyzeExportToImage_Click(object sender, EventArgs e)
        {
            try
            {
                AnalyzeExportToImage();
                MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e1) { }
        }
        private void btn_AnalyzeExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                AnalyzeExportToExcel();
                MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e1) { }
        }
        private void btn_AnalyzeCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
