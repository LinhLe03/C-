using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    public partial class Notepad1 : Form
    {
        public Notepad1()
        {
            InitializeComponent();
        }

        //open new file
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            richTextBox1.Clear();
        }

        // open a file
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if(openFileDialog1.ShowDialog()== DialogResult.OK) 
            {
                richTextBox1.Clear();
            }
        }

        // save a file
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "Text File|*.txt|PDF file|*.pdf|Word File|*.doc";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
        }


        //close appication

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //undo

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }    

        //cut 

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }


        // paste
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        //select all text
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            richTextBox1.SelectAll();
        }
            
        
        //display date and time
        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = System.DateTime.Now.ToString();
        }

        

        //for font options 
        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        //providing color to the text

        private void colorToolStripMenuItem_Click(object sender, EventArgs e) { 
          if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }


    }
}
