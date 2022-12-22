
namespace Bai11
{
    partial class Bai11
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
            this.groupBoxShapes = new System.Windows.Forms.GroupBox();
            this.groupBoxPen = new System.Windows.Forms.GroupBox();
            this.groupBoxBrushes = new System.Windows.Forms.GroupBox();
            this.radioButtonLine = new System.Windows.Forms.RadioButton();
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonEl = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.pictureBox_ShowPen = new System.Windows.Forms.PictureBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxShapes.SuspendLayout();
            this.groupBoxPen.SuspendLayout();
            this.groupBoxBrushes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ShowPen)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxShapes
            // 
            this.groupBoxShapes.Controls.Add(this.radioButtonEl);
            this.groupBoxShapes.Controls.Add(this.radioButtonRectangle);
            this.groupBoxShapes.Controls.Add(this.radioButtonLine);
            this.groupBoxShapes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxShapes.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.groupBoxShapes.Location = new System.Drawing.Point(5, 16);
            this.groupBoxShapes.Name = "groupBoxShapes";
            this.groupBoxShapes.Size = new System.Drawing.Size(269, 151);
            this.groupBoxShapes.TabIndex = 0;
            this.groupBoxShapes.TabStop = false;
            this.groupBoxShapes.Text = "Shapes";
            // 
            // groupBoxPen
            // 
            this.groupBoxPen.Controls.Add(this.btnColor);
            this.groupBoxPen.Controls.Add(this.numericUpDownWidth);
            this.groupBoxPen.Controls.Add(this.label1);
            this.groupBoxPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPen.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.groupBoxPen.Location = new System.Drawing.Point(5, 171);
            this.groupBoxPen.Name = "groupBoxPen";
            this.groupBoxPen.Size = new System.Drawing.Size(269, 130);
            this.groupBoxPen.TabIndex = 1;
            this.groupBoxPen.TabStop = false;
            this.groupBoxPen.Text = "Pen";
            // 
            // groupBoxBrushes
            // 
            this.groupBoxBrushes.Controls.Add(this.radioButton7);
            this.groupBoxBrushes.Controls.Add(this.radioButton6);
            this.groupBoxBrushes.Controls.Add(this.radioButton5);
            this.groupBoxBrushes.Controls.Add(this.radioButton4);
            this.groupBoxBrushes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBrushes.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.groupBoxBrushes.Location = new System.Drawing.Point(5, 309);
            this.groupBoxBrushes.Name = "groupBoxBrushes";
            this.groupBoxBrushes.Size = new System.Drawing.Size(269, 191);
            this.groupBoxBrushes.TabIndex = 2;
            this.groupBoxBrushes.TabStop = false;
            this.groupBoxBrushes.Text = "Brushes";
            // 
            // radioButtonLine
            // 
            this.radioButtonLine.AutoSize = true;
            this.radioButtonLine.ForeColor = System.Drawing.Color.Black;
            this.radioButtonLine.Location = new System.Drawing.Point(18, 26);
            this.radioButtonLine.Name = "radioButtonLine";
            this.radioButtonLine.Size = new System.Drawing.Size(62, 24);
            this.radioButtonLine.TabIndex = 0;
            this.radioButtonLine.TabStop = true;
            this.radioButtonLine.Text = "Line";
            this.radioButtonLine.UseVisualStyleBackColor = true;
            this.radioButtonLine.CheckedChanged += new System.EventHandler(this.radioButtonLine_CheckedChanged);
            // 
            // radioButtonRectangle
            // 
            this.radioButtonRectangle.AutoSize = true;
            this.radioButtonRectangle.ForeColor = System.Drawing.Color.Black;
            this.radioButtonRectangle.Location = new System.Drawing.Point(18, 64);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new System.Drawing.Size(105, 24);
            this.radioButtonRectangle.TabIndex = 1;
            this.radioButtonRectangle.TabStop = true;
            this.radioButtonRectangle.Text = "Rectangle";
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            this.radioButtonRectangle.CheckedChanged += new System.EventHandler(this.radioButtonRectangle_CheckedChanged);
            // 
            // radioButtonEl
            // 
            this.radioButtonEl.AutoSize = true;
            this.radioButtonEl.ForeColor = System.Drawing.Color.Black;
            this.radioButtonEl.Location = new System.Drawing.Point(18, 108);
            this.radioButtonEl.Name = "radioButtonEl";
            this.radioButtonEl.Size = new System.Drawing.Size(80, 24);
            this.radioButtonEl.TabIndex = 2;
            this.radioButtonEl.TabStop = true;
            this.radioButtonEl.Text = "Ellipse";
            this.radioButtonEl.UseVisualStyleBackColor = true;
            this.radioButtonEl.CheckedChanged += new System.EventHandler(this.radioButtonEl_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(95, 30);
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(98, 27);
            this.numericUpDownWidth.TabIndex = 1;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWidth.ValueChanged += new System.EventHandler(this.numericUpDownWidth_ValueChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.ForeColor = System.Drawing.Color.Black;
            this.radioButton4.Location = new System.Drawing.Point(18, 26);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(112, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "SolidBrush";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.ForeColor = System.Drawing.Color.Black;
            this.radioButton5.Location = new System.Drawing.Point(18, 70);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(120, 24);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "HatchBrush";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.ForeColor = System.Drawing.Color.Black;
            this.radioButton6.Location = new System.Drawing.Point(18, 112);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(131, 24);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "TextureBrush";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.ForeColor = System.Drawing.Color.Black;
            this.radioButton7.Location = new System.Drawing.Point(18, 157);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(186, 24);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "LinearGradientBrush";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // pictureBox_ShowPen
            // 
            this.pictureBox_ShowPen.Location = new System.Drawing.Point(280, 29);
            this.pictureBox_ShowPen.Name = "pictureBox_ShowPen";
            this.pictureBox_ShowPen.Size = new System.Drawing.Size(716, 550);
            this.pictureBox_ShowPen.TabIndex = 3;
            this.pictureBox_ShowPen.TabStop = false;
            this.pictureBox_ShowPen.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_ShowPen_Paint);
            this.pictureBox_ShowPen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_ShowPen_MouseDown);
            this.pictureBox_ShowPen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_ShowPen_MouseMove);
            this.pictureBox_ShowPen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_ShowPen_MouseUp);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Black;
            this.btnColor.Location = new System.Drawing.Point(18, 82);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(102, 33);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "Color...";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(5, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bai11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 587);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox_ShowPen);
            this.Controls.Add(this.groupBoxBrushes);
            this.Controls.Add(this.groupBoxPen);
            this.Controls.Add(this.groupBoxShapes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Bai11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai11";
            this.Load += new System.EventHandler(this.Bai11_Load);
            this.groupBoxShapes.ResumeLayout(false);
            this.groupBoxShapes.PerformLayout();
            this.groupBoxPen.ResumeLayout(false);
            this.groupBoxPen.PerformLayout();
            this.groupBoxBrushes.ResumeLayout(false);
            this.groupBoxBrushes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ShowPen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxShapes;
        private System.Windows.Forms.RadioButton radioButtonEl;
        private System.Windows.Forms.RadioButton radioButtonRectangle;
        private System.Windows.Forms.RadioButton radioButtonLine;
        private System.Windows.Forms.GroupBox groupBoxPen;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxBrushes;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.PictureBox pictureBox_ShowPen;
        private System.Windows.Forms.Button button1;
    }
}