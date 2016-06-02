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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string progName = "Note Taker";

        public void exitApp()
        {
            // Display a message box asking users if they
            // want to exit the application.
            if (MessageBox.Show("Do you want to exit?", progName,
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void newNote()
        {
            string currentTabName = tabControl1.SelectedTab.Text;
            Form2 newNoteEdit;
            newNoteEdit = new Form2(currentTabName);
            newNoteEdit.Show();

        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitApp();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void newNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newNote();
        }
    }
}


