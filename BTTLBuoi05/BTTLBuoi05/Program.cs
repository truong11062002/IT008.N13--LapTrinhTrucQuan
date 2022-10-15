using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;



namespace BTTLBuoi05
{
    class Program : Form
    {
        static Form MyForm = new Form();
        static Label lb = new Label();
        static Label newLb = new Label();
        static Timer timer = new Timer();


        public static void MyForm_KeyDown(Object sender, KeyEventArgs kea)
        {
            if (kea.KeyCode == Keys.Left)
            {
                lb.Location = new Point(lb.Location.X - 10, lb.Location.Y);
            }
            if (kea.KeyCode == Keys.Right)
            {
                lb.Location = new Point(lb.Location.X + 10, lb.Location.Y);
            }
            
            Console.WriteLine("KeyDown");
        }
        public static void MyForm_KeyUp(Object sender, KeyEventArgs kea)
        {
            Console.WriteLine("KeyUp");
        }

        public static void MyForm_KeyPress(Object sender, KeyPressEventArgs kea)
        {
            if(kea.KeyChar == 'x')
            {
                Console.WriteLine("KeyPress");
            }
        }

        public static void MyForm_MouseClick(Object sender, MouseEventArgs mea)
        {
            if (mea.Button == MouseButtons.Left)
                MessageBox.Show("Nhan chuot trai");
            if (mea.Button == MouseButtons.Right)
                MessageBox.Show("Nhan chuot phai");
            if (mea.Button == MouseButtons.Middle)
                MessageBox.Show("Nhan chuot giua");
        }
        public static void MyForm_MouseMove(Object sender, MouseEventArgs mea)
        {
            //Ve mot duong thang tu toa do (0,0) den toa do chuot di chuyen
            newLb.ForeColor = Color.Red;

            //Graphics g = CreateGraphics();
            //Pen pen = new Pen(System.Drawing.Color.Blue);
            //g.DrawLine(pen, 0, 0, mea.X, mea.Y);
        }

        public static void MyForm_MouseWheel(Object sender, MouseEventArgs mea)
        {
            if (mea.Delta > 0)
                MessageBox.Show("Ban vua scroll chuot len", "Thong bao");
            else
                MessageBox.Show("Ban vua scroll chuot xuong", "Thong bao");
        }

        public static void MyForm_OnClick(Object sender, EventArgs e)
        {
            
        }

        static public void TimerOnTick(object obj, EventArgs ea)
        {
            Timer timer = (Timer)obj;
            timer.Stop();
            timer.Tick -= new EventHandler(TimerOnTick);
        }
        //public void DrawRectangleRectangle(PaintEventArgs e)
        //{
        //    // Create pen.
        //    Pen blackPen = new Pen(Color.Black, 3);
        //    // Create rectangle.
        //    Rectangle rect = new Rectangle(0, 0, 200, 200);
        //    // Draw rectangle to screen.
        //    e.Graphics.DrawRectangle(blackPen, rect);
        //}
        static void Main(string[] args)
        {

            MyForm.Text = "Test Keyboard";
            MyForm.KeyDown += new KeyEventHandler(MyForm_KeyDown);
            MyForm.KeyUp += new KeyEventHandler(MyForm_KeyUp);
            MyForm.KeyPress += new KeyPressEventHandler(MyForm_KeyPress);
            MyForm.MouseClick += new MouseEventHandler(MyForm_MouseClick);
            MyForm.MouseMove += new MouseEventHandler(MyForm_MouseMove);
            MyForm.MouseWheel += new MouseEventHandler(MyForm_MouseWheel);
            MyForm.Click += new EventHandler(MyForm_OnClick);


            lb.Text = "Test";
            lb.Left = 50;
            lb.Top = 50;

            newLb.Text = "New label";
            newLb.Left = 80;
            newLb.Top = 90;

            newLb.Text = "Closing in Five Minutes";
            timer.Interval = 5 * 60 * 1000;
            timer.Tick += new EventHandler(TimerOnTick);
            timer.Enabled = true;

            //timer.Text = "000";
            //timer.Left = 150;
            //timer.Top = 150;
            //timer.Height = 100;
            //timer.Width = 100;


            MyForm.Controls.Add(lb);
            MyForm.Controls.Add(newLb);
            //MyForm.Controls.Add(timer);


            MyForm.Width = 650;
            MyForm.Height = 500;
            MyForm.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(MyForm);
            Console.ReadKey();
        }
    }

    
}
