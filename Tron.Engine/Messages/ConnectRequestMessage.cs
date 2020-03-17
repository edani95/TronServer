using System;
using System.Collections.Generic;
using System.Text;
using Tron.Engine.Common;

namespace Tron.Engine.Messages
{
    public class ConnectRequestMessage
    {
        public string Name { get; set; }

        public string LobbyIdentifier { get; set; }

        public Privacy Privacy { get; set; }
    }
}
