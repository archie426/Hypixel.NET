using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi
{
    public class PlayerByUuid
    {
        [JsonProperty("player")]
        public Player.Player Player { get; set; }
    }
}
