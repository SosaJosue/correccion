class Marinero:Tripulacion
{
    public double pesopescado {get; set;}
    public double sueldo {get; set;}
    private double bono {get; set;}
    private double sueldototal {get; set;}
    
    public Marinero(string nombre, long telefono, long cedula, int edad, int tEmpresa, string sexo, string barco, double bono, int cAlmacen,double sueldo):base(nombre, telefono, cedula, edad, tEmpresa, sexo, barco, cAlmacen){
        this.barco = barco;
        this.bono = bono;
        this.sueldo=sueldo;
    }

    public override double CalculoSueldo(){
        if (pesopescado >= 1)
        {
            bono=bono*0.25;
        }
        return sueldototal = sueldo + bono;
    }
    public override void imprimir (){
        System.Console.WriteLine("Datos del marinero:");
        System.Console.WriteLine("Cedula: "+cedula);
        System.Console.WriteLine("Nombre: "+nombre);
        System.Console.WriteLine("sexo: "+sexo);
        System.Console.WriteLine("Edad: "+edad);
        System.Console.WriteLine("Telefono: "+telefono);
        System.Console.WriteLine("Tiempo en la empresa: "+tEmpresa);
        System.Console.WriteLine("Sueldo base: "+sueldo);
        System.Console.WriteLine("Monto del bono: "+bono);
        System.Console.WriteLine("Sueldo Total: "+CalculoSueldo());
        System.Console.WriteLine("");
    }
}