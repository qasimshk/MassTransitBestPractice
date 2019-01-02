namespace CQRS.Models
{
    public sealed class Queues
    {
        // Payments
        public static readonly string PaymentCollect = "Payment.Collect";
        public static readonly string PaymentRefund = "Payment.Refund";

        // Notifications
        public static readonly string Notifications = "Notification.Service";
    }
}
