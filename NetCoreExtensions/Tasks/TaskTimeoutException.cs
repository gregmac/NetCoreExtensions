using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace NetCoreExtensions.Tasks
{
    /// <summary>
    /// The exception thrown when a task has timed out
    /// </summary>
    [SuppressMessage("Readability", "RCS1194", Justification = "Only use requires a task to be passed")]
    public class TaskTimeoutException : TimeoutException
    {
        /// <summary>
        /// Create a new timeout exception, indicating the task that timed out, and 
        /// the amount of time that has elapsed.
        /// </summary>
        /// <param name="task"></param>
        /// <param name="timeout"></param>
        public TaskTimeoutException(Task task, TimeSpan timeout)
        {
            Task = task;
            Timeout = timeout;
        }

        /// <summary>
        /// The Task that timed out
        /// </summary>
        public Task Task { get; }

        /// <summary>
        /// The timeout that passed
        /// </summary>
        public TimeSpan Timeout { get; }
    }
}
