namespace Products_managment.PL
{
    partial class FRM_ADD_PRODUCT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pbox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textQte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textdec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textref = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategoreis = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnok);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textPrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textQte);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textdec);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textref);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbCategoreis);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(471, 571);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المنتج :";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(63, 503);
            this.btnok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(87, 39);
            this.btnok.TabIndex = 14;
            this.btnok.Text = "موافق";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(188, 503);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 39);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 439);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "تحديد ملف الصورة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbox
            // 
            this.pbox.Image = global::Products_managment.Properties.Resources.No;
            this.pbox.Location = new System.Drawing.Point(73, 304);
            this.pbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(220, 135);
            this.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox.TabIndex = 11;
            this.pbox.TabStop = false;
            this.pbox.Click += new System.EventHandler(this.pbox_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "صورة المنتج:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(73, 265);
            this.textPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(220, 30);
            this.textPrice.TabIndex = 3;
            this.textPrice.TextChanged += new System.EventHandler(this.textPrice_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "ثمن المنتج:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textQte
            // 
            this.textQte.Location = new System.Drawing.Point(73, 218);
            this.textQte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textQte.Name = "textQte";
            this.textQte.Size = new System.Drawing.Size(220, 30);
            this.textQte.TabIndex = 2;
            this.textQte.TextChanged += new System.EventHandler(this.textQte_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "الكمية المخزنة:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textdec
            // 
            this.textdec.Location = new System.Drawing.Point(73, 134);
            this.textdec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textdec.Multiline = true;
            this.textdec.Name = "textdec";
            this.textdec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textdec.Size = new System.Drawing.Size(220, 75);
            this.textdec.TabIndex = 1;
            this.textdec.TextChanged += new System.EventHandler(this.textdec_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "وصف المنتج:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textref
            // 
            this.textref.Location = new System.Drawing.Point(73, 87);
            this.textref.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textref.Name = "textref";
            this.textref.Size = new System.Drawing.Size(220, 30);
            this.textref.TabIndex = 0;
            this.textref.TextChanged += new System.EventHandler(this.textref_TextChanged);
            this.textref.Validated += new System.EventHandler(this.textref_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "معرف المنتج:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbCategoreis
            // 
            this.cmbCategoreis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoreis.FormattingEnabled = true;
            this.cmbCategoreis.Location = new System.Drawing.Point(73, 39);
            this.cmbCategoreis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCategoreis.Name = "cmbCategoreis";
            this.cmbCategoreis.Size = new System.Drawing.Size(220, 31);
            this.cmbCategoreis.TabIndex = 1;
            this.cmbCategoreis.SelectedIndexChanged += new System.EventHandler(this.cmbCategoreis_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "صنف المنتج :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FRM_ADD_PRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 571);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FRM_ADD_PRODUCT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة منتج جديد";
            this.Load += new System.EventHandler(this.FRM_ADD_PRODUCT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.PictureBox pbox;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textPrice;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textQte;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textdec;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textref;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbCategoreis;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnok;
    }
}