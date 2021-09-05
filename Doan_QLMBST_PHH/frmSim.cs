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
    public partial class frmSim : Form
    {
        public frmSim()
        {
            InitializeComponent();
        }
        QL_SimTheEntities db = new QL_SimTheEntities();
        void load_cb()
        {
            var qr = db.Sims.Select(s => s.TenNhaMang).Distinct().ToList();
            cb_tnm.DataSource = qr;
            cb_tnm.DisplayMember = "TenNhaMang";
        }
        void load_luoi()
        {
            var qr = db.Sims.ToList();

            luoi_s.DataSource = qr;
            luoi_s.Columns[8].Visible = false;
            luoi_s.Columns[9].Visible = false;
        }
        private void frmSim_Load(object sender, EventArgs e)
        {
            load_cb();
            load_luoi();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if(bt_them.Text == "Thêm")
            {
                bt_them.Text = "Lưu";
                bds.AddNew();
                luoi_s.CurrentRow.Cells[1].Value = cb_tnm.Text;

            }
            else
            {
                Sim s = new Sim();
                string ma = luoi_s.CurrentRow.Cells[0].Value.ToString();
                var qr = from d in db.Sims where d.MaS == ma select d;
                if (qr.Count() != 0)
                {
                    MessageBox.Show("Trùng mã sim, vui lòng nhập lại", "Thông báo");
                }
                else
                {
                    s.MaS = luoi_s.CurrentRow.Cells[0].Value.ToString();
                    s.TenNhaMang = luoi_s.CurrentRow.Cells[1].Value.ToString();
                    s.NgayKichHoat = DateTime.Parse(luoi_s.CurrentRow.Cells[2].Value.ToString());
                    s.SoSim = luoi_s.CurrentRow.Cells[3].Value.ToString();
                    s.LoaiSim = luoi_s.CurrentRow.Cells[4].Value.ToString();
                    s.GiaSim = int.Parse(luoi_s.CurrentRow.Cells[5].Value.ToString());
                    s.TinhTrang = "Còn hàng";
                    s.GiaNhap = int.Parse(luoi_s.CurrentRow.Cells[7].Value.ToString());
                    db.Sims.Add(s);
                    db.SaveChanges();
                    MessageBox.Show("Thêm sim mới thành công", "Thông báo", MessageBoxButtons.OK);
                    bt_them.Text = "Thêm";
                    load_luoi();
                }
            }
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            var qr = db.Sims.Where(s => s.TenNhaMang == cb_tnm.Text);
            bds.DataSource = qr.ToList();
            luoi_s.DataSource = bds;
            luoi_s.Columns[8].Visible = false;
            luoi_s.Columns[9].Visible = false;
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if(bt_sua.Text == "Sửa")
            {
                bt_sua.Text = "Lưu";
                luoi_s.CurrentRow.Cells[0].ReadOnly = true;
            }
            else
            {
                string ma = luoi_s.CurrentRow.Cells[0].Value.ToString();
                var qr = db.Sims.Where(s => s.MaS == ma);
                qr.FirstOrDefault().TenNhaMang = luoi_s.CurrentRow.Cells[1].Value.ToString();
                qr.FirstOrDefault().NgayKichHoat = DateTime.Parse(luoi_s.CurrentRow.Cells[2].Value.ToString());
                qr.FirstOrDefault().SoSim = luoi_s.CurrentRow.Cells[3].Value.ToString();
                qr.FirstOrDefault().LoaiSim = luoi_s.CurrentRow.Cells[4].Value.ToString();
                qr.FirstOrDefault().GiaSim = int.Parse(luoi_s.CurrentRow.Cells[5].Value.ToString());
                qr.FirstOrDefault().TinhTrang = luoi_s.CurrentRow.Cells[6].Value.ToString();
                qr.FirstOrDefault().GiaNhap = int.Parse(luoi_s.CurrentRow.Cells[7].Value.ToString());
                db.SaveChanges();
                MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK);
                bt_sua.Text = "Sửa";
                luoi_s.CurrentRow.Cells[0].ReadOnly = false;
                load_luoi();
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (luoi_s.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int i;
                    for (i = 0; i < luoi_s.Rows.Count; i++)
                    {
                        if (luoi_s.Rows[i].Selected)
                        {
                            string ma = luoi_s.Rows[i].Cells[0].Value.ToString();
                            var qr = from s in db.Sims where s.MaS == ma select s;
                            db.Sims.Remove(qr.FirstOrDefault());
                            db.SaveChanges();
                        }
                    }
                    load_luoi();
                    MessageBox.Show("xóa thành công");
                }
            }
            else
            {
                MessageBox.Show("chọn bản ghi cần xóa", "Thông báo");
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
