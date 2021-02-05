namespace Security6
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
            this.label2 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.TextBox();
            this.genX = new System.Windows.Forms.Button();
            this.genY = new System.Windows.Forms.Button();
            this.outAliceK = new System.Windows.Forms.Label();
            this.outAliceX = new System.Windows.Forms.Label();
            this.outBobY = new System.Windows.Forms.Label();
            this.outBobK = new System.Windows.Forms.Label();
            this.Alice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Button();
            this.aList = new System.Windows.Forms.ComboBox();
            this.p = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "a";
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(53, 97);
            this.x.Multiline = true;
            this.x.Name = "x";
            this.x.ReadOnly = true;
            this.x.Size = new System.Drawing.Size(54, 20);
            this.x.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "y";
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(399, 97);
            this.y.Name = "y";
            this.y.ReadOnly = true;
            this.y.Size = new System.Drawing.Size(36, 20);
            this.y.TabIndex = 7;
            // 
            // genX
            // 
            this.genX.Location = new System.Drawing.Point(109, 97);
            this.genX.Name = "genX";
            this.genX.Size = new System.Drawing.Size(56, 21);
            this.genX.TabIndex = 8;
            this.genX.Text = "Генер...";
            this.genX.UseVisualStyleBackColor = true;
            this.genX.Click += new System.EventHandler(this.genX_Click);
            // 
            // genY
            // 
            this.genY.Location = new System.Drawing.Point(300, 97);
            this.genY.Name = "genY";
            this.genY.Size = new System.Drawing.Size(75, 21);
            this.genY.TabIndex = 9;
            this.genY.Text = "Генер...";
            this.genY.UseVisualStyleBackColor = true;
            this.genY.Click += new System.EventHandler(this.genY_Click);
            // 
            // outAliceK
            // 
            this.outAliceK.AutoSize = true;
            this.outAliceK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outAliceK.Location = new System.Drawing.Point(32, 189);
            this.outAliceK.Name = "outAliceK";
            this.outAliceK.Size = new System.Drawing.Size(60, 24);
            this.outAliceK.TabIndex = 10;
            this.outAliceK.Text = "label5";
            this.outAliceK.Visible = false;
            // 
            // outAliceX
            // 
            this.outAliceX.AutoSize = true;
            this.outAliceX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outAliceX.Location = new System.Drawing.Point(33, 145);
            this.outAliceX.Name = "outAliceX";
            this.outAliceX.Size = new System.Drawing.Size(46, 17);
            this.outAliceX.TabIndex = 11;
            this.outAliceX.Text = "label5";
            this.outAliceX.Visible = false;
            // 
            // outBobY
            // 
            this.outBobY.AutoSize = true;
            this.outBobY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outBobY.Location = new System.Drawing.Point(297, 145);
            this.outBobY.Name = "outBobY";
            this.outBobY.Size = new System.Drawing.Size(46, 17);
            this.outBobY.TabIndex = 12;
            this.outBobY.Text = "label5";
            this.outBobY.Visible = false;
            // 
            // outBobK
            // 
            this.outBobK.AutoSize = true;
            this.outBobK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outBobK.Location = new System.Drawing.Point(296, 189);
            this.outBobK.Name = "outBobK";
            this.outBobK.Size = new System.Drawing.Size(60, 24);
            this.outBobK.TabIndex = 13;
            this.outBobK.Text = "label5";
            this.outBobK.Visible = false;
            // 
            // Alice
            // 
            this.Alice.AutoSize = true;
            this.Alice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Alice.Location = new System.Drawing.Point(37, 9);
            this.Alice.Name = "Alice";
            this.Alice.Size = new System.Drawing.Size(55, 25);
            this.Alice.TabIndex = 14;
            this.Alice.Text = "Alice";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(339, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Bob";
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(186, 90);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 36);
            this.check.TabIndex = 16;
            this.check.Text = "Перевірити";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // aList
            // 
            this.aList.FormattingEnabled = true;
            this.aList.Location = new System.Drawing.Point(52, 70);
            this.aList.Name = "aList";
            this.aList.Size = new System.Drawing.Size(55, 21);
            this.aList.TabIndex = 17;
            this.aList.SelectedIndexChanged += new System.EventHandler(this.aList_SelectedIndexChanged);
            // 
            // p
            // 
            this.p.FormattingEnabled = true;
            this.p.Location = new System.Drawing.Point(53, 43);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(54, 21);
            this.p.TabIndex = 18;
            this.p.SelectedIndexChanged += new System.EventHandler(this.p_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(450, 253);
            this.Controls.Add(this.p);
            this.Controls.Add(this.aList);
            this.Controls.Add(this.check);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Alice);
            this.Controls.Add(this.outBobK);
            this.Controls.Add(this.outBobY);
            this.Controls.Add(this.outAliceX);
            this.Controls.Add(this.outAliceK);
            this.Controls.Add(this.genY);
            this.Controls.Add(this.genX);
            this.Controls.Add(this.y);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.x);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Відкритий розподіл криптографічних ключів";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox y;
        private System.Windows.Forms.Button genX;
        private System.Windows.Forms.Button genY;
        private System.Windows.Forms.Label outAliceK;
        private System.Windows.Forms.Label outAliceX;
        private System.Windows.Forms.Label outBobY;
        private System.Windows.Forms.Label outBobK;
        private System.Windows.Forms.Label Alice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.ComboBox aList;
        private System.Windows.Forms.ComboBox p;
    }
}

