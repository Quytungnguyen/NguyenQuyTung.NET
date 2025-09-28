using System;
using System.Windows.Forms;

namespace WindowsFormsApp_CauThu
{
    public partial class SplashForm : Form
    {
        Timer timer;
        int progress = 0;

        public SplashForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None; // không viền
            this.TopMost = true;

            // setup timer cho progress bar
            timer = new Timer();
            timer.Interval = 50; // 50ms
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        // Khi click vào label thì vào Menu ngay
        private void lblAppName_Click(object sender, EventArgs e)
        {
            GoToMenu();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progress += 2;
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = Math.Min(progress, 100);
            }
            else
            {
                timer.Stop();
                GoToMenu();
            }
        }

        private void GoToMenu()
        {
            this.Hide();
            Menu mainForm = new Menu();
            mainForm.FormClosed += (s, args) => this.Close(); // đóng splash khi Menu đóng
            mainForm.Show();
        }
    }
}
