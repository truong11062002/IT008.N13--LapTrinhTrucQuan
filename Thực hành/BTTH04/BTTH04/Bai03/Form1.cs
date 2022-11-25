using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OpenFileDialog o;
        string[] filePaths;
        string[] fileNames;
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                o = new OpenFileDialog();
                o.Filter = "Mp3 files, mp4 file (*.avi *.mpeg *.wav *.midi *.mp4 *.mp3) | *.mp*";
                o.Multiselect = true;
                o.Title = "Open";
                if (o.ShowDialog() == DialogResult.OK)
                {
                    filePaths = o.FileNames; // Get path file
                    fileNames = o.SafeFileNames; // Get name file
                }

                else
                {
                    return;
                }
                foreach (var item in fileNames)
                {
                    this.listBox1.Items.Add(item);
                }
            }
            catch (Exception err)
            {

                if (err is ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Argument is out of range");
                }
                else if (err is FormatException)
                {
                    MessageBox.Show("Format Exception");
                }
                else
                {
                    throw;
                }
            }
            
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex != -1)
                {
                    int choosed = listBox1.SelectedIndex;
                    axWindowsMediaPlayer1.URL = filePaths[choosed];
                    this.textBox1.Text = fileNames[choosed];
                }
            }
            catch (Exception err)
            {

                if (err is ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Argument is out of range");
                }
                else if (err is FormatException)
                {
                    MessageBox.Show("Format Exception");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn lại bài khác", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "Hôm nay là ngày " + DateTime.Now.ToShortDateString() + " - Bây giờ là " + DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
