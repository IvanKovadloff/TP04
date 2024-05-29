class Paquete{
    //Propiedades
    public string Hotel {get; private set;}
    public string Aereo {get; private set;}
    public string Excursion {get; private set;}
    //Constructor
    public Paquete (){ }
    public Paquete (string hotel, string aereo, string excursion){
        hotel = Hotel;
        aereo = Aereo;
        excursion = Excursion;
    }
}
