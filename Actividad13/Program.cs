// See https://aka.ms/new-console-template for more information

List<Dispositivo> dispositivos = new List<Dispositivo>();
Console.WriteLine("¿Cúantos dispositivos desea registrar");
int n=int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Dispositivo dis = new Dispositivo();
    Console.WriteLine($"\nDispositivos{i + 1}");
    Console.Write("Nombre del dispositivo:_ "); dis.Nombre = Console.ReadLine();
    Console.Write("Resultado de la prueva 1:_ "); dis.Rendimiento1=double.Parse(Console.ReadLine());
    Console.Write("Resultado de la prueva 2:_ "); dis.Rendimiento2 = double.Parse(Console.ReadLine());
    Console.Write("Resultado de la prueva 3:_ "); dis.Rendimiento3 = double.Parse(Console.ReadLine());
    dispositivos.Add(dis);
}
double SumaPromedio = 0;
Dispositivo Mayor = dispositivos[0];
Console.WriteLine("\n LISTADO DE DISPOSITIVOS ");
foreach (Dispositivo dis in dispositivos)
{
    dis.MostrarDatos();
    SumaPromedio += dis.CalcularPromedio();
    if (dis.CalcularPromedio() > Mayor.CalcularPromedio())
    {
        Mayor = dis;
    }
}

Console.WriteLine($"Promedio general de rendimiento: {SumaPromedio/dispositivos.Count:F2}");
Console.WriteLine("Mayor Rendimiento");
Mayor.MostrarDatos();

class Dispositivo
{
    public string Nombre;
    public double Rendimiento1;
    public double Rendimiento2;
    public double Rendimiento3;

    public double CalcularPromedio()
    { 
        return (Rendimiento1 + Rendimiento2 + Rendimiento3) / 3;
    }

    public string Estado()
    {
        if (CalcularPromedio()<80)
        {
            return "Necesita Mantenimiento";
        }
        else 
        {
            return "Optimo";
        }

    }

    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre:{Nombre} | Promedio Rendimiento:{CalcularPromedio():F2} | Estado:{Estado()} ");
    }

}