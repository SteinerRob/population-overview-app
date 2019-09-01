using System.Collections.Generic;
using System.Drawing;
using System;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace PopulationPresov
{
    public class DrawingManager
        {
        



        public void DrawGraph(Chart chart1, List<Day>days, int gender )
        {
            var chart = chart1.ChartAreas[0];

            chart.AxisX.IntervalType = DateTimeIntervalType.Number                ;
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 2;
            chart.AxisX.Maximum = days.Count;
            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = MaxY(days);
            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = 50;
            if (chart1.Series == null)
            {
                chart1.Series.Add("Population");
                chart1.Series["Population"].ChartType = SeriesChartType.Line;
                if (gender == 0)
                {
                    chart1.Series["Population"].Color = Color.Blue;
                }
                else
                    chart1.Series["Population"].Color = Color.Red;
                chart1.Series[0].IsVisibleInLegend = false;

                foreach (var day in days)
                {
                    chart1.Series["Population"].Points.AddY(day.Count);
                }
            }
            else
            {
                chart1.Series.Clear();
                chart1.Series.Add("Population");
                chart1.Series["Population"].ChartType = SeriesChartType.Line;
                if (gender == 0)

                    chart1.Series["Population"].Color = Color.Blue;
                else
                    chart1.Series["Population"].Color = Color.Red;
                chart1.Series[0].IsVisibleInLegend = false;

                foreach (var day in days)
                {
                    chart1.Series["Population"].Points.AddXY(day.GetDateTime().Day, day.Count);
                }
            }


        }
        private int MaxX(List<Day> days)
        {
            int MaxX = 0;
            foreach (var day in days)
            {
                if (Convert.ToInt32(day.GetDoubleTime()) < MaxX)
                    MaxX = Convert.ToInt32(day.GetDoubleTime());
            }
            return MaxX;
        }
        private int MaxY(List<Day> days)
        {
            int maxY = 0;

            foreach (var day in days)
            {
                if (maxY < day.Count)
                    maxY = day.Count;
            }
            return maxY;
        }
    }
}
