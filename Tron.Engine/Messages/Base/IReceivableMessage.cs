using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Tron.Engine.Messages.Base
{
    public interface IReceivableMessage
    {
        Color? PlayerId { get; set; }
    }
}
