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
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        public void TextUpdate(String str)
        {
            label1.Text = str;
        }

        public void ClearText()
        {
            label1.Text = string.Empty;
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //InputDialogFrm inputFrm = new InputDialogFrm(this.TextUpdate, this.ClearText) { Visible = true };
            //inputFrm.Show();
            InputDialogFrm2 inputFrm = new InputDialogFrm2() { Visible = true };
            inputFrm.ButtonSubmitClicked += f2_BtnSubmit;
            inputFrm.ButtonClearClicked += f2_BtnClear;
            inputFrm.Show();

        }

        private void f2_BtnClear()
        {
            label1.Text = string.Empty;
        }

        private void f2_BtnSubmit(string strText)
        {
            label1.Text = strText;
        }
    }
}
