namespace ThreadStartAndEndCompletion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var taskCompletionSource = new TaskCompletionSource<bool>();

            var thread = new Thread(() =>
            {
                Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
                Thread.Sleep(1000);
                taskCompletionSource.TrySetResult(true);
                Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
            });
            
            thread.Start();
            var test = taskCompletionSource.Task.Result;
            Console.WriteLine("Task was done: {0}", test);
        }
    }
}
