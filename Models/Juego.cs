

using Newtonsoft.Json;
namespace ToDoListmaster.Models;
 static class Juego{
static public List<Palabra> ListaPalabras {get; private set;}
static public List<Usuario> Jugadores {get; private set;}
static public Usuario JugadorActual {get; private set;} 


private void LlenarListaPalabras(){
ListaPalabras.Add("Casa", 1);
}

public void InicializarJuego(string usuario, int dificultad){
   int intentos = 0;
 JugadorActual = new Usuario(usuario, intentos);
 Palabra palabra = new Palabra(CargarPalabra(dificultad), dificultad);
    
}
private string CargarPalabra(int dificultad){
    Random rnd = new Random();
    int IndiceRandom = rnd.Next(0, ListaPalabras.Count);
   string PalabraRandom = ListaPalabras[IndiceRandom];
   return PalabraRandom;
}
void FinJuego(int intentos){

}

List<Usuario> DevolverListaUsuarios(){
    List<int> numerosOrdenados = Jugadores.OrderBy(CantidadIntentos).ToList();
    return Jugadores;
}

}