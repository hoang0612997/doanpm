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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        QL_SimTheEntities db = new QL_SimTheEntities();
        private void btdangnhap_Click(object sender, EventArgs e)
        {
            if (txttk.Text == "" && txtmk.Text != "")
            {
                MessageBox.Show("Bạn chưa điền thông tin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtmk.Text == "" && txttk.Text != "")
            {
                MessageBox.Show("Bạn chưa điền mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txttk.Text == "" && txtmk.Text == "")
            {
                MessageBox.Show("Chưa điền tài khoản & mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtmk.Text != "" && txttk.Text != "")
            {
                var qr = from d in db.taikhoans
                         where d.taikhoan1 == txttk.Text && d.matkhau == txtmk.Text
                         select d;
                if (qr.Count() == 0)
                {
                    MessageBox.Show("Tên đăng nhập không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttk.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    frmMenu fr = new frmMenu();
                    fr.Show();
                    this.Hide();
                }
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
