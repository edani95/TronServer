using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Tron.Engine.Messages;
using Tron.Protocol.Messages;
using Tron.Protocol.Messages.Common;

namespace Tron.Protocol.AutoMapper.Converters
{
    class StartGameToStartConverter : ITypeConverter<StartGameMessage, Start>
    {
        public Start Convert(StartGameMessage source, Start destination, ResolutionContext context)
        {
            destination ??= new Start();

            foreach(var playerPosition in source.PlayersToPositionIds)
            {
                var playerPositionDto = new PlayerPosition
                {
                    Color = context.Mapper.Map<Color>(playerPosition.Key),
                    PositionId = playerPosition.Value
                };
                destination.PlayerPositions.Add(playerPositionDto);
            }

            return destination;
        }
    }
}
