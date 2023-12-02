
namespace Tyuiu.BrukhovAA.Sprint6.Task0.V9
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
            this.pictureBoxFormula_BAA = new System.Windows.Forms.PictureBox();
            this.textBoxRead_BAA = new System.Windows.Forms.TextBox();
            this.groupBoxGetValue_BAA = new System.Windows.Forms.GroupBox();
            this.textBoxVarX_BAA = new System.Windows.Forms.TextBox();
            this.labelVarX_BAA = new System.Windows.Forms.Label();
            this.groupBoxResult_BAA = new System.Windows.Forms.GroupBox();
            this.labelResult_BAA = new System.Windows.Forms.Label();
            this.textBoxResult_BAA = new System.Windows.Forms.TextBox();
            this.buttonDone_BAA = new System.Windows.Forms.Button();
            this.buttonStudent_BAA = new System.Windows.Forms.Button();
            this.groupBoxRead_BAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_BAA)).BeginInit();
            this.groupBoxGetValue_BAA.SuspendLayout();
            this.groupBoxResult_BAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRead_BAA
            // 
            this.groupBoxRead_BAA.Controls.Add(this.pictureBoxFormula_BAA);
            this.groupBoxRead_BAA.Controls.Add(this.textBoxRead_BAA);
            this.groupBoxRead_BAA.Location = new System.Drawing.Point(24, 29);
            this.groupBoxRead_BAA.Name = "groupBoxRead_BAA";
            this.groupBoxRead_BAA.Size = new System.Drawing.Size(753, 241);
            this.groupBoxRead_BAA.TabIndex = 0;
            this.groupBoxRead_BAA.TabStop = false;
            this.groupBoxRead_BAA.Text = "Условие";
            // 
            // pictureBoxFormula_BAA
            // 
            this.pictureBoxFormula_BAA.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_BAA.ErrorImage")));
            this.pictureBoxFormula_BAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_BAA.Image")));
            this.pictureBoxFormula_BAA.Location = new System.Drawing.Point(627, 19);
            this.pictureBoxFormula_BAA.Name = "pictureBoxFormula_BAA";
            this.pictureBoxFormula_BAA.Size = new System.Drawing.Size(108, 62);
            this.pictureBoxFormula_BAA.TabIndex = 4;
            this.pictureBoxFormula_BAA.TabStop = false;
            // 
            // textBoxRead_BAA
            // 
            this.textBoxRead_BAA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRead_BAA.Location = new System.Drawing.Point(6, 19);
            this.textBoxRead_BAA.Multiline = true;
            this.textBoxRead_BAA.Name = "textBoxRead_BAA";
            this.textBoxRead_BAA.ReadOnly = true;
            this.textBoxRead_BAA.Size = new System.Drawing.Size(453, 216);
            this.textBoxRead_BAA.TabIndex = 3;
            this.textBoxRead_BAA.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxGetValue_BAA
            // 
            this.groupBoxGetValue_BAA.Controls.Add(this.textBoxVarX_BAA);
            this.groupBoxGetValue_BAA.Controls.Add(this.labelVarX_BAA);
            this.groupBoxGetValue_BAA.Location = new System.Drawing.Point(24, 276);
            this.groupBoxGetValue_BAA.Name = "groupBoxGetValue_BAA";
            this.groupBoxGetValue_BAA.Size = new System.Drawing.Size(459, 104);
            this.groupBoxGetValue_BAA.TabIndex = 1;
            this.groupBoxGetValue_BAA.TabStop = false;
            this.groupBoxGetValue_BAA.Text = "Ввод данных";
            // 
            // textBoxVarX_BAA
            // 
            this.textBoxVarX_BAA.Location = new System.Drawing.Point(32, 43);
            this.textBoxVarX_BAA.Name = "textBoxVarX_BAA";
            this.textBoxVarX_BAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarX_BAA.TabIndex = 4;
            this.textBoxVarX_BAA.Text = "3";
            this.textBoxVarX_BAA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxVarX_KeyPress);
            // 
            // labelVarX_BAA
            // 
            this.labelVarX_BAA.AutoSize = true;
            this.labelVarX_BAA.Location = new System.Drawing.Point(29, 24);
            this.labelVarX_BAA.Name = "labelVarX_BAA";
            this.labelVarX_BAA.Size = new System.Drawing.Size(84, 13);
            this.labelVarX_BAA.TabIndex = 3;
            this.labelVarX_BAA.Text = "Переменная X:";
            // 
            // groupBoxResult_BAA
            // 
            this.groupBoxResult_BAA.Controls.Add(this.labelResult_BAA);
            this.groupBoxResult_BAA.Controls.Add(this.textBoxResult_BAA);
            this.groupBoxResult_BAA.Location = new System.Drawing.Point(501, 276);
            this.groupBoxResult_BAA.Name = "groupBoxResult_BAA";
            this.groupBoxResult_BAA.Size = new System.Drawing.Size(276, 104);
            this.groupBoxResult_BAA.TabIndex = 2;
            this.groupBoxResult_BAA.TabStop = false;
            this.groupBoxResult_BAA.Text = "Вывод данных";
            // 
            // labelResult_BAA
            // 
            this.labelResult_BAA.AutoSize = true;
            this.labelResult_BAA.Location = new System.Drawing.Point(24, 24);
            this.labelResult_BAA.Name = "labelResult_BAA";
            this.labelResult_BAA.Size = new System.Drawing.Size(59, 13);
            this.labelResult_BAA.TabIndex = 1;
            this.labelResult_BAA.Text = "Результат";
            // 
            // textBoxResult_BAA
            // 
            this.textBoxResult_BAA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResult_BAA.Location = new System.Drawing.Point(24, 43);
            this.textBoxResult_BAA.Name = "textBoxResult_BAA";
            this.textBoxResult_BAA.ReadOnly = true;
            this.textBoxResult_BAA.Size = new System.Drawing.Size(234, 20);
            this.textBoxResult_BAA.TabIndex = 0;
            // 
            // buttonDone_BAA
            // 
            this.buttonDone_BAA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDone_BAA.Location = new System.Drawing.Point(651, 386);
            this.buttonDone_BAA.Name = "buttonDone_BAA";
            this.buttonDone_BAA.Size = new System.Drawing.Size(125, 42);
            this.buttonDone_BAA.TabIndex = 3;
            this.buttonDone_BAA.Text = "Выполнить";
            this.buttonDone_BAA.UseVisualStyleBackColor = true;
            this.buttonDone_BAA.Click += new System.EventHandler(this.buttonDone_BAA_Click);
            // 
            // buttonStudent_BAA
            // 
            this.buttonStudent_BAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudent_BAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStudent_BAA.Location = new System.Drawing.Point(602, 386);
            this.buttonStudent_BAA.Name = "buttonStudent_BAA";
            this.buttonStudent_BAA.Size = new System.Drawing.Size(42, 42);
            this.buttonStudent_BAA.TabIndex = 4;
            this.buttonStudent_BAA.Text = "?";
            this.buttonStudent_BAA.UseVisualStyleBackColor = true;
            this.buttonStudent_BAA.Click += new System.EventHandler(this.buttonStudent_BAA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStudent_BAA);
            this.Controls.Add(this.buttonDone_BAA);
            this.Controls.Add(this.groupBoxResult_BAA);
            this.Controls.Add(this.groupBoxGetValue_BAA);
            this.Controls.Add(this.groupBoxRead_BAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 9 | Брюхов А. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxRead_BAA.ResumeLayout(false);
            this.groupBoxRead_BAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_BAA)).EndInit();
            this.groupBoxGetValue_BAA.ResumeLayout(false);
            this.groupBoxGetValue_BAA.PerformLayout();
            this.groupBoxResult_BAA.ResumeLayout(false);
            this.groupBoxResult_BAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRead_BAA;
        private System.Windows.Forms.GroupBox groupBoxGetValue_BAA;
        private System.Windows.Forms.GroupBox groupBoxResult_BAA;
        private System.Windows.Forms.TextBox textBoxRead_BAA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_BAA;
        private System.Windows.Forms.Label labelVarX_BAA;
        private System.Windows.Forms.Label labelResult_BAA;
        private System.Windows.Forms.TextBox textBoxResult_BAA;
        private System.Windows.Forms.Button buttonDone_BAA;
        private System.Windows.Forms.Button buttonStudent_BAA;
        private System.Windows.Forms.TextBox textBoxVarX_BAA;
    }
}

