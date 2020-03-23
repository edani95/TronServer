using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Tron.Engine.Messages;
using Tron.Protocol.AutoMapper.Converters;
using Tron.Protocol.Messages;
using EngineCommon = Tron.Engine.Common;
using ProtocolCommon = Tron.Protocol.Messages.Common;

namespace Tron.Protocol.AutoMapper
{
    class AMProfile : Profile
    {
        public AMProfile()
        {
            // Common
            CreateMap<System.Drawing.Color, ProtocolCommon.Color>()
                .ForMember(c => c.Rgb, config =>
                {
                    config.MapFrom(c => $"#{c.R:X2}{c.G:X2}{c.B:X2}");
                });
            CreateMap<ProtocolCommon.Color, System.Drawing.Color>()
                .ForMember(c => c, config =>
                {
                    config.MapFrom(c => System.Drawing.ColorTranslator.FromHtml(c.Rgb));
                });
            CreateMap<ProtocolCommon.Direction, EngineCommon.Direction>()
                .ConvertUsing<DirectionProtocolToEngineConverter>();
            CreateMap<EngineCommon.Direction, ProtocolCommon.Direction>()
                .ConvertUsing<DirectionEngineToProtocolConverter>();
            CreateMap<EngineCommon.ConnectStatus, ProtocolCommon.ConnectState>()
                .ConvertUsing<ConnectionEngineToProtocolConverter>();
            CreateMap<EngineCommon.ExtendedPlayerId, ProtocolCommon.Player>()
                .ForMember(p => p.Color, config =>
                {
                    config.MapFrom(epi => epi.Id);
                });
            CreateMap<EngineCommon.Change, ProtocolCommon.Change>()
                .ForMember(c => c.Color, config =>
                {
                    config.MapFrom(c => c.PlayerId);
                })
                .ForMember(c => c.Dead, config =>
                {
                    config.MapFrom(c => c.IsDead);
                });
            CreateMap<ProtocolCommon.Change, EngineCommon.Change>()
                .ForMember(c => c.PlayerId, config =>
                {
                    config.MapFrom(c => c.Color);
                })
                .ForMember(c => c.IsDead, config =>
                {
                    config.MapFrom(c => c.Dead);
                });
            CreateMap<EngineCommon.GameSettings, ProtocolCommon.Setting>()
                .ConvertUsing<SettingsEngineToProtocolConverter>();
            CreateMap<ProtocolCommon.Setting, EngineCommon.GameSettings>()
                .ConvertUsing<SettingsProtocolToEngineConverter>();

            // Received by server
            CreateMap<Request, ConnectRequestMessage>()
                .ForMember(crm => crm.LobbyIdentifier, config =>
                {
                    config.MapFrom(r => r.ConnectionGroupId);
                });
            CreateMap<Chat, ChatMessage>()
                .ForMember(cm => cm.PlayerId, config =>
                {
                    config.MapFrom(c => c.Color);
                });
            CreateMap<Ready, ReadyMessage>()
                .ForMember(rm => rm.PlayerId, config =>
                {
                    config.MapFrom(r => r.Color);
                });
            CreateMap<Configure, ConfigureMessage>()
                .ForMember(cm => cm.PlayerId, config =>
                {
                    config.MapFrom(c => c.Color);
                });
            CreateMap<PlayerEvent, PlayerEventMessage>()
                .ForMember(pem => pem.PlayerId, config =>
                {
                    config.MapFrom(pe => pe.Color);
                });

            // Sent by server
            CreateMap<ConnectResponseMessage, Response>()
                .ForMember(r => r.Color, config =>
                {
                    config.MapFrom(crm => crm.PlayerId);
                });
            CreateMap<ChatMessage, Chat>()
                .ForMember(c => c.Color, config =>
                {
                    config.MapFrom(cm => cm.PlayerId);
                });
            CreateMap<ReadyMessage, Ready>()
                .ForMember(r => r.Color, config =>
                {
                    config.MapFrom(rm => rm.PlayerId);
                });
            CreateMap<ConfigureMessage, Configure>()
                .ForMember(c => c.Color, config =>
                {
                    config.MapFrom(cm => cm.PlayerId);
                });
            CreateMap<ConnectionStatusMessage, Connection>();
            CreateMap<StartGameMessage, Start>()
                .ConvertUsing<StartGameToStartConverter>();
            CreateMap<TickMessage, Tick>()
                .ConvertUsing<TickMessageToTickConverter>();
            CreateMap<PlayerEventMessage, PlayerEvent>()
                .ForMember(pe => pe.Color, config =>
                {
                    config.MapFrom(pem => pem.PlayerId);
                });
        }
    }
}
