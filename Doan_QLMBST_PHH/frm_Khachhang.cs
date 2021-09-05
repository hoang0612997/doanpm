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
    public partial class frm_Khachhang : Form
    {
        public frm_Khachhang()
        {
            InitializeComponent();
        }
        public static string makh;
        QL_SimTheEntities db = new QL_SimTheEntities();
        void load_cb()
        {
            var qr = db.KhachHangs.ToList();
            cb_makh.DataSource = qr;
            cb_makh.DisplayMember = "Makh";
        }
        void load_luoi()
        {
            var qr = db.KhachHangs.ToList();
            bds.DataSource = qr;
            bdn.BindingSource = bds;
            luoi_kh.DataSource = bds;
            luoi_kh.Columns[4].Visible = false;
            luoi_kh.Columns[5].Visible = false;
        }
        private void frm_Khachhang_Load(object sender, EventArgs e)
        {
            load_cb();
            load_luoi();
        }
        void xoatrang()
        {
            cb_makh.Text = "";
            cb_makh.DataBindings.Clear();
            txt_ht.Text = "";
            txt_ht.DataBindings.Clear();
            txt_dc.Text = "";
            txt_dc.DataBindings.Clear();
            txt_sdt.Text = "";
            txt_sdt.DataBindings.Clear();
        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            if (bt_them.Text == "Thêm")
            {
                bt_them.Text = "Lưu";
                xoatrang();
                cb_makh.Focus();
            }
            else
            {
                KhachHang kh = new KhachHang();
                var qr = db.KhachHangs.Where(s => s.Makh == cb_makh.Text);
                if (qr.Count() != 0)
                {
                    MessageBox.Show("Trùng mã khách hàng. Nhập lại", "Thông báo");
                }
                else
                {
                    kh.Makh = cb_makh.Text;
                    kh.Tenkh = txt_ht.Text;
                    kh.DiaChi = txt_dc.Text;
                    kh.SoDienThoai = txt_sdt.Text;
                    db.KhachHangs.Add(kh);
                    db.SaveChanges();
                    MessageBox.Show("Đã thêm khách hàng mới.", "Thông báo", MessageBoxButtons.OK);
                    load_luoi();
                    load_cb();
                    bt_them.Text = "Thêm";


                }
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (bt_sua.Text == "Sửa")
            {
                bt_sua.Text = "Lưu";
                cb_makh.Enabled = false;
            }
            else
            {
                KhachHang kh = new KhachHang();
                var qr = db.KhachHangs.Where(s => s.Makh == cb_makh.Text);
                qr.FirstOrDefault().Tenkh = txt_ht.Text;
                qr.FirstOrDefault().DiaChi = txt_dc.Text;
                qr.FirstOrDefault().SoDienThoai = txt_sdt.Text;
                db.SaveChanges();
                MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK);
                bt_sua.Text = "Sửa";
                cb_makh.Enabled = true;
                load_luoi();
                load_cb();
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (luoi_kh.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo.", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int i;
                    for (i = 0; i < luoi_kh.Rows.Count; i++)
                    {
                        if (luoi_kh.Rows[i].Selected)
                        {
                            string ma = luoi_kh.Rows[i].Cells[0].Value.ToString();
                            var qr = from s in db.KhachHangs where s.Makh == ma select s;
                            db.KhachHangs.Remove(qr.FirstOrDefault());
                            db.SaveChanges();
                        }
                    }
                    load_luoi();
                    load_cb();
                    MessageBox.Show("Đã xóa thành công.");
                }
            }
            else
            {
                MessageBox.Show("chọn bản ghi cần xóa.", "Thông báo.");
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

        private void bt_khmt_Click(object sender, EventArgs e)
        {
            makh = cb_makh.Text;
            frmMuaBanThe frm_mbt = new frmMuaBanThe();
            frm_mbt.Show();
        }

        private void bt_khms_Click(object sender, EventArgs e)
        {
            makh = cb_makh.Text;
            frmMBSim frm_mbs = new frmMBSim();
            frm_mbs.Show();
        }

        private void cb_makh_SelectedIndexChanged(object sender, EventArgs e)
        {
            var qr = db.KhachHangs.Where(s => s.Makh == cb_makh.Text).ToList();
            txt_ht.DataBindings.Clear();
            txt_ht.DataBindings.Add("Text", qr, "Tenkh");
            txt_dc.DataBindings.Clear();
            txt_dc.DataBindings.Add("Text", qr, "Diachi");
            txt_sdt.DataBindings.Clear();
            txt_sdt.DataBindings.Add("Text", qr, "SoDienThoai");
        }

        private void luoi_kh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_makh.Text = luoi_kh.CurrentRow.Cells[0].Value.ToString();
            txt_ht.Text = luoi_kh.CurrentRow.Cells[1].Value.ToString();
            txt_dc.Text = luoi_kh.CurrentRow.Cells[2].Value.ToString();
            txt_sdt.Text = luoi_kh.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
