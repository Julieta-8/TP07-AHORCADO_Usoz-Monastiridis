
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
namespace TP_Ahorcado.Models;
using Newtonsoft.Json;

 static class Juego{
static public List<Palabra> ListaPalabras  = new List<Palabra>();
static public List<Usuario> Jugadores = new List<Usuario>();
static public Usuario JugadorActual;



public static void InicializarJuego(string usuario, int dificultad){
   int intentos = 0;
   
 JugadorActual = new Usuario(usuario, intentos);
 Palabra palabra = new Palabra(CargarPalabra(dificultad), dificultad);
    
}
private static string CargarPalabra(int dificultad){
    Random rnd = new Random();
    int IndiceRandom = rnd.Next(0, ListaPalabras.Count);
   Palabra PalabraRandom = ListaPalabras[IndiceRandom];
   while(PalabraRandom.Dificultad != dificultad){
     IndiceRandom = rnd.Next(0, ListaPalabras.Count);
  PalabraRandom = ListaPalabras[IndiceRandom];
   }
   return PalabraRandom.Texto;
}
static void FinJuego(int intentos){
Jugadores.Add(JugadorActual);
}

static List<Usuario> DevolverListaUsuarios(){
    Jugadores.Sort()
   // List<int> numerosOrdenados = Jugadores.OrderBy(Usuario.CantidadIntentos).ToList();*//
    return Jugadores;
}


private static void LlenarListaPalabras(){
  // Crear palabras de dificultad 1
        Palabra Palabra1 = new Palabra("Casa", 1);
        ListaPalabras.Add(Palabra1);
        Palabra Palabra2 = new Palabra("Sol", 1);
        ListaPalabras.Add(Palabra2);
        Palabra Palabra3 = new Palabra("Perro", 1);
        ListaPalabras.Add(Palabra3);
        Palabra Palabra4 = new Palabra("Flor", 1);
        ListaPalabras.Add(Palabra4);
        Palabra Palabra5 = new Palabra("Gato", 1);
        ListaPalabras.Add(Palabra5);
        Palabra Palabra6 = new Palabra("Luna", 1);
        ListaPalabras.Add(Palabra6);
        Palabra Palabra7 = new Palabra("Rojo", 1);
        ListaPalabras.Add(Palabra7);
        Palabra Palabra8 = new Palabra("Libro", 1);
        ListaPalabras.Add(Palabra8);
        Palabra Palabra9 = new Palabra("Agua", 1);
        ListaPalabras.Add(Palabra9);
        Palabra Palabra10 = new Palabra("Rosa", 1);
        ListaPalabras.Add(Palabra10);

        // Crear palabras de dificultad 2
        Palabra Palabra11 = new Palabra("Elefante", 2);
        ListaPalabras.Add(Palabra11);
        Palabra Palabra12 = new Palabra("Ratón", 2);
        ListaPalabras.Add(Palabra12);
        Palabra Palabra13 = new Palabra("Computadora", 2);
        ListaPalabras.Add(Palabra13);
        Palabra Palabra14 = new Palabra("Jirafa", 2);
        ListaPalabras.Add(Palabra14);
        Palabra Palabra15 = new Palabra("Sombrero", 2);
        ListaPalabras.Add(Palabra15);
        Palabra Palabra16 = new Palabra("Teléfono", 2);
        ListaPalabras.Add(Palabra16);
        Palabra Palabra17 = new Palabra("Ventana", 2);
        ListaPalabras.Add(Palabra17);
        Palabra Palabra18 = new Palabra("Coche", 2);
        ListaPalabras.Add(Palabra18);
        Palabra Palabra19 = new Palabra("Papel", 2);
        ListaPalabras.Add(Palabra19);
        Palabra Palabra20 = new Palabra("Cuaderno", 2);
        ListaPalabras.Add(Palabra20);

        // Crear palabras de dificultad 3
        Palabra Palabra21 = new Palabra("Matemáticas", 3);
        ListaPalabras.Add(Palabra21);
        Palabra Palabra22 = new Palabra("Química", 3);
        ListaPalabras.Add(Palabra22);
        Palabra Palabra23 = new Palabra("Astronauta", 3);
        ListaPalabras.Add(Palabra23);
        Palabra Palabra24 = new Palabra("Computación", 3);
        ListaPalabras.Add(Palabra24);
        Palabra Palabra25 = new Palabra("Microondas", 3);
        ListaPalabras.Add(Palabra25);
        Palabra Palabra26 = new Palabra("Bicicleta", 3);
        ListaPalabras.Add(Palabra26);
        Palabra Palabra27 = new Palabra("Camara", 3);
        ListaPalabras.Add(Palabra27);
        Palabra Palabra28 = new Palabra("Callejón", 3);
        ListaPalabras.Add(Palabra28);
        Palabra Palabra29 = new Palabra("Aire", 3);
        ListaPalabras.Add(Palabra29);
        Palabra Palabra30 = new Palabra("Edificio", 3);
        ListaPalabras.Add(Palabra30);

        // Crear palabras de dificultad 4
        Palabra Palabra31 = new Palabra("Hipopotamo", 4);
        ListaPalabras.Add(Palabra31);
        Palabra Palabra32 = new Palabra("Neumonoultramicroscopicosilicovolcanoconiosis", 4);
        ListaPalabras.Add(Palabra32);
        Palabra Palabra33 = new Palabra("Anticonstitucionalmente", 4);
        ListaPalabras.Add(Palabra33);
        Palabra Palabra34 = new Palabra("Psicofarmacología", 4);
        ListaPalabras.Add(Palabra34);
        Palabra Palabra35 = new Palabra("Paralelepípedo", 4);
        ListaPalabras.Add(Palabra35);
        Palabra Palabra36 = new Palabra("Electroencefalografista", 4);
        ListaPalabras.Add(Palabra36);
        Palabra Palabra37 = new Palabra("Ecotomografía", 4);
        ListaPalabras.Add(Palabra37);
        Palabra Palabra38 = new Palabra("Cromatografía", 4);
        ListaPalabras.Add(Palabra38);
        Palabra Palabra39 = new Palabra("Fotovoltaico", 4);
        ListaPalabras.Add(Palabra39);
        Palabra Palabra40 = new Palabra("Inconstitucionalidad", 4);
        ListaPalabras.Add(Palabra40);
}


}