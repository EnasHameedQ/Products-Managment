using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Products_managment.PL
{
    public partial class FRM_ADD_PRODUCT : Form
    {
        public string state = "add";
        BL.CLS_PRODUCT prd = new BL.CLS_PRODUCT();
        public FRM_ADD_PRODUCT()
        {
            InitializeComponent();
            cmbCategoreis.DataSource = prd.GET_ALL_CATEGORIES();
            cmbCategoreis.DisplayMember = "DISCARIPTION_CAT";
            cmbCategoreis.ValueMember = "ID_CAT";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور| *.JPG; *.PNG; *.BMP; *.GIF";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                MemoryStream ms = new MemoryStream();
                pbox.Image.Save(ms, pbox.Image.RawFormat);
                byte[] byteimage = ms.ToArray();

                prd.ADD_PRODUCT(Convert.ToInt32(cmbCategoreis.SelectedValue), textdec.Text, textref.Text, Convert.ToInt32(textQte.Text),
                    textPrice.Text, byteimage);

                MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                pbox.Image.Save(ms, pbox.Image.RawFormat);
                byte[] byteimage = ms.ToArray();

                prd.UPDATE_PRODUCT(Convert.ToInt32(cmbCategoreis.SelectedValue), textdec.Text, textref.Text, Convert.ToInt32(textQte.Text),
                    textPrice.Text, byteimage);

                MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FRM_PRODUCTS.getMainForm.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();
            }
            FRM_PRODUCTS.getMainForm.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();

        }
        private void textref_Validated(object sender, EventArgs e)
        {
            if ( state == "add")
            {
                DataTable Dt = new DataTable();
                Dt = prd.varifayProductID(textref.Text);
                if (Dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذا المعرف موجود مسبقاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textref.Focus();
                    textref.SelectionStart = 0;
                    textref.SelectionLength = textref.TextLength;
                }
            }
        }

        private void FRM_ADD_PRODUCT_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textref_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textQte_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textdec_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pbox_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbCategoreis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {

        }

      

    }
}
