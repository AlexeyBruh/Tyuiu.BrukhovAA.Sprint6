using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.BrukhovAA.Sprint6.Task3.V2.Lib;

namespace Tyuiu.BrukhovAA.Sprint6.Task3.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { -12, -4, -20, 5, -5 }, { 2, 15, 1, -20, 7 }, { 15, -15, 2, 11, 5 }, { -19, -9, 16, 0, 1 }, { 17, 16, 5, 12, -8 } };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_BAA.ColumnCount = columns;
            dataGridViewMatrix_BAA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_BAA.Columns[i].Width = 25;
            }
        }

        private void buttonDone_BA_Click(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            int[,] valueArray = ds.Calculate(mtrx);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    int value = valueArray[i, j];
                    dataGridViewMatrix_BAA.Rows[i].Cells[j].Value = Convert.ToString(value);
                }
            }
        }

        private void buttonHelp_BA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУб-23-1 Брюхов Алексей Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
