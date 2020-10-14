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
        public Form1()
        {
            Width = 462;
            Height = 412;
            Label txt1 = new Label();
            txt1.Text = "Введите данные";
            txt1.Size = new Size(132, 19);
            txt1.Location = new Point(13, 13);
            Controls.Add(txt1);
            Label txt2 = new Label();
            txt2.Text = "Что найти?";
            txt2.Size = new Size(90, 19);
            txt2.Location = new Point(13, 246);
            Controls.Add(txt2);
            Label txt3 = new Label();
            txt3.Text = "Решение";
            txt3.Size = new Size(70, 19);
            txt3.Location = new Point(214, 13);
            Controls.Add(txt3);
            TextBox txtA = new TextBox();
            txtA.Location = new Point(88, 39);
            txtA.Size = new Size(100, 20);
            Controls.Add(txtA);
            TextBox txtB = new TextBox();
            txtB.Location = new Point(88, 65);
            txtB.Size = new Size(100, 20);
            Controls.Add(txtB);
            TextBox txtC = new TextBox();
            txtC.Location = new Point(88, 91);
            txtC.Size = new Size(100, 20);
            Controls.Add(txtC);
            TextBox txtH = new TextBox();
            txtH.Location = new Point(88, 117);
            txtH.Size = new Size(100, 20);
            Controls.Add(txtH);
            TextBox txtS = new TextBox();
            txtS.Location = new Point(88, 143);
            txtS.Size = new Size(100, 20);
            Controls.Add(txtS);
            TextBox txtP = new TextBox();
            txtP.Location = new Point(88, 169);
            txtP.Size = new Size(100, 20);
            Controls.Add(txtP);
            CheckBox checkA = new CheckBox();
            checkA.Text = "Сторона A";
            checkA.Size = new Size(78, 17);
            checkA.Location = new Point(13, 42);
            Controls.Add(checkA);
            CheckBox checkB = new CheckBox();
            checkB.Text = "Сторона B";
            checkB.Size = new Size(78, 17);
            checkB.Location = new Point(13, 68);
            Controls.Add(checkB);
            CheckBox checkC = new CheckBox();
            checkC.Text = "Сторона C";
            checkC.Size = new Size(78, 17);
            checkC.Location = new Point(13, 94);
            Controls.Add(checkC);
            CheckBox checkH = new CheckBox();
            checkH.Text = "Высота";
            checkH.Size = new Size(78, 17);
            checkH.Location = new Point(13, 120);
            Controls.Add(checkH);
            CheckBox checkS = new CheckBox();
            checkS.Text = "Площадь";
            checkS.Size = new Size(78, 17);
            checkS.Location = new Point(13, 146);
            Controls.Add(checkS);
            CheckBox checkP = new CheckBox();
            checkP.Text = "Периметр";
            checkP.Size = new Size(78, 17);
            checkP.Location = new Point(13, 172);
            Controls.Add(checkP);
            CheckBox checkFS = new CheckBox();
            checkFS.Text = "Площадь";
            checkFS.Size = new Size(73, 17);
            checkFS.Location = new Point(13, 271);
            Controls.Add(checkFS);
            CheckBox checkFP = new CheckBox();
            checkFP.Text = "Периметр";
            checkFP.Size = new Size(77, 17);
            checkFP.Location = new Point(13, 294);
            Controls.Add(checkFP);
            Button btn1 = new Button();
            btn1.Text = "Создать";
            btn1.Size = new Size(90, 45);
            btn1.Location = new Point(13, 195);
            Controls.Add(btn1);
            Button btn2 = new Button();
            btn2.Text = "Найти";
            btn2.Size = new Size(90, 45);
            btn2.Location = new Point(13, 317);
            Controls.Add(btn2);
            ListBox lbox = new ListBox();
            lbox.Size = new Size(217, 238);
            lbox.Location = new Point(214 ,38);
            Controls.Add(lbox);
            PictureBox img = new PictureBox();
            img.Size = new Size(91, 68);
            img.Location = new Point(340, 294);
            Controls.Add(img);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkH_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkP_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);
        }

        private void checkFS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkFP_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
