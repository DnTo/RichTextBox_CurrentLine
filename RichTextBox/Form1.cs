using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            var rtb = sender as System.Windows.Forms.RichTextBox;
           
            this.tbNumberOfLines.Text = rtb.Lines.Count().ToString();
            this.tbEndOfLinesIndex.Text = string.Join("-", rtb.Lines.ToList().Select(x => x.Length));
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            var rtb = sender as System.Windows.Forms.RichTextBox;
            tbSelectedText.Text = rtb.SelectedText;

            int cursorPosition = rtb.SelectionStart;
            var index = rtb.GetLineFromCharIndex(cursorPosition);
            tbCurrentLine.Text = index.ToString();
        }
    }
}
