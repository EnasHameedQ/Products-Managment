using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Products_managment.PL
{
    public partial class Form_LOGIN : Form
    {
        BL.CLS_LOGIN log = new BL.CLS_LOGIN();

        public Form_LOGIN()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            DataTable Dt = log.LOGIN(txtID.Text,txtBWD.Text);
            if( Dt.Rows.Count>0)
            {
                FRM_MIAN.getMainForm.المنتجاتToolStripMenuItem.Enabled = true;
                FRM_MIAN.getMainForm.المستخدمينToolStripMenuItem.Enabled = true;
                FRM_MIAN.getMainForm.العملاءToolStripMenuItem.Enabled = true;
                FRM_MIAN.getMainForm.إنشاءنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                FRM_MIAN.getMainForm.إستعادةتسخةمحفوظةToolStripMenuItem.Enabled = true;
                this.Close();
            }
            else  
            
            { MessageBox.Show("login field!"); }
           }

        private void Form_LOGIN_Load(object sender, EventArgs e)
        {

        }
        }
   
}
