using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProbandoGrafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Titles.Clear();

            int[] numeros = {Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text),Convert.ToInt32(textBox3.Text),
                             Convert.ToInt32(textBox4.Text),Convert.ToInt32(textBox5.Text),Convert.ToInt32(textBox6.Text)};
            Series seriesLine = new Series();
            seriesLine.ChartType = SeriesChartType.Area;
            for (int i = 0; i < 3; i++)
            {
                seriesLine.Points.Add(new DataPoint(i,numeros[i]));
            }

            ChartArea area1 = new ChartArea();
            chart1.ChartAreas.Add(area1);
            chart1.Series.Add(seriesLine);

            Series seriesLine2 = new Series();
            seriesLine2.ChartType = SeriesChartType.Area;
            for (int i = 0; i < 3; i++)
            {
                seriesLine2.Points.Add(new DataPoint(i, numeros[i+3]));
            }

            ChartArea area2 = new ChartArea();
            chart1.ChartAreas.Add(area2);
            chart1.Series.Add(seriesLine2);
        }
    }
}
