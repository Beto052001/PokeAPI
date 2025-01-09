using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeAPI7DaysOfCode.Entities
{
    public class Pokemon
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
