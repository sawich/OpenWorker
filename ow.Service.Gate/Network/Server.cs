﻿using ow.Framework.IO.Network;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCoreServer;
using System;

namespace ow.Service.Gate.Network
{
    public sealed class Server : GameServer
    {
        public Server(IConfiguration configuration, IServiceProvider services) : base(configuration) =>
            _services = services;

        protected override TcpSession CreateSession() =>
            _services.GetRequiredService<Session>();

        private readonly IServiceProvider _services;
    }
}
