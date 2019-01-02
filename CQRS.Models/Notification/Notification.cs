namespace CQRS.Models.Notification
{
    public class Notification : INotification
    {
        public string Message { get; set; }
    }
}