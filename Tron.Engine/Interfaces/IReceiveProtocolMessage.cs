using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Tron.Engine.Messages;
using Tron.Engine.Messages.Base;

namespace Tron.Engine.Interfaces
{
    public interface IReceiveProtocolMessage
    {
        void AcceptNewPlayer(ConnectRequestMessage connectRequestMessage);

        void ReceiveMessageFromPlayer(IReceivableMessage receivableMessage);

        void DisconnectPlayer(Color playerId);
    }
}
