using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.BrukhovAA.Sprint6.Task1.V11.Lib;

namespace Tyuiu.BrukhovAA.Sprint6.Task1.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_BAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_BAA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_BAA.Text);

                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] arrayRes = new double[len];
                arrayRes = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_BAA.Text = "";
                textBoxResult_BAA.AppendText("+-----------+-----------+" + Environment.NewLine);
                textBoxResult_BAA.AppendText("|      X    |    f(x)   |" + Environment.NewLine);
                textBoxResult_BAA.AppendText("+-----------+-----------+" + Environment.NewLine);
                
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = string.Format("| {0,6:d}    |  {1, 6:f2}   |", startStep, arrayRes[i]);
                    textBoxResult_BAA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_BAA.AppendText("+-----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStudent_BAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУб-23-1 Брюхов Алексей Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxStartStep_BAA_Key(object sender, KeyPressEventArgs e)
        {
        }

        private void textBoxResult_BAA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

