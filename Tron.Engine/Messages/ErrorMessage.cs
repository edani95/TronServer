using System;
using System.Collections.Generic;
using System.Text;
using Tron.Engine.Common;
using Tron.Engine.Messages.Base;

namespace Tron.Engine.Messages
{
    public class ErrorMessage
    {
        public ErrorType Type { get; set; }

        public string Message { get; set; }
    }
}
