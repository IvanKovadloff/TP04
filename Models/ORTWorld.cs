namespace TP04.Models{
public static class ORTWorld{
    //Propiedades
    public static List < string > ListaDestinos {get; private set;} = new List<string>{"1ny.jpg", "2madrid.jpg","3london.png", 
    "4dubai.jfif", "5miami.jpg","6la.jpg", "7montevideo.jpg", "8bsas.jpeg", 
    "9barcelona.jpg", "10tokyo.jfif"};
    public static List < string > ListaHoteles {get; private set;} =new List<string>{"1hotel.png", "2hotel.png","3hotel.jpg", 
    "4hotel.jpg", "5hotel.png","6hotel.jpg", "7hotel.jpg", "8hotel.jpg", 
    "9hotel.jpg", "10hotel.jpg"};
    public static List< string > ListaAereos {get; private set;} = new List<string>{"1air.jpg", "2air.jpg","3air.jpg", 
    "4air.jpg", "5air.jpg","6air.jpg", "7air.jpg", "8air.jpg", 
    "9air.jpg", "10air.jpg"};
    public static List< string > ListaExcursiones {get; private set;}= new List<string>{"1paisaje.jpg", "2paisaje.jpg","3paisaje.jpg", 
    "4paisaje.jpg", "5paisaje.jpg","6paisaje.jpg", "7paisaje.jpg", "8paisaje.jpg", 
    "9paisaje.jpg", "10paisaje.jpg"};
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