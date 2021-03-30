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
   
    public partial class FRM_PRODUCTS : Form
    {
        /// <summary>
        /// //copy from main
        private static FRM_PRODUCTS frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        { frm = null; }
        public static FRM_PRODUCTS getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_PRODUCTS();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
       
        
        /// </summary>
        public string state = "add";
        BL.CLS_PRODUCT prd = new BL.CLS_PRODUCT();
        public FRM_PRODUCTS()
        {
            InitializeComponent();
            /// <summary>
            //للتحقق من موجود الفورم عند بناءه
            if (frm == null)
                frm = this;
            /// </summary>
            this.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
           DT = prd.searchProduct(textSEARCH.Text);
            this.dataGridView1.DataSource = DT;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FRM_PRODUCTS_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف المنتج المحدد؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                prd.DeleteProduct(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();
            }
            else
            {
                MessageBox.Show("تم الغاء عملية الحذف  ", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             
            }
                      }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
           frm.textref.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
           frm.textdec.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString(); 
           frm.textQte.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
           frm.textPrice.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
           frm.cmbCategoreis.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
           frm.Text = "تحديث المنتج:" + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
          frm.btnok.Text = "تحديث";
           frm.state = "update";
           frm.textref.ReadOnly = true;
           byte[] image = (byte[])prd.Get_IMAGE_Product(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];//مصفوفة بيانات ثنائية لحفظ الصورة
            MemoryStream ms = new MemoryStream(image);
            frm.pbox.Image = Image.FromStream(ms);

          frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FRM_PREVIEW frm = new FRM_PREVIEW();
            byte[] image = (byte[])prd.Get_IMAGE_Product(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];//مصفوفة بيانات ثنائية لحفظ الصورة
            MemoryStream ms = new MemoryStream (image);
            frm.pictureBox1.Image = Image.FromStream(ms);

            frm.ShowDialog();

        }
        
        //عملية البحث كل شي كامل لكن لا يبحث 
        
        

    }
}
