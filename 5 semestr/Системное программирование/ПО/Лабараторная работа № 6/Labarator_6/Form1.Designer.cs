namespace Labarator_6
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
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose( );
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewKeyValue = new System.Windows.Forms.TextBox();
            this.txtKeyName = new System.Windows.Forms.TextBox();
            this.txtKeyValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFindValue = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnKeyEdit = new System.Windows.Forms.Button();
            this.btnKeyRemove = new System.Windows.Forms.Button();
            this.btnKeyAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pnlLeftSide = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRegOn = new System.Windows.Forms.Button();
            this.btnRegOff = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTaskMOn = new System.Windows.Forms.Button();
            this.btnTaskMOff = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlLeftSide.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Значение (нов.) :";
            // 
            // txtNewKeyValue
            // 
            this.txtNewKeyValue.Location = new System.Drawing.Point(109, 83);
            this.txtNewKeyValue.Name = "txtNewKeyValue";
            this.txtNewKeyValue.Size = new System.Drawing.Size(125, 20);
            this.txtNewKeyValue.TabIndex = 26;
            // 
            // txtKeyName
            // 
            this.txtKeyName.Location = new System.Drawing.Point(109, 30);
            this.txtKeyName.Name = "txtKeyName";
            this.txtKeyName.Size = new System.Drawing.Size(125, 20);
            this.txtKeyName.TabIndex = 25;
            // 
            // txtKeyValue
            // 
            this.txtKeyValue.Location = new System.Drawing.Point(109, 57);
            this.txtKeyValue.Name = "txtKeyValue";
            this.txtKeyValue.Size = new System.Drawing.Size(125, 20);
            this.txtKeyValue.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Значение :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtNewKeyValue);
            this.groupBox4.Controls.Add(this.txtKeyName);
            this.groupBox4.Controls.Add(this.txtKeyValue);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(10, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 126);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ключ :";
            // 
            // txtFindValue
            // 
            this.txtFindValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFindValue.Location = new System.Drawing.Point(282, 12);
            this.txtFindValue.Name = "txtFindValue";
            this.txtFindValue.Size = new System.Drawing.Size(405, 20);
            this.txtFindValue.TabIndex = 22;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.Location = new System.Drawing.Point(702, 10);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(122, 23);
            this.btnFind.TabIndex = 21;
            this.btnFind.Text = "Поиск";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click_1);
            // 
            // btnKeyEdit
            // 
            this.btnKeyEdit.Location = new System.Drawing.Point(109, 88);
            this.btnKeyEdit.Name = "btnKeyEdit";
            this.btnKeyEdit.Size = new System.Drawing.Size(122, 23);
            this.btnKeyEdit.TabIndex = 5;
            this.btnKeyEdit.Text = "Редактирование";
            this.btnKeyEdit.UseVisualStyleBackColor = true;
            // 
            // btnKeyRemove
            // 
            this.btnKeyRemove.Location = new System.Drawing.Point(109, 59);
            this.btnKeyRemove.Name = "btnKeyRemove";
            this.btnKeyRemove.Size = new System.Drawing.Size(122, 23);
            this.btnKeyRemove.TabIndex = 4;
            this.btnKeyRemove.Text = "Удаление";
            this.btnKeyRemove.UseVisualStyleBackColor = true;
            // 
            // btnKeyAdd
            // 
            this.btnKeyAdd.Location = new System.Drawing.Point(109, 30);
            this.btnKeyAdd.Name = "btnKeyAdd";
            this.btnKeyAdd.Size = new System.Drawing.Size(122, 23);
            this.btnKeyAdd.TabIndex = 3;
            this.btnKeyAdd.Text = "Добавление";
            this.btnKeyAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKeyEdit);
            this.groupBox3.Controls.Add(this.btnKeyRemove);
            this.groupBox3.Controls.Add(this.btnKeyAdd);
            this.groupBox3.Location = new System.Drawing.Point(10, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 134);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Реестр (ключ)";
            // 
            // pnlLeftSide
            // 
            this.pnlLeftSide.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLeftSide.Controls.Add(this.btnPrint);
            this.pnlLeftSide.Controls.Add(this.groupBox4);
            this.pnlLeftSide.Controls.Add(this.groupBox3);
            this.pnlLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftSide.Location = new System.Drawing.Point(0, 46);
            this.pnlLeftSide.Name = "pnlLeftSide";
            this.pnlLeftSide.Size = new System.Drawing.Size(275, 450);
            this.pnlLeftSide.TabIndex = 6;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(136, 405);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(122, 23);
            this.btnPrint.TabIndex = 26;
            this.btnPrint.Text = "Вывод";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // pnlStatus
            // 
            this.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.Location = new System.Drawing.Point(0, 496);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(847, 53);
            this.pnlStatus.TabIndex = 5;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMenu.Controls.Add(this.txtFindValue);
            this.pnlMenu.Controls.Add(this.btnFind);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(847, 46);
            this.pnlMenu.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(275, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 450);
            this.panel1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRegOn);
            this.groupBox2.Controls.Add(this.btnRegOff);
            this.groupBox2.Location = new System.Drawing.Point(28, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 92);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление Regedit";
            // 
            // btnRegOn
            // 
            this.btnRegOn.Location = new System.Drawing.Point(32, 19);
            this.btnRegOn.Name = "btnRegOn";
            this.btnRegOn.Size = new System.Drawing.Size(106, 23);
            this.btnRegOn.TabIndex = 2;
            this.btnRegOn.Text = "Разблокировать";
            this.btnRegOn.UseVisualStyleBackColor = true;
            // 
            // btnRegOff
            // 
            this.btnRegOff.Location = new System.Drawing.Point(31, 57);
            this.btnRegOff.Name = "btnRegOff";
            this.btnRegOff.Size = new System.Drawing.Size(107, 23);
            this.btnRegOff.TabIndex = 1;
            this.btnRegOff.Text = "Off";
            this.btnRegOff.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTaskMOn);
            this.groupBox1.Controls.Add(this.btnTaskMOff);
            this.groupBox1.Location = new System.Drawing.Point(28, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 94);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Диспетчером задач";
            // 
            // btnTaskMOn
            // 
            this.btnTaskMOn.Location = new System.Drawing.Point(31, 19);
            this.btnTaskMOn.Name = "btnTaskMOn";
            this.btnTaskMOn.Size = new System.Drawing.Size(107, 23);
            this.btnTaskMOn.TabIndex = 2;
            this.btnTaskMOn.Text = "Разблокировать";
            this.btnTaskMOn.UseVisualStyleBackColor = true;
            // 
            // btnTaskMOff
            // 
            this.btnTaskMOff.Location = new System.Drawing.Point(31, 57);
            this.btnTaskMOff.Name = "btnTaskMOff";
            this.btnTaskMOff.Size = new System.Drawing.Size(107, 23);
            this.btnTaskMOff.TabIndex = 1;
            this.btnTaskMOff.Text = "Заблокировать";
            this.btnTaskMOff.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtConsole);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 194);
            this.panel2.TabIndex = 0;
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsole.ForeColor = System.Drawing.Color.White;
            this.txtConsole.Location = new System.Drawing.Point(0, 0);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(564, 190);
            this.txtConsole.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 549);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlLeftSide);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.pnlMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.pnlLeftSide.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewKeyValue;
        private System.Windows.Forms.TextBox txtKeyName;
        private System.Windows.Forms.TextBox txtKeyValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFindValue;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnKeyEdit;
        private System.Windows.Forms.Button btnKeyRemove;
        private System.Windows.Forms.Button btnKeyAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel pnlLeftSide;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRegOn;
        private System.Windows.Forms.Button btnRegOff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTaskMOn;
        private System.Windows.Forms.Button btnTaskMOff;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtConsole;
    }
}

