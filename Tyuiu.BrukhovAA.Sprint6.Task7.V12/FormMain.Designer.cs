
namespace Tyuiu.BrukhovAA.Sprint6.Task7.V12
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons_BAA = new System.Windows.Forms.Panel();
            this.buttonHelp_BAA = new System.Windows.Forms.Button();
            this.buttonSaveFile_BAA = new System.Windows.Forms.Button();
            this.buttonDone_BAA = new System.Windows.Forms.Button();
            this.buttonOpenFile_BAA = new System.Windows.Forms.Button();
            this.panelRead_BAA = new System.Windows.Forms.Panel();
            this.groupBoxRead_BAA = new System.Windows.Forms.GroupBox();
            this.labelRead_BAA = new System.Windows.Forms.Label();
            this.panelDataInput_BAA = new System.Windows.Forms.Panel();
            this.groupBoxDataInput_BAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewDataInput_BAA = new System.Windows.Forms.DataGridView();
            this.splitterDataInput_BAA = new System.Windows.Forms.Splitter();
            this.panelDataOutput_BAA = new System.Windows.Forms.Panel();
            this.groupBoxDataOutput_BAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewDataOutput_BAA = new System.Windows.Forms.DataGridView();
            this.openFileDialog_BAA = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButtons_BAA = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog_BAA = new System.Windows.Forms.SaveFileDialog();
            this.panelButtons_BAA.SuspendLayout();
            this.panelRead_BAA.SuspendLayout();
            this.groupBoxRead_BAA.SuspendLayout();
            this.panelDataInput_BAA.SuspendLayout();
            this.groupBoxDataInput_BAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataInput_BAA)).BeginInit();
            this.panelDataOutput_BAA.SuspendLayout();
            this.groupBoxDataOutput_BAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataOutput_BAA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons_BAA
            // 
            this.panelButtons_BAA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons_BAA.Controls.Add(this.buttonHelp_BAA);
            this.panelButtons_BAA.Controls.Add(this.buttonSaveFile_BAA);
            this.panelButtons_BAA.Controls.Add(this.buttonDone_BAA);
            this.panelButtons_BAA.Controls.Add(this.buttonOpenFile_BAA);
            this.panelButtons_BAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_BAA.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_BAA.Name = "panelButtons_BAA";
            this.panelButtons_BAA.Size = new System.Drawing.Size(816, 59);
            this.panelButtons_BAA.TabIndex = 0;
            // 
            // buttonHelp_BAA
            // 
            this.buttonHelp_BAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_BAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_BAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_BAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_BAA.Image")));
            this.buttonHelp_BAA.Location = new System.Drawing.Point(720, 4);
            this.buttonHelp_BAA.Name = "buttonHelp_BAA";
            this.buttonHelp_BAA.Size = new System.Drawing.Size(91, 48);
            this.buttonHelp_BAA.TabIndex = 0;
            this.toolTipButtons_BAA.SetToolTip(this.buttonHelp_BAA, "О программе");
            this.buttonHelp_BAA.UseVisualStyleBackColor = true;
            this.buttonHelp_BAA.Click += new System.EventHandler(this.buttonHelp_BAA_Click);
            // 
            // buttonSaveFile_BAA
            // 
            this.buttonSaveFile_BAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveFile_BAA.Enabled = false;
            this.buttonSaveFile_BAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_BAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_BAA.Image")));
            this.buttonSaveFile_BAA.Location = new System.Drawing.Point(198, 4);
            this.buttonSaveFile_BAA.Name = "buttonSaveFile_BAA";
            this.buttonSaveFile_BAA.Size = new System.Drawing.Size(91, 48);
            this.buttonSaveFile_BAA.TabIndex = 0;
            this.toolTipButtons_BAA.SetToolTip(this.buttonSaveFile_BAA, "Сохранение результата работы программы на \r\nлокальном диске\r\n");
            this.buttonSaveFile_BAA.UseVisualStyleBackColor = true;
            this.buttonSaveFile_BAA.Click += new System.EventHandler(this.buttonSaveFile_BAA_Click);
            this.buttonSaveFile_BAA.MouseEnter += new System.EventHandler(this.buttonSaveFile_BAA_MouseEnter);
            // 
            // buttonDone_BAA
            // 
            this.buttonDone_BAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_BAA.Enabled = false;
            this.buttonDone_BAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_BAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_BAA.Image")));
            this.buttonDone_BAA.Location = new System.Drawing.Point(101, 4);
            this.buttonDone_BAA.Name = "buttonDone_BAA";
            this.buttonDone_BAA.Size = new System.Drawing.Size(91, 48);
            this.buttonDone_BAA.TabIndex = 0;
            this.toolTipButtons_BAA.SetToolTip(this.buttonDone_BAA, "Запуск программы");
            this.buttonDone_BAA.UseVisualStyleBackColor = true;
            this.buttonDone_BAA.Click += new System.EventHandler(this.buttonDone_BAA_Click);
            this.buttonDone_BAA.MouseEnter += new System.EventHandler(this.ButtonDone_BAA_MouseEnter);
            // 
            // buttonOpenFile_BAA
            // 
            this.buttonOpenFile_BAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_BAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_BAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_BAA.Image")));
            this.buttonOpenFile_BAA.Location = new System.Drawing.Point(4, 4);
            this.buttonOpenFile_BAA.Name = "buttonOpenFile_BAA";
            this.buttonOpenFile_BAA.Size = new System.Drawing.Size(91, 48);
            this.buttonOpenFile_BAA.TabIndex = 0;
            this.toolTipButtons_BAA.SetToolTip(this.buttonOpenFile_BAA, "Открыть файл для обработки");
            this.buttonOpenFile_BAA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_BAA.Click += new System.EventHandler(this.buttonOpenFile_BAA_Click);
            this.buttonOpenFile_BAA.MouseEnter += new System.EventHandler(this.ButtonOpenFile_BAA_MouseEnter);
            // 
            // panelRead_BAA
            // 
            this.panelRead_BAA.Controls.Add(this.groupBoxRead_BAA);
            this.panelRead_BAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRead_BAA.Location = new System.Drawing.Point(0, 59);
            this.panelRead_BAA.Name = "panelRead_BAA";
            this.panelRead_BAA.Size = new System.Drawing.Size(816, 68);
            this.panelRead_BAA.TabIndex = 1;
            // 
            // groupBoxRead_BAA
            // 
            this.groupBoxRead_BAA.Controls.Add(this.labelRead_BAA);
            this.groupBoxRead_BAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRead_BAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRead_BAA.Name = "groupBoxRead_BAA";
            this.groupBoxRead_BAA.Size = new System.Drawing.Size(816, 68);
            this.groupBoxRead_BAA.TabIndex = 0;
            this.groupBoxRead_BAA.TabStop = false;
            this.groupBoxRead_BAA.Text = "Условие:";
            // 
            // labelRead_BAA
            // 
            this.labelRead_BAA.AutoSize = true;
            this.labelRead_BAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRead_BAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRead_BAA.Location = new System.Drawing.Point(3, 16);
            this.labelRead_BAA.Name = "labelRead_BAA";
            this.labelRead_BAA.Size = new System.Drawing.Size(794, 45);
            this.labelRead_BAA.TabIndex = 0;
            this.labelRead_BAA.Text = resources.GetString("labelRead_BAA.Text");
            // 
            // panelDataInput_BAA
            // 
            this.panelDataInput_BAA.Controls.Add(this.groupBoxDataInput_BAA);
            this.panelDataInput_BAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDataInput_BAA.Location = new System.Drawing.Point(0, 127);
            this.panelDataInput_BAA.Name = "panelDataInput_BAA";
            this.panelDataInput_BAA.Size = new System.Drawing.Size(398, 284);
            this.panelDataInput_BAA.TabIndex = 2;
            // 
            // groupBoxDataInput_BAA
            // 
            this.groupBoxDataInput_BAA.Controls.Add(this.dataGridViewDataInput_BAA);
            this.groupBoxDataInput_BAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDataInput_BAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDataInput_BAA.Name = "groupBoxDataInput_BAA";
            this.groupBoxDataInput_BAA.Size = new System.Drawing.Size(398, 284);
            this.groupBoxDataInput_BAA.TabIndex = 0;
            this.groupBoxDataInput_BAA.TabStop = false;
            this.groupBoxDataInput_BAA.Text = "Ввод:";
            // 
            // dataGridViewDataInput_BAA
            // 
            this.dataGridViewDataInput_BAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataInput_BAA.ColumnHeadersVisible = false;
            this.dataGridViewDataInput_BAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDataInput_BAA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewDataInput_BAA.Name = "dataGridViewDataInput_BAA";
            this.dataGridViewDataInput_BAA.RowHeadersVisible = false;
            this.dataGridViewDataInput_BAA.Size = new System.Drawing.Size(392, 265);
            this.dataGridViewDataInput_BAA.TabIndex = 0;
            // 
            // splitterDataInput_BAA
            // 
            this.splitterDataInput_BAA.Location = new System.Drawing.Point(398, 127);
            this.splitterDataInput_BAA.Name = "splitterDataInput_BAA";
            this.splitterDataInput_BAA.Size = new System.Drawing.Size(3, 284);
            this.splitterDataInput_BAA.TabIndex = 3;
            this.splitterDataInput_BAA.TabStop = false;
            // 
            // panelDataOutput_BAA
            // 
            this.panelDataOutput_BAA.Controls.Add(this.groupBoxDataOutput_BAA);
            this.panelDataOutput_BAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataOutput_BAA.Location = new System.Drawing.Point(401, 127);
            this.panelDataOutput_BAA.Name = "panelDataOutput_BAA";
            this.panelDataOutput_BAA.Size = new System.Drawing.Size(415, 284);
            this.panelDataOutput_BAA.TabIndex = 4;
            // 
            // groupBoxDataOutput_BAA
            // 
            this.groupBoxDataOutput_BAA.Controls.Add(this.dataGridViewDataOutput_BAA);
            this.groupBoxDataOutput_BAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDataOutput_BAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDataOutput_BAA.Name = "groupBoxDataOutput_BAA";
            this.groupBoxDataOutput_BAA.Size = new System.Drawing.Size(415, 284);
            this.groupBoxDataOutput_BAA.TabIndex = 0;
            this.groupBoxDataOutput_BAA.TabStop = false;
            this.groupBoxDataOutput_BAA.Text = "Вывод:";
            // 
            // dataGridViewDataOutput_BAA
            // 
            this.dataGridViewDataOutput_BAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataOutput_BAA.ColumnHeadersVisible = false;
            this.dataGridViewDataOutput_BAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDataOutput_BAA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewDataOutput_BAA.Name = "dataGridViewDataOutput_BAA";
            this.dataGridViewDataOutput_BAA.RowHeadersVisible = false;
            this.dataGridViewDataOutput_BAA.Size = new System.Drawing.Size(409, 265);
            this.dataGridViewDataOutput_BAA.TabIndex = 0;
            // 
            // toolTipButtons_BAA
            // 
            this.toolTipButtons_BAA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButtons_BAA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 411);
            this.Controls.Add(this.panelDataOutput_BAA);
            this.Controls.Add(this.splitterDataInput_BAA);
            this.Controls.Add(this.panelDataInput_BAA);
            this.Controls.Add(this.panelRead_BAA);
            this.Controls.Add(this.panelButtons_BAA);
            this.MinimumSize = new System.Drawing.Size(832, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 12 | Брюхов А. А.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelButtons_BAA.ResumeLayout(false);
            this.panelRead_BAA.ResumeLayout(false);
            this.groupBoxRead_BAA.ResumeLayout(false);
            this.groupBoxRead_BAA.PerformLayout();
            this.panelDataInput_BAA.ResumeLayout(false);
            this.groupBoxDataInput_BAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataInput_BAA)).EndInit();
            this.panelDataOutput_BAA.ResumeLayout(false);
            this.groupBoxDataOutput_BAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataOutput_BAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_BAA;
        private System.Windows.Forms.Panel panelRead_BAA;
        private System.Windows.Forms.Panel panelDataInput_BAA;
        private System.Windows.Forms.Splitter splitterDataInput_BAA;
        private System.Windows.Forms.Panel panelDataOutput_BAA;
        private System.Windows.Forms.GroupBox groupBoxRead_BAA;
        private System.Windows.Forms.Label labelRead_BAA;
        private System.Windows.Forms.GroupBox groupBoxDataInput_BAA;
        private System.Windows.Forms.DataGridView dataGridViewDataInput_BAA;
        private System.Windows.Forms.GroupBox groupBoxDataOutput_BAA;
        private System.Windows.Forms.DataGridView dataGridViewDataOutput_BAA;
        private System.Windows.Forms.Button buttonHelp_BAA;
        private System.Windows.Forms.Button buttonDone_BAA;
        private System.Windows.Forms.Button buttonOpenFile_BAA;
        private System.Windows.Forms.OpenFileDialog openFileDialog_BAA;
        private System.Windows.Forms.ToolTip toolTipButtons_BAA;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_BAA;
        private System.Windows.Forms.Button buttonSaveFile_BAA;
    }
}

