using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Principal_Menu_UC : Form
    {
        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();
        }
        private void DemonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DemonstracaoKey f = new Frm_DemonstracaoKey();
            f.ShowDialog();
        }

        private void HelloWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_HelloWorld_UC U = new Frm_HelloWorld_UC();
            TabPage TB = new TabPage();
            TB.Name = "Hello World";
            TB.Text = "Hello World";
            TB.ImageIndex = 1;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);

        }

        private void MáscaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mascara f = new Frm_Mascara();
            f.ShowDialog();
        }

        private void ValidaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF f = new Frm_ValidaCPF();
            f.ShowDialog();
        }

        private void ValidaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF2 f = new Frm_ValidaCPF2();
            f.ShowDialog();
        }

        private void ValídaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaSenha f = new Frm_ValidaSenha();
            f.ShowDialog();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
