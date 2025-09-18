
using Dapper;
using Newtonsoft.Json;
namespace ToDoListmaster.Models;
public class Usuario{
     [JsonProperty]
    public string Nombre { get; set; }
     public int CantidadIntentos { get; set; }
}