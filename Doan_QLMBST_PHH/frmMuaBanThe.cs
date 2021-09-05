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
    public partial class frmMuaBanThe : Form
    {
        public frmMuaBanThe()
        {
            InitializeComponent();
        }
        QL_SimTheEntities db = new QL_SimTheEntities();
        public static string thangcx;
        void load_cb()
        {
            var qr = db.Thes.ToList();
            cb_mat.DataSource = qr;
            cb_mat.ValueMember = "MaThe";

        }
        void load_cbmat2()
        {
            //var qr = db.Thes.ToList();
            //cb_mathe2.DataSource = qr;
            //cb_mathe2.ValueMember = "MaThe";
        }
        void load_mbt()
        {
            var qr = db.MuaBanThes.ToList();
            bds_mbt.DataSource = qr;
            bdn.BindingSource = bds_mbt;
            txt_makh.DataBindings.Clear();
            txt_makh.DataBindings.Add("Text", bds_mbt, "Makh");
            txt_mathe2.DataBindings.Clear();
            txt_mathe2.DataBindings.Add("Text", bds_mbt, "MaThe");
            //txt_mb.DataBindings.Clear();
            //txt_mb.DataBindings.Add("Text", bds_mbt, "MuaBan");
            txt_nmb.DataBindings.Clear();
            txt_nmb.DataBindings.Add("Text", bds_mbt, "NgayMuaBan");
            txt_slm.DataBindings.Clear();
            txt_slm.DataBindings.Add("Text", bds_mbt, "SoLuong");
            var qr1 = from s in db.MuaBanThes select new { s.Makh, s.MaThe, s.NgayMuaBan, s.SoLuong, thanhtien = s.The.MenhGia * s.SoLuong };
            bds2.DataSource = qr1.ToList();
            luoi_ctmbt.DataSource = bds2;
        }
        private void frmMuaBanThe_Load(object sender, EventArgs e)
        {
            load_mbt();
            load_cb();
            //load_cbmat2();
            txt_thang.Enabled = false;
        }
        void xoatrang()
        {
            txt_makh.Text = "";
            txt_makh.DataBindings.Clear();
            txt_mathe2.Text = "";
            txt_mathe2.DataBindings.Clear();
            //txt_mb.Text = "";
            //txt_mb.DataBindings.Clear();
            txt_nmb.Text = "";
            txt_nmb.DataBindings.Clear();
            txt_slm.Text = "";
            txt_slm.DataBindings.Clear();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (bt_them.Text == "Thêm")
            {
                bt_them.Text = "Lưu";
                //load_cbmat2();
                xoatrang();
                txt_makh.Text = frm_Khachhang.makh;
            }
            else
            {
                MuaBanThe mb = new MuaBanThe();
                mb.Makh = txt_makh.Text;
                mb.MaThe = txt_mathe2.Text;
                mb.NgayMuaBan = DateTime.Parse(txt_nmb.Text);
                //mb.MuaBan = txt_mb.Text;
                mb.SoLuong = int.Parse(txt_slm.Text);
                var qr = db.KhachHangs.Where(d => d.Makh == txt_makh.Text);
                if (qr.Count() == 0)
                {
                    MessageBox.Show("mã kh phải có trong bảng kh");
                }
                else
                {
                    var qr2 = db.MuaBanThes.Where(d => d.Makh == txt_makh.Text && d.MaThe == txt_mathe2.Text);
                    if (qr2.Count() != 0)
                    {
                        qr2.FirstOrDefault().SoLuong = qr2.FirstOrDefault().SoLuong + int.Parse(txt_slm.Text);
                        qr2.FirstOrDefault().NgayMuaBan = DateTime.Parse(txt_nmb.Text);
                        The t = new The();
                        var qr3 = db.Thes.Where(a => a.MaThe == txt_mathe2.Text);
                        if (qr3.Count() != 0) qr3.FirstOrDefault().SoLuong = qr3.FirstOrDefault().SoLuong - int.Parse(txt_slm.Text);
                        db.SaveChanges();
                        MessageBox.Show("Cập nhật bán thẻ thành công", "Thông báo", MessageBoxButtons.OK);
                        cb_mat_SelectedIndexChanged(sender, e);
                        bt_them.Text = "Thêm";
                        load_mbt();

                    }
                    else
                    {
                        var qr3 = db.Thes.Where(a => a.MaThe == txt_mathe2.Text);
                        if (qr3.Count() != 0) qr3.FirstOrDefault().SoLuong = qr3.FirstOrDefault().SoLuong - int.Parse(txt_slm.Text);
                        db.MuaBanThes.Add(mb);
                        db.SaveChanges();
                        bt_them.Text = "Thêm";
                        MessageBox.Show("Thêm thông tin bán thẻ thành công", "Thông báo", MessageBoxButtons.OK);
                        cb_mat_SelectedIndexChanged(sender, e);
                        load_mbt();

                    }
                }
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (luoi_ctmbt.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int i;
                    for (i = 0; i < luoi_ctmbt.Rows.Count; i++)
                    {
                        if (luoi_ctmbt.Rows[i].Selected)
                        {
                            string ma = luoi_ctmbt.Rows[i].Cells[0].Value.ToString();
                            var qr = from s in db.KhachHangs where s.Makh == ma select s;
                            db.KhachHangs.Remove(qr.FirstOrDefault());
                            db.SaveChanges();
                        }
                    }
                    load_mbt();

                    MessageBox.Show("xóa thành công");
                }
            }
            else
            {
                MessageBox.Show("chọn bản ghi cần xóa", "Thông báo");
            }
        }
        void vhh(bool gt)
        {
            txt_makh.Enabled = gt;
            txt_mathe2.Enabled = gt;
            txt_nmb.Enabled = gt;
            txt_slm.Enabled = gt;
            bt_them.Enabled = gt;
            bt_xoa.Enabled = gt;
            bt_thoat.Enabled = gt;
        }
        void vhh2(bool gt)
        {

        }
        private void bt_tkThe_Click(object sender, EventArgs e)
        {
            if (bt_tkThe.Text == "Thống kê")
            {
                bt_tkThe.Text = "In";
                vhh(false);
                txt_thang.Enabled = true;
                txt_thang.Focus();
            }
            else
            {
                if (txt_thang.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tháng cần thống kê", "Thông báo");
                    txt_thang.Focus();
                }
                else
                {
                    thangcx = txt_thang.Text;
                    frmThongKeThe frTKT = new frmThongKeThe();
                    frTKT.Show();
                    vhh(true);
                    bt_tkThe.Text = "Thống kê";
                    txt_thang.ResetText();
                    txt_thang.Enabled = false;
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

        private void cb_mat_SelectedIndexChanged(object sender, EventArgs e)
        {
            var qr = db.Thes.Where(s => s.MaThe == cb_mat.Text).ToList();
            txt_tnm.DataBindings.Clear();
            txt_tnm.DataBindings.Add("Text", qr, "TenNhaMang");
            txt_mg.DataBindings.Clear();
            txt_mg.DataBindings.Add("Text", qr, "MenhGia");
            txt_sl.DataBindings.Clear();
            txt_sl.DataBindings.Add("Text", qr, "SoLuong");
            txt_gn.DataBindings.Clear();
            txt_gn.DataBindings.Add("Text", qr, "GiaNhap");
        }

        private void luoi_ctmbt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_makh.Text = luoi_ctmbt.CurrentRow.Cells[0].Value.ToString();
            txt_mathe2.Text = luoi_ctmbt.CurrentRow.Cells[1].Value.ToString();
            //txt_mb.Text = luoi_ctmbt.CurrentRow.Cells[2].Value.ToString();
            txt_nmb.Text = luoi_ctmbt.CurrentRow.Cells[2].Value.ToString();
            txt_slm.Text = luoi_ctmbt.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
