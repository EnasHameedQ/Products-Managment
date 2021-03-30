using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products_managment.PL
{
    public partial class FRM_MIAN : Form
    {
        //single instance
        //failed
        private static FRM_MIAN frm;
        //hintelerاجراء 
        static void frm_FormClosed(object sender, FormClosedEventArgs e )
        { frm = null; }
        //getter
        public static FRM_MIAN getMainForm
        { get
            {
                if (frm == null)
                {
                    frm = new FRM_MIAN();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public FRM_MIAN()
        {
            InitializeComponent();

            if (frm == null)
                 frm = this;
                this.المنتجاتToolStripMenuItem.Enabled = false;
                this.المستخدمينToolStripMenuItem.Enabled = false;
                this.العملاءToolStripMenuItem.Enabled = false;
                this.إنشاءنسخةاحتياطيةToolStripMenuItem.Enabled = false;
                this.إستعادةتسخةمحفوظةToolStripMenuItem.Enabled = false;
            
        }

        private void إستعادةتسخةمحفوظةToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_LOGIN frm = new Form_LOGIN();
            frm.ShowDialog();
        }

        private void إضافةمنتججديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.ShowDialog();
        }

        private void إدارةالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_PRODUCTS frm = new FRM_PRODUCTS();
            frm.ShowDialog();
        }

        private void FRM_MIAN_Load(object sender, EventArgs e)
        {

        }
    }
}
