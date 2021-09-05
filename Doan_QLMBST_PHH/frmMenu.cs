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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void cácSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cậpNhậtThôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Khachhang f1 = new frm_Khachhang();
            f1.Show();
        }

        private void simToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSim fs = new frmSim();
            fs.Show();
        }

        private void thẻToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThe ft = new frmThe();
            ft.Show();
        }

        private void muabánSimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMBSim fmbs = new frmMBSim();
            fmbs.Show();
        }

        private void muabánThẻToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMuaBanThe fmbt = new frmMuaBanThe();
            fmbt.Show();
        }

        private void thốngKêDoanhThuBánThẻToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMuaBanThe fmbt = new frmMuaBanThe();
            fmbt.Show();
        }

        private void thốngKêDoanhThuBánSimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMBSim fmbs = new frmMBSim();
            fmbs.Show();
        }

        private void thốngKêTổngDoanhThuBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void tìmKiếmKháchHàngĐãMuaTạiCửaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {

                Application.Exit();
            }
        }
    }
}
