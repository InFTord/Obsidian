﻿using Obsidian.Net;
using System.IO;
using System.Threading.Tasks;

namespace Obsidian.Boss
{
    public class BossBarUpdateHealthAction : BossBarAction
    {
        public override int Action => 2;
        public float Health { get; set; }

        public override async Task<byte[]> ToArrayAsync()
        {
            using (var stream = new MinecraftStream(new MemoryStream()))
            {
                await stream.WriteFloatAsync(Health);

                return stream.ToArray();
            }
        }
    }
}