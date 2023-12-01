
namespace Tyuiu.BrukhovAA.Sprint6.Task1.V11
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
            this.groupBoxRead_BAA = new System.Windows.Forms.GroupBox();
            this.textBoxRead_BAA = new System.Windows.Forms.TextBox();
            this.pictureBoxRead_BAA = new System.Windows.Forms.PictureBox();
            this.groupBoxData_BAA = new System.Windows.Forms.GroupBox();
            this.textBoxStartStep_BAA = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_BAA = new System.Windows.Forms.TextBox();
            this.labelStartStep_BAA = new System.Windows.Forms.Label();
            this.labelStopStep_BAA = new System.Windows.Forms.Label();
            this.groupBoxResult_BAA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_BAA = new System.Windows.Forms.TextBox();
            this.buttonStudent_BAA = new System.Windows.Forms.Button();
            this.buttonDone_BAA = new System.Windows.Forms.Button();
            this.labelResult_BAA = new System.Windows.Forms.Label();
            this.groupBoxRead_BAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRead_BAA)).BeginInit();
            this.groupBoxData_BAA.SuspendLayout();
            this.groupBoxResult_BAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRead_BAA
            // 
            this.groupBoxRead_BAA.Controls.Add(this.pictureBoxRead_BAA);
            this.groupBoxRead_BAA.Controls.Add(this.textBoxRead_BAA);
            this.groupBoxRead_BAA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxRead_BAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxRead_BAA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxRead_BAA.Name = "groupBoxRead_BAA";
            this.groupBoxRead_BAA.Size = new System.Drawing.Size(489, 219);
            this.groupBoxRead_BAA.TabIndex = 0;
            this.groupBoxRead_BAA.TabStop = false;
            this.groupBoxRead_BAA.Text = "Условие";
            // 
            // textBoxRead_BAA
            // 
            this.textBoxRead_BAA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRead_BAA.Location = new System.Drawing.Point(6, 19);
            this.textBoxRead_BAA.Multiline = true;
            this.textBoxRead_BAA.Name = "textBoxRead_BAA";
            this.textBoxRead_BAA.ReadOnly = true;
            this.textBoxRead_BAA.Size = new System.Drawing.Size(342, 34);
            this.textBoxRead_BAA.TabIndex = 0;
            this.textBoxRead_BAA.Text = "Протабулировать функцию в заданном диапозоне [-5; 5].\r\nРезультат вывести в виде т" +
    "аблицы";
            // 
            // pictureBoxRead_BAA
            // 
            this.pictureBoxRead_BAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRead_BAA.Image")));
            this.pictureBoxRead_BAA.Location = new System.Drawing.Point(6, 59);
            this.pictureBoxRead_BAA.Name = "pictureBoxRead_BAA";
            this.pictureBoxRead_BAA.Size = new System.Drawing.Size(286, 36);
            this.pictureBoxRead_BAA.TabIndex = 1;
            this.pictureBoxRead_BAA.TabStop = false;
            // 
            // groupBoxData_BAA
            // 
            this.groupBoxData_BAA.Controls.Add(this.labelStopStep_BAA);
            this.groupBoxData_BAA.Controls.Add(this.labelStartStep_BAA);
            this.groupBoxData_BAA.Controls.Add(this.textBoxStopStep_BAA);
            this.groupBoxData_BAA.Controls.Add(this.textBoxStartStep_BAA);
            this.groupBoxData_BAA.Location = new System.Drawing.Point(19, 238);
            this.groupBoxData_BAA.Name = "groupBoxData_BAA";
            this.groupBoxData_BAA.Size = new System.Drawing.Size(286, 73);
            this.groupBoxData_BAA.TabIndex = 1;
            this.groupBoxData_BAA.TabStop = false;
            this.groupBoxData_BAA.Text = "Ввод данных";
            // 
            // textBoxStartStep_BAA
            // 
            this.textBoxStartStep_BAA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxStartStep_BAA.Location = new System.Drawing.Point(7, 36);
            this.textBoxStartStep_BAA.Name = "textBoxStartStep_BAA";
            this.textBoxStartStep_BAA.Size = new System.Drawing.Size(129, 20);
            this.textBoxStartStep_BAA.TabIndex = 0;
            this.textBoxStartStep_BAA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartStep_BAA_Key);
            // 
            // textBoxStopStep_BAA
            // 
            this.textBoxStopStep_BAA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxStopStep_BAA.Location = new System.Drawing.Point(151, 36);
            this.textBoxStopStep_BAA.Name = "textBoxStopStep_BAA";
            this.textBoxStopStep_BAA.Size = new System.Drawing.Size(129, 20);
            this.textBoxStopStep_BAA.TabIndex = 0;
            this.textBoxStopStep_BAA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartStep_BAA_Key);
            // 
            // labelStartStep_BAA
            // 
            this.labelStartStep_BAA.AutoSize = true;
            this.labelStartStep_BAA.Location = new System.Drawing.Point(7, 17);
            this.labelStartStep_BAA.Name = "labelStartStep_BAA";
            this.labelStartStep_BAA.Size = new System.Drawing.Size(67, 13);
            this.labelStartStep_BAA.TabIndex = 1;
            this.labelStartStep_BAA.Text = "Старт шага:";
            // 
            // labelStopStep_BAA
            // 
            this.labelStopStep_BAA.AutoSize = true;
            this.labelStopStep_BAA.Location = new System.Drawing.Point(148, 17);
            this.labelStopStep_BAA.Name = "labelStopStep_BAA";
            this.labelStopStep_BAA.Size = new System.Drawing.Size(69, 13);
            this.labelStopStep_BAA.TabIndex = 2;
            this.labelStopStep_BAA.Text = "Конец шага:";
            // 
            // groupBoxResult_BAA
            // 
            this.groupBoxResult_BAA.Controls.Add(this.labelResult_BAA);
            this.groupBoxResult_BAA.Controls.Add(this.textBoxResult_BAA);
            this.groupBoxResult_BAA.Location = new System.Drawing.Point(508, 13);
            this.groupBoxResult_BAA.Name = "groupBoxResult_BAA";
            this.groupBoxResult_BAA.Size = new System.Drawing.Size(200, 298);
            this.groupBoxResult_BAA.TabIndex = 2;
            this.groupBoxResult_BAA.TabStop = false;
            this.groupBoxResult_BAA.Text = "Вывод данных";
            // 
            // textBoxResult_BAA
            // 
            this.textBoxResult_BAA.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_BAA.Location = new System.Drawing.Point(7, 39);
            this.textBoxResult_BAA.Multiline = true;
            this.textBoxResult_BAA.Name = "textBoxResult_BAA";
            this.textBoxResult_BAA.ReadOnly = true;
            this.textBoxResult_BAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_BAA.Size = new System.Drawing.Size(187, 253);
            this.textBoxResult_BAA.TabIndex = 0;
            this.textBoxResult_BAA.TextChanged += new System.EventHandler(this.textBoxResult_BAA_TextChanged);
            // 
            // buttonStudent_BAA
            // 
            this.buttonStudent_BAA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonStudent_BAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStudent_BAA.Location = new System.Drawing.Point(312, 239);
            this.buttonStudent_BAA.Name = "buttonStudent_BAA";
            this.buttonStudent_BAA.Size = new System.Drawing.Size(78, 72);
            this.buttonStudent_BAA.TabIndex = 3;
            this.buttonStudent_BAA.Text = "Справка";
            this.buttonStudent_BAA.UseVisualStyleBackColor = false;
            this.buttonStudent_BAA.Click += new System.EventHandler(this.buttonStudent_BAA_Click);
            // 
            // buttonDone_BAA
            // 
            this.buttonDone_BAA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_BAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_BAA.Location = new System.Drawing.Point(397, 239);
            this.buttonDone_BAA.Name = "buttonDone_BAA";
            this.buttonDone_BAA.Size = new System.Drawing.Size(105, 72);
            this.buttonDone_BAA.TabIndex = 4;
            this.buttonDone_BAA.Text = "Выполнить";
            this.buttonDone_BAA.UseVisualStyleBackColor = false;
            this.buttonDone_BAA.Click += new System.EventHandler(this.buttonDone_BAA_Click);
            // 
            // labelResult_BAA
            // 
            this.labelResult_BAA.AutoSize = true;
            this.labelResult_BAA.Location = new System.Drawing.Point(7, 20);
            this.labelResult_BAA.Name = "labelResult_BAA";
            this.labelResult_BAA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_BAA.TabIndex = 1;
            this.labelResult_BAA.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 316);
            this.Controls.Add(this.buttonDone_BAA);
            this.Controls.Add(this.buttonStudent_BAA);
            this.Controls.Add(this.groupBoxResult_BAA);
            this.Controls.Add(this.groupBoxData_BAA);
            this.Controls.Add(this.groupBoxRead_BAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 11 | Брюхов А. А.";
            this.groupBoxRead_BAA.ResumeLayout(false);
            this.groupBoxRead_BAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRead_BAA)).EndInit();
            this.groupBoxData_BAA.ResumeLayout(false);
            this.groupBoxData_BAA.PerformLayout();
            this.groupBoxResult_BAA.ResumeLayout(false);
            this.groupBoxResult_BAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRead_BAA;
        private System.Windows.Forms.PictureBox pictureBoxRead_BAA;
        private System.Windows.Forms.TextBox textBoxRead_BAA;
        private System.Windows.Forms.GroupBox groupBoxData_BAA;
        private System.Windows.Forms.Label labelStopStep_BAA;
        private System.Windows.Forms.Label labelStartStep_BAA;
        private System.Windows.Forms.TextBox textBoxStopStep_BAA;
        private System.Windows.Forms.TextBox textBoxStartStep_BAA;
        private System.Windows.Forms.GroupBox groupBoxResult_BAA;
        private System.Windows.Forms.TextBox textBoxResult_BAA;
        private System.Windows.Forms.Label labelResult_BAA;
        private System.Windows.Forms.Button buttonStudent_BAA;
        private System.Windows.Forms.Button buttonDone_BAA;
    }
}

