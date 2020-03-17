using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Tron.Engine.Common;
using Tron.Engine.Messages.Base;

namespace Tron.Engine.Messages
{
    public class ConfigureMessage : IReceivableMessage
    {
        public Color? PlayerId { get; set; }

        public GameSettings Settings { get; set; }
    }
}
