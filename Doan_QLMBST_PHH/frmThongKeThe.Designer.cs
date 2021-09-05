namespace Doan_QLMBST_PHH
{
    partial class frmThongKeThe
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
            this.crpThongke = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crpThongke
            // 
            this.crpThongke.ActiveViewIndex = -1;
            this.crpThongke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpThongke.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpThongke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpThongke.Location = new System.Drawing.Point(0, 0);
            this.crpThongke.Name = "crpThongke";
            this.crpThongke.Size = new System.Drawing.Size(962, 767);
            this.crpThongke.TabIndex = 0;
            // 
            // frmThongKeThe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 767);
            this.Controls.Add(this.crpThongke);
            this.Name = "frmThongKeThe";
            this.Text = "frmThongKeThe";
            this.Load += new System.EventHandler(this.frmThongKeThe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpThongke;
    }
}