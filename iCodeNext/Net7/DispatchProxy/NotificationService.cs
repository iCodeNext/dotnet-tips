using System;

namespace iCodeNext.Net7;

public interface INotificationService
{
    void Send(string message);
    void CheckDelivery(int messageId);
}

public class NotificationService : INotificationService
{
    public void CheckDelivery(int messageId)
        => Console.WriteLine("Check Delivery");

    public void Send(string message)
    {
        Console.WriteLine(message);
    }
}
