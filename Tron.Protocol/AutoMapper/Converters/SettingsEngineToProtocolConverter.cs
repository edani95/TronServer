using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using EngineCommon = Tron.Engine.Common;
using ProtocolCommon = Tron.Protocol.Messages.Common;

namespace Tron.Protocol.AutoMapper.Converters
{
    class SettingsEngineToProtocolConverter : ITypeConverter<EngineCommon.GameSettings, ProtocolCommon.Setting>
    {
        public ProtocolCommon.Setting Convert(EngineCommon.GameSettings source, ProtocolCommon.Setting destination, ResolutionContext context)
        {
            destination ??= new ProtocolCommon.Setting();

            destination.Countdown = source.Countdown;
            destination.Width = source.LogicalWidth;
            destination.Height = source.LogicalHeight;
            destination.Speed = source.SpeedMs;
            foreach(var playerPosition in source.StartPositionWithIds)
            {
                var playerPositionDto = new ProtocolCommon.Position
                {
                    CoordinateX = playerPosition.Value.CoordX,
                    CoordinateY = playerPosition.Value.CoordY,
                    Direction = context.Mapper.Map<ProtocolCommon.Direction>(playerPosition.Value.Direction),
                    PositionId = playerPosition.Key
                };
                destination.StartPositions.Add(playerPositionDto);
            }

            return destination;
        }
    }
}
