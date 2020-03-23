﻿using System;
using System.Collections.Generic;
 using System.Drawing;
using System.Text;
using Tron.Engine.Interfaces;
using Tron.Engine.Messages;
using Tron.Engine.Messages.Base;

namespace Tron.Engine
{
    public class Game : IReceiveProtocolMessage
    {
        private readonly IProtocolCommunicator protocolCommunicator;


        public Game(IProtocolCommunicator protocolCommunicator)
        {
            this.protocolCommunicator = protocolCommunicator;
            this.protocolCommunicator.GameEngine = this;
        }

        public bool AcceptNewPlayer(ConnectRequestMessage connectRequestMessage, out ConnectResponseMessage responseMessage)
        {
            throw new NotImplementedException();
        }

        public void DisconnectPlayer(Color playerId)
        {
            throw new NotImplementedException();
        }

        public void ReceiveMessageFromPlayer(IReceivableMessage receivableMessage)
        {
            throw new NotImplementedException();
        }
    }
}
