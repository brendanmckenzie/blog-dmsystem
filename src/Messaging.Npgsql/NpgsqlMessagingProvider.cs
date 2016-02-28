using System;
using System.Collections.Generic;
using Messaging.Models;

namespace Messaging.Npgsql
{
    public class NpgsqlMessagingProvider : IMessagingProvider
    {
        public void AddUser(Guid user, Guid conversation)
        {
            throw new NotImplementedException();
        }

        public void ArchiveConversation(Guid user, Guid conversation)
        {
            throw new NotImplementedException();
        }

        public void LeaveConversation(Guid user, Guid conversation)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Conversation> ListConversations(Guid user, ConversationStatus? status = null)
        {
            throw new NotImplementedException();
        }

        public void Search(string query)
        {
            throw new NotImplementedException();
        }

        public void SendMessage(Guid user, Guid conversation, string message)
        {
            throw new NotImplementedException();
        }

        public void StartConversation(Guid initiator, Guid recipient, string subject, string message)
        {
            throw new NotImplementedException();
        }

        public int UnreadMessages(Guid user)
        {
            throw new NotImplementedException();
        }
    }
}