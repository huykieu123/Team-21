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
namespace View
{
    public partial class frmView : Form
    {
        XulyDanhsach xLyDanhSach;
        public frmView()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        
        private void frmView_Load(object sender, EventArgs e)
        {
            xLyDanhSach = new XulyDanhsach();
            IEnumerable<Full_Contract> dsContract = xLyDanhSach.GetFull_ConTract();
            LoadDuLieuToGridView(dsContract);
        }
        void LoadDuLieuToGridView(IEnumerable<Full_Contract> dsC)
        {
            //Đưa dữ liệu lên DGV
            dgvView.DataSource = dsC.ToList();
            dgvView.Columns["ID"].Width = 50;
            dgvView.Columns["ID"].HeaderText = "STT";
            dgvView.Columns["Full_Contract_Code"].Width = 160;
            dgvView.Columns["Full_Contract_Code"].HeaderText = "Mã Bất Động Sản";
            dgvView.Columns["Customer_Name"].HeaderText = "Tên Khách Hàng";
            dgvView.Columns["Year_Of_Birth"].HeaderText = "Năm Sinh";
            dgvView.Columns["Customer_Address"].HeaderText = "Địa Chỉ Khách Hàng";
            dgvView.Columns["Mobile"].HeaderText = "Số Điện Thoại";
            dgvView.Columns["Property_ID"].HeaderText = "Mã Bất Động Sản";
            dgvView.Columns["Date_Of_Contract"].HeaderText = "Ngày lập hợp đồng";
            dgvView.Columns["Price"].HeaderText = "Giá";
        }

        private void mniAddProperty_Click(object sender, EventArgs e)
        {
                Add ad = new Add();
                ad.MdiParent = this;
                ad.Show();
                ad.BringToFront();

                groupBox1.SendToBack();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
