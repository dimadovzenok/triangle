using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        ListBox llist;
        Button btn, btn1, btn2, btn3;
        RadioButton r1, r2;
        Label lblA, lblB, lblC, lblH;
        TextBox txtA, txtB, txtC, txtH;
        Graphics gp;
        Pen p = new Pen(Brushes.Black, 2);
        Panel panel1;
        PictureBox pictureBox1;

        public Form3()
        { 
            this.BackgroundImage = Image.FromFile("C:/Users/opilane/source/repos/triangle2/image/fon.png");

            this.Size = new Size(600, 600);
            this.Text = "Треугольник";
            llist = new ListBox();
            llist.Location = new Point(250, 60);
            llist.Size = new Size(265, 150);
            Controls.Add(llist);

            btn = new Button();
            btn.Location = new Point(350, 230);
            btn.Size = new Size(100, 70);
            btn.Click += Btn_Click;
            btn.Text = "Решение";
            Controls.Add(btn);

            btn1 = new Button();
            btn1.Location = new Point(50, 260);
            btn1.Size = new Size(100, 70);
            btn1.Click += Btn1_Click;
            btn1.Text = "Остроугольный";
            Controls.Add(btn1);

            btn2 = new Button();
            btn2.Location = new Point(50, 330);
            btn2.Size = new Size(100, 70);
            btn2.Click += Btn2_Click;
            btn2.Text = "Равнобедреный";
            Controls.Add(btn2);

            btn3 = new Button();
            btn3.Location = new Point(50, 400);
            btn3.Size = new Size(100, 70);
            btn3.Click += Btn3_Click;
            btn3.Text = "Прямоугольный";
            Controls.Add(btn3);

   
            r1 = new RadioButton();
            r1.Text = "Скрыть данные";
            r1.Location = new Point(350, 30);
            r1.CheckedChanged += new EventHandler(Radiobuttons_Changed);
            Controls.Add(r1);

            r2 = new RadioButton();
            r2.Text = "Показать данные";
            r2.Location = new Point(350, 10);
            r2.CheckedChanged += new EventHandler(Radiobuttons_Changed);
            Controls.Add(r2);

            lblA = new Label();
            lblA.Size = new Size(70, 30);
            lblA.Location = new Point(50, 100);
            lblA.Text = "Сторона А";
            Controls.Add(lblA);

            lblB = new Label();
            lblB.Size = new Size(70, 30);
            lblB.Location = new Point(50, 130);
            lblB.Text = "Сторона B";
            Controls.Add(lblB);

            lblC = new Label();
            lblC.Size = new Size(70, 30);
            lblC.Location = new Point(50, 160);
            lblC.Text = "Сторона C";
            Controls.Add(lblC);

            lblH = new Label();
            lblH.Size = new Size(70, 30);
            lblH.Location = new Point(50, 190);
            lblH.Text = "Сторона H";
            Controls.Add(lblH);

            txtA = new TextBox();
            txtA.Location = new Point(120, 100);
            Controls.Add(txtA);

            txtB = new TextBox();
            txtB.Location = new Point(120, 130);
            Controls.Add(txtB);

            txtC = new TextBox();
            txtC.Location = new Point(120, 160);
            Controls.Add(txtC);

            txtH = new TextBox();
            txtH.Location = new Point(120, 190);
            Controls.Add(txtH);

            panel1 = new Panel();
            gp = panel1.CreateGraphics();
            this.Controls.Add(panel1);

            pictureBox1 = new PictureBox();
            pictureBox1.Image = new Bitmap("C:/Users/opilane/source/repos/triangle2/image/image.png");
            pictureBox1.Location = new Point(300, 300);
            pictureBox1.Size = new Size(250, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            this.Controls.Add(pictureBox1);
        }

    

        private void Btn1_Click(object sender, EventArgs e)
        {
            gp.Clear(Color.White);
            Point p1 = new Point(60, 5);
            Point p2 = new Point(150, 5);
            Point p3 = new Point(100, 30);
            gp.DrawLine(p, p1, p2);
            gp.DrawLine(p, p2, p3);
            gp.DrawLine(p, p3, p1);
        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            gp.Clear(Color.White);
            Point p1 = new Point(100, 100);
            Point p2 = new Point(140, 100);
            Point p3 = new Point(120,30);
            gp.DrawLine(p, p1, p2); 
            gp.DrawLine(p, p2, p3); 
            gp.DrawLine(p, p3, p1); 

        }
        private void Btn3_Click(object sender, EventArgs e)
        {
            gp.Clear(Color.White);
            Point p1 = new Point(70, 5);
            Point p2 = new Point(157, 5);
            Point p3 = new Point(70, 30);
            gp.DrawLine(p, p1, p2); 
            gp.DrawLine(p, p2, p3); 
            gp.DrawLine(p, p3, p1); 

        }
        private void Radiobuttons_Changed(object sender, EventArgs e)
        {
            if (r1.Checked)
            {
                llist.Visible = false;
                //llist.Items.Clear();
            }
            if (r2.Checked)
            {
                llist.Visible = true;
                //Triangle triangle = new Triangle(a, b, c, h);
                //llist.Items.Add("Сторона а:" + " " + triangle.outputA());
                //llist.Items.Add("Сторона b:" + " " + triangle.outputB());
                //llist.Items.Add("Сторона c:" + " " + triangle.outputC());
                //llist.Items.Add("Высота:" + " " + triangle.outputH());
                //llist.Items.Add("Периметр:" + " " + Convert.ToString(triangle.Perimeter()));
                //llist.Items.Add("Полупериметр" + " " + Convert.ToString(triangle.SemiPerimeter()));
                //llist.Items.Add("Площадь:" + " " + Convert.ToString(triangle.Surface()));
                //if (triangle.ExistTriangle) { llist.Items.Add("Существует?  Существует"); }
                //else llist.Items.Add("Существует?  Не существует");
                //llist.Items.Add("Спецификатор:" + " " + triangle.TriangleType());
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            llist.Items.Clear();
            double a, b, c, h;
            if (txtA.Text == "" || txtB.Text == "" || txtC.Text == "" || txtH.Text == "")
            {
                a = 0;
                b = 0;
                c = 0;
                h = 0;
            }
            else
            {
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                c = Convert.ToDouble(txtC.Text);
                h = Convert.ToDouble(txtH.Text);
            }
            Triangle triangle = new Triangle(a, b, c, h);
            llist.Items.Add("Сторона а:" + " " + triangle.outputA());
            llist.Items.Add("Сторона b:" + " " + triangle.outputB());
            llist.Items.Add("Сторона c:" + " " + triangle.outputC());
            llist.Items.Add("Высота:" + " " + triangle.outputH());
            llist.Items.Add("Периметр:" + " " + Convert.ToString(triangle.Perimeter()));
            llist.Items.Add("Полупериметр" + " " + Convert.ToString(triangle.SemiPerimeter()));
            llist.Items.Add("Площадь:" + " " + Convert.ToString(triangle.Surface()));
            if (triangle.ExistTriangle) { llist.Items.Add("Существует?  Существует"); }
            else llist.Items.Add("Существует?  Не существует");
            llist.Items.Add("Спецификатор:" + " " + triangle.TriangleType());
            pictureBox1.Image = Image.FromFile(triangle.ImageType());
        }
    }
}
