namespace Doan_QLMBST_PHH
{
    partial class frmThongKeSim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crpThongkeSim = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crpThongkeSim
            // 
            this.crpThongkeSim.ActiveViewIndex = -1;
            this.crpThongkeSim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpThongkeSim.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpThongkeSim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpThongkeSim.Location = new System.Drawing.Point(0, 0);
            this.crpThongkeSim.Name = "crpThongkeSim";
            this.crpThongkeSim.Size = new System.Drawing.Size(912, 582);
            this.crpThongkeSim.TabIndex = 0;
            // 
            // frmThongKeSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 582);
            this.Controls.Add(this.crpThongkeSim);
            this.Name = "frmThongKeSim";
            this.Text = "frmThongKeSim";
            this.Load += new System.EventHandler(this.frmThongKeSim_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpThongkeSim;
    }
}