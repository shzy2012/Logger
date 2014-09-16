namespace Logger
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class LogWriter
    {
        public LogWriter() { }

        public void Writer(object message)
        {
            try
            {
                StringBuilder logmessage = new StringBuilder();
                logmessage.AppendLine(string.Empty);
                logmessage.AppendLine("--------------------------------------------------------------------------------------------");
                logmessage.AppendLine(string.Format("{0}    {1}", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), message ?? string.Empty));

                var fullpath = CheckLogAndBackPath();
                File.AppendAllText(fullpath, logmessage.ToString(), Encoding.UTF8);
            }
            catch { }
        }


        public void Writer(object message, Exception exception)
        {
            try
            {
                StringBuilder logmessage = new StringBuilder();
                logmessage.AppendLine(string.Empty);
                logmessage.AppendLine("--------------------------------------------------------------------------------------------");
                logmessage.AppendLine(string.Format("{0}    {1}     {2}", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), message ?? string.Empty, " [Exception: " + exception.Message + "]"));
                logmessage.AppendLine(exception.StackTrace);

                var fullpath = CheckLogAndBackPath();
                File.AppendAllText(fullpath, logmessage.ToString(), Encoding.UTF8);
            }
            catch { }
        }

        private string CheckLogAndBackPath()
        {
            var outputpath = Path.Combine(LogConfig.CurrentApplicationPath, LogConfig.LogPath);
            if (!Directory.Exists(outputpath))
            {
                Directory.CreateDirectory(outputpath);
            }

            var fullpath = Path.Combine(outputpath, LogConfig.LogFileName);
            if (!File.Exists(fullpath))
            {
                return fullpath;
            }

            FileInfo fileinfo = new FileInfo(fullpath);
            if (fileinfo.Length / 1024 < LogConfig.MaximumFileSize)
            {
                return fullpath;
            }

            var directory = new DirectoryInfo(outputpath);
            var filecount = directory.GetFiles().Length;
            if (filecount > LogConfig.MaxSizeRollBackups)
            {
                var newest = directory.GetFiles().OrderBy(x => x.LastWriteTime).FirstOrDefault();
                if (newest != null)
                {
                    File.Copy(fullpath, newest.FullName, true);

                    return fullpath;
                }
            }

            File.Move(fullpath, (fullpath + (filecount++).ToString()));

            return fullpath;
        }
    }
}
