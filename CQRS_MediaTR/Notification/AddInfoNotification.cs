using MediatR;

namespace CQRS_MediaTR.Notification
{
    public class AddInfoNotification : INotification
    {
        public string Message { get; set; } = string.Empty;
    }
}
