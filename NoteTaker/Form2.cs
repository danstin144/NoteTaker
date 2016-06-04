using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaker
{
    public partial class Form2 : Form
    {
        public Form2(string title)
        {
            InitializeComponent();
            this.Text = title;
        }

        public void saveFile()
        {
            if (string.IsNullOrWhiteSpace(richTextBox2.Text) || richTextBox2.Text == "Enter Title Here")
            {
                MessageBox.Show("You Must Enter a Title for Note!");
            }
            else
            {
                var db = new SQLiteDatabase();
                string noteContent = richTextBox1.Rtf;
                string noteName = richTextBox2.Text;
                Dictionary<String, String> data = new Dictionary<String, String>();
                data.Add("entry", "null");
                data.Add("note", noteContent);
                data.Add("title", noteName);
                db.Insert("notes", data);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            saveFile();
        }
    }
}
