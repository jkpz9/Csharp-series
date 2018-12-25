using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormInteraction
{
    public partial class InputDialogFrm : Form
    {
        private readonly Action<string> updateText;
        private readonly Action clearText;
        public InputDialogFrm(Action<string> update, Action clearText)
        {
            InitializeComponent();
            this.updateText = update;
            this.clearText = clearText;
        }

        private void InputDialogFrm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateText(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearText();
            textBox1.Text = String.Empty;
        }
    }
}
