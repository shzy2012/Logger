namespace Logger
{
    using System;

    public sealed class LogManager
    {
        private LogWriter log = null;
        public LogManager()
        {
            log = new LogWriter();
        }

        /// <summary>
        /// info
        /// </summary>
        /// <param name="message"></param>
        public void Info(object message)
        {
            if (LogConfig.MaxSizeRollBackups == 0)
            {
                return;
            }

            log.Writer("[Info]: " + message);
        }

        /// <summary>
        /// Error
        /// </summary>
        /// <param name="exception"></param>
        public void Error(Exception exception)
        {
            if (exception == null || LogConfig.MaxSizeRollBackups == 0)
            {
                return;
            }

            log.Writer("[Error]: " + exception);
        }

        /// <summary>
        /// Error
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public void Error(object message, Exception exception)
        {
            if (exception == null || LogConfig.MaxSizeRollBackups == 0)
            {
                return;
            }

            log.Writer("[Error]: " + message, exception);
        }

    }

}
