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
            /* ���̉�ʂ͕��� */
            this.Visible = false;

            /* �v���C��ʕ\�� */
            Form playWin = new playWindow();
            /* �����ɕ\������ */
            playWin.StartPosition = FormStartPosition.CenterScreen;
            playWin.Show();
        }
    }
}