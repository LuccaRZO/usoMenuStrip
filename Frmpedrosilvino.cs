using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemploMenu
{
    public partial class Frmpedrosilvino : Form
    {
        public Frmpedrosilvino()
        {
            InitializeComponent();
        }

        private void frmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmcanudocomcafe frm = new Frmcanudocomcafe(); //indico qual será aberto
            this.Hide();
            frm.ShowDialog();
        }

        private void exibirFrmpedrosilvino_Click(object sender, EventArgs e)
        {
            Frmpedrosilvino frm = new Frmpedrosilvino(); //indico qual será aberto
            this.Hide();
            frm.ShowDialog();
        }

        private void exibirFrmpagodin_Click(object sender, EventArgs e)
        {
            Frmpagodin frm = new Frmpagodin(); //indico qual será aberto
            this.Hide();
            frm.ShowDialog();
        }
    }
}
