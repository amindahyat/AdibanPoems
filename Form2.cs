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
using System.Data.SQLite;

namespace RandomQoutes
{
    public partial class Form2 : Form
    {
        SQLiteConnection con = new SQLiteConnection("Data Source=DATA\\Poetry.db;Version=3;");
        public Form2()
        {
            InitializeComponent();
        }
        List<string> dirs = new List<string>();
        DataTable Poems = new DataTable();
        private void Form2_Load(object sender, EventArgs e)
        {
           /* string path = Environment.CurrentDirectory + "\\DATA\\poems\\"; // مسیر مورد نظر

            string[] directories = Directory.GetDirectories(path);

            foreach (string dir in directories)
            {
                //dirs.Add(Path.GetFileName(dir));
                ListBoxItem d= new ListBoxItem();
                d.Text = Path.GetFileName(dir);
                d.TextAlignment = eButtonTextAlignment.Center;
                listBoxAdv1.Items.Add(d);
            }*/
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Poets", con);
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
              
                listBoxAdv1.Items.Add(row["Name"].ToString());
            }


        }

        private void listBoxAdv1_ItemClick(object sender, EventArgs e)
        {
            /*string path = Environment.CurrentDirectory + "\\DATA\\poems\\"+listBoxAdv1.SelectedItem.ToString(); // مسیر مورد نظر
            poems.ToList().Clear();
            poems = Directory.GetFiles(path);
            
            foreach (string dir in poems)
            {
                dirs.Add(Path.GetFileName(dir));
                
            }
            numericUpDown1.Maximum= poems.Length-1;
            labelX1.Text = "تعداد اشعار: " + poems.Length.ToString();
            string path2 =poems[Convert.ToInt32( numericUpDown1.Value)].ToString(); // مسیر مورد نظر
            textBoxX1.Text = File.ReadAllText(path2);*/
            Poems.Rows.Clear();
            int poetId = listBoxAdv1.SelectedIndex +1;
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Poems Where PoetId="+poetId, con);
            da.Fill(Poems);
            if (Poems.Rows.Count > 0)
            {
                string poemText = Poems.Rows[0]["Content"].ToString();
                textBoxX1.Text = poemText;
                numericUpDown1.Maximum = Poems.Rows.Count - 1;
                labelX1.Text = "تعداد اشعار: " + Poems.Rows.Count.ToString();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (listBoxAdv1.SelectedIndex != -1)
            {
                int selectedPoemIndex = Convert.ToInt32(numericUpDown1.Value);
                if (selectedPoemIndex < Poems.Rows.Count)
                {
                    string poemText = Poems.Rows[selectedPoemIndex]["Content"].ToString();
                    textBoxX1.Text = poemText;
                }
            }
            /* if (poems.Length < numericUpDown1.Value)
             {
                 return;
             }
             else if(listBoxAdv1.SelectedIndex!=-1)
             {
                 string path2 = poems[Convert.ToInt32(numericUpDown1.Value)].ToString(); // مسیر مورد نظر
                 textBoxX1.Text = File.ReadAllText(path2);
             }*/
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            info f=new info();
            f.Show();
        }

        private void listBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Poems.Rows.Clear();
            int poetId = listBoxAdv1.SelectedIndex + 1;
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Poems Where PoetId=" + poetId, con);
            da.Fill(Poems);
            if (Poems.Rows.Count > 0)
            {
                string poemText = Poems.Rows[0]["Content"].ToString();
                textBoxX1.Text = poemText;
                numericUpDown1.Maximum = Poems.Rows.Count - 1;
                labelX1.Text = "تعداد اشعار: " + Poems.Rows.Count.ToString();
            }
        }
    }
}
