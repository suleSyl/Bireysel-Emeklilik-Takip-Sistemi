using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_Project
{
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }

        private void MDIForm_Load(object sender, EventArgs e)
        {
            DbOperations.dbOlustur();
            DbOperations.tabloOlustur();            
        }

        void ChildForm(Form _childForm)
        {
            this.Width = _childForm.Width + 22;
            this.Height = _childForm.Height + 68;

            bool durum = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    durum = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }
            }
            if (durum == false)
            {
                _childForm.MdiParent = this;
                _childForm.Show();
            }
        }

        private void mevcutMüşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form1());
        }

        private void yeniMüşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form2());
        }



        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void müşteriBilgileriniGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form3());
        }

        private void müşteriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form4());
        }

        private void ödemeGirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form5());
        }

        private void müşteriyeÖdemeYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form6());
        }
    }
}
