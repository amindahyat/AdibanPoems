using System.Windows.Forms;

namespace RandomQoutes
{
    partial class Form2
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
            this.listBoxAdv1 = new System.Windows.Forms.ListBox();
            this.buttonItem1 = new System.Windows.Forms.Button();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelX1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxAdv1
            // 
            this.listBoxAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxAdv1.Font = new System.Drawing.Font("B Mitra", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listBoxAdv1.ItemHeight = 27;
            this.listBoxAdv1.Location = new System.Drawing.Point(479, 12);
            this.listBoxAdv1.Name = "listBoxAdv1";
            this.listBoxAdv1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxAdv1.Size = new System.Drawing.Size(182, 436);
            this.listBoxAdv1.TabIndex = 0;
            this.listBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.listBoxAdv1_SelectedIndexChanged);
            // 
            // buttonItem1
            // 
            this.buttonItem1.Location = new System.Drawing.Point(0, 0);
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Size = new System.Drawing.Size(75, 23);
            this.buttonItem1.TabIndex = 0;
            // 
            // textBoxX1
            // 
            this.textBoxX1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxX1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxX1.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxX1.Location = new System.Drawing.Point(12, 71);
            this.textBoxX1.Multiline = true;
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxX1.Size = new System.Drawing.Size(461, 379);
            this.textBoxX1.TabIndex = 2;
            this.textBoxX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(353, 12);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 53);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("B Mitra", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX1.Location = new System.Drawing.Point(32, 18);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(170, 53);
            this.labelX1.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 456);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.listBoxAdv1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(592, 503);
            this.Name = "Form2";
            this.Text = "صفحه اشعار";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxAdv1;
        private Button buttonItem1;
        private TextBox textBoxX1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private Label labelX1;
    }
}