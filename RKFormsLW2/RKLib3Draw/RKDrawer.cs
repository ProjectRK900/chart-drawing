using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace RKLib3Draw
{
    public class RKDrawer
    {
        public static string drawNewChart(Chart MainChart, List<double> x, List<double> y, string func, string legend) 
        {
            MainChart.Series[legend].Points.Clear();

            y.RemoveRange(7, y.Count - 7);
            x.RemoveRange(7, x.Count - 7);
            MainChart.ChartAreas["MainChartArea"].AxisY.Minimum = y.Min();
            MainChart.ChartAreas["MainChartArea"].AxisY.Maximum = y.Max();

            MainChart.ChartAreas["MainChartArea"].AxisX.Minimum = x.Min();
            MainChart.ChartAreas["MainChartArea"].AxisX.Maximum = x.Max();

            int max;
            if (x.Count > y.Count)
                max = y.Count;
            else
                max = x.Count;

            for (int i = 0; i < max; i++)
                MainChart.Series[legend].Points.AddXY(x[i], y[i]);

            if (func != "")
            {
                MainChart.Series[legend].Name = "График функции " + func;

                return "График функции " + func;
            }
            else
            {
                MainChart.Series[legend].Name = "График точек";

                return "График точек";
            }
        }
    }
}
