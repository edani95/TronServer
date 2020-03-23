using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Tron.Engine.Messages;
using Tron.Protocol.Messages;
using Tron.Protocol.Messages.Common;

namespace Tron.Protocol.AutoMapper.Converters
{
    class TickMessageToTickConverter : ITypeConverter<TickMessage, Tick>
    {
        public Tick Convert(TickMessage source, Tick destination, ResolutionContext context)
        {
            destination ??= new Tick();

            destination.Countdown = source.Countdown ?? 0;
            destination.LastTick = source.IsLastTick;
            foreach(var change in source.Changes)
            {
                destination.Changes.Add(context.Mapper.Map<Change>(change));
            }

            return destination;
        }
    }
}
