using MediatR;
using System.Diagnostics;

namespace CQRS_MediaTR.Notification
{
    public class NewnotificationHandler : INotificationHandler<AddInfoNotification>
    {
        public Task Handle(AddInfoNotification notification, CancellationToken cancellationToken)
        {
            Debugger.Log(1, "Info", "new notificaiotn handelr");
            return Task.CompletedTask;
        }
    }
}
