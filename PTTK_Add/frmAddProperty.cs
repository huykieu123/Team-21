using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK_Add
{
    public partial class frmAddProperty : Form
    {
        public frmAddProperty()
        {
            InitializeComponent();
        }

        private void frmAddProperty_Load(object sender, EventArgs e)
        {
            LockText(false);
        }

        void LockText(bool khoa)
        {
            txtMaBDS.Enabled = khoa;
            txtMaHuyHoach.Enabled = khoa;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LockText(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            LockText(false);
        }

        private void picBDS_Click(object sender, EventArgs e)
        {

        }


        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void picBDS_Click_1(object sender, EventArgs e)
        {

        }

        private void newFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mniAddProperty_Click(object sender, EventArgs e)
        {

        }

        private void mniViewListOfProperty_Click(object sender, EventArgs e)
        {

        }

        private void numGia_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMaBDS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaHuyHoach_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tìmKiếmHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cậpNhậtHợpĐòngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xoaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
