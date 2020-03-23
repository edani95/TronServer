using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Tron.Engine.Common;
using Tron.Engine.Messages.Base;

namespace Tron.Engine.Messages
{
    public class ConnectionStatusMessage
    {
        public ExtendedPlayerId PlayerId { get; set; }

        public ConnectStatus Action { get; set; }
    }
}
