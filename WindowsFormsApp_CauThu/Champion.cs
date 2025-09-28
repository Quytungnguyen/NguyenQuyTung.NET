using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Lib_CauThu;

namespace WindowsFormsApp_CauThu
{
    public partial class Champion : Form
    {
        private Label lblChampionClub;
        private PictureBox pictureBoxChampion;
        private Label lblChampionName;

        public Champion(CauThu winner)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Champion TOTY";

            lblChampionName.Text = $"Chúc mừng: {winner.Ten}";
            lblChampionClub.Text = $"CLB: {winner.CLB.TenCLB} - Quốc tịch: {winner.QuocTich}";

            string imgPath = Path.Combine(
                @"D:\Project\NguyenQuyTung_DotNet\DotNet_Project\WindowsFormsApp_CauThu\Resources",
                Path.GetFileName(winner.Anh));

            if (File.Exists(imgPath))
            {
                pictureBoxChampion.Image = Image.FromFile(imgPath);
                pictureBoxChampion.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void InitializeComponent()
        {
            this.lblChampionName = new System.Windows.Forms.Label();
            this.lblChampionClub = new System.Windows.Forms.Label();
            this.pictureBoxChampion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChampion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChampionName
            // 
            this.lblChampionName.AutoSize = true;
            this.lblChampionName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblChampionName.Location = new System.Drawing.Point(30, 20);
            this.lblChampionName.Name = "lblChampionName";
            this.lblChampionName.Size = new System.Drawing.Size(120, 21);
            this.lblChampionName.TabIndex = 0;
            this.lblChampionName.Text = "Tên cầu thủ";
            // 
            // lblChampionClub
            // 
            this.lblChampionClub.AutoSize = true;
            this.lblChampionClub.Location = new System.Drawing.Point(32, 55);
            this.lblChampionClub.Name = "lblChampionClub";
            this.lblChampionClub.Size = new System.Drawing.Size(70, 15);
            this.lblChampionClub.TabIndex = 1;
            this.lblChampionClub.Text = "CLB + QG";
            // 
            // pictureBoxChampion
            // 
            this.pictureBoxChampion.Location = new System.Drawing.Point(35, 85);
            this.pictureBoxChampion.Name = "pictureBoxChampion";
            this.pictureBoxChampion.Size = new System.Drawing.Size(400, 300);
            this.pictureBoxChampion.TabIndex = 2;
            this.pictureBoxChampion.TabStop = false;
            // 
            // Champion
            // 
            this.ClientSize = new System.Drawing.Size(500, 420);
            this.Controls.Add(this.pictureBoxChampion);
            this.Controls.Add(this.lblChampionClub);
            this.Controls.Add(this.lblChampionName);
            this.Name = "Champion";
            this.ResumeLayout(false);
            this.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChampion)).EndInit();
        }
    }
}
