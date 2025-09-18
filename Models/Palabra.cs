
using Newtonsoft.Json;
namespace ToDoListmaster.Models;
public class Palabra{
     [JsonProperty]
    public string Texto{ get; private set; }
     public int Dificultad { get; private set; }


          public Palabra(string Texto, int Dificultad){
     this.Texto = Texto;
     this.Dificultad = Dificultad;
}
}