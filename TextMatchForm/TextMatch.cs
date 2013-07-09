using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextMatchForm
{
    public partial class TextMatch : Form
    {
        public TextMatch()
        {
            InitializeComponent();
        }

        private void ValidateInput()
        {
            bool error = false;
            if (txtMain.Text == string.Empty)
            {
                errorProvider1.SetError(txtMain, "Please fill the main text");
                error = true;
            }
            else
            {
                errorProvider1.SetError(txtMain, string.Empty);
                error = false;
            }

            if (txtSubText.Text == string.Empty)
            {
                errorProvider1.SetError(txtSubText, "Please fill the sub text");
                error = true;
            }
            else
            {
                errorProvider1.SetError(txtSubText, string.Empty);
                if (error != true)
                    error = false;
            }
        }

        private void btnFindMatches_Click(object sender, EventArgs e)
        {
            ValidateInput();

            var logic = new TextMatchLogic.ProcessTextMatch { MainText = txtMain.Text, SubText = txtSubText.Text };
            lblResult.Text = logic.Process();
        }

        private void TextMatch_Load(object sender, EventArgs e)
        {
            ActiveControl = txtMain;
            errorProvider1.ContainerControl = this;
        }
    }
}
