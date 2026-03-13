// See https://aka.ms/new-console-template for more information

List<Dispositivo> dispositivos = new List<Dispositivo>();
Console.WriteLine("¿Cúantos sispositivos desea registrar");
int n=int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Dispositivo dis = new Dispositivo();
    Console.WriteLine($"\nDispositivos{i + 1}");
    Console.Write("Nombre del dispositivo:_ "); dis.Nombre = Console.ReadLine();
    Console.Write("Resultado de la prueva 1:_ "); dis.Rendimiento1=double.Parse(Console.ReadLine());
    Console.Write("Resultado de la prueva 2:_ "); dis.Rendimiento2 = double.Parse(Console.ReadLine());
    Console.Write("Resultado de la prueva 3:_ "); dis.Rendimiento3 = double.Parse(Console.ReadLine());
}



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
        if (CalcularPromedio()>=80)
        {
            return "Óptimo";
        }
        else if (CalcularPromedio()<80)
        {
            return "Necesita mantenimiento";
        }

    }

    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre:{Nombre} | Promedio Rendimiento:{CalcularPromedio} | Estado:{Estado} ");
    }

}