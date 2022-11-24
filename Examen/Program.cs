internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("---------Datos del barco---------");
        Barco barco1 = new Barco("Tercaro A", "Pesquero", 10, 3000);
        barco1.imrpimir();


        System.Console.WriteLine("---------Datos Ubicacion----------");
        Ubicacion gps = new Ubicacion("8´24´54", "9´23´21", 30, "23/11/2022", "09:00");
        gps.imprimir();


        System.Console.WriteLine("-------Datos de tripulacion-------");
        System.Console.WriteLine("");
        Capitan capitan1 = new Capitan("Marcos", 098432123, 23339876542, 20, 20, "M", "Tercero B", 5000, 4500, 30000);
        capitan1.CalculoSueldo();
        capitan1.imprimir();


        JefeF jefe = new JefeF("Juan", 098432123, 2339876542, 23, 15, "M", "Tercero B", 30000, 3500);
        jefe.CalculoSueldo();
        jefe.imprimir();
        

        Marinero marinero1 = new Marinero("Pedro", 098432123, 23339876542, 19, 10, "M", "Tercero B", 30000, 1750,900);
        marinero1.CalculoSueldo();
        marinero1.imprimir();
        Marinero marinero2 = new Marinero("Maria", 098432123, 23339876542, 19, 10, "F", "Tercero B", 30000, 1750,900);
        marinero2.CalculoSueldo();
        marinero2.imprimir();
        Marinero marinero3 = new Marinero("Pedro2", 098432123, 23339876542, 21, 10, "M", "Tercero B", 30000, 1750,900);
        marinero3.CalculoSueldo();
        marinero3.imprimir();


        List<Tripulacion> Lista1 = new List<Tripulacion>();
        Lista1.Add(capitan1);
        Lista1.Add(jefe);
        Lista1.Add(marinero1);
        Lista1.Add(marinero2);
        Lista1.Add(marinero3);

        foreach (var dato in Lista1)
        {
            //System.Console.WriteLine(dato.ToString());
        }
    }
}