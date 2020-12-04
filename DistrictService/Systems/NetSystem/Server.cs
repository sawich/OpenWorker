﻿using Core.Systems.NetSystem;
using Microsoft.Extensions.Configuration;

namespace DistrictService.Systems.NetSystem
{
    public class Server : SwServer
    {
        public ushort ZoneId { get; init; }

        public Server(IConfiguration configuration) : base(configuration)
        {
            ZoneId = ushort.Parse("ZoneId");
        }
    }
}