using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace test
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //Form form1 = new Form();
        //    //Form form2 = new Form();
        //    //form1.Text = "Form passed to Run()";
        //    //form2.Text = "This is a form dialog";

        //    //MessageBox.Show("Application.Run() has returned control back to Main.Bye, bye!", "TwoForms");

        //    //form1.FormBorderStyle = FormBorderStyle.FixedDialog;
        //    //form2.MaximizeBox = false;

        //    //form1.BackColor = System.Drawing.Color.BlanchedAlmond;
        //    //form1.Cursor = Cursors.Hand;

        //    //form2.ShowDialog();
        //    //form1.Show();
        //    //Application.Run(form1);
        //}

        static TextBox tb1;
        static TextBox tb2;
        static TextBox tb3;

        static void Main(string[] args)
        {
            tb1 = new TextBox();
            tb1.Left = 10;
            tb1.Top = 10;

            tb2 = new TextBox();
            tb2.Left = 10;
            tb2.Top = 40;

            tb3 = new TextBox();
            tb3.Left = 10;
            tb3.Top = 70;

            Button b = new Button();
            b.Text = "OK";
            b.Location = new Point(100, 100);

            Form f = new Form();

            f.Controls.Add(b);
            f.Controls.Add(tb1);
            f.Controls.Add(tb2);
            f.Controls.Add(tb3);

            b.Click += new EventHandler(b_Click);
            Application.Run(f);

            //Form f1 = new Form();
            //Button b = new Button();
            //b.Text = "OK";
            //b.Click += new EventHandler(b_Click);
            //b.Location = new Point(10, 10);

            //Button b1 = new Button();
            //b1.Text = "Exit";
            //b1.Click += new EventHandler(b1_Click);
            //b1.Location = new Point(b.Left, b.Height + b.Top + 10);

            //f1.Controls.Add(b);
            //f1.Controls.Add(b1);
            //f1.Text = "2 Paint Event";
            //f1.BackColor = Color.White;
            //f1.AcceptButton = b;
            //f1.CancelButton = b1;
            //Application.Run(f1);
            

        }
        private static void b_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Button is clicked");

            int sum;

            sum = System.Convert.ToInt32(tb1.Text) + System.Convert.ToInt32(tb2.Text);
            tb3.Text = sum.ToString();
        }

        private static void b1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

    }
}
