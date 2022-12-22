
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
            this.comboBox_Item = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox_Item
            // 
            this.comboBox_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Item.FormattingEnabled = true;
            this.comboBox_Item.Items.AddRange(new object[] {
            "Circle",
            "Square",
            "Elipse",
            "Pie",
            "Filled Square",
            "Filled Circle",
            "Filled Elipse",
            "Filled Pie"});
            this.comboBox_Item.Location = new System.Drawing.Point(46, 33);
            this.comboBox_Item.Name = "comboBox_Item";
            this.comboBox_Item.Size = new System.Drawing.Size(197, 33);
            this.comboBox_Item.TabIndex = 0;
            this.comboBox_Item.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_Item);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Item;
    }
}

