using System.IO;

namespace MPH_Phantasy
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            UserControl();
        }

        /* Window����֐� */
        static void UserControl()
        {
            /* �X�^�[�g��ʂ��N�� */
            Form f1 = new Form1();
            f1.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(f1);
            ApplicationConfiguration.Initialize();
            
        }

        /* �����_�ł̃v���C�󋵂�flush����(�Z�[�u�@�\) */
        public static void savingProf()
        {
            bool wrTrue = false;
            var fileName = "saveData.txt";

            try
            {
                StreamWriter sw = new StreamWriter("\\Resourses\\saveData.txt");
            }
            catch (IOException ex)
            {

            }
        }

        public static void loadingData()
        {

        }
    }
}