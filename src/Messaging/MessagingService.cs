using System;
using System.Collections.Generic;
using Messaging.Models;

namespace Messaging
{
    public class MessagingService
    {
        public MessagingService(IMessagingProvider messagingProvider)
        {
            _messagingProvider = messagingProvider;
        }

        public void AddUser(Guid user, Guid conversation)
            => _messagingProvider.AddUser(user, conversation);

        public void StartConversation(Guid initiator, Guid recipient, string subject, string message)
            => _messagingProvider.StartConversation(initiator, recipient, subject, message);

        public int UnreadMessageCount(Guid user)
            => _messagingProvider.UnreadMessageCount(user);

        public void SendMessage(Guid user, Guid conversation, string message)
            => _messagingProvider.SendMessage(user, conversation, message);

        public void LeaveConversation(Guid user, Guid conversation)
            => _messagingProvider.LeaveConversation(user, conversation);

        public void ArchiveConversation(Guid user, Guid conversation)
            => _messagingProvider.ArchiveConversation(user, conversation);

        public void Search(string query)
            => _messagingProvider.Search(query);

        public IEnumerable<Conversation> ListConversations(Guid user, ConversationStatus? status = null)
            => _messagingProvider.ListConversations(user, status);

        readonly IMessagingProvider _messagingProvider;
    }
}