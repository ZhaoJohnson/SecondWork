using System;
using System.IO;
using System.Linq;
using System.Text;

namespace MyTools
{
    public static class MyLog
    {
        private static StringBuilder _txtBuilder;
        public static void OutputAndSaveTxt(string message)
        {
            Console.WriteLine(message);
            _txtBuilder.AppendLine(message);

        }
        public static void SaveEx(string message )
        {
            Console.WriteLine(message);
            string TheBasePath = AppDomain.CurrentDomain.BaseDirectory;
            string LogPath = TheBasePath + "MyLogs";
            string dateTodayfileName = DateTime.Now.ToString("mmmm_dd_yyyy") + "logs.txt";
            if (!Directory.Exists(LogPath))
                Directory.CreateDirectory(LogPath);
            DirectoryInfo mylogpath = new DirectoryInfo(LogPath);
            var FullPath = Path.Combine(LogPath, dateTodayfileName);
            
            FileStream myfs = new FileStream(FullPath, FileMode.OpenOrCreate);
            using (StreamWriter mysw = new StreamWriter(myfs))
            {
                mysw.WriteLine(message);
                mysw.Flush();
                mysw.Close();
                myfs.Close();
            }
        }

        public static void SaveEnd()
        {
            string LogPath = AppDomain.CurrentDomain.BaseDirectory;
            string logFileNmae = "Log_" + DateTime.Today.ToString("MMddyyyy") + ".txt";
            string FullPath = Path.Combine(LogPath, logFileNmae);
            StreamWriter writer = null;

            FileStream myfs = new FileStream(FullPath, FileMode.OpenOrCreate);
            using (StreamWriter mysw = new StreamWriter(myfs))
            {
                mysw.WriteLine(_txtBuilder.ToString());
                mysw.Flush();
                mysw.Close();
                myfs.Close();
            }
        }
    }
}