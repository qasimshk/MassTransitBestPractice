using CQRS.Models.Payment;
using MassTransit;
using Payment.Service.Commands;
using Payment.Service.Helper;
using System;
using System.Threading.Tasks;

namespace Payment.Service.Consumes
{
    public class CollectionPaymentConsumer : IConsumer<IPayment>
    {
        private readonly Messages _messages;

        public CollectionPaymentConsumer(Messages messages)
        {
            _messages = messages;
        }

        public async Task Consume(ConsumeContext<IPayment> context)
        {
            var res = await _messages.DispatchAsync(new CollectPaymentCommand
            {
                StudentId = context.Message.StudentId,
                Amount = context.Message.Amount,
                CourseName = context.Message.CourseName,
                TransactionDate = context.Message.TransactionDate
            });

            if (!res.IsSuccessful)
                Console.WriteLine(res.ResponseMessage);
            else
                Console.WriteLine("Payment collected successfully");
        }
    }
}