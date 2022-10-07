using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BT01
{
    class Program
    {
        static Form form1 = new Form();
        static ComboBox mybox = new ComboBox();
        

        static void SelectedChanged(Object sender, EventArgs e)
        {
            int size = int.Parse(mybox.Text);

        }

        static void Main(string[] args)
        {


            form1.Text = "Nhan 2 ma tran";

            Label lb = new Label();
            lb.Text = "Kich thuoc";
            lb.Size = new Size(50, 50);
            lb.Left = 20;
            lb.Top = 30;


            form1.Width = 500;
            form1.Height = 300;
            
            mybox.Location = new Point(30, 77);
            mybox.Size = new Size(100, 50);

            mybox.Top = 20;
            mybox.Left = 100;

            mybox.Items.Add("2");
            mybox.Items.Add("3");
            mybox.Items.Add("4");
            mybox.Items.Add("5");

            mybox.SelectedIndexChanged += new EventHandler(SelectedChanged);

            form1.Controls.Add(lb);
            form1.Controls.Add(mybox);
            Application.Run(form1);
        }
    }
}
