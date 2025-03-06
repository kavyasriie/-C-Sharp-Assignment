using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekly_Assesment2
{
public interface ILogger
    {
        void Log(string message);
    }

    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging to file: {message}");
        }
    }
    public abstract class LoggerDecorator : ILogger
    {
        protected ILogger _logger;

        public LoggerDecorator(ILogger logger)
        {
            _logger = logger;
        }

        public virtual void Log(string message)
        {
            _logger.Log(message);
        }
    }
    public class TimestampLogger : LoggerDecorator
    {
        public TimestampLogger(ILogger logger) : base(logger) { }

        public override void Log(string message)
        {
            string timestampMessage = $"[{DateTime.Now}] {message}";
            base.Log(timestampMessage);
        }
    }
    public class ErrorLogger : LoggerDecorator
    {
        private string _errorType;

        public ErrorLogger(ILogger logger, string errorType) : base(logger)
        {
            _errorType = errorType;
        }

        public override void Log(string message)
        {
            string categorizedMessage = $"[{_errorType}] {message}";
            base.Log(categorizedMessage);
        }
    }

    //class Program
    //{
    //    static void Main()
    //    {
    //        ILogger logger = new FileLogger();

    //        ILogger timestampedLogger = new TimestampLogger(logger);
    //        ILogger categorizedLogger = new ErrorLogger(timestampedLogger, "ERROR");

    //        Console.WriteLine("Standard Logging:");
    //        logger.Log("System started");

    //        Console.WriteLine("\nLogging with Timestamp:");
    //        timestampedLogger.Log("User login successful");

    //        Console.WriteLine("\nLogging with Timestamp and Error Categorization:");
    //        categorizedLogger.Log("Database connection failed");
    //    }
    //}

}