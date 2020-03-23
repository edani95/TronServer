using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using EngineCommon = Tron.Engine.Common;
using ProtocolCommon = Tron.Protocol.Messages.Common;

namespace Tron.Protocol.AutoMapper.Converters
{
    class DirectionProtocolToEngineConverter : ITypeConverter<ProtocolCommon.Direction, EngineCommon.Direction>
    {
        public EngineCommon.Direction Convert(ProtocolCommon.Direction source, EngineCommon.Direction destination, ResolutionContext context)
        {
            return source switch
            {
                ProtocolCommon.Direction.Up     => EngineCommon.Direction.Up,
                ProtocolCommon.Direction.Down   => EngineCommon.Direction.Down,
                ProtocolCommon.Direction.Left   => EngineCommon.Direction.Left,
                ProtocolCommon.Direction.Right  => EngineCommon.Direction.Right,
                _                               => EngineCommon.Direction.Up,
            };
        }
    }
}
