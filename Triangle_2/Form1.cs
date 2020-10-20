using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_2
{
    public partial class Form1 : Form
    {
        Label txt1, txt2, txt3, txt4;
        TextBox txtA, txtB, txtC, txtH, txtP, txtS;
        CheckBox checkA, checkB, checkC, checkH, checkP, checkS, checkFP, checkFS;
        Button btn1, btn2;
        ListBox lbox;
        PictureBox img;
        public Form1()
        {
            Width = 462;
            Height = 412;
            txt1 = new Label();
            txt1.Text = "Введите данные";
            txt1.Size = new Size(132, 19);
            txt1.Location = new Point(13, 13);
            Controls.Add(txt1);

            txt2 = new Label();
            txt2.Text = "Что найти?";
            txt2.Size = new Size(90, 19);
            txt2.Location = new Point(13, 246);
            Controls.Add(txt2);

            txt3 = new Label();
            txt3.Text = "Решение";
            txt3.Size = new Size(70, 19);
            txt3.Location = new Point(214, 13);
            Controls.Add(txt3);

            txt4 = new Label();
            txt4.Text = "Треугольник:";
            txt4.Size = new Size(170, 19);
            txt4.Location = new Point(140, 350);
            Controls.Add(txt4);

            txtA = new TextBox();
            txtA.Location = new Point(88, 39);
            txtA.Size = new Size(100, 20);
            Controls.Add(txtA);
            txtA.TextChanged += TxtA_TextChanged;

            txtB = new TextBox();
            txtB.Location = new Point(88, 65);
            txtB.Size = new Size(100, 20);
            Controls.Add(txtB);
            txtB.TextChanged += TxtB_TextChanged;

            txtC = new TextBox();
            txtC.Location = new Point(88, 91);
            txtC.Size = new Size(100, 20);
            Controls.Add(txtC);
            txtC.TextChanged += TxtC_TextChanged;

            txtH = new TextBox();
            txtH.Location = new Point(88, 117);
            txtH.Size = new Size(100, 20);
            Controls.Add(txtH);
            txtH.TextChanged += TxtH_TextChanged;

            txtS = new TextBox();
            txtS.Location = new Point(88, 143);
            txtS.Size = new Size(100, 20);
            Controls.Add(txtS);
            txtS.TextChanged += TxtS_TextChanged;

            txtP = new TextBox();
            txtP.Location = new Point(88, 169);
            txtP.Size = new Size(100, 20);
            Controls.Add(txtP);
            txtP.TextChanged += TxtP_TextChanged;

            checkA = new CheckBox();
            checkA.Text = "Сторона A";
            checkA.Size = new Size(78, 17);
            checkA.Location = new Point(13, 42);
            Controls.Add(checkA);

            checkB = new CheckBox();
            checkB.Text = "Сторона B";
            checkB.Size = new Size(78, 17);
            checkB.Location = new Point(13, 68);
            Controls.Add(checkB);

            checkC = new CheckBox();
            checkC.Text = "Сторона C";
            checkC.Size = new Size(78, 17);
            checkC.Location = new Point(13, 94);
            Controls.Add(checkC);

            checkH = new CheckBox();
            checkH.Text = "Высота";
            checkH.Size = new Size(78, 17);
            checkH.Location = new Point(13, 120);
            Controls.Add(checkH);

            checkS = new CheckBox();
            checkS.Text = "Площадь";
            checkS.Size = new Size(78, 17);
            checkS.Location = new Point(13, 146);
            Controls.Add(checkS);

            checkP = new CheckBox();
            checkP.Text = "Периметр";
            checkP.Size = new Size(78, 17);
            checkP.Location = new Point(13, 172);
            Controls.Add(checkP);

            checkFS = new CheckBox();
            checkFS.Text = "Площадь";
            checkFS.Size = new Size(73, 17);
            checkFS.Location = new Point(13, 271);
            Controls.Add(checkFS);

            checkFP = new CheckBox();
            checkFP.Text = "Периметр";
            checkFP.Size = new Size(77, 17);
            checkFP.Location = new Point(13, 294);
            Controls.Add(checkFP);

            btn1 = new Button();
            btn1.Text = "Создать";
            btn1.Size = new Size(90, 45);
            btn1.Location = new Point(13, 195);
            Controls.Add(btn1);
            btn1.Click += Btn1_Click;

            btn2 = new Button();
            btn2.Text = "Найти";
            btn2.Size = new Size(90, 45);
            btn2.Location = new Point(13, 317);
            Controls.Add(btn2);

            lbox = new ListBox();
            lbox.Size = new Size(217, 238);
            lbox.Location = new Point(214 ,38);
            Controls.Add(lbox);

            img = new PictureBox();
            img.Size = new Size(91, 68);
            img.Location = new Point(340, 294);
            Controls.Add(img);
        }

        private void TxtH_TextChanged(object sender, EventArgs e)
        {
            if (txtH.TextLength > 0)
            {
                checkH.Enabled = false;
            }
            else
            {
                checkH.Enabled = true;
            }
        }

        private void TxtC_TextChanged(object sender, EventArgs e)
        {
            if (txtC.TextLength > 0)
            {
                checkC.Enabled = false;
            }
            else
            {
                checkC.Enabled = true;
            }
        }

        private void TxtB_TextChanged(object sender, EventArgs e)
        {
            if (txtB.TextLength > 0)
            {
                checkB.Enabled = false;
            }
            else
            {
                checkB.Enabled = true;
            }
        }

        private void TxtP_TextChanged(object sender, EventArgs e)
        {
            if (txtP.TextLength > 0)
            {
                checkP.Enabled = false;
                checkFP.Enabled = false;
            }
            else
            {
                checkP.Enabled = true;
                checkFP.Enabled = true;
            }
        }

        private void TxtS_TextChanged(object sender, EventArgs e)
        {
            if(txtS.TextLength > 0)
            {
                checkS.Enabled = false;
                checkFS.Enabled = false;
            }
            else
            {
                checkS.Enabled = true;
                checkFS.Enabled = true;
            }
        }

        private void TxtA_TextChanged(object sender, EventArgs e)
        {
            if (txtA.TextLength > 0)
            {
                checkA.Enabled = false;
            }
            else
            {
                checkA.Enabled = true;
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
