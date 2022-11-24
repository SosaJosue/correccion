class Ubicacion
{
    public string CX {get; set;}
    public string CY {get; set;}
    public int Dtripulados {get; set;}
    public string fechaR {get; set;} //cambio
    public string horaR {get; set;} //cambio

    public Ubicacion(string CX, string CY, int Dtripulados, string fechaR, string horaR){
        this.CX = CX;
        this.CY = CY;
        this.Dtripulados = Dtripulados;
        this.fechaR = fechaR;
        this.horaR = horaR;
    }
    public void imprimir(){
        System.Console.WriteLine("Coordenadas x: "+CX);
        System.Console.WriteLine("Coordenadas y: "+CY);
        System.Console.WriteLine("Dias tripulados: "+Dtripulados);
        System.Console.WriteLine("Fecha de registro: "+fechaR);
        System.Console.WriteLine("Hora de registro: "+horaR);
        System.Console.WriteLine("");
    }
}