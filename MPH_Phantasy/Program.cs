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

        /* Window制御関数 */
        static void UserControl()
        {
            /* スタート画面を起動 */
            Form f1 = new Form1();
            f1.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(f1);
            ApplicationConfiguration.Initialize();
            
        }

        /* 現時点でのプレイ状況をflushする(セーブ機能) */
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