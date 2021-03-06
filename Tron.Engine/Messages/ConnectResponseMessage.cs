﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Tron.Engine.Common;
using Tron.Engine.Messages.Base;

namespace Tron.Engine.Messages
{
    public class ConnectResponseMessage
    {
        public Color PlayerId { get; set; }

        public ICollection<PlayerId> Players { get; set; }

        public string LobbyIdentifier { get; set; }

        public GameSettings Settings { get; set; }
    }
}
