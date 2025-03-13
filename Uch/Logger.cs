using Microsoft.Extensions.Logging;

namespace Uch;

internal class Logger
{
    public class FileLoggerProvider : ILoggerProvider
    {
        private readonly string filePath;

        public FileLoggerProvider(string filePath)
        {
            var info = new FileInfo(filePath);
            this.filePath = info.FullName;
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new FileLogger(categoryName, filePath);
        }

        public void Dispose() { }
    }

    public class FileLogger : ILogger, IDisposable
    {
        private readonly string _categoryName;
        private readonly string _filePath;
        static readonly Lock _lock = new();

        public FileLogger(string categoryName, string filePath)
        {
            _filePath = filePath;
            _categoryName = categoryName;
        }

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull
        {
            return this;
        }

        public void Dispose()
        {
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(
            LogLevel logLevel,
            EventId eventId,
            TState state,
            Exception? exception,
            Func<TState, Exception?, string> formatter)
        {
            if (!IsEnabled(logLevel)) return;

            var message = $"[{logLevel}] [{_categoryName}] {formatter(state, exception)}";

            lock (_lock)
            {
                File.AppendAllText(_filePath, message + Environment.NewLine);
            }
        }
    }
}
