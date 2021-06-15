using Obsidian.Serialization.Attributes;

namespace Obsidian.Net.Packets.Status
{
    public partial class PingPong : IClientboundPacket
    {
        [Field(0)]
        public long Payload;

        public int Id => 0x01;
    }
}
