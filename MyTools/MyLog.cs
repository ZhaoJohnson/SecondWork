using System;
using System.IO;
using System.Linq;

namespace MyTools
{
    public static class MyLog
    {
        public static StreamWriter setStream(string LogPath)
        {
            string logFileNmae = "Log_" + DateTime.Today.ToString("MMddyyyy") + ".txt";
            string FullPath = Path.Combine(LogPath, logFileNmae);
            StreamWriter writer = null;

            if (Directory.Exists(LogPath))
            {
                if (File.Exists(FullPath))
                    writer = File.AppendText(FullPath);
                else
                    writer = File.CreateText(FullPath);
            }
            else
            {
                Directory.CreateDirectory(LogPath);
                writer = File.CreateText(FullPath);
            }
            return writer;
        }
        public static void SaveEx(string message )
        {
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
    }
}