using System;
using System.Collections.Generic;
using System.Text;

namespace Tron.Engine.Common
{
    public class GameSettings
    {
        public int LogicalWidth { get; set; }

        public int LogicalHeight { get; set; }

        public int SpeedMs { get; set; }

        public int Countdown { get; set; }

        public IDictionary<int, Position> StartPositionWithIds { get; set; }
    }
}
