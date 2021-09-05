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
    public partial class frmThongKeSim : Form
    {
        public frmThongKeSim()
        {
            InitializeComponent();
        }

        private void frmThongKeSim_Load(object sender, EventArgs e)
        {
            rpThongkeSim rp = new rpThongkeSim();
            rp.SetParameterValue("thangcx", frmMBSim.thangcx);
            crpThongkeSim.ReportSource = rp;
        }
    }
}
