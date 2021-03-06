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
    public partial class Frm_Principal_Menu_MDI : Form
    {
        public Frm_Principal_Menu_MDI()
        {
            InitializeComponent();
        }

        private void DemonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DemonstracaoKey f = new Frm_DemonstracaoKey
            {
                MdiParent = this
            };
            f.Show();
        }

        private void HelloWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_HelloWorld f = new Frm_HelloWorld
            {
                MdiParent = this
            };
            f.Show();
        }

        private void MáscaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mascara f = new Frm_Mascara
            {
                MdiParent = this
            };
            f.Show();
        }

        private void ValidaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF f = new Frm_ValidaCPF
            {
                MdiParent = this
            };
            f.Show();
        }

        private void ValidaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF2 f = new Frm_ValidaCPF2
            {
                MdiParent = this
            };
            f.Show();
        }

        private void ValídaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaSenha f = new Frm_ValidaSenha
            {
                MdiParent = this
            };
            f.Show();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Principal_Menu_MDI_Load(object sender, EventArgs e)
        {

        }

        private void CascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void HorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void VerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);

        }
    }
}
