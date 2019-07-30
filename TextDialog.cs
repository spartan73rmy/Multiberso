using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiberso
{
    public partial class TextDialog : Form
    {
        public TextDialog(string Texto)
        {
            InitializeComponent();
            lblText.Text = Texto;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void CheckBoxInvertir_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxInvertir.Text.Equals("Formula = Escala - (Valor * Escala)/Maximo"))
                checkBoxInvertir.Text = "Formula = (Valor * Escala)/Maximo";
            else
                checkBoxInvertir.Text = "Formula = Escala - (Valor * Escala)/Maximo";
        }
    }
}
