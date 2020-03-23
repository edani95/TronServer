using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using EngineCommon = Tron.Engine.Common;
using ProtocolCommon = Tron.Protocol.Messages.Common;

namespace Tron.Protocol.AutoMapper.Converters
{
    class DirectionEngineToProtocolConverter : ITypeConverter<EngineCommon.Direction, ProtocolCommon.Direction>
    {
        public ProtocolCommon.Direction Convert(EngineCommon.Direction source, ProtocolCommon.Direction destination, ResolutionContext context)
        {
            return source switch
            {
                EngineCommon.Direction.Up       => ProtocolCommon.Direction.Up,
                EngineCommon.Direction.Down     => ProtocolCommon.Direction.Down,
                EngineCommon.Direction.Left     => ProtocolCommon.Direction.Left,
                EngineCommon.Direction.Right    => ProtocolCommon.Direction.Right,
                _                               => ProtocolCommon.Direction.Up,
            };
        }
    }
}
