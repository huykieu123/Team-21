
namespace PTTK_Add
{
    partial class frmAddProperty
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.numGia = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaBDS = new System.Windows.Forms.TextBox();
            this.txtMaHuyHoach = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picBDS = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mniViewListOfProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmHợpĐồngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAddProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtHợpĐòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBDS)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.numGia);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtMaBDS);
            this.groupBox1.Controls.Add(this.txtMaHuyHoach);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1076, 579);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm hợp đồng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(884, 469);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 42);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // numGia
            // 
            this.numGia.Location = new System.Drawing.Point(350, 182);
            this.numGia.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numGia.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numGia.Name = "numGia";
            this.numGia.Size = new System.Drawing.Size(425, 34);
            this.numGia.TabIndex = 5;
            this.numGia.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numGia.ValueChanged += new System.EventHandler(this.numGia_ValueChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(729, 469);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 42);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaBDS
            // 
            this.txtMaBDS.Location = new System.Drawing.Point(351, 336);
            this.txtMaBDS.Name = "txtMaBDS";
            this.txtMaBDS.Size = new System.Drawing.Size(425, 34);
            this.txtMaBDS.TabIndex = 2;
            this.txtMaBDS.TextChanged += new System.EventHandler(this.txtMaBDS_TextChanged);
            // 
            // txtMaHuyHoach
            // 
            this.txtMaHuyHoach.Location = new System.Drawing.Point(350, 285);
            this.txtMaHuyHoach.Name = "txtMaHuyHoach";
            this.txtMaHuyHoach.Size = new System.Drawing.Size(425, 34);
            this.txtMaHuyHoach.TabIndex = 2;
            this.txtMaHuyHoach.TextChanged += new System.EventHandler(this.txtMaHuyHoach_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(350, 236);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(425, 34);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(350, 136);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(425, 34);
            this.txtDiachi.TabIndex = 2;
            this.txtDiachi.TextChanged += new System.EventHandler(this.txtDiachi_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tình trạng bất động sản";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã số huy hoạch";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã số bất động sản";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá tiền";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Địa chỉ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // picBDS
            // 
            this.picBDS.Image = global::PTTK_Add.Properties.Resources.logoproperty;
            this.picBDS.Location = new System.Drawing.Point(1005, 0);
            this.picBDS.Name = "picBDS";
            this.picBDS.Size = new System.Drawing.Size(95, 52);
            this.picBDS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBDS.TabIndex = 3;
            this.picBDS.TabStop = false;
            this.picBDS.Click += new System.EventHandler(this.picBDS_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniViewListOfProperty,
            this.tìmKiếmHợpĐồngToolStripMenuItem,
            this.mniAddProperty,
            this.cậpNhậtHợpĐòngToolStripMenuItem,
            this.xoaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 36);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mniViewListOfProperty
            // 
            this.mniViewListOfProperty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mniViewListOfProperty.Name = "mniViewListOfProperty";
            this.mniViewListOfProperty.Size = new System.Drawing.Size(249, 32);
            this.mniViewListOfProperty.Text = "Xem danh sách hợp đồng";
            this.mniViewListOfProperty.Click += new System.EventHandler(this.mniViewListOfProperty_Click);
            // 
            // tìmKiếmHợpĐồngToolStripMenuItem
            // 
            this.tìmKiếmHợpĐồngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tìmKiếmHợpĐồngToolStripMenuItem.Name = "tìmKiếmHợpĐồngToolStripMenuItem";
            this.tìmKiếmHợpĐồngToolStripMenuItem.Size = new System.Drawing.Size(197, 32);
            this.tìmKiếmHợpĐồngToolStripMenuItem.Text = "Tìm kiếm hợp đồng";
            this.tìmKiếmHợpĐồngToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmHợpĐồngToolStripMenuItem_Click);
            // 
            // mniAddProperty
            // 
            this.mniAddProperty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mniAddProperty.Name = "mniAddProperty";
            this.mniAddProperty.Size = new System.Drawing.Size(166, 32);
            this.mniAddProperty.Text = "Thêm hợp đồng";
            this.mniAddProperty.Click += new System.EventHandler(this.mniAddProperty_Click);
            // 
            // cậpNhậtHợpĐòngToolStripMenuItem
            // 
            this.cậpNhậtHợpĐòngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cậpNhậtHợpĐòngToolStripMenuItem.Name = "cậpNhậtHợpĐòngToolStripMenuItem";
            this.cậpNhậtHợpĐòngToolStripMenuItem.Size = new System.Drawing.Size(196, 32);
            this.cậpNhậtHợpĐòngToolStripMenuItem.Text = "Cập nhật hợp đồng";
            this.cậpNhậtHợpĐòngToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtHợpĐòngToolStripMenuItem_Click);
            // 
            // xoaToolStripMenuItem
            // 
            this.xoaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
            this.xoaToolStripMenuItem.Size = new System.Drawing.Size(152, 32);
            this.xoaToolStripMenuItem.Text = "Xóa hợp đồng";
            this.xoaToolStripMenuItem.Click += new System.EventHandler(this.xoaToolStripMenuItem_Click_1);
            // 
            // frmAddProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Controls.Add(this.picBDS);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddProperty";
            this.Text = "Add Property";
            this.Load += new System.EventHandler(this.frmAddProperty_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBDS)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.PictureBox picBDS;
        private System.Windows.Forms.TextBox txtMaBDS;
        private System.Windows.Forms.TextBox txtMaHuyHoach;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numGia;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniViewListOfProperty;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmHợpĐồngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniAddProperty;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtHợpĐòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaToolStripMenuItem;
    }
}

