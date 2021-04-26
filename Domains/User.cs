using Kros.KORM.Metadata.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sample.KormAutoincrement.Domains
{
    [Alias("Users")]
    public class User
    {
        [JsonIgnore]
        public long Id { get; set; }

        public string Name { get; set; }
    }
}
