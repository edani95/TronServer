using System;
using System.Collections.Generic;
using System.Text;
using Tron.Engine.Common;
using Tron.Engine.Messages;
using Tron.Engine.Messages.Base;

namespace Tron.Engine.Interfaces
{
    public interface IReceiveProtocolMessage
    {
        bool TryAcceptNewPlayer(ConnectRequestMessage connectRequestMessage, out ConnectResponseMessage responseMessage);

        void ReceiveMessageFromPlayer(IReceivableMessage receivableMessage);

        void DisconnectPlayer(PlayerId playerId);
    }
}
