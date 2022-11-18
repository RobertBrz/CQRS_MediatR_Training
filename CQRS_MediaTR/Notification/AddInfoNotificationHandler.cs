using MediatR;
using System.Diagnostics;

namespace CQRS_MediaTR.Notification
{
    public class AddInfoNotificationHandler : INotificationHandler<AddInfoNotification>
    {
        public Task Handle(AddInfoNotification notification, CancellationToken cancellationToken)
        {
            Debugger.Log(1, "Info", "printsth");
            return Task.CompletedTask;
        }
    }
}
