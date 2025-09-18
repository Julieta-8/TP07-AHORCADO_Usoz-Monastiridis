
using Dapper;
using Newtonsoft.Json;
namespace ToDoListmaster.Models;
public class Palabra{
     [JsonProperty]
    public string Texto { get; set; }
     public int Dificultad { get; set; }
}