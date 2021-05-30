﻿using Obsidian.API;
using Obsidian.Entities;
using Obsidian.Serialization.Attributes;
using System.Threading.Tasks;

namespace Obsidian.Net.Packets.Play.Clientbound
{
    [ClientOnly]
    public partial class EntityEquipment : ISerializablePacket
    {
        [Field(0), VarLength]
        public int EntityId { get; set; }

        [Field(1), ActualType(typeof(int)), VarLength]
        public ESlot Slot { get; set; }

        [Field(2)]
        public ItemStack Item { get; set; }

        public int Id => 0x47;

        public Task ReadAsync(MinecraftStream stream) => Task.CompletedTask;

        public Task HandleAsync(Server server, Player player) => Task.CompletedTask;
    }

    public enum ESlot : int
    {
        MainHand,
        OffHand,

        Boots,
        Leggings,
        Chestplate,
        Helmet
    }
}