using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Google.Protobuf;
using Tron.Engine.Common;
using Tron.Engine.Interfaces;
using Tron.Engine.Messages;
using Tron.Engine.Messages.Base;
using Tron.Protocol.AutoMapper;
using Tron.Protocol.Common;
using Tron.Protocol.Messages;

namespace Tron.Protocol
{
    public class CommunicationService : IProtocolCommunicator, IDisposable
    {
        private readonly IMapper mapper;

        private IReceiveProtocolMessage gameEngine;
        private CancellationTokenSource listenerTaskCancellation;
        private TcpListener tcpListener;
        private ConcurrentDictionary<ClientId, ClientStreams> playerStreams;
        private bool isAlive;
         

        public IReceiveProtocolMessage GameEngine
        {
            set
            {
                gameEngine = value;
            }
        }


        public CommunicationService()
        {
            mapper = new MapperConfiguration(cfg => cfg.AddProfile<AMProfile>())
                .CreateMapper();

            isAlive = true;
            playerStreams = new ConcurrentDictionary<ClientId, ClientStreams>();
            listenerTaskCancellation = new CancellationTokenSource();
            var listenerTask = Task.Run(AcceptConnections, listenerTaskCancellation.Token);
        }

        public async Task<bool> SendMessageAsync(ISendableMessage sendableMessage, params PlayerId[] playerIds)
        {
            throw new NotImplementedException();
        }

        public async Task TestConnectionsAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            try
            {
                isAlive = false;
                Thread.Sleep(100);
                listenerTaskCancellation.Cancel();
            }
            catch
            {
            }
        }

        private async Task AcceptConnections()
        {
            if(tcpListener != null)
            {
                tcpListener.Stop();
            }

            tcpListener = new TcpListener(IPAddress.Any, 8080);
            tcpListener.Start();

            try
            {
                while(isAlive)
                {
                    var tcpClient = await tcpListener.AcceptTcpClientAsync();

                    var inputStream = new CodedInputStream(tcpClient.GetStream(), true);
                    var outputStream = new CodedOutputStream(tcpClient.GetStream(), true);

                    if(Handshake(inputStream, outputStream, out var clientId))
                    {
                        //TODO: hibakezelés: TryAdd lehet false
                        playerStreams.TryAdd((ClientId)clientId, new ClientStreams
                        {
                            InputStream = inputStream,
                            OutputStream = outputStream
                        });
                    }
                }
            }
            catch(ThreadAbortException)
            {
            }
        }

        private bool Handshake(CodedInputStream inputStream, CodedOutputStream outputStream, out ClientId? clientId)
        {
            var connectRequestMessage = Request.Parser.ParseFrom(inputStream);
            
            if(gameEngine.AcceptNewPlayer(mapper.Map<ConnectRequestMessage>(connectRequestMessage), out var responseMessage))
            {
                var connectResponseMessage = mapper.Map<Response>(responseMessage);
                connectResponseMessage.WriteTo(outputStream);

                clientId = new ClientId
                {
                    LobbyId = responseMessage.LobbyIdentifier,
                    PlayerId = responseMessage.PlayerId
                };
                return true;
            }

            clientId = null;
            return false;
        }
    }
}
