

using Newtonsoft.Json;
namespace ToDoListmaster.Models;
public class Usuario{
     [JsonProperty]
    public string Nombre { get; private set; }
     public int CantidadIntentos { get; private set; }


     public Usuario(string Nombre, int CantidadIntentos){
     this.Nombre = Nombre;
     this.CantidadIntentos= CantidadIntentos;
}
}
