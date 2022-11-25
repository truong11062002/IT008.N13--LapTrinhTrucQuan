using System;
using System.IO;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        BackgroundWorker worker = new BackgroundWorker();
        OpenFileDialog o;
        public Form1()
        {
            InitializeComponent();
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;

            worker.ProgressChanged += Worker_ProgressChanged;
            worker.DoWork += Worker_DoWork;
        }

        void CopyFile(string source, string des)
        {
            FileStream fsOut = new FileStream(des, FileMode.Create);
            FileStream fsIn = new FileStream(source, FileMode.Open);

            byte[] bt = new byte[1048756];

            int readByte;
            while((readByte = fsIn.Read(bt, 0 , bt.Length)) > 0)
            {
                fsOut.Write(bt, 0, readByte);
                worker.ReportProgress((int)(fsIn.Position * 100 / fsIn.Length));
                

            }
            fsIn.Close();
            fsOut.Close();
        }
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            CopyFile(txtSource.Text, txtTarget.Text);
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label3.Text = progressBar1.Value.ToString() + "%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            o = new OpenFileDialog();

            if(o.ShowDialog() == DialogResult.OK)
            {
                txtSource.Text = o.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if(fbd.ShowDialog() == DialogResult.OK)
            {
                txtTarget.Text = Path.Combine(fbd.SelectedPath, Path.GetFileName(txtSource.Text));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            worker.RunWorkerAsync();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
