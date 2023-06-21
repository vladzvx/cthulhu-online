using MongoDB.Bson.Serialization.Attributes;

namespace Cthulhu.CoreLib.Entities.Possessions
{
    public class Possession
    {
        [BsonId]
        public long Possessiond { get; set; }
        public PresenceType Type { get; set; }
        public double Quantity { get; set; } = 1;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
