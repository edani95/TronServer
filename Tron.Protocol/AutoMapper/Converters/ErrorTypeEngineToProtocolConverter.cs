using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Tron.Engine.Common;
using Tron.Protocol.Messages.Common;

namespace Tron.Protocol.AutoMapper.Converters
{
    class ErrorTypeEngineToProtocolConverter : ITypeConverter<ErrorType, ErrorCode>
    {
        public ErrorCode Convert(ErrorType source, ErrorCode destination, ResolutionContext context)
        {
            return source switch
            {
                ErrorType.NotExistingLobby  => ErrorCode.NotExistingLobby,
                _                           => ErrorCode.Other
            };
        }
    }
}
