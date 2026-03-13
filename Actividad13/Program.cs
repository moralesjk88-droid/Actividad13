// See https://aka.ms/new-console-template for more information
class Dispositivos
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