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
    public partial class frmThe : Form
    {
        public frmThe()
        {
            InitializeComponent();
        }
        QL_SimTheEntities db = new QL_SimTheEntities();
        void load_cb()
        {
            var qr = db.Thes.Select(s => s.TenNhaMang).Distinct().ToList();
            cb_nm.DataSource = qr;
            cb_nm.DisplayMember = "TenNhaMang";
        }
        void load_luoi()
        {
            var qr = db.Thes.ToList();

            luoi_the.DataSource = qr;
            luoi_the.Columns[5].Visible = false;
            luoi_the.Columns[6].Visible = false;
        }
        private void frmThe_Load(object sender, EventArgs e)
        {
            load_cb();
            load_luoi();
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            var qr = db.Thes.Where(s => s.TenNhaMang == cb_nm.Text);
            bds.DataSource = qr.ToList();
            luoi_the.DataSource = bds;
            luoi_the.Columns[5].Visible = false;
            luoi_the.Columns[6].Visible = false;
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (bt_them.Text == "Thêm thẻ mới")
            {
                bt_them.Text = "Lưu";
                bds.AddNew();
                luoi_the.CurrentRow.Cells[1].Value = cb_nm.Text;


            }
            else
            {
                The t = new The();
                string ma = luoi_the.CurrentRow.Cells[0].Value.ToString();
                var qr = from d in db.Thes where d.MaThe == ma select d;
                if (qr.Count() != 0)
                {
                    qr.FirstOrDefault().SoLuong = qr.FirstOrDefault().SoLuong + int.Parse(luoi_the.CurrentRow.Cells[3].Value.ToString());
                    db.SaveChanges();
                    MessageBox.Show("Cập nhật thẻ mới thành công", "Thông báo", MessageBoxButtons.OK);
                    bt_them.Text = "Thêm thẻ mới";
                    load_luoi();
                }
                else
                {
                    t.MaThe = luoi_the.CurrentRow.Cells[0].Value.ToString();
                    t.TenNhaMang = luoi_the.CurrentRow.Cells[1].Value.ToString();
                    t.MenhGia = int.Parse(luoi_the.CurrentRow.Cells[2].Value.ToString());
                    t.SoLuong = int.Parse(luoi_the.CurrentRow.Cells[3].Value.ToString());
                    t.GiaNhap = int.Parse(luoi_the.CurrentRow.Cells[4].Value.ToString());
                    db.Thes.Add(t);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thẻ mới thành công", "Thông báo", MessageBoxButtons.OK);
                    bt_them.Text = "Thêm thẻ mới";
                    load_luoi();
                }
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (bt_sua.Text == "Sửa")
            {
                bt_sua.Text = "Lưu";
                luoi_the.CurrentRow.Cells[0].ReadOnly = true;
            }
            else
            {
                string ma = luoi_the.CurrentRow.Cells[0].Value.ToString();
                var qr = db.Thes.Where(s => s.MaThe == ma);
                qr.FirstOrDefault().TenNhaMang = luoi_the.CurrentRow.Cells[1].Value.ToString();
                qr.FirstOrDefault().MenhGia = int.Parse(luoi_the.CurrentRow.Cells[2].Value.ToString());
                qr.FirstOrDefault().SoLuong = int.Parse(luoi_the.CurrentRow.Cells[3].Value.ToString());
                qr.FirstOrDefault().GiaNhap = int.Parse(luoi_the.CurrentRow.Cells[4].Value.ToString());
                db.SaveChanges();
                MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK);
                bt_sua.Text = "Sửa";
                luoi_the.CurrentRow.Cells[0].ReadOnly = false;
                load_luoi();
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (luoi_the.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int i;
                    for (i = 0; i < luoi_the.Rows.Count; i++)
                    {
                        if (luoi_the.Rows[i].Selected)
                        {
                            string ma = luoi_the.Rows[i].Cells[0].Value.ToString();
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
