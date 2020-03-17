using System;
using System.Collections.Generic;
using System.Text;
using Tron.Engine.Interfaces;

namespace Tron.Engine
{
    public class Game
    {
        private readonly IProtocolCommunicator protocolCommunicator;


        public Game(IProtocolCommunicator protocolCommunicator)
        {
            this.protocolCommunicator = protocolCommunicator;
        }
    }
}
