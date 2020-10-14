namespace Triangle_2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkA = new System.Windows.Forms.CheckBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.checkB = new System.Windows.Forms.CheckBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.checkC = new System.Windows.Forms.CheckBox();
            this.txtS = new System.Windows.Forms.TextBox();
            this.checkS = new System.Windows.Forms.CheckBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.checkH = new System.Windows.Forms.CheckBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.checkP = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkFS = new System.Windows.Forms.CheckBox();
            this.checkFP = new System.Windows.Forms.CheckBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 19);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Введите данные";
            // 
            // checkA
            // 
            this.checkA.AutoSize = true;
            this.checkA.Location = new System.Drawing.Point(13, 42);
            this.checkA.Name = "checkA";
            this.checkA.Size = new System.Drawing.Size(78, 17);
            this.checkA.TabIndex = 1;
            this.checkA.Text = "Сторона A";
            this.checkA.UseVisualStyleBackColor = true;
            this.checkA.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(88, 39);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 2;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(88, 65);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 4;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // checkB
            // 
            this.checkB.AutoSize = true;
            this.checkB.Location = new System.Drawing.Point(13, 68);
            this.checkB.Name = "checkB";
            this.checkB.Size = new System.Drawing.Size(78, 17);
            this.checkB.TabIndex = 3;
            this.checkB.Text = "Сторона B";
            this.checkB.UseVisualStyleBackColor = true;
            this.checkB.CheckedChanged += new System.EventHandler(this.checkB_CheckedChanged);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(88, 91);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 6;
            this.txtC.TextChanged += new System.EventHandler(this.txtC_TextChanged);
            // 
            // checkC
            // 
            this.checkC.AutoSize = true;
            this.checkC.Location = new System.Drawing.Point(13, 94);
            this.checkC.Name = "checkC";
            this.checkC.Size = new System.Drawing.Size(78, 17);
            this.checkC.TabIndex = 5;
            this.checkC.Text = "Сторона C";
            this.checkC.UseVisualStyleBackColor = true;
            this.checkC.CheckedChanged += new System.EventHandler(this.checkC_CheckedChanged);
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(88, 143);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(100, 20);
            this.txtS.TabIndex = 10;
            this.txtS.TextChanged += new System.EventHandler(this.txtS_TextChanged);
            // 
            // checkS
            // 
            this.checkS.AutoSize = true;
            this.checkS.Location = new System.Drawing.Point(13, 146);
            this.checkS.Name = "checkS";
            this.checkS.Size = new System.Drawing.Size(73, 17);
            this.checkS.TabIndex = 9;
            this.checkS.Text = "Площадь";
            this.checkS.UseVisualStyleBackColor = true;
            this.checkS.CheckedChanged += new System.EventHandler(this.checkS_CheckedChanged);
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(88, 117);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(100, 20);
            this.txtH.TabIndex = 8;
            this.txtH.TextChanged += new System.EventHandler(this.txtH_TextChanged);
            // 
            // checkH
            // 
            this.checkH.AutoSize = true;
            this.checkH.Location = new System.Drawing.Point(13, 120);
            this.checkH.Name = "checkH";
            this.checkH.Size = new System.Drawing.Size(64, 17);
            this.checkH.TabIndex = 7;
            this.checkH.Text = "Высота";
            this.checkH.UseVisualStyleBackColor = true;
            this.checkH.CheckedChanged += new System.EventHandler(this.checkH_CheckedChanged);
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(88, 169);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(100, 20);
            this.txtP.TabIndex = 12;
            this.txtP.TextChanged += new System.EventHandler(this.txtP_TextChanged);
            // 
            // checkP
            // 
            this.checkP.AutoSize = true;
            this.checkP.Location = new System.Drawing.Point(13, 172);
            this.checkP.Name = "checkP";
            this.checkP.Size = new System.Drawing.Size(77, 17);
            this.checkP.TabIndex = 11;
            this.checkP.Text = "Периметр";
            this.checkP.UseVisualStyleBackColor = true;
            this.checkP.CheckedChanged += new System.EventHandler(this.checkP_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox2.Location = new System.Drawing.Point(13, 246);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 19);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "Что найти?";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // checkFS
            // 
            this.checkFS.AutoSize = true;
            this.checkFS.Location = new System.Drawing.Point(13, 271);
            this.checkFS.Name = "checkFS";
            this.checkFS.Size = new System.Drawing.Size(73, 17);
            this.checkFS.TabIndex = 14;
            this.checkFS.Text = "Площадь";
            this.checkFS.UseVisualStyleBackColor = true;
            this.checkFS.CheckedChanged += new System.EventHandler(this.checkFS_CheckedChanged);
            // 
            // checkFP
            // 
            this.checkFP.AutoSize = true;
            this.checkFP.Location = new System.Drawing.Point(13, 294);
            this.checkFP.Name = "checkFP";
            this.checkFP.Size = new System.Drawing.Size(77, 17);
            this.checkFP.TabIndex = 15;
            this.checkFP.Text = "Периметр";
            this.checkFP.UseVisualStyleBackColor = true;
            this.checkFP.CheckedChanged += new System.EventHandler(this.checkFP_CheckedChanged);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn1.Location = new System.Drawing.Point(13, 195);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(90, 45);
            this.btn1.TabIndex = 16;
            this.btn1.Text = "Создать";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn2.Location = new System.Drawing.Point(13, 317);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(90, 45);
            this.btn2.TabIndex = 17;
            this.btn2.Text = "Найти";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox3.Location = new System.Drawing.Point(214, 13);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(70, 19);
            this.textBox3.TabIndex = 18;
            this.textBox3.Text = "Решение";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(340, 294);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 68);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(214, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(217, 238);
            this.listBox1.TabIndex = 22;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 373);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.checkFP);
            this.Controls.Add(this.checkFS);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.checkP);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.checkS);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.checkH);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.checkC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.checkB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.checkA);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Треугольник";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.CheckBox checkB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.CheckBox checkC;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.CheckBox checkS;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.CheckBox checkH;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.CheckBox checkP;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkFS;
        private System.Windows.Forms.CheckBox checkFP;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

