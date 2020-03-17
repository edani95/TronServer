using System;
using System.Collections.Generic;
using System.Text;
using Tron.Engine.Common;
using Tron.Engine.Messages.Base;

namespace Tron.Engine.Messages
{
    public class TickMessage
    {
        public int? Countdown { get; set; }

        public ICollection<Change> Changes { get; set; }

        public bool IsLastTick { get; set; }
    }
}
