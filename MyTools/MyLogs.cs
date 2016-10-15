using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTools
{
    public static class MyLogs
    {
        
        public static void Writelog(string ExString)
        {

        }

        private static void Init()
        {
            string TheBasePath = AppDomain.CurrentDomain.BaseDirectory;
            string LogPath = TheBasePath + "MyLogs";
            string dateTodayfileName = DateTime.Now.ToString("MMMMddyy") + "logs";
            if (!Directory.Exists(LogPath))
                 Directory.CreateDirectory(LogPath);
            DirectoryInfo mylogpath = new DirectoryInfo(LogPath);
            var logfile = mylogpath.GetFiles($"{dateTodayfileName}.txt", SearchOption.AllDirectories).FirstOrDefault() ?? null;
            if (logfile != null)
            {
                if (!File.Exists(LogPath+mylogpath))
                    File.Create(LogPath + mylogpath);
                
            }
        }
        private static int CreateOrLoad()
        {
            try
            {
                int a = 5;
                int b = 0;
                return a / b;
            }
            catch (Exception)
            {
                
                CreateOrLoad();
                throw;
            }
        }
    }
}
