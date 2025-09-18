namespace TP_Ahorcado.Models;

using Newtonsoft.Json;

public class Usuario{
     [JsonProperty]
    public string Nombre { get; private set; }
     public int CantidadIntentos { get; private set; }


     public Usuario(string Nombre, int CantidadIntentos){
     this.Nombre = Nombre;
     this.CantidadIntentos= CantidadIntentos;
}
}
