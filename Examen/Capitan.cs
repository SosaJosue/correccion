class Capitan:Tripulacion
{
    public int hExperticia {get; set;}
    public double sueldo {get; set;}
    private double sueldoTotal {get; set;}
    private double bono {get; set;}


    public Capitan(string nombre, long telefono, long cedula, int edad, int tEmpresa, string sexo, string barco, int hExperticia, double sueldo, int cAlmacen):base(nombre, telefono, cedula, edad, tEmpresa, sexo, barco, cAlmacen){
        this.hExperticia = hExperticia;
        this.sueldo = sueldo;
        this.barco = barco;
    }

    public override double CalculoSueldo(){
        if(hExperticia >= 5000 && hExperticia < 150000){
            bono = sueldo * 0.20;
            return sueldoTotal = sueldo + bono;

        }
        if(hExperticia>=150000 && hExperticia < 300000){
            bono = sueldo * 0.40;
            return sueldoTotal = sueldo + bono;
            
        }
        if(hExperticia>=300000){
            bono =sueldo * 0.75;
            return sueldoTotal = sueldo + bono;
        }
        else{

            return sueldoTotal = sueldo;
        }
    }
    
    public override void imprimir(){
        System.Console.WriteLine("--Datos del capitan--");
        System.Console.WriteLine("Cedula: "+cedula);
        System.Console.WriteLine("Nombre: "+nombre);
        System.Console.WriteLine("sexo: "+sexo);
        System.Console.WriteLine("Edad: "+edad);
        System.Console.WriteLine("Telefono: "+telefono);
        System.Console.WriteLine("Tiempo en la empresa: "+tEmpresa);
        System.Console.WriteLine("Sueldo base: "+sueldo);
        System.Console.WriteLine("Bono: "+bono);
        System.Console.WriteLine("Sueldo Total: "+CalculoSueldo());
        System.Console.WriteLine("");
    }
}