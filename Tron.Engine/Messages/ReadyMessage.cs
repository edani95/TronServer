using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Tron.Engine.Messages.Base;

namespace Tron.Engine.Messages
{
    public class ReadyMessage : IReceivableMessage
    {
        public Color? PlayerId { get; set; }

        public bool IsReady { get; set; }
    }
}
