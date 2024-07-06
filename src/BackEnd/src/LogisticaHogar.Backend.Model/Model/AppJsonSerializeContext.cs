
using System.Text.Json.Serialization;

namespace LogisticaHogar.Backend.Model  
{
    [JsonSerializable(typeof(Producto))]
    [JsonSerializable(typeof(List<Producto>))]
    public partial class AppJsonSerializerContext : JsonSerializerContext
    {
    }
}
