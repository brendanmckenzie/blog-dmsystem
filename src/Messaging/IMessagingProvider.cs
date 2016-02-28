using System;
using System.Collections.Generic;
using Messaging.Models;

namespace Messaging
{
    public interface IMessagingProvider
    {
        void StartConversation(Guid initiator, Guid recipient, string subject, string message);

        int UnreadMessages(Guid user);

        void SendMessage(Guid user, Guid conversation, string message);

        void LeaveConversation(Guid user, Guid conversation);

        void ArchiveConversation(Guid user, Guid conversation);

        void Search(string query);

        IEnumerable<Conversation> ListConversations(Guid user, ConversationStatus? status = null);

        void AddUser(Guid user, Guid conversation);
    }
}