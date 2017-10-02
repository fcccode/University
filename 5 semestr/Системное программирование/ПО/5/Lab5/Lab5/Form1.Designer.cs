namespace Lab5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose( );
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnBubble = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBubble = new System.Windows.Forms.TextBox();
            this.btnMerge = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMerge = new System.Windows.Forms.TextBox();
            this.btnQuick = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuick = new System.Windows.Forms.TextBox();
            this.btnSheider = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSheider = new System.Windows.Forms.TextBox();
            this.btnRadix = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRadix = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCounter = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCounter = new System.Windows.Forms.TextBox();
            this.txtArraySize = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMinValue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaxValue = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Генерация";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(127, 23);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(100, 20);
            this.txtInsert.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вставками";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(250, 21);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(106, 23);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Посчитать";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnBubble
            // 
            this.btnBubble.Location = new System.Drawing.Point(250, 50);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.Size = new System.Drawing.Size(106, 23);
            this.btnBubble.TabIndex = 6;
            this.btnBubble.Text = "Посчитать";
            this.btnBubble.UseVisualStyleBackColor = true;
            this.btnBubble.Click += new System.EventHandler(this.btnBubble_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пузырьком";
            // 
            // txtBubble
            // 
            this.txtBubble.Location = new System.Drawing.Point(127, 52);
            this.txtBubble.Name = "txtBubble";
            this.txtBubble.Size = new System.Drawing.Size(100, 20);
            this.txtBubble.TabIndex = 4;
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(250, 79);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(106, 23);
            this.btnMerge.TabIndex = 9;
            this.btnMerge.Text = "Посчитать";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Слиянием";
            // 
            // txtMerge
            // 
            this.txtMerge.Location = new System.Drawing.Point(127, 81);
            this.txtMerge.Name = "txtMerge";
            this.txtMerge.Size = new System.Drawing.Size(100, 20);
            this.txtMerge.TabIndex = 7;
            // 
            // btnQuick
            // 
            this.btnQuick.Location = new System.Drawing.Point(250, 108);
            this.btnQuick.Name = "btnQuick";
            this.btnQuick.Size = new System.Drawing.Size(106, 23);
            this.btnQuick.TabIndex = 12;
            this.btnQuick.Text = "Посчитать";
            this.btnQuick.UseVisualStyleBackColor = true;
            this.btnQuick.Click += new System.EventHandler(this.btnQuick_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Быстрая";
            // 
            // txtQuick
            // 
            this.txtQuick.Location = new System.Drawing.Point(127, 110);
            this.txtQuick.Name = "txtQuick";
            this.txtQuick.Size = new System.Drawing.Size(100, 20);
            this.txtQuick.TabIndex = 10;
            // 
            // btnSheider
            // 
            this.btnSheider.Location = new System.Drawing.Point(250, 137);
            this.btnSheider.Name = "btnSheider";
            this.btnSheider.Size = new System.Drawing.Size(106, 23);
            this.btnSheider.TabIndex = 15;
            this.btnSheider.Text = "Посчитать";
            this.btnSheider.UseVisualStyleBackColor = true;
            this.btnSheider.Click += new System.EventHandler(this.btnSheider_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Перемешиванием";
            // 
            // txtSheider
            // 
            this.txtSheider.Location = new System.Drawing.Point(127, 139);
            this.txtSheider.Name = "txtSheider";
            this.txtSheider.Size = new System.Drawing.Size(100, 20);
            this.txtSheider.TabIndex = 13;
            // 
            // btnRadix
            // 
            this.btnRadix.Location = new System.Drawing.Point(250, 166);
            this.btnRadix.Name = "btnRadix";
            this.btnRadix.Size = new System.Drawing.Size(106, 23);
            this.btnRadix.TabIndex = 18;
            this.btnRadix.Text = "Посчитать";
            this.btnRadix.UseVisualStyleBackColor = true;
            this.btnRadix.Click += new System.EventHandler(this.btnRadix_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Поразрядная";
            // 
            // txtRadix
            // 
            this.txtRadix.Location = new System.Drawing.Point(127, 168);
            this.txtRadix.Name = "txtRadix";
            this.txtRadix.Size = new System.Drawing.Size(100, 20);
            this.txtRadix.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCounter);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCounter);
            this.groupBox1.Controls.Add(this.txtMerge);
            this.groupBox1.Controls.Add(this.btnRadix);
            this.groupBox1.Controls.Add(this.txtInsert);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRadix);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.btnSheider);
            this.groupBox1.Controls.Add(this.txtBubble);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSheider);
            this.groupBox1.Controls.Add(this.btnBubble);
            this.groupBox1.Controls.Add(this.btnQuick);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnMerge);
            this.groupBox1.Controls.Add(this.txtQuick);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 238);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка ( в миллисекундах)";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(115, 158);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 24);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(115, 192);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCounter
            // 
            this.btnCounter.Location = new System.Drawing.Point(250, 195);
            this.btnCounter.Name = "btnCounter";
            this.btnCounter.Size = new System.Drawing.Size(106, 23);
            this.btnCounter.TabIndex = 21;
            this.btnCounter.Text = "Посчитать";
            this.btnCounter.UseVisualStyleBackColor = true;
            this.btnCounter.Click += new System.EventHandler(this.btnCounter_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "С подсчетом";
            // 
            // txtCounter
            // 
            this.txtCounter.Location = new System.Drawing.Point(127, 197);
            this.txtCounter.Name = "txtCounter";
            this.txtCounter.Size = new System.Drawing.Size(100, 20);
            this.txtCounter.TabIndex = 19;
            // 
            // txtArraySize
            // 
            this.txtArraySize.Location = new System.Drawing.Point(115, 28);
            this.txtArraySize.Name = "txtArraySize";
            this.txtArraySize.Size = new System.Drawing.Size(100, 20);
            this.txtArraySize.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.txtMaxValue);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtMinValue);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtArraySize);
            this.groupBox2.Location = new System.Drawing.Point(414, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 238);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Размер массива";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Мин. значение";
            // 
            // txtMinValue
            // 
            this.txtMinValue.Location = new System.Drawing.Point(115, 54);
            this.txtMinValue.Name = "txtMinValue";
            this.txtMinValue.Size = new System.Drawing.Size(100, 20);
            this.txtMinValue.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Макс. значение";
            // 
            // txtMaxValue
            // 
            this.txtMaxValue.Location = new System.Drawing.Point(115, 82);
            this.txtMaxValue.Name = "txtMaxValue";
            this.txtMaxValue.Size = new System.Drawing.Size(100, 20);
            this.txtMaxValue.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 262);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Лабараторная работа # 5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnBubble;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBubble;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMerge;
        private System.Windows.Forms.Button btnQuick;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuick;
        private System.Windows.Forms.Button btnSheider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSheider;
        private System.Windows.Forms.Button btnRadix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRadix;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCounter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCounter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtArraySize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaxValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMinValue;
        private System.Windows.Forms.Label label8;
    }
}

