using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RKLib1Read;
using RKLib2Output;
using RKLib3Draw;

namespace RKFormsLW2
{
    public partial class Main : Form
    {
        private List<double> x, y;
        private string func, legend;

        public Main()
        {
            InitializeComponent();
            
            xyDGV.Rows.Add("X:");
            xyDGV.Rows[1].SetValues("Y:");

            x = new List<double>();
            y = new List<double>();

            savepointsBtn.Enabled = false;
            drawfuncBtn.Enabled = false;

            legend = "Series";

            MainChart.Visible = false;
        }

        private string funcAdvanced(string oldf)
        {
            //string newFunc = oldf.Replace(" ", "");
            string newFunc = oldf;
            Regex reg = new Regex(@"(?<=\^)\d+");
            MatchCollection mts = reg.Matches(newFunc);
            if (mts.Count > 0)
            {
                foreach (Match i in mts)
                    newFunc = newFunc.Replace("^" + i.Value.ToString(), string.Concat(Enumerable.Repeat("*x", Convert.ToInt32(i.Value) - 1)));
            }

            return newFunc;
        }

        private void readfileBtn_Click(object sender, EventArgs e)
        {
            drawfuncBtn.Enabled = false;
            if (openFileDialog.ShowDialog().ToString() == "OK")
            {
                xyDGV.Rows.Clear();
                xyDGV.Rows.Add("X:");
                xyDGV.Rows[1].SetValues("Y:");

                RKRead reader = new RKRead(openFileDialog.FileName);
                filenameL.Text = "Имя файла: " + reader.getfilename();

                if (reader.getdatatype() == "xy")
                {
                    MainChart.Visible = false;
                    functionL.Text = "Функция: ";
                    func = "";

                    x = reader.getX();
                    y = reader.getY();

                    xyDGV.Rows[0].SetValues("X:", x[0], x[1], x[2], x[3], x[4], x[5], x[6]);
                    xyDGV.Rows[1].SetValues("Y:", y[0], y[1], y[2], y[3], y[4], y[5], y[6]);

                    drawfuncBtn.Enabled = true;
                }
                else if (reader.getdatatype() == "function")
                {
                    MainChart.Visible = false;
                    x.Clear();
                    y.Clear();
                    for (int i = 0; i < 7; i++)
                        x.Add(i + 1);
                    xyDGV.Rows[0].SetValues("X:", x[0], x[1], x[2], x[3], x[4], x[5], x[6]);

                    string tempFunc = funcAdvanced(reader.getfunction());
                    for (int i = 0; i < 7; i++)
                    {
                        try
                        {
                            y.Add(Double.Parse(new DataTable().Compute(tempFunc.Replace("x", x[i].ToString()), null).ToString()));
                        }
                        catch { y.Add(0); }
                    }
                    xyDGV.Rows[1].SetValues("Y:", y[0], y[1], y[2], y[3], y[4], y[5], y[6]);

                    functionL.Text = "Функция: " + reader.getfunction();
                    func = reader.getfunction();

                    drawfuncBtn.Enabled = true;
                }

                savepointsBtn.Enabled = true;
            }
        }

        private void savepointsBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog().ToString() == "OK")
            {
                List<string> factX = new List<string>();
                List<string> factY = new List<string>();
                for (int i = 1; i < 8; i++)
                {
                    factX.Add(xyDGV.Rows[0].Cells[i].Value.ToString());
                    factY.Add(xyDGV.Rows[1].Cells[i].Value.ToString());
                }

                RKOutput.writeXYinFile(factX, factY, saveFileDialog.FileName);
            }
            else
                MessageBox.Show("Точки графика не были сохранены", "Внимание!", MessageBoxButtons.OK , MessageBoxIcon.Warning);
        }

        private void drawfuncBtn_Click(object sender, EventArgs e)
        {
            legend = RKDrawer.drawNewChart(MainChart, x, y, func, legend);

            drawfuncBtn.Enabled = false;
            MainChart.Visible = true;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            MainChart.Visible = false;

            xyDGV.Rows.Clear();
            xyDGV.Rows.Add("X:");
            xyDGV.Rows[1].SetValues("Y:");

            functionL.Text = "Функция: ";
            filenameL.Text = "Имя файла: ";

            x = new List<double>();
            y = new List<double>();

            savepointsBtn.Enabled = false;
            drawfuncBtn.Enabled = false;
        }
    }
}
