using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Tron.Engine.Messages.Base;

namespace Tron.Engine.Messages
{
    public class ChatMessage : IReceivableMessage
    {
        public Color? PlayerId { get; set; }

        public string Message { get; set; }
    }
}
