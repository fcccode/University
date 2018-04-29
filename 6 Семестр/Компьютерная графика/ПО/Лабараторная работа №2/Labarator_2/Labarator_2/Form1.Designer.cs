namespace Labarator_1
{
    partial class picture
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
            this.drawingArea = new System.Windows.Forms.PictureBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.horizontTrack = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sunPositionTrack = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.sunSizeTrack = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.housexTrack = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.houseyTrack = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horizontTrack)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sunPositionTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunSizeTrack)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.housexTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseyTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // drawingArea
            // 
            this.drawingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingArea.Location = new System.Drawing.Point(0, 0);
            this.drawingArea.Name = "drawingArea";
            this.drawingArea.Size = new System.Drawing.Size(484, 400);
            this.drawingArea.TabIndex = 0;
            this.drawingArea.TabStop = false;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(15, 371);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(170, 23);
            this.btnDraw.TabIndex = 3;
            this.btnDraw.Text = "Нарисовать";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.horizontTrack);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 62);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Горизонт";
            // 
            // horizontTrack
            // 
            this.horizontTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.horizontTrack.Location = new System.Drawing.Point(3, 16);
            this.horizontTrack.Name = "horizontTrack";
            this.horizontTrack.Size = new System.Drawing.Size(176, 43);
            this.horizontTrack.TabIndex = 0;
            this.horizontTrack.Scroll += new System.EventHandler(this.horizontTrack_Scroll);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnDraw);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(484, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 400);
            this.panel1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.sunPositionTrack);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.sunSizeTrack);
            this.groupBox2.Location = new System.Drawing.Point(6, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 142);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Солнце";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "позиция по x";
            // 
            // sunPositionTrack
            // 
            this.sunPositionTrack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sunPositionTrack.Location = new System.Drawing.Point(3, 94);
            this.sunPositionTrack.Name = "sunPositionTrack";
            this.sunPositionTrack.Size = new System.Drawing.Size(176, 45);
            this.sunPositionTrack.TabIndex = 8;
            this.sunPositionTrack.Scroll += new System.EventHandler(this.sunPosition_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "размер";
            // 
            // sunSizeTrack
            // 
            this.sunSizeTrack.Location = new System.Drawing.Point(0, 33);
            this.sunSizeTrack.Maximum = 50;
            this.sunSizeTrack.Minimum = 10;
            this.sunSizeTrack.Name = "sunSizeTrack";
            this.sunSizeTrack.Size = new System.Drawing.Size(179, 45);
            this.sunSizeTrack.TabIndex = 6;
            this.sunSizeTrack.Value = 10;
            this.sunSizeTrack.Scroll += new System.EventHandler(this.sunSize_Scroll);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.drawingArea);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 400);
            this.panel2.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.housexTrack);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.houseyTrack);
            this.groupBox3.Location = new System.Drawing.Point(9, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 142);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Дом";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "позиция по x";
            // 
            // housexTrack
            // 
            this.housexTrack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.housexTrack.Location = new System.Drawing.Point(3, 94);
            this.housexTrack.Name = "housexTrack";
            this.housexTrack.Size = new System.Drawing.Size(176, 45);
            this.housexTrack.TabIndex = 8;
            this.housexTrack.Scroll += new System.EventHandler(this.housexTrack_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "позиция по y";
            // 
            // houseyTrack
            // 
            this.houseyTrack.Location = new System.Drawing.Point(0, 33);
            this.houseyTrack.Maximum = 50;
            this.houseyTrack.Minimum = 10;
            this.houseyTrack.Name = "houseyTrack";
            this.houseyTrack.Size = new System.Drawing.Size(179, 45);
            this.houseyTrack.TabIndex = 6;
            this.houseyTrack.Value = 10;
            this.houseyTrack.Scroll += new System.EventHandler(this.houseyTrack_Scroll);
            // 
            // picture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 400);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "picture";
            this.Text = "Лабараторная работа №1";
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horizontTrack)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sunPositionTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunSizeTrack)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.housexTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseyTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox drawingArea;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar horizontTrack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar sunPositionTrack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar sunSizeTrack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar housexTrack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar houseyTrack;
    }
}

