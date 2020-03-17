using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Tron.Engine.Messages.Base;

namespace Tron.Engine.Messages
{
    public class StartGameMessage
    {
        public IDictionary<Color, int> PlayersToPositionIds { get; set; }
    }
}
