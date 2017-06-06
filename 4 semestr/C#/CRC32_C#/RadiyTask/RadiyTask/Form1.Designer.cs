namespace RadiyTask
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
            this.cln = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.textBoxRcvr = new System.Windows.Forms.TextBox();
            this.rec = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Label();
            this.dest = new System.Windows.Forms.Label();
            this.hash = new System.Windows.Forms.Label();
            this.textBoxSnd = new System.Windows.Forms.TextBox();
            this.textBoxDst = new System.Windows.Forms.TextBox();
            this.textBoxHash = new System.Windows.Forms.TextBox();
            this.direction = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.richTextBoxData = new System.Windows.Forms.RichTextBox();
            this.dlength = new System.Windows.Forms.Label();
            this.textBoxDLen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cln
            // 
            this.cln.Location = new System.Drawing.Point(16, 186);
            this.cln.Name = "cln";
            this.cln.Size = new System.Drawing.Size(121, 23);
            this.cln.TabIndex = 0;
            this.cln.Text = "clean";
            this.cln.UseVisualStyleBackColor = true;
            this.cln.Click += new System.EventHandler(this.cln_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(215, 186);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 1;
            this.sendBtn.Text = "send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(386, 186);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // textBoxRcvr
            // 
            this.textBoxRcvr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxRcvr.Location = new System.Drawing.Point(96, 42);
            this.textBoxRcvr.MaxLength = 2;
            this.textBoxRcvr.Name = "textBoxRcvr";
            this.textBoxRcvr.Size = new System.Drawing.Size(100, 20);
            this.textBoxRcvr.TabIndex = 3;
            this.textBoxRcvr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRcvr_KeyPress);
            // 
            // rec
            // 
            this.rec.AutoSize = true;
            this.rec.Location = new System.Drawing.Point(12, 47);
            this.rec.Name = "rec";
            this.rec.Size = new System.Drawing.Size(77, 13);
            this.rec.TabIndex = 4;
            this.rec.Text = "Receiver        :";
            // 
            // send
            // 
            this.send.AutoSize = true;
            this.send.Location = new System.Drawing.Point(12, 71);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(80, 13);
            this.send.TabIndex = 5;
            this.send.Text = "Sender           : ";
            // 
            // dest
            // 
            this.dest.AutoSize = true;
            this.dest.Location = new System.Drawing.Point(12, 97);
            this.dest.Name = "dest";
            this.dest.Size = new System.Drawing.Size(76, 13);
            this.dest.TabIndex = 6;
            this.dest.Text = "Purpose         :";
            // 
            // hash
            // 
            this.hash.AutoSize = true;
            this.hash.Location = new System.Drawing.Point(12, 123);
            this.hash.Name = "hash";
            this.hash.Size = new System.Drawing.Size(77, 13);
            this.hash.TabIndex = 7;
            this.hash.Text = "Hash              :";
            // 
            // textBoxSnd
            // 
            this.textBoxSnd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxSnd.Location = new System.Drawing.Point(96, 68);
            this.textBoxSnd.MaxLength = 2;
            this.textBoxSnd.Name = "textBoxSnd";
            this.textBoxSnd.Size = new System.Drawing.Size(100, 20);
            this.textBoxSnd.TabIndex = 8;
            this.textBoxSnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSnd_KeyPress);
            // 
            // textBoxDst
            // 
            this.textBoxDst.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDst.Location = new System.Drawing.Point(96, 94);
            this.textBoxDst.MaxLength = 2;
            this.textBoxDst.Name = "textBoxDst";
            this.textBoxDst.Size = new System.Drawing.Size(100, 20);
            this.textBoxDst.TabIndex = 9;
            this.textBoxDst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDst_KeyPress);
            // 
            // textBoxHash
            // 
            this.textBoxHash.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxHash.Location = new System.Drawing.Point(96, 120);
            this.textBoxHash.MaxLength = 8;
            this.textBoxHash.Name = "textBoxHash";
            this.textBoxHash.Size = new System.Drawing.Size(100, 20);
            this.textBoxHash.TabIndex = 10;
            this.textBoxHash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHash_KeyPress);
            // 
            // direction
            // 
            this.direction.AutoSize = true;
            this.direction.Location = new System.Drawing.Point(13, 9);
            this.direction.Name = "direction";
            this.direction.Size = new System.Drawing.Size(49, 13);
            this.direction.TabIndex = 11;
            this.direction.Text = "Direction";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "label6";
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Location = new System.Drawing.Point(212, 9);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(36, 13);
            this.data.TabIndex = 13;
            this.data.Text = "Data :";
            // 
            // richTextBoxData
            // 
            this.richTextBoxData.Location = new System.Drawing.Point(215, 41);
            this.richTextBoxData.Name = "richTextBoxData";
            this.richTextBoxData.Size = new System.Drawing.Size(246, 125);
            this.richTextBoxData.TabIndex = 14;
            this.richTextBoxData.Text = "";
            this.richTextBoxData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBoxData_KeyPress);
            // 
            // dlength
            // 
            this.dlength.AutoSize = true;
            this.dlength.Location = new System.Drawing.Point(12, 149);
            this.dlength.Name = "dlength";
            this.dlength.Size = new System.Drawing.Size(78, 13);
            this.dlength.TabIndex = 16;
            this.dlength.Text = "Data Length   :";
            // 
            // textBoxDLen
            // 
            this.textBoxDLen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDLen.Location = new System.Drawing.Point(96, 146);
            this.textBoxDLen.MaxLength = 4;
            this.textBoxDLen.Name = "textBoxDLen";
            this.textBoxDLen.Size = new System.Drawing.Size(100, 20);
            this.textBoxDLen.TabIndex = 15;
            this.textBoxDLen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDLen_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 227);
            this.Controls.Add(this.dlength);
            this.Controls.Add(this.textBoxDLen);
            this.Controls.Add(this.richTextBoxData);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.direction);
            this.Controls.Add(this.textBoxHash);
            this.Controls.Add(this.textBoxDst);
            this.Controls.Add(this.textBoxSnd);
            this.Controls.Add(this.hash);
            this.Controls.Add(this.dest);
            this.Controls.Add(this.send);
            this.Controls.Add(this.rec);
            this.Controls.Add(this.textBoxRcvr);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.cln);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Package Struct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cln;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox textBoxRcvr;
        private System.Windows.Forms.Label rec;
        private System.Windows.Forms.Label send;
        private System.Windows.Forms.Label dest;
        private System.Windows.Forms.Label hash;
        private System.Windows.Forms.TextBox textBoxSnd;
        private System.Windows.Forms.TextBox textBoxDst;
        private System.Windows.Forms.TextBox textBoxHash;
        private System.Windows.Forms.Label direction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.RichTextBox richTextBoxData;
        private System.Windows.Forms.Label dlength;
        private System.Windows.Forms.TextBox textBoxDLen;
    }
}

