using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BrukhovAA.Sprint6.Task5.V6.Lib;
using System.IO;

namespace Tyuiu.BrukhovAA.Sprint6.Task5.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = $@"{Directory.GetCurrentDirectory()}\InPutFileTask5V6.txt";

        private void buttonHelp_BAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУб-23-1 Брюхов Алексей Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_BAA_Click(object sender, EventArgs e)
        {
            dataGridViewDataOut_BAA.ColumnCount = 2;
            dataGridViewDataOut_BAA.Columns[0].Width = 20;
            dataGridViewDataOut_BAA.Columns[0].Width = 50;

            this.chartData_BAA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartData_BAA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartData_BAA.Series[0].Points.Clear();

            double[] numsArr = new double[ds.len];

            numsArr = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsArr.Length; i++)
            {
                dataGridViewDataOut_BAA.Rows.Add(Convert.ToString(i), Convert.ToString(numsArr[i]));
                chartData_BAA.Series[0].Points.AddXY(i, numsArr[i]);
            }
        }

        private void buttonOpenFile_BAA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
