using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Tron.Engine.Common;
using Tron.Protocol.Messages.Common;

namespace Tron.Protocol.AutoMapper.Converters
{
    class ConnectionEngineToProtocolConverter : ITypeConverter<ConnectStatus, ConnectState>
    {
        public ConnectState Convert(ConnectStatus source, ConnectState destination, ResolutionContext context)
        {
            return source switch
            {
                ConnectStatus.Connected     => ConnectState.Connect,
                ConnectStatus.Disconnected  => ConnectState.Disconnect,
                _                           => ConnectState.Connect
            };
        }
    }
}
