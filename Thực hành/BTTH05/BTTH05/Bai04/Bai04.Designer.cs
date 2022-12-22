
namespace Bai04
{
    partial class Bai04
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Font = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Size = new System.Windows.Forms.ComboBox();
            this.checkBox_Bold = new System.Windows.Forms.CheckBox();
            this.checkBox_italic = new System.Windows.Forms.CheckBox();
            this.checkBox_underline = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Left = new System.Windows.Forms.RadioButton();
            this.radioButton_Center = new System.Windows.Forms.RadioButton();
            this.radioButton_Right = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.label_text = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font";
            // 
            // comboBox_Font
            // 
            this.comboBox_Font.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Font.FormattingEnabled = true;
            this.comboBox_Font.Location = new System.Drawing.Point(112, 43);
            this.comboBox_Font.Name = "comboBox_Font";
            this.comboBox_Font.Size = new System.Drawing.Size(249, 28);
            this.comboBox_Font.TabIndex = 1;
            this.comboBox_Font.Text = "Arial";
            this.comboBox_Font.SelectedIndexChanged += new System.EventHandler(this.comboBox_Font_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(478, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox_Size
            // 
            this.comboBox_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Size.FormattingEnabled = true;
            this.comboBox_Size.Location = new System.Drawing.Point(556, 47);
            this.comboBox_Size.Name = "comboBox_Size";
            this.comboBox_Size.Size = new System.Drawing.Size(82, 28);
            this.comboBox_Size.TabIndex = 3;
            this.comboBox_Size.Text = "28";
            this.comboBox_Size.SelectedIndexChanged += new System.EventHandler(this.comboBox_Size_SelectedIndexChanged);
            // 
            // checkBox_Bold
            // 
            this.checkBox_Bold.AutoSize = true;
            this.checkBox_Bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Bold.Location = new System.Drawing.Point(35, 109);
            this.checkBox_Bold.Name = "checkBox_Bold";
            this.checkBox_Bold.Size = new System.Drawing.Size(52, 33);
            this.checkBox_Bold.TabIndex = 4;
            this.checkBox_Bold.Text = "B";
            this.checkBox_Bold.UseVisualStyleBackColor = true;
            this.checkBox_Bold.CheckedChanged += new System.EventHandler(this.checkBox_Bold_CheckedChanged);
            // 
            // checkBox_italic
            // 
            this.checkBox_italic.AutoSize = true;
            this.checkBox_italic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_italic.Location = new System.Drawing.Point(112, 109);
            this.checkBox_italic.Name = "checkBox_italic";
            this.checkBox_italic.Size = new System.Drawing.Size(41, 33);
            this.checkBox_italic.TabIndex = 5;
            this.checkBox_italic.Text = "I";
            this.checkBox_italic.UseVisualStyleBackColor = true;
            this.checkBox_italic.CheckedChanged += new System.EventHandler(this.checkBox_italic_CheckedChanged);
            // 
            // checkBox_underline
            // 
            this.checkBox_underline.AutoSize = true;
            this.checkBox_underline.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_underline.Location = new System.Drawing.Point(178, 109);
            this.checkBox_underline.Name = "checkBox_underline";
            this.checkBox_underline.Size = new System.Drawing.Size(52, 33);
            this.checkBox_underline.TabIndex = 6;
            this.checkBox_underline.Text = "U";
            this.checkBox_underline.UseVisualStyleBackColor = true;
            this.checkBox_underline.CheckedChanged += new System.EventHandler(this.checkBox_underline_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Right);
            this.groupBox1.Controls.Add(this.radioButton_Center);
            this.groupBox1.Controls.Add(this.radioButton_Left);
            this.groupBox1.Location = new System.Drawing.Point(42, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 192);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Align Text";
            // 
            // radioButton_Left
            // 
            this.radioButton_Left.AutoSize = true;
            this.radioButton_Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Left.Location = new System.Drawing.Point(19, 41);
            this.radioButton_Left.Name = "radioButton_Left";
            this.radioButton_Left.Size = new System.Drawing.Size(65, 29);
            this.radioButton_Left.TabIndex = 0;
            this.radioButton_Left.TabStop = true;
            this.radioButton_Left.Text = "Left";
            this.radioButton_Left.UseVisualStyleBackColor = true;
            this.radioButton_Left.CheckedChanged += new System.EventHandler(this.radioButton_Left_CheckedChanged);
            // 
            // radioButton_Center
            // 
            this.radioButton_Center.AutoSize = true;
            this.radioButton_Center.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Center.Location = new System.Drawing.Point(19, 90);
            this.radioButton_Center.Name = "radioButton_Center";
            this.radioButton_Center.Size = new System.Drawing.Size(92, 29);
            this.radioButton_Center.TabIndex = 1;
            this.radioButton_Center.TabStop = true;
            this.radioButton_Center.Text = "Center";
            this.radioButton_Center.UseVisualStyleBackColor = true;
            this.radioButton_Center.CheckedChanged += new System.EventHandler(this.radioButton_Center_CheckedChanged);
            // 
            // radioButton_Right
            // 
            this.radioButton_Right.AutoSize = true;
            this.radioButton_Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Right.Location = new System.Drawing.Point(19, 140);
            this.radioButton_Right.Name = "radioButton_Right";
            this.radioButton_Right.Size = new System.Drawing.Size(77, 29);
            this.radioButton_Right.TabIndex = 2;
            this.radioButton_Right.TabStop = true;
            this.radioButton_Right.Text = "Right";
            this.radioButton_Right.UseVisualStyleBackColor = true;
            this.radioButton_Right.CheckedChanged += new System.EventHandler(this.radioButton_Right_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(478, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Color";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Fuchsia;
            this.btnColor.Location = new System.Drawing.Point(556, 109);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(62, 30);
            this.btnColor.TabIndex = 9;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_text
            // 
            this.label_text.BackColor = System.Drawing.Color.White;
            this.label_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_text.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_text.ForeColor = System.Drawing.Color.Fuchsia;
            this.label_text.Location = new System.Drawing.Point(445, 237);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(328, 123);
            this.label_text.TabIndex = 10;
            this.label_text.Text = "Hello";
            this.label_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 464);
            this.Controls.Add(this.label_text);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox_underline);
            this.Controls.Add(this.checkBox_italic);
            this.Controls.Add(this.checkBox_Bold);
            this.Controls.Add(this.comboBox_Size);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Font);
            this.Controls.Add(this.label1);
            this.Name = "Bai04";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai04";
            this.Load += new System.EventHandler(this.Bai04_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Font;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Size;
        private System.Windows.Forms.CheckBox checkBox_Bold;
        private System.Windows.Forms.CheckBox checkBox_italic;
        private System.Windows.Forms.CheckBox checkBox_underline;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Right;
        private System.Windows.Forms.RadioButton radioButton_Center;
        private System.Windows.Forms.RadioButton radioButton_Left;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label label_text;
    }
}