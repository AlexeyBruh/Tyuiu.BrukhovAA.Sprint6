using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BrukhovAA.Sprint6.Task2.V6.Lib;

namespace Tyuiu.BrukhovAA.Sprint6.Task2.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void dataGridViewResult_BAA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDone_BAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_BAA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_BAA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] array = new double[len];

                array = ds.GetMassFunction(startStep, stopStep);

                this.chartResult_BAA.Titles.Add("График функции");

                this.chartResult_BAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_BAA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult_BAA.Rows.Add(Convert.ToString(startStep), Convert.ToString(array[i]));

                    this.chartResult_BAA.Series[0].Points.AddXY(startStep, array[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_BAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУб-23-1 Брюхов Алексей Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_BAAMouseEnter(object sender, EventArgs e)
        {
            buttonDone_BAA.BackColor = Color.Red;
        }

        private void buttonDone_BAAMouseLeave(object sender, EventArgs e)
        {
            buttonDone_BAA.BackColor = Color.Green;
        }

        private void buttonDone_BAAMouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_BAA.BackColor = Color.Blue;
        }
    }
    }
