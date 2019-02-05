using System;
using System.Threading;
using System.Threading.Tasks;

namespace NetCoreExtensions.Tasks
{
    /// <summary>
    /// Task related methods
    /// </summary>
    public static class TaskExtensions
    {
        /// <summary>
        /// <para>Timeout if the task has not returned results in the specified amount of time.</para>
        /// <para>
        /// Note that the original task will continue running, and can be accessed in the 
        /// exception thrown by this method (in case of timeout).
        /// </para>
        /// <para>Throws a <see cref="TaskTimeoutException"/> if the time has passed.</para>
        /// </summary>
        /// <typeparam name="T">Type of Task return value</typeparam>
        /// <param name="task">The original Task</param>
        /// <param name="timeout">Amount of time to wait for a result</param>
        /// <returns>The value from the original <paramref name="task"/>.</returns>
        public static Task<T> TimeoutAfter<T>(this Task<T> task, TimeSpan timeout)
            => TimeoutAfter(task, timeout, CancellationToken.None);

        /// <summary>
        /// <para>Timeout if the task has not returned results in the specified amount of time.</para>
        /// <para>
        /// Note that the original task will continue running, and can be accessed in the 
        /// exception thrown by this method (in case of timeout).
        /// </para>
        /// <para>Throws a <see cref="TaskTimeoutException"/> if the time has passed.</para>
        /// </summary>
        /// <typeparam name="T">Type of Task return value</typeparam>
        /// <param name="task">The original Task</param>
        /// <param name="millisecondsDelay">Amount of time to wait for a result in milliseconds</param>
        /// <returns>The value from the original <paramref name="task"/>.</returns>
        public static Task<T> TimeoutAfter<T>(this Task<T> task, int millisecondsDelay)
            => TimeoutAfter(task, TimeSpan.FromMilliseconds(millisecondsDelay), CancellationToken.None);

        /// <summary>
        /// <para>
        /// Timeout if the task has not returned results in the specified amount of time,
        /// or if there has been a cancellation.
        /// </para>
        /// <para>
        /// Note that the original task will continue running, and can be accessed in the 
        /// exception thrown by this method (in case of timeout or cancelation).
        /// </para>
        /// <para>
        /// Throws a <see cref="TaskTimeoutException"/> if the time has passed, and
        /// <see cref="TaskCanceledException"/> if the cancellation token was canceled.
        /// </para>
        /// </summary>
        /// <typeparam name="T">Type of Task return value</typeparam>
        /// <param name="task">The original Task</param>
        /// <param name="timeout">Amount of time to wait for a result</param>
        /// <param name="cancellationToken">A token to cancel the task</param>
        /// <returns>The value from the original <paramref name="task"/>.</returns>
        public static async Task<T> TimeoutAfter<T>(this Task<T> task, TimeSpan timeout, CancellationToken cancellationToken)
        {
            var result = await Task.WhenAny(task, Task.Delay(timeout, cancellationToken)).ConfigureAwait(false);
            if (result == task) return await task;

            if (cancellationToken.IsCancellationRequested) throw new TaskCanceledException(task);

            throw new TaskTimeoutException(task, timeout);
        }

        /// <summary>
        /// <para>
        /// Timeout if the task has not returned results in the specified amount of time,
        /// or if there has been a cancellation.
        /// </para>
        /// <para>
        /// Note that the original task will continue running, and can be accessed in the 
        /// exception thrown by this method (in case of timeout or cancelation).
        /// </para>
        /// <para>
        /// Throws a <see cref="TaskTimeoutException"/> if the time has passed, and
        /// <see cref="TaskCanceledException"/> if the cancellation token was canceled.
        /// </para>
        /// </summary>
        /// <typeparam name="T">Type of Task return value</typeparam>
        /// <param name="task">The original Task</param>
        /// <param name="millisecondsDelay">Amount of time to wait for a result in milliseconds</param>
        /// <param name="cancellationToken">A token to cancel the task</param>
        /// <returns>The value from the original <paramref name="task"/>.</returns>
        public static Task<T> TimeoutAfter<T>(this Task<T> task, int millisecondsDelay, CancellationToken cancellationToken)
            => TimeoutAfter(task, TimeSpan.FromMilliseconds(millisecondsDelay), cancellationToken);

        /// <summary>
        /// Timeout if the task has not returned results in the specified amount of time.
        /// Throws a <see cref="TaskTimeoutException"/> if the time has passed.
        /// </summary>
        /// <param name="task">The original Task</param>
        /// <param name="timeout">Amount of time to wait for a result</param>
        public static Task TimeoutAfter(this Task task, TimeSpan timeout)
           => TimeoutAfter(task, timeout, CancellationToken.None);

        /// <summary>
        /// Timeout if the task has not returned results in the specified amount of time.
        /// Throws a <see cref="TaskTimeoutException"/> if the time has passed.
        /// </summary>
        /// <param name="task">The original Task</param>
        /// <param name="millisecondsDelay">Amount of time to wait for a result in milliseconds</param>
        public static Task TimeoutAfter(this Task task, int millisecondsDelay)
           => TimeoutAfter(task, TimeSpan.FromMilliseconds(millisecondsDelay), CancellationToken.None);

        /// <summary>
        /// <para>
        /// Timeout if the task has not returned results in the specified amount of time,
        /// or if there has been a cancellation.
        /// </para>
        /// <para>
        /// Note that the original task will continue running, and can be accessed in the 
        /// exception thrown by this method (in case of timeout or cancelation).
        /// </para>
        /// <para>
        /// Throws a <see cref="TaskTimeoutException"/> if the time has passed, and
        /// <see cref="TaskCanceledException"/> if the cancellation token was canceled.
        /// </para>
        /// </summary>
        /// <param name="task">The original Task</param>
        /// <param name="timeout">Amount of time to wait for a result</param>
        /// <param name="cancellationToken">A token to cancel the task</param>
        public static async Task TimeoutAfter(this Task task, TimeSpan timeout, CancellationToken cancellationToken)
        {
            var result = await Task.WhenAny(task, Task.Delay(timeout, cancellationToken)).ConfigureAwait(false);
            if (result == task) return;

            if (cancellationToken.IsCancellationRequested) throw new TaskCanceledException(task);

            throw new TaskTimeoutException(task, timeout);
        }

        /// <summary>
        /// <para>
        /// Timeout if the task has not returned results in the specified amount of time,
        /// or if there has been a cancellation.
        /// </para>
        /// <para>
        /// Note that the original task will continue running, and can be accessed in the 
        /// exception thrown by this method (in case of timeout or cancelation).
        /// </para>
        /// <para>
        /// Throws a <see cref="TaskTimeoutException"/> if the time has passed, and
        /// <see cref="TaskCanceledException"/> if the cancellation token was canceled.
        /// </para>
        /// </summary>
        /// <param name="task">The original Task</param>
        /// <param name="millisecondsDelay">Amount of time to wait for a result in milliseconds</param>
        /// <param name="cancellationToken">A token to cancel the task</param>
        public static Task TimeoutAfter(this Task task, int millisecondsDelay, CancellationToken cancellationToken)
            => TimeoutAfter(task, TimeSpan.FromMilliseconds(millisecondsDelay), cancellationToken);
    }

}
