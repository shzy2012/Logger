namespace Logger
{
    using System;

    public class LogConfig
    {
        private static string logPath = "logs";

        private static string logFileName = "log.txt";

        private static long maximumFileSize = 100; //100kb

        private static int maxSizeRollBackups = 5;

        private static string currentApplicationPath = AppDomain.CurrentDomain.BaseDirectory;

        /// <summary>
        /// path of log output
        /// </summary>
        public static string LogPath
        {
            get { return logPath; }
            set { value = logPath; }
        }

        /// <summary>
        /// name of log
        /// </summary>
        public static string LogFileName
        {
            get { return logFileName; }
            set { value = logFileName; }
        }

        /// <summary>
        /// max size of log
        /// </summary>
        public static long MaximumFileSize
        {
            get { return maximumFileSize; }
            set { value = maximumFileSize; }
        }

        /// <summary>
        /// max backup files of log
        /// </summary>
        public static int MaxSizeRollBackups
        {
            get { return maxSizeRollBackups; }
            set { value = maxSizeRollBackups; }
        }

        /// <summary>
        /// current application path
        /// </summary>
        public static string CurrentApplicationPath
        {
            get { return currentApplicationPath; }
        }

    }
}
