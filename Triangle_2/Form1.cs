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
        Label txt1, txt2, txt3;
        TextBox txtA, txtB, txtC, txtH, txtP, txtS;
        CheckBox checkA, checkB, checkC, checkH, checkP, checkS, checkFP, checkFS;
        Button btn1, btn2;
        ListView lView;
        PictureBox img;
        private bool byHeight;
        public Form1()
        {
            Width = 470;
            Height = 330;
            txt1 = new Label();
            txt1.Text = "Введите данные";
            txt1.Size = new Size(132, 19);
            txt1.Location = new Point(13, 13);
            Controls.Add(txt1);

            txt3 = new Label();
            txt3.Text = "Решение";
            txt3.Size = new Size(70, 19);
            txt3.Location = new Point(214, 13);
            Controls.Add(txt3);

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

            btn1 = new Button();
            btn1.Text = "Создать";
            btn1.Size = new Size(90, 45);
            btn1.Location = new Point(13, 230);
            Controls.Add(btn1);
            btn1.Click += Btn1_Click;

            lView = new ListView();
            lView.Size = new Size(217, 238);
            lView.Location = new Point(214 ,38);
            lView.View = View.Details;
            lView.Columns.Add("Параметр", 107, HorizontalAlignment.Left);
            lView.Columns.Add("Значение", 106, HorizontalAlignment.Right);
            Controls.Add(lView);

            img = new PictureBox();
            img.Size = new Size(80, 80);
            img.Location = new Point(120, 200);
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
            }
            else
            {
                checkP.Enabled = true;
            }
        }

        private void TxtS_TextChanged(object sender, EventArgs e)
        {
            if(txtS.TextLength > 0)
            {
                checkS.Enabled = false;
            }
            else
            {
                checkS.Enabled = true;
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
            if (lView.Items.Count > 0)
            {
                lView.Items.Clear();
            }
            if (txtA.Text.Length > 0 && txtB.Text.Length > 0 && txtC.Text.Length > 0)
            {
                double a, b, c;
                a = Convert.ToDouble(txtA.Text); // считываем значение стороны а
                b = Convert.ToDouble(txtB.Text); // считываем значение стороны b
                c = Convert.ToDouble(txtC.Text); // считываем значение стороны c
                Triangle triangle = new Triangle(a, b, c); // создаем объект класса Triangle с именем triangle
                lView.Items.Add("Сторона A"); // добавляем соответсвующие ячейки в коллекцию items объекта listview1
                lView.Items.Add("Сторона B"); // (при клике на кнопку Запуск первый столбец заполнится этими нашими именами)
                lView.Items.Add("Сторона C"); //
                lView.Items.Add("Периметр"); //
                lView.Items.Add("Полупериметр"); //
                lView.Items.Add("Площадь"); //
                lView.Items.Add("Существует?"); //
                lView.Items.Add("Спецификатор"); //
                lView.Items[0].SubItems.Add(triangle.OutputA()); // методы по выводу сторон a, b ,c
                lView.Items[1].SubItems.Add(triangle.OutputB()); // (Item'у с индексом [i] присваиваем значение сабайтема, содержащегося во втором столбце
                lView.Items[2].SubItems.Add(triangle.OutputC()); //
                lView.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter())); //выводим периметр
                lView.Items[4].SubItems.Add(Convert.ToString(triangle.HalfPerimeter())); //выводим полупериметр
                lView.Items[5].SubItems.Add(Convert.ToString(triangle.Surface())); // выводим значение площади
                if (triangle.ExistTriangle) { lView.Items[6].SubItems.Add("Существует"); } // свойство Triangle.exist
                else lView.Items[6].SubItems.Add("Не существует");
                lView.Items[7].SubItems.Add(triangle.TriangleType); // выводим вид треугольника
                if(triangle.TriangleType == "Равносторонний")
                {
                    img.Image = new Bitmap("triangle1.png");
                    img.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else if(triangle.TriangleType == "Равнобедренный")
                {
                    img.Image = new Bitmap("triangle2.png");
                    img.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else if(triangle.TriangleType == "Разносторонний" && triangle.ExistTriangle == true)
                {
                    img.Image = new Bitmap("triangle3.png");
                    img.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    img.Image = new Bitmap("none.png");
                }
            }
            else if (txtA.Text.Length > 0 && txtH.Text.Length > 0)
            {
                double a, h;
                a = Convert.ToDouble(txtA.Text); // считываем значение стороны а
                h = Convert.ToDouble(txtH.Text);
                Triangle triangle = new Triangle(byHeight, a, h); // создаем объект класса Triangle с именем triangle
                lView.Items.Add("Сторона а"); // добавляем соответсвующие ячейки в коллекцию items объекта listview1
                lView.Items.Add("Сторона b"); // (при клике на кнопку Запуск первый столбец заполнится этими нашими именами)
                lView.Items.Add("Сторона c"); //
                lView.Items.Add("Высота"); //
                lView.Items.Add("Периметр"); //
                lView.Items.Add("Площадь"); //
                lView.Items.Add("Существует?"); //
                lView.Items.Add("Спецификатор"); //
                lView.Items[0].SubItems.Add(triangle.OutputA()); // методы по выводу сторон a, b ,c
                lView.Items[1].SubItems.Add(triangle.OutputB()); // (Item'у с индексом [i] присваиваем значение сабайтема, содержащегося во втором столбце
                lView.Items[2].SubItems.Add(triangle.OutputC()); //
                lView.Items[3].SubItems.Add(triangle.OutputH()); //
                lView.Items[4].SubItems.Add(Convert.ToString(triangle.Perimeter())); //выводим периметр
                lView.Items[5].SubItems.Add(Convert.ToString(triangle.Surface())); // выводим значение площади
                if (triangle.ExistTriangle) { lView.Items[6].SubItems.Add("Существует"); } // свойство Triangle.exist
                else lView.Items[6].SubItems.Add("Не существует");
                lView.Items[7].SubItems.Add(triangle.TriangleType); // выводим вид треугольника
                if (triangle.TriangleType == "Равносторонний")
                {
                    img.Image = new Bitmap("triangle1.png");
                    img.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else if (triangle.TriangleType == "Равнобедренный")
                {
                    img.Image = new Bitmap("triangle2.png");
                    img.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else if (triangle.TriangleType == "Разносторонний" && triangle.ExistTriangle == true)
                {
                    img.Image = new Bitmap("triangle3.png");
                    img.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    img.Image = new Bitmap("none.png");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
