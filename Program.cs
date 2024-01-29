class Program
{
    static async Task Main(string[] args)
    {
        Task task1 = PrintMessages("Задача 1", 200);
        Task task2 = PrintMessages("Задача 2", 150);
        Task task3 = PrintMessages("Задача 3", 1000);

        await Task.WhenAll(task1, task2, task3);

        Console.WriteLine("Все задачи завершены.");
    }

    static async Task PrintMessages(string taskName, int delay)
    {
        for (int i = 1; i <= 5; i++)
        {
            await Task.Delay(delay);
            Console.WriteLine($"Сообщение от {taskName}, шаг {i} - Поток: {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
