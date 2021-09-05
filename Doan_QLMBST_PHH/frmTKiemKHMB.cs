using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan_QLMBST_PHH
{
    public partial class frmTKiemKHMB : Form
    {
        public frmTKiemKHMB()
        {
            InitializeComponent();
        }
        QL_SimTheEntities db = new QL_SimTheEntities();
        private void frmTKiemKHMB_Load(object sender, EventArgs e)
        {

        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            if(!rd_makh.Checked && !rd_ms.Checked && !rd_mt.Checked)
                MessageBox.Show("Vui lòng chọn tiêu chí tìm kiếm", "Thông báo");
            else if (rd_makh.Checked)
            {

                string ma = Microsoft.VisualBasic.Interaction.InputBox("Nhập mã khách hàng", "Thông báo");
                var qr = from s in db.MuaBanThes where s.Makh == ma select new { s.Makh, s.KhachHang.Tenkh, s.KhachHang.DiaChi, s.KhachHang.SoDienThoai, s.MaThe, s.SoLuong };
                var qr1 = from d in db.MuaBanSims where d.Makh == ma select new { d.Makh, d.KhachHang.Tenkh, d.KhachHang.DiaChi, d.KhachHang.SoDienThoai, d.MaS };
                if (qr.ToList().Count() == 0 && qr1.ToList().Count() == 0)
                {
                    MessageBox.Show("Khách hàng này chưa mua sản phẩm nào tại cửa hàng", "Thông báo");
                }
                else
                {
                    luoi_kq.DataSource = qr.ToList();
                    luoi_kq2.DataSource = qr1.ToList();
                    //luoi_kq2.Columns[4].Visible = false;
                    //luoi_kq2.Columns[5].Visible = false;
                }
            }
            else if (rd_mt.Checked)
            {

                string ma = Microsoft.VisualBasic.Interaction.InputBox("Nhập mã thẻ", "Thông báo");
                var qr = from s in db.MuaBanThes where s.MaThe == ma select new { s.Makh, s.KhachHang.Tenkh, s.KhachHang.DiaChi, s.KhachHang.SoDienThoai, s.MaThe, s.SoLuong };
                if (qr.ToList().Count() == 0)
                {
                    MessageBox.Show("Khách hàng này chưa mua sản phẩm nào tại cửa hàng", "Thông báo");
                }
                else
                {
                    luoi_kq.DataSource = qr.ToList();

                }
            }
            else
            {
                string ma = Microsoft.VisualBasic.Interaction.InputBox("Nhập mã sim", "Thông báo");
                var qr = from s in db.MuaBanSims where s.MaS == ma select new { s.Makh, s.KhachHang.Tenkh, s.KhachHang.DiaChi, s.KhachHang.SoDienThoai, s.MaS };
                if (qr.ToList().Count() == 0)
                {
                    MessageBox.Show("Khách hàng này chưa mua sản phẩm nào tại cửa hàng", "Thông báo");
                }
                else
                {

                    luoi_kq2.DataSource = qr.ToList();
                    //luoi_kq2.Columns[4].Visible = false;
                    //luoi_kq2.Columns[5].Visible = false;
                }
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
