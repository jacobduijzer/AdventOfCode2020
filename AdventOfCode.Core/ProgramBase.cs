using System.Diagnostics;

namespace AdventOfCode.Core
{
    public abstract class ProgramBase
    {
        private readonly ILogger _logger;

        protected ProgramBase() => _logger = new Logger();

        protected void LogMessage(string message) =>
            _logger.Log($"{this.GetType().Name}: {new StackTrace().GetFrame(1).GetMethod().Name}: {message}");

        public abstract void RunExercise1();

        public abstract void RunExercise2();
    }
}