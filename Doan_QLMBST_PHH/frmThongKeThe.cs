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
    public partial class frmThongKeThe : Form
    {
        public frmThongKeThe()
        {
            InitializeComponent();
        }

        private void frmThongKeThe_Load(object sender, EventArgs e)
        {
            rpThongkeThe rp = new rpThongkeThe();
            rp.SetParameterValue("thangcx", frmMuaBanThe.thangcx);
            crpThongke.ReportSource = rp;
        }
    }
}
