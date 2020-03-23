using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using Tron.Engine.Common;
using Tron.Engine.Messages.Base;

namespace Tron.Engine.Interfaces
{
    public interface IProtocolCommunicator
    {
        IReceiveProtocolMessage GameEngine { set; }

        Task<bool> SendMessageAsync(ISendableMessage sendableMessage, params PlayerId[] playerIds);

        Task TestConnectionsAsync();
    }
}
