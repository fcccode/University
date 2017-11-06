namespace Labarator_1_1
{
    partial class Form1
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
            this.Cne = new System.Windows.Forms.GroupBox();
            this.txtTrariz = new System.Windows.Forms.TextBox();
            this.txtOet = new System.Windows.Forms.TextBox();
            this.txtSp = new System.Windows.Forms.TextBox();
            this.txtIpz = new System.Windows.Forms.TextBox();
            this.txtPvs = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtMinValue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStudentListCount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLoadXml = new System.Windows.Forms.Button();
            this.Cne.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // Cne
            // 
            this.Cne.Controls.Add(this.txtTrariz);
            this.Cne.Controls.Add(this.txtOet);
            this.Cne.Controls.Add(this.txtSp);
            this.Cne.Controls.Add(this.txtIpz);
            this.Cne.Controls.Add(this.txtPvs);
            this.Cne.Controls.Add(this.txtSurname);
            this.Cne.Controls.Add(this.txtName);
            this.Cne.Controls.Add(this.label7);
            this.Cne.Controls.Add(this.label6);
            this.Cne.Controls.Add(this.label5);
            this.Cne.Controls.Add(this.label4);
            this.Cne.Controls.Add(this.label3);
            this.Cne.Controls.Add(this.label2);
            this.Cne.Controls.Add(this.label1);
            this.Cne.Location = new System.Drawing.Point(24, 24);
            this.Cne.Name = "Cne";
            this.Cne.Size = new System.Drawing.Size(223, 212);
            this.Cne.TabIndex = 1;
            this.Cne.TabStop = false;
            this.Cne.Text = "Студент";
            // 
            // txtTrariz
            // 
            this.txtTrariz.Location = new System.Drawing.Point(135, 180);
            this.txtTrariz.MaxLength = 1;
            this.txtTrariz.Name = "txtTrariz";
            this.txtTrariz.Size = new System.Drawing.Size(61, 20);
            this.txtTrariz.TabIndex = 13;
            this.txtTrariz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrariz_KeyPress);
            // 
            // txtOet
            // 
            this.txtOet.Location = new System.Drawing.Point(135, 157);
            this.txtOet.MaxLength = 1;
            this.txtOet.Name = "txtOet";
            this.txtOet.Size = new System.Drawing.Size(61, 20);
            this.txtOet.TabIndex = 12;
            this.txtOet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOet_KeyPress);
            // 
            // txtSp
            // 
            this.txtSp.Location = new System.Drawing.Point(135, 134);
            this.txtSp.MaxLength = 1;
            this.txtSp.Name = "txtSp";
            this.txtSp.Size = new System.Drawing.Size(61, 20);
            this.txtSp.TabIndex = 11;
            this.txtSp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSp_KeyPress);
            // 
            // txtIpz
            // 
            this.txtIpz.Location = new System.Drawing.Point(135, 111);
            this.txtIpz.MaxLength = 1;
            this.txtIpz.Name = "txtIpz";
            this.txtIpz.Size = new System.Drawing.Size(61, 20);
            this.txtIpz.TabIndex = 10;
            this.txtIpz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIpz_KeyPress);
            // 
            // txtPvs
            // 
            this.txtPvs.Location = new System.Drawing.Point(135, 88);
            this.txtPvs.MaxLength = 1;
            this.txtPvs.Name = "txtPvs";
            this.txtPvs.Size = new System.Drawing.Size(61, 20);
            this.txtPvs.TabIndex = 9;
            this.txtPvs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPvs_KeyPress);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(96, 46);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(96, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Оценка по ТРАРИЗ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Оценка по ОЕТ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Оценка по СП";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Оценка по ИПЗ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Оценка по ПВС";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(272, 258);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(85, 258);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 16;
            this.btnClean.Text = "Очистить";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtResult);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnFind);
            this.groupBox2.Controls.Add(this.txtMinValue);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtStudentListCount);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(269, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 212);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Статистика";
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(135, 131);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(98, 20);
            this.txtResult.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Результат";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(158, 180);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 16;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtMinValue
            // 
            this.txtMinValue.Location = new System.Drawing.Point(135, 59);
            this.txtMinValue.MaxLength = 1;
            this.txtMinValue.Name = "txtMinValue";
            this.txtMinValue.Size = new System.Drawing.Size(98, 20);
            this.txtMinValue.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Оценка";
            // 
            // txtStudentListCount
            // 
            this.txtStudentListCount.Enabled = false;
            this.txtStudentListCount.Location = new System.Drawing.Point(135, 29);
            this.txtStudentListCount.Name = "txtStudentListCount";
            this.txtStudentListCount.Size = new System.Drawing.Size(98, 20);
            this.txtStudentListCount.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "В списке студентов ";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(452, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Закрыть";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(172, 258);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLoadXml
            // 
            this.btnLoadXml.Location = new System.Drawing.Point(353, 258);
            this.btnLoadXml.Name = "btnLoadXml";
            this.btnLoadXml.Size = new System.Drawing.Size(75, 23);
            this.btnLoadXml.TabIndex = 20;
            this.btnLoadXml.Text = "Загрузить";
            this.btnLoadXml.UseVisualStyleBackColor = true;
            this.btnLoadXml.Click += new System.EventHandler(this.btnLoadXml_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 306);
            this.Controls.Add(this.btnLoadXml);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Cne);
            this.Name = "Form1";
            this.Text = "Лабараторная работа № 1";
            this.Cne.ResumeLayout(false);
            this.Cne.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Cne;
        private System.Windows.Forms.TextBox txtTrariz;
        private System.Windows.Forms.TextBox txtOet;
        private System.Windows.Forms.TextBox txtSp;
        private System.Windows.Forms.TextBox txtIpz;
        private System.Windows.Forms.TextBox txtPvs;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtMinValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStudentListCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLoadXml;
    }
}

