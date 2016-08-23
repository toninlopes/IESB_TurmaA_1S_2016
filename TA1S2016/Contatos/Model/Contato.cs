using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contatos.Model
{
    [SQLite.Net.Attributes.Table(nameof(Contato))]
    public class Contato
    {
        [SQLite.Net.Attributes.Column(nameof(ID)),
        SQLite.Net.Attributes.PrimaryKey,
        SQLite.Net.Attributes.AutoIncrement]
        public string ID { get; set; }

        [SQLite.Net.Attributes.MaxLength(100),
        SQLite.Net.Attributes.NotNull]
        [Newtonsoft.Json.JsonProperty("Name")]
        public string Nome { get; set; }

        [SQLite.Net.Attributes.MaxLength(100)]
        public string Email { get; set; }

        [SQLite.Net.Attributes.MaxLength(40)]
        [Newtonsoft.Json.JsonProperty("MobileNumber")]
        public string Telefone { get; set; }

        [Newtonsoft.Json.JsonProperty("IsFavorite")]
        public bool IsFavorito { get; set; }
    }
}
