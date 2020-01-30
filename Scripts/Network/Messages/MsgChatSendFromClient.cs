using Mirror;

namespace Insthync.ChatSystem
{
    public class MsgChatSendFromClient : MessageBase
    {
        public string channelId = string.Empty;
        public string[] chatData;
    }
}
