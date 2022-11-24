class JefeF:Tripulacion
{
    public bool pesoP = true;
    public bool pesoM = true;
    private double sueldototal {get; set;}
    private double bonopes {get; set;}
    private double bonomar {get; set;}
    public double sueldo {get; set;}
    
    public JefeF(string nombre, long telefono, long cedula, int edad, int tEmpresa, string sexo, string barco,int cAlmacen, double sueldo):base(nombre, telefono, cedula, edad, tEmpresa, sexo, barco, cAlmacen){
        this.barco = barco;
        this.sueldo = sueldo;
    }
    
    public override double CalculoSueldo(){
        if(pesoP == true && pesoM == true){
            bonopes = cAlmacen * 0.1;
            bonomar = cAlmacen * 0.2;
            return sueldototal = sueldo + bonopes + bonomar; 
        }
        if(pesoP ==true && pesoM == false){
            bonopes = cAlmacen * 0.1;
            return sueldototal = sueldo + bonopes;
        }
        if (pesoP == false && pesoM == true){
            bonomar = cAlmacen * 0.2;
            return sueldototal = sueldo + bonomar;
        }else{
            return sueldototal = sueldo;
        }
    }
    public override void imprimir(){
        System.Console.WriteLine("Datos del jefe de folta:");
        System.Console.WriteLine("Cedula: "+cedula);
        System.Console.WriteLine("Nombre: "+nombre);
        System.Console.WriteLine("sexo: "+sexo);
        System.Console.WriteLine("Edad: "+edad);
        System.Console.WriteLine("Telefono: "+telefono);
        System.Console.WriteLine("Tiempo en la empresa: "+tEmpresa);
        System.Console.WriteLine("Sueldo base: "+sueldo);
        System.Console.WriteLine("Bono por pescado: "+bonopes);
        System.Console.WriteLine("Bono por mariscos: "+bonomar);
        System.Console.WriteLine("Sueldo Total: "+CalculoSueldo());
        System.Console.WriteLine("");
    }
}
