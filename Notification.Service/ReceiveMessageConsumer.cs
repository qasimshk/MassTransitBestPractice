using CQRS.Models.Notification;
using MassTransit;
using System;
using System.Threading.Tasks;

namespace Notification.Service
{
    public class ReceiveMessageConsumer : IConsumer<INotification>
    {
        public Task Consume(ConsumeContext<INotification> context)
        {
            Console.WriteLine(context.Message.Message);
            Console.WriteLine(string.Empty);
            return Task.CompletedTask;
        }
    }
}