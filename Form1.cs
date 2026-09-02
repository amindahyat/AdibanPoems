using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace RandomQoutes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Qoute> list = new List<Qoute>();
        string f = File.ReadAllText(Environment.CurrentDirectory + "\\DATA\\QOUETS.json");
        
        private void Form1_Load(object sender, EventArgs e)
        {
            list = JsonConvert.DeserializeObject<List<Qoute>>(f);
            Random random = new Random();
            int d=random.Next(386);
            labelX1.Text=list[d].body;
            labelX2.Text = list[d].author;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int d = random.Next(386);
            
            labelX1.Text = list[d].body;
            labelX2.Text = list[d].author;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.Show();
            this.Hide();
            

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            info f = new info();
            f.Show();
        }
    }
    class Qoute
    {
        public string body { get; set; }
        public string author { get; set; }
    }
}
