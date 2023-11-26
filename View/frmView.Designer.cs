
namespace View
{
    partial class frmView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mniViewListOfProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmHợpĐồngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAddProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtHợpĐồngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaHợpĐồngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 36);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniViewListOfProperty,
            this.tìmKiếmHợpĐồngToolStripMenuItem,
            this.mniAddProperty,
            this.cậpNhậtHợpĐồngToolStripMenuItem,
            this.xóaHợpĐồngToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1200, 36);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mniViewListOfProperty
            // 
            this.mniViewListOfProperty.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mniViewListOfProperty.Name = "mniViewListOfProperty";
            this.mniViewListOfProperty.Size = new System.Drawing.Size(249, 32);
            this.mniViewListOfProperty.Text = "Xem danh sách hợp đồng";
            // 
            // tìmKiếmHợpĐồngToolStripMenuItem
            // 
            this.tìmKiếmHợpĐồngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tìmKiếmHợpĐồngToolStripMenuItem.Name = "tìmKiếmHợpĐồngToolStripMenuItem";
            this.tìmKiếmHợpĐồngToolStripMenuItem.Size = new System.Drawing.Size(197, 32);
            this.tìmKiếmHợpĐồngToolStripMenuItem.Text = "Tìm kiếm hợp đồng";
            // 
            // mniAddProperty
            // 
            this.mniAddProperty.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mniAddProperty.Name = "mniAddProperty";
            this.mniAddProperty.Size = new System.Drawing.Size(166, 32);
            this.mniAddProperty.Text = "Thêm hợp đồng";
            this.mniAddProperty.Click += new System.EventHandler(this.mniAddProperty_Click);
            // 
            // cậpNhậtHợpĐồngToolStripMenuItem
            // 
            this.cậpNhậtHợpĐồngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cậpNhậtHợpĐồngToolStripMenuItem.Name = "cậpNhậtHợpĐồngToolStripMenuItem";
            this.cậpNhậtHợpĐồngToolStripMenuItem.Size = new System.Drawing.Size(196, 32);
            this.cậpNhậtHợpĐồngToolStripMenuItem.Text = "Cập nhật hợp đồng";
            // 
            // xóaHợpĐồngToolStripMenuItem
            // 
            this.xóaHợpĐồngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.xóaHợpĐồngToolStripMenuItem.Name = "xóaHợpĐồngToolStripMenuItem";
            this.xóaHợpĐồngToolStripMenuItem.Size = new System.Drawing.Size(152, 32);
            this.xóaHợpĐồngToolStripMenuItem.Text = "Xóa hợp đồng";
            // 
            // dgvView
            // 
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvView.Location = new System.Drawing.Point(3, 26);
            this.dgvView.Name = "dgvView";
            this.dgvView.RowHeadersWidth = 51;
            this.dgvView.RowTemplate.Height = 24;
            this.dgvView.Size = new System.Drawing.Size(1173, 526);
            this.dgvView.TabIndex = 0;
            this.dgvView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvView_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvView);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1179, 555);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hợp đồng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // frmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmView";
            this.Text = "Xem danh sách";
            this.Load += new System.EventHandler(this.frmView_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mniViewListOfProperty;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmHợpĐồngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniAddProperty;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtHợpĐồngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaHợpĐồngToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

