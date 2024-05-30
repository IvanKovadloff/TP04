namespace TP04.Models{
public static class ORTWorld{
    //Propiedades
    public static List < string > ListaDestinos {get; private set;} = new List<string>{"new york", "madrid", "londres", "dubai", "miami",
    "los angeles", "montevideo", "buenos aires", "barcelona", "tokyo"};
    public static List < string > ListaHoteles {get; private set;} =new List<string>{"1ny.jpg", "2madrid.jpg","3london.png", 
    "4dubai.jfif", "5miami.jpg","6la.jpg", "7montevideo.jpg", "8bsas.jpeg", 
    "9barcelona.jpg", "10tokyo.jfif"};
    public static List< string > ListaAereos {get; private set;} = new List<string>{"Avion1", "Avion2","Avion3","Avion4","Avion5","Avion6","Avion7","Avion8","Avion9","Avion10"};
    public static List< string > ListaExcursiones {get; private set;}= new List<string>{"Ex1", "Ex2","Ex3","Ex4","Ex5","Avion6","Avion7","Avion8","Avion9","Avion10"};
    public static Dictionary<string, Paquete> Paquetes {get; private set;}
    //Metodos
    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
    {
        bool seRepite= ListaDestinos.Contains(destinoSeleccionado);
        if(!seRepite)
        {
            Paquetes.Add(destinoSeleccionado,paquete);
        }
        return seRepite;
    }
    }
}