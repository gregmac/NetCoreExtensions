using NetCoreExtensions.DateTime;
using NetCoreExtensions.Tasks;
using System.Threading.Tasks;
using Shouldly;
using Xunit;
using System;
using System.Threading;

namespace NetCoreExtensions.Tests
{
    public class TaskTests
    {

        [Fact(Timeout = 2000)]
        public void TimeoutAfter_T()
        {
            Should.NotThrow(async () =>
            {
                var result = await NewFastTaskT(42)
                    .TimeoutAfter(Forever);

                result.ShouldBe(42);
            });
        }

        [Fact(Timeout = 2000)]
        public void TimeoutAfter_T_TimeSpan()
        {
            var task = NewLongRunningTaskT(42);
            var ex = Should.Throw<TaskTimeoutException>(async () =>
            {
                await task.TimeoutAfter(FastTimeout);
            });
            ex.Task.ShouldBe(task);
            ex.Timeout.ShouldBe(FastTimeout);
        }

        [Fact(Timeout = 2000)]
        public async void TimeoutAfter_T_Cancelation()
        {
            var cancellation = new CancellationTokenSource(1.Seconds()); // automatically cancel after 1s

            var task = NewLongRunningTaskT(42);

            var ex = await Record.ExceptionAsync(async () =>
            {
                await task.TimeoutAfter(Forever, cancellation.Token);
            });

            ex.ShouldBeOfType<TaskCanceledException>();
            ((TaskCanceledException)ex).Task.ShouldBe(task);
        }


        [Fact(Timeout = 2000)]
        public void TimeoutAfter()
        {
            Should.NotThrow(async () =>
            {
                await NewFastTask()
                    .TimeoutAfter(Forever);
            });
        }

        [Fact(Timeout = 2000)]
        public void TimeoutAfter_TimeSpan()
        {
            var task = NewLongRunningTask();
            var ex = Should.Throw<TaskTimeoutException>(async () =>
            {
                await task.TimeoutAfter(FastTimeout);
            });
            ex.Task.ShouldBe(task);
            ex.Timeout.ShouldBe(FastTimeout);
        }

        [Fact(Timeout = 2000)]
        public async void TimeoutAfter_Cancelation()
        {
            var cancellation = new CancellationTokenSource(1.Seconds()); // automatically cancel after 1s

            var task = NewLongRunningTask();

            var ex = await Record.ExceptionAsync(async () =>
            {
                await task.TimeoutAfter(Forever, cancellation.Token);
            });

            ex.ShouldBeOfType<TaskCanceledException>();
            ((TaskCanceledException)ex).Task.ShouldBe(task);
        }

        /// <summary>
        /// Fast Timeout value for testing (200ms)
        /// </summary>
        private TimeSpan FastTimeout = 200.Milliseconds();

        /// <summary>
        /// A value so long that it will never return (in context of unit tests) (1hr)
        /// </summary>
        private TimeSpan Forever = 1.Hours();

        /// <summary>
        /// Task that returns in 10 milliseconds
        /// </summary>
        private async Task<int> NewFastTaskT(int returnValue)
        {
            await Task.Delay(10.Milliseconds());
            return returnValue;
        }

        /// <summary>
        /// Task that returns in 1 minute
        /// </summary>
        private async Task<int> NewLongRunningTaskT(int returnValue)
        {
            await Task.Delay(1.Minutes());
            return returnValue;
        }

        /// <summary>
        /// Task that returns in 10 milliseconds
        /// </summary>
        private Task NewFastTask() => Task.Delay(10.Milliseconds());

        /// <summary>
        /// Task that returns in 1 minute
        /// </summary>
        private Task NewLongRunningTask() => Task.Delay(1.Minutes());

    }
}
