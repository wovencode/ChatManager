using Mirror;

namespace Insthync.ChatSystem
{
    public class MsgChatReceiveFromServer : MessageBase
    {
        public string channelId = string.Empty;
        public string senderId = string.Empty;
        public string senderName = string.Empty;
        public string message;
    }
}
