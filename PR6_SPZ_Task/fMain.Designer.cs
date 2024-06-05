namespace PR6_SPZ_Task
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbX1 = new System.Windows.Forms.TextBox();
            this.tbX2 = new System.Windows.Forms.TextBox();
            this.tbAvg = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Змінна Х1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Змінна Х2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Результат розрахунку Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Середнє арифметичне";
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalc.FlatAppearance.BorderSize = 0;
            this.btnCalc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCalc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Location = new System.Drawing.Point(33, 219);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(125, 42);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Обчислити";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(194, 219);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 42);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(355, 219);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 42);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbX1
            // 
            this.tbX1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbX1.Location = new System.Drawing.Point(251, 27);
            this.tbX1.Name = "tbX1";
            this.tbX1.Size = new System.Drawing.Size(229, 29);
            this.tbX1.TabIndex = 7;
            // 
            // tbX2
            // 
            this.tbX2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbX2.Location = new System.Drawing.Point(251, 73);
            this.tbX2.Name = "tbX2";
            this.tbX2.Size = new System.Drawing.Size(229, 29);
            this.tbX2.TabIndex = 8;
            // 
            // tbAvg
            // 
            this.tbAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAvg.Location = new System.Drawing.Point(251, 119);
            this.tbAvg.Name = "tbAvg";
            this.tbAvg.ReadOnly = true;
            this.tbAvg.Size = new System.Drawing.Size(229, 29);
            this.tbAvg.TabIndex = 9;
            // 
            // tbY
            // 
            this.tbY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbY.Location = new System.Drawing.Point(251, 165);
            this.tbY.Name = "tbY";
            this.tbY.ReadOnly = true;
            this.tbY.Size = new System.Drawing.Size(229, 29);
            this.tbY.TabIndex = 10;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 282);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbAvg);
            this.Controls.Add(this.tbX2);
            this.Controls.Add(this.tbX1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Onest", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbX1;
        private System.Windows.Forms.TextBox tbX2;
        private System.Windows.Forms.TextBox tbAvg;
        private System.Windows.Forms.TextBox tbY;
    }
}

