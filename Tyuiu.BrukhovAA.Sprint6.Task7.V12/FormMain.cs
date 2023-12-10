using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BrukhovAA.Sprint6.Task7.V12.Lib;
using System.IO;

namespace Tyuiu.BrukhovAA.Sprint6.Task7.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        static int rows;
        static int colums;
        static string openFilePath;


        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] array = new int[rows, colums];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    array[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            return array;
        }


        private void buttonHelp_BAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_BAA_Click(object sender, EventArgs e)
        {
            openFileDialog_BAA.ShowDialog();
            openFilePath = openFileDialog_BAA.FileName;

            int[,] arrayValues = LoadFromFileData(openFilePath);
            int rows = arrayValues.GetUpperBound(0) + 1;
            int colums = arrayValues.Length / rows;

            dataGridViewDataInput_BAA.ColumnCount = colums;
            dataGridViewDataInput_BAA.RowCount = rows;
            dataGridViewDataOutput_BAA.ColumnCount = rows;
            dataGridViewDataOutput_BAA.RowCount = colums;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewDataInput_BAA.Columns[i].Width = 25;
                dataGridViewDataOutput_BAA.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewDataInput_BAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_BAA.Enabled = true;
        }

        private void buttonSaveFile_BAA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = ds.GetMatrix(openFilePath);

            saveFileDialog_BAA.FileName = "OutPutFileTask7.csv";
            saveFileDialog_BAA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_BAA.ShowDialog();

            string path = saveFileDialog_BAA.FileName;

            FileInfo fl = new FileInfo(path);
            bool fileExists = fl.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewDataOutput_BAA.RowCount;
            int columns = dataGridViewDataOutput_BAA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    if ( j != columns - 1)
                    {
                        str = str + dataGridViewDataOutput_BAA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewDataOutput_BAA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

        }

        private void buttonDone_BAA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = ds.GetMatrix(openFilePath);
            int rows = arrayValues.GetUpperBound(0) + 1;
            int colums = arrayValues.Length / rows;

            for (int r = 0; r < rows; r++)
            {
                for(int c = 0; c < colums; c++)
                {
                    dataGridViewDataOutput_BAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSaveFile_BAA.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewDataInput_BAA.ColumnCount = 50;
            dataGridViewDataOutput_BAA.ColumnCount = 50;

            dataGridViewDataOutput_BAA.RowCount = 50;
            dataGridViewDataInput_BAA.RowCount = 50;

            panelDataInput_BAA.Width = this.Width / 2;
        }

        private void ButtonOpenFile_BAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_BAA.ToolTipTitle = "Открыть файл";
        }

        private void ButtonDone_BAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_BAA.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_BAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_BAA.ToolTipTitle = "Сохранить в файл";
        }
    }
}
