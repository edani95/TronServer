using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using Tron.Engine.Messages.Base;

namespace Tron.Engine.Interfaces
{
    public interface IProtocolCommunicator
    {
        void RegisterGameEngine(IReceiveProtocolMessage protocolMessageReceiver);

        Task<bool> SendMessageAsync(ISendableMessage sendableMessage, params Color[] playerIds);

        Task<bool> TestConnectionsAsync();
    }
}
