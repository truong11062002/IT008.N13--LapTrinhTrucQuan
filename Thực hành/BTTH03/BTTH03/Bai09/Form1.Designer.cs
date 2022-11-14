
namespace Bai09
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.second_rtb = new System.Windows.Forms.RichTextBox();
            this.first_rtb = new System.Windows.Forms.RichTextBox();
            this.chuyennganh_comboBox = new System.Windows.Forms.ComboBox();
            this.hoten_textBox = new System.Windows.Forms.TextBox();
            this.maSV_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nam_radioButton = new System.Windows.Forms.RadioButton();
            this.nu_radioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nu_radioButton);
            this.groupBox1.Controls.Add(this.nam_radioButton);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btn_back);
            this.groupBox1.Controls.Add(this.btn_next);
            this.groupBox1.Controls.Add(this.second_rtb);
            this.groupBox1.Controls.Add(this.first_rtb);
            this.groupBox1.Controls.Add(this.chuyennganh_comboBox);
            this.groupBox1.Controls.Add(this.hoten_textBox);
            this.groupBox1.Controls.Add(this.maSV_textbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1065, 457);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(595, 413);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 37);
            this.button4.TabIndex = 15;
            this.button4.Text = "Xóa chọn";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(392, 413);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 37);
            this.button3.TabIndex = 14;
            this.button3.Text = "Lưu Thông Tin";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(525, 324);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(59, 49);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "<";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(525, 269);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(59, 49);
            this.btn_next.TabIndex = 12;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // second_rtb
            // 
            this.second_rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second_rtb.Location = new System.Drawing.Point(615, 253);
            this.second_rtb.Name = "second_rtb";
            this.second_rtb.ReadOnly = true;
            this.second_rtb.Size = new System.Drawing.Size(315, 146);
            this.second_rtb.TabIndex = 11;
            this.second_rtb.Text = "";
            // 
            // first_rtb
            // 
            this.first_rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_rtb.Location = new System.Drawing.Point(184, 253);
            this.first_rtb.Name = "first_rtb";
            this.first_rtb.Size = new System.Drawing.Size(315, 146);
            this.first_rtb.TabIndex = 10;
            this.first_rtb.Text = "";
            // 
            // chuyennganh_comboBox
            // 
            this.chuyennganh_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chuyennganh_comboBox.FormattingEnabled = true;
            this.chuyennganh_comboBox.Items.AddRange(new object[] {
            "Hệ thống thông tin",
            "Công nghệ thông tin",
            "Hệ thống thông tin",
            "Khoa học máy tính",
            "Kỹ thuật phần mềm",
            "Kỹ thuật máy tính",
            "Mạng máy tính và truyền thông",
            "An toàn thông tin",
            "Thương mại điện tử",
            "Khoa học dữ liệu",
            "Khoa học máy tính (định hướng AI)"});
            this.chuyennganh_comboBox.Location = new System.Drawing.Point(366, 130);
            this.chuyennganh_comboBox.Name = "chuyennganh_comboBox";
            this.chuyennganh_comboBox.Size = new System.Drawing.Size(360, 28);
            this.chuyennganh_comboBox.TabIndex = 7;
            this.chuyennganh_comboBox.Text = "Hệ thống thông tin";
            // 
            // hoten_textBox
            // 
            this.hoten_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoten_textBox.Location = new System.Drawing.Point(368, 84);
            this.hoten_textBox.Name = "hoten_textBox";
            this.hoten_textBox.Size = new System.Drawing.Size(358, 27);
            this.hoten_textBox.TabIndex = 6;
            // 
            // maSV_textbox
            // 
            this.maSV_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maSV_textbox.Location = new System.Drawing.Point(368, 41);
            this.maSV_textbox.Name = "maSV_textbox";
            this.maSV_textbox.Size = new System.Drawing.Size(175, 27);
            this.maSV_textbox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(181, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chọn Các Môn Học Tham Gia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(181, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chuyên Ngành";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 484);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1063, 258);
            this.dataGridView1.TabIndex = 1;
            // 
            // nam_radioButton
            // 
            this.nam_radioButton.AutoSize = true;
            this.nam_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nam_radioButton.Location = new System.Drawing.Point(368, 178);
            this.nam_radioButton.Name = "nam_radioButton";
            this.nam_radioButton.Size = new System.Drawing.Size(65, 24);
            this.nam_radioButton.TabIndex = 16;
            this.nam_radioButton.TabStop = true;
            this.nam_radioButton.Text = "Nam";
            this.nam_radioButton.UseVisualStyleBackColor = true;
            // 
            // nu_radioButton
            // 
            this.nu_radioButton.AutoSize = true;
            this.nu_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nu_radioButton.Location = new System.Drawing.Point(476, 178);
            this.nu_radioButton.Name = "nu_radioButton";
            this.nu_radioButton.Size = new System.Drawing.Size(51, 24);
            this.nu_radioButton.TabIndex = 17;
            this.nu_radioButton.TabStop = true;
            this.nu_radioButton.Text = "Nữ";
            this.nu_radioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 771);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Liệu Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox chuyennganh_comboBox;
        private System.Windows.Forms.TextBox hoten_textBox;
        private System.Windows.Forms.TextBox maSV_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.RichTextBox second_rtb;
        private System.Windows.Forms.RichTextBox first_rtb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton nu_radioButton;
        private System.Windows.Forms.RadioButton nam_radioButton;
    }
}

