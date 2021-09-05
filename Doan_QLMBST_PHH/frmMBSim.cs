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
    public partial class frmMBSim : Form
    {
        public frmMBSim()
        {
            InitializeComponent();
        }
        QL_SimTheEntities db = new QL_SimTheEntities();
        public static string thangcx;
        int i = 0;
        void load_cb()
        {
            var qr = db.Sims.ToList();
            cb_mas.DataSource = qr;
            cb_mas.ValueMember = "MaS";
        }
        void load_mbs()
        {
            var qr = db.MuaBanSims.ToList();
            bds.DataSource = qr.ToList();
            bdn.BindingSource = bds;
            luoi_mbs.DataSource = bds;
            luoi_mbs.Columns[3].Visible = false;
            luoi_mbs.Columns[4].Visible = false;

        }
        private void frmMBSim_Load(object sender, EventArgs e)
        {
            load_cb();
            load_mbs();
            txt_thang.Enabled = false;
        }
        void vhh(bool gt)
        {
            cb_mas.Enabled = gt;
            txt_tnm.Enabled = gt;
            txt_nkh.Enabled = gt;
            txt_ss.Enabled = gt;
            txt_ls.Enabled = gt;
            txt_gs.Enabled = gt;
            txt_tts.Enabled = gt;
            bt_chon.Enabled = gt;
            bt_xoa.Enabled = gt;
            bt_thoat.Enabled = gt;
        }
        private void bt_tkSim_Click(object sender, EventArgs e)
        {
            if (bt_tkSim.Text == "Thống kê")
            {
                bt_tkSim.Text = "In";
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
                thangcx = txt_thang.Text;
                frmThongKeSim frmtkS = new frmThongKeSim();
                frmtkS.Show();
                bt_tkSim.Text = "Thống kê";
                vhh(true);
                txt_thang.Enabled = false;
                txt_thang.ResetText();
            }
        }

        private void bt_chon_Click(object sender, EventArgs e)
        {
            bds.AddNew();
            luoi_mbs.CurrentRow.Cells[1].Value = cb_mas.Text;
            luoi_mbs.CurrentRow.Cells[0].Value = frm_Khachhang.makh;
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            string ma = luoi_mbs.CurrentRow.Cells[0].Value.ToString();
            string ma2 = luoi_mbs.CurrentRow.Cells[1].Value.ToString();
            MuaBanSim mbs = new MuaBanSim();
            mbs.Makh = luoi_mbs.CurrentRow.Cells[0].Value.ToString();
            mbs.MaS = luoi_mbs.CurrentRow.Cells[1].Value.ToString();
            mbs.NgayMuaBan = DateTime.Parse(luoi_mbs.CurrentRow.Cells[2].Value.ToString());
            var qr = db.KhachHangs.Where(d => d.Makh == ma);
            if (qr.Count() == 0)
            {
                MessageBox.Show("mã khách hàng phải có trong bảng khách hàng", "Thông báo");
            }
            else
            {
                //var qr2 = db.MuaBanSims.Where(a => a.Makh == ma && a.MaS == ma2 || a.Sim.TinhTrang =="Đã Bán");
                if (txt_tts.Text == "Đã bán")
                {
                    MessageBox.Show("Sim này đã được bán, vui lòng chọn sim khác", "Thông báo");
                }
                else
                {
                    var qr3 = db.Sims.Where(t => t.MaS == ma2);
                    if (qr3.Count() != 0) qr3.FirstOrDefault().TinhTrang = "Đã Bán";
                    db.MuaBanSims.Add(mbs);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thông tin bán sim mới thành công", "Thông báo", MessageBoxButtons.OK);
                    load_mbs();
                    cb_mas_SelectedIndexChanged(sender, e);
                }
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (luoi_mbs.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int i;
                    for (i = 0; i < luoi_mbs.Rows.Count; i++)
                    {
                        if (luoi_mbs.Rows[i].Selected)
                        {
                            string ma = luoi_mbs.Rows[i].Cells[0].Value.ToString();
                            var qr = from s in db.KhachHangs where s.Makh == ma select s;
                            db.KhachHangs.Remove(qr.FirstOrDefault());
                            db.SaveChanges();
                        }
                    }
                    load_mbs();
                    MessageBox.Show("xóa thành công");
                }
            }
            else
            {
                MessageBox.Show("chọn bản ghi cần xóa", "Thông báo");
            }
        }

        private void cb_mas_SelectedIndexChanged(object sender, EventArgs e)
        {
            var qr = db.Sims.Where(d => d.MaS == cb_mas.Text.Trim()).ToList();
            txt_tnm.DataBindings.Clear();
            txt_tnm.DataBindings.Add("Text", qr, "TenNhaMang");
            txt_nkh.DataBindings.Clear();
            txt_nkh.DataBindings.Add("Text", qr, "NgayKichHoat");
            txt_ss.DataBindings.Clear();
            txt_ss.DataBindings.Add("Text", qr, "SoSim");
            txt_ls.DataBindings.Clear();
            txt_ls.DataBindings.Add("Text", qr, "LoaiSim");
            txt_gs.DataBindings.Clear();
            txt_gs.DataBindings.Add("Text", qr, "GiaSim");
            txt_tts.DataBindings.Clear();
            txt_tts.DataBindings.Add("Text", qr, "TinhTrang");
            txt_gn.DataBindings.Clear();
            txt_gn.DataBindings.Add("Text", qr, "GiaNhap");
        }
    }
}
