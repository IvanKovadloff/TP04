class ORTWorld{
    //Propiedades
    public List < string > ListaDestinos {get; private set;}
    public List < string > ListaHoteles {get; private set;} = new List<string>{"new york", "madrid", "londres", "dubai", "miami",
    "los angeles", "tokyo", "montevideo", "buenos aires", "barcelona"};
    public List< string > ListaAereos {get; private set;}
    public List< string > ListaExcursiones {get; private set;}
    public Dictionary<string, Paquete> Paquetes {get; private set;}
    //Constructor vacio
    ORTWorld(){}
    //Metodos
    public bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
    {
        bool seRepite= ListaDestinos.Contains(destinoSeleccionado);
        if(!seRepite)
        {
            Paquetes.Add(destinoSeleccionado,paquete);
        }
        return seRepite;
    }
    
}