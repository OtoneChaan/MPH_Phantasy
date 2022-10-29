namespace MPH_Phantasy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* 今の画面は閉じる */
            this.Visible = false;

            /* プレイ画面表示 */
            Form playWin = new playWindow();
            /* 中央に表示する */
            playWin.StartPosition = FormStartPosition.CenterScreen;
            playWin.Show();
        }
    }
}