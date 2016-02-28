namespace Messaging
{
    public class MessagingService
    {
        public MessagingService(IMessagingProvider messagingProvider)
        {
            _messagingProvider = messagingProvider;
        }

        readonly IMessagingProvider _messagingProvider;
    }
}