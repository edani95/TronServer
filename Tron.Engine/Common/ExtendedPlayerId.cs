using System;
using System.Collections.Generic;
using System.Text;

namespace Tron.Engine.Common
{
    public class ExtendedPlayerId : PlayerId
    {
        public string Name { get; set; }

        public bool IsReady { get; set; }
    }
}
