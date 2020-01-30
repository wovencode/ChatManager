using UnityEngine;

namespace Insthync.ChatSystem
{
    [System.Serializable]
    public class ChatMessage
    {
        public enum ChatState
        {
            Send,
            Receive
        }
        public ChatChannelData channelData;
        public string senderId;
        public string senderName;
        public string message;
        public ChatState chatState;
        public float receiveTime;

        public ChatMessage(ChatChannelData channelData, string senderId, string senderName, string message, ChatState chatState)
        {
            this.channelData = channelData;
            this.senderId = senderId;
            this.senderName = senderName;
            this.message = message;
            this.chatState = chatState;
            this.receiveTime = Time.unscaledTime;
        }

        public string GetMessage()
        {
            string prefix = chatState == ChatState.Send ? channelData.prefixSend : channelData.prefixReceive;
            return "<b>" + prefix + senderName + "</b>: " + message;
        }
    }
}
