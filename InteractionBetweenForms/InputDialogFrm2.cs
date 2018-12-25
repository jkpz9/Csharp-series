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
    public partial class InputDialogFrm2 : Form
    {
        public event Action<string> ButtonSubmitClicked;

        public event Action ButtonClearClicked;

        public InputDialogFrm2()
        {
            InitializeComponent();
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ButtonSubmitClicked?.Invoke(sender, e);
            Action<string> action = ButtonSubmitClicked;
            if (action != null)
            {
                action(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Action action = ButtonClearClicked;
            if (action != null)
            {
                action();
            }
        }
    }
}
