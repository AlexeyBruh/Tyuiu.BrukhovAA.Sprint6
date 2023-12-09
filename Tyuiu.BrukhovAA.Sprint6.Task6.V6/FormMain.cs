using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BrukhovAA.Sprint6.Task6.V6.Lib;
using System.IO;

namespace Tyuiu.BrukhovAA.Sprint6.Task6.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string openFilePath;

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_BAA_Click(object sender, EventArgs e)
        {
            textBoxDataOutput_BAA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_BAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDataLoad_BAA_Click(object sender, EventArgs e)
        {
            openFileDialog_BAA.ShowDialog();
            openFilePath = openFileDialog_BAA.FileName;
            textBoxDataInput_BAA.Text = File.ReadAllText(openFilePath);
            groupBoxDataInput_BAA.Text = groupBoxDataInput_BAA.Text + openFileDialog_BAA.FileName; ;
            buttonDone_BAA.Enabled = true;
        }
    }
}
