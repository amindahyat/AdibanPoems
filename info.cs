using System;
using System.Windows.Forms;

namespace RandomQoutes
{
    public partial class info : Form
    {
        public info()
        {
            InitializeComponent();
        }

        //InfoVersion i=new InfoVersion();

        private void info_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void labelX2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(labelX2.Text);
         

        }

        private void labelX1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(labelX1.Text);
         
        }

        private void labelX4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(labelX4.Text);
           
        }

        private void info_Load(object sender, EventArgs e)
        {
            labelX10.Text= this.ProductVersion;
          //  labelX11.Text = i.PersianBuildDateTime.ToString();
        }
    }
}
