class Barco
{
    public string nombres {get; set;}
    public string tipo {get; set;}
    public int capacidad {get; set;}
    public int cAlmacen {get; set;}

    public Barco(string nombres, string tipo, int capacidad, int cAlmacen){
        this.nombres = nombres;
        this.tipo = tipo;
        this.capacidad = capacidad;
        this.cAlmacen = cAlmacen;
    }

    public void imrpimir(){
        System.Console.WriteLine("Nombre del barco: "+nombres);
        System.Console.WriteLine("Tipo de baco: "+tipo);
        System.Console.WriteLine("Capacidad de pasajeros: "+capacidad);
        System.Console.WriteLine("Capacidad de almacenamiento:"+ cAlmacen);
        System.Console.WriteLine("");
    }
}