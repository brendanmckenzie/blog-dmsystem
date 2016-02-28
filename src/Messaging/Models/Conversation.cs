using System;

namespace Messaging.Models
{
    public enum ConversationStatus
    {
        New,
        Read,
        Archived
    }

    public class Conversation
    {
        public DateTime Created { get; set; }
        public DateTime LastMessage { get; set; }
    }
}