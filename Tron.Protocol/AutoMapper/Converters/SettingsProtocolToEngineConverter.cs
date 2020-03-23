using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using EngineCommon = Tron.Engine.Common;
using ProtocolCommon = Tron.Protocol.Messages.Common;

namespace Tron.Protocol.AutoMapper.Converters
{
    class SettingsProtocolToEngineConverter : ITypeConverter<ProtocolCommon.Setting, EngineCommon.GameSettings>
    {
        public EngineCommon.GameSettings Convert(ProtocolCommon.Setting source, EngineCommon.GameSettings destination, ResolutionContext context)
        {
            destination ??= new EngineCommon.GameSettings();

            destination.Countdown = source.Countdown;
            destination.LogicalWidth = source.Width;
            destination.LogicalHeight = source.Height;
            destination.SpeedMs = source.Speed;
            destination.StartPositionWithIds ??= new Dictionary<int, EngineCommon.Position>();
            foreach(var playerPosition in source.StartPositions)
            {
                var playerPositionDto = new EngineCommon.Position
                {
                    CoordX = playerPosition.CoordinateX,
                    CoordY = playerPosition.CoordinateY,
                    Direction = context.Mapper.Map<EngineCommon.Direction>(playerPosition.Direction),
                };
                destination.StartPositionWithIds.Add(playerPosition.PositionId, playerPositionDto);
            }

            return destination;
        }
    }
}
