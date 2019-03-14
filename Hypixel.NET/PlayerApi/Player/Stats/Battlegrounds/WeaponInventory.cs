using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats.Battlegrounds
{
    public class WeaponInventory
    {
        [JsonProperty("ability")]
        public int Ability { get; set; }

        [JsonProperty("abilityBoost")]
        public int AbilityBoost { get; set; }

        [JsonProperty("damage")]
        public int Damage { get; set; }

        [JsonProperty("energy")]
        public int Energy { get; set; }

        [JsonProperty("chance")]
        public int Chance { get; set; }

        [JsonProperty("multiplier")]
        public int Multiplier { get; set; }

        [JsonProperty("health")]
        public int Health { get; set; }

        [JsonProperty("cooldown")]
        public int Cooldown { get; set; }

        [JsonProperty("movement")]
        public int Movement { get; set; }

        [JsonProperty("material")]
        public string Material { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("crafted")]
        public bool Crafted { get; set; }

        [JsonProperty("upgradeMax")]
        public int UpgradeMax { get; set; }

        [JsonProperty("upgradeTimes")]
        public int UpgradeTimes { get; set; }
    }
}