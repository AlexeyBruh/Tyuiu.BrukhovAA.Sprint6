
namespace Tyuiu.BrukhovAA.Sprint6.Task2.V6
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxRead_BAA = new System.Windows.Forms.GroupBox();
            this.groupBoxData_BAA = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_BAA = new System.Windows.Forms.GroupBox();
            this.textBoxRead_BAA = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_BAA = new System.Windows.Forms.PictureBox();
            this.textBoxStartStep_BAA = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_BAA = new System.Windows.Forms.TextBox();
            this.labelStartStep_BAA = new System.Windows.Forms.Label();
            this.labelStopStep_BAA = new System.Windows.Forms.Label();
            this.buttonHelp_BAA = new System.Windows.Forms.Button();
            this.buttonDone_BAA = new System.Windows.Forms.Button();
            this.dataGridViewResult_BAA = new System.Windows.Forms.DataGridView();
            this.labelResult_BAA = new System.Windows.Forms.Label();
            this.ColumnX_BAA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFx_BAA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartResult_BAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxRead_BAA.SuspendLayout();
            this.groupBoxData_BAA.SuspendLayout();
            this.groupBoxResult_BAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_BAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_BAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_BAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxRead_BAA
            // 
            this.groupBoxRead_BAA.Controls.Add(this.pictureBoxFormula_BAA);
            this.groupBoxRead_BAA.Controls.Add(this.textBoxRead_BAA);
            this.groupBoxRead_BAA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxRead_BAA.Name = "groupBoxRead_BAA";
            this.groupBoxRead_BAA.Size = new System.Drawing.Size(526, 208);
            this.groupBoxRead_BAA.TabIndex = 0;
            this.groupBoxRead_BAA.TabStop = false;
            this.groupBoxRead_BAA.Text = "Условие";
            // 
            // groupBoxData_BAA
            // 
            this.groupBoxData_BAA.Controls.Add(this.labelStopStep_BAA);
            this.groupBoxData_BAA.Controls.Add(this.labelStartStep_BAA);
            this.groupBoxData_BAA.Controls.Add(this.textBoxStopStep_BAA);
            this.groupBoxData_BAA.Controls.Add(this.textBoxStartStep_BAA);
            this.groupBoxData_BAA.Location = new System.Drawing.Point(13, 227);
            this.groupBoxData_BAA.Name = "groupBoxData_BAA";
            this.groupBoxData_BAA.Size = new System.Drawing.Size(276, 75);
            this.groupBoxData_BAA.TabIndex = 1;
            this.groupBoxData_BAA.TabStop = false;
            this.groupBoxData_BAA.Text = "Ввод данных";
            // 
            // groupBoxResult_BAA
            // 
            this.groupBoxResult_BAA.Controls.Add(this.chartResult_BAA);
            this.groupBoxResult_BAA.Controls.Add(this.labelResult_BAA);
            this.groupBoxResult_BAA.Controls.Add(this.dataGridViewResult_BAA);
            this.groupBoxResult_BAA.Location = new System.Drawing.Point(545, 13);
            this.groupBoxResult_BAA.Name = "groupBoxResult_BAA";
            this.groupBoxResult_BAA.Size = new System.Drawing.Size(472, 289);
            this.groupBoxResult_BAA.TabIndex = 2;
            this.groupBoxResult_BAA.TabStop = false;
            this.groupBoxResult_BAA.Text = "Вывод данных";
            // 
            // textBoxRead_BAA
            // 
            this.textBoxRead_BAA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRead_BAA.Location = new System.Drawing.Point(7, 20);
            this.textBoxRead_BAA.Multiline = true;
            this.textBoxRead_BAA.Name = "textBoxRead_BAA";
            this.textBoxRead_BAA.ReadOnly = true;
            this.textBoxRead_BAA.Size = new System.Drawing.Size(371, 36);
            this.textBoxRead_BAA.TabIndex = 0;
            this.textBoxRead_BAA.Text = "Протабулировать функцию в заданном диапозоне [-5; 5].\r\nРезультат вывести в DataGr" +
    "idView и построить график функции.";
            // 
            // pictureBoxFormula_BAA
            // 
            this.pictureBoxFormula_BAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_BAA.Image")));
            this.pictureBoxFormula_BAA.Location = new System.Drawing.Point(7, 62);
            this.pictureBoxFormula_BAA.Name = "pictureBoxFormula_BAA";
            this.pictureBoxFormula_BAA.Size = new System.Drawing.Size(324, 40);
            this.pictureBoxFormula_BAA.TabIndex = 1;
            this.pictureBoxFormula_BAA.TabStop = false;
            // 
            // textBoxStartStep_BAA
            // 
            this.textBoxStartStep_BAA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxStartStep_BAA.Location = new System.Drawing.Point(7, 38);
            this.textBoxStartStep_BAA.Name = "textBoxStartStep_BAA";
            this.textBoxStartStep_BAA.Size = new System.Drawing.Size(123, 20);
            this.textBoxStartStep_BAA.TabIndex = 0;
            this.textBoxStartStep_BAA.Text = "-5";
            // 
            // textBoxStopStep_BAA
            // 
            this.textBoxStopStep_BAA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxStopStep_BAA.Location = new System.Drawing.Point(153, 38);
            this.textBoxStopStep_BAA.Name = "textBoxStopStep_BAA";
            this.textBoxStopStep_BAA.Size = new System.Drawing.Size(117, 20);
            this.textBoxStopStep_BAA.TabIndex = 0;
            this.textBoxStopStep_BAA.Text = "5";
            // 
            // labelStartStep_BAA
            // 
            this.labelStartStep_BAA.AutoSize = true;
            this.labelStartStep_BAA.Location = new System.Drawing.Point(7, 20);
            this.labelStartStep_BAA.Name = "labelStartStep_BAA";
            this.labelStartStep_BAA.Size = new System.Drawing.Size(67, 13);
            this.labelStartStep_BAA.TabIndex = 1;
            this.labelStartStep_BAA.Text = "Старт шага:";
            // 
            // labelStopStep_BAA
            // 
            this.labelStopStep_BAA.AutoSize = true;
            this.labelStopStep_BAA.Location = new System.Drawing.Point(150, 22);
            this.labelStopStep_BAA.Name = "labelStopStep_BAA";
            this.labelStopStep_BAA.Size = new System.Drawing.Size(69, 13);
            this.labelStopStep_BAA.TabIndex = 1;
            this.labelStopStep_BAA.Text = "Конец шага:";
            // 
            // buttonHelp_BAA
            // 
            this.buttonHelp_BAA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonHelp_BAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_BAA.Location = new System.Drawing.Point(295, 227);
            this.buttonHelp_BAA.Name = "buttonHelp_BAA";
            this.buttonHelp_BAA.Size = new System.Drawing.Size(95, 74);
            this.buttonHelp_BAA.TabIndex = 3;
            this.buttonHelp_BAA.Text = "Справка";
            this.buttonHelp_BAA.UseVisualStyleBackColor = false;
            this.buttonHelp_BAA.Click += new System.EventHandler(this.buttonHelp_BAA_Click);
            // 
            // buttonDone_BAA
            // 
            this.buttonDone_BAA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_BAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_BAA.Location = new System.Drawing.Point(396, 227);
            this.buttonDone_BAA.Name = "buttonDone_BAA";
            this.buttonDone_BAA.Size = new System.Drawing.Size(143, 74);
            this.buttonDone_BAA.TabIndex = 4;
            this.buttonDone_BAA.Text = "Выполнить";
            this.buttonDone_BAA.UseVisualStyleBackColor = false;
            this.buttonDone_BAA.Click += new System.EventHandler(this.buttonDone_BAA_Click);
            this.buttonDone_BAA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_BAAMouseDown);
            this.buttonDone_BAA.MouseEnter += new System.EventHandler(this.buttonDone_BAAMouseEnter);
            this.buttonDone_BAA.MouseLeave += new System.EventHandler(this.buttonDone_BAAMouseLeave);
            // 
            // dataGridViewResult_BAA
            // 
            this.dataGridViewResult_BAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_BAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX_BAA,
            this.ColumnFx_BAA});
            this.dataGridViewResult_BAA.Location = new System.Drawing.Point(6, 36);
            this.dataGridViewResult_BAA.Name = "dataGridViewResult_BAA";
            this.dataGridViewResult_BAA.RowHeadersVisible = false;
            this.dataGridViewResult_BAA.Size = new System.Drawing.Size(124, 247);
            this.dataGridViewResult_BAA.TabIndex = 0;
            this.dataGridViewResult_BAA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResult_BAA_CellContentClick);
            // 
            // labelResult_BAA
            // 
            this.labelResult_BAA.AutoSize = true;
            this.labelResult_BAA.Location = new System.Drawing.Point(6, 20);
            this.labelResult_BAA.Name = "labelResult_BAA";
            this.labelResult_BAA.Size = new System.Drawing.Size(59, 13);
            this.labelResult_BAA.TabIndex = 1;
            this.labelResult_BAA.Text = "Результат";
            // 
            // ColumnX_BAA
            // 
            this.ColumnX_BAA.HeaderText = "X";
            this.ColumnX_BAA.Name = "ColumnX_BAA";
            this.ColumnX_BAA.ReadOnly = true;
            this.ColumnX_BAA.Width = 65;
            // 
            // ColumnFx_BAA
            // 
            this.ColumnFx_BAA.HeaderText = "F(X)";
            this.ColumnFx_BAA.Name = "ColumnFx_BAA";
            this.ColumnFx_BAA.ReadOnly = true;
            this.ColumnFx_BAA.Width = 65;
            // 
            // chartResult_BAA
            // 
            chartArea4.Name = "ChartArea1";
            this.chartResult_BAA.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartResult_BAA.Legends.Add(legend4);
            this.chartResult_BAA.Location = new System.Drawing.Point(136, 36);
            this.chartResult_BAA.Name = "chartResult_BAA";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartResult_BAA.Series.Add(series4);
            this.chartResult_BAA.Size = new System.Drawing.Size(336, 247);
            this.chartResult_BAA.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 314);
            this.Controls.Add(this.buttonDone_BAA);
            this.Controls.Add(this.buttonHelp_BAA);
            this.Controls.Add(this.groupBoxResult_BAA);
            this.Controls.Add(this.groupBoxData_BAA);
            this.Controls.Add(this.groupBoxRead_BAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Такс 2 | Вариант 6 | Брюхов А. А.";
            this.groupBoxRead_BAA.ResumeLayout(false);
            this.groupBoxRead_BAA.PerformLayout();
            this.groupBoxData_BAA.ResumeLayout(false);
            this.groupBoxData_BAA.PerformLayout();
            this.groupBoxResult_BAA.ResumeLayout(false);
            this.groupBoxResult_BAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_BAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_BAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_BAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRead_BAA;
        private System.Windows.Forms.GroupBox groupBoxData_BAA;
        private System.Windows.Forms.GroupBox groupBoxResult_BAA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_BAA;
        private System.Windows.Forms.TextBox textBoxRead_BAA;
        private System.Windows.Forms.Label labelStopStep_BAA;
        private System.Windows.Forms.Label labelStartStep_BAA;
        private System.Windows.Forms.TextBox textBoxStopStep_BAA;
        private System.Windows.Forms.TextBox textBoxStartStep_BAA;
        private System.Windows.Forms.Label labelResult_BAA;
        private System.Windows.Forms.DataGridView dataGridViewResult_BAA;
        private System.Windows.Forms.Button buttonHelp_BAA;
        private System.Windows.Forms.Button buttonDone_BAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_BAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX_BAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFx_BAA;
    }
}

