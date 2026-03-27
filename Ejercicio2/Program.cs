// See https://aka.ms/new-console-template for more information








public class Equipo
{
    public int codigo;
    public string nombre;
    public string tipo;
    public double Usohora;
    public int PrestadoHora;
    public string estado;


    public double CostoTotal()// double para calcular horas prestadas
    {
        return Usohora * PrestadoHora;

         }

  

    public void MostrarDatos() // void para mostrar los datos
    {
        Console.WriteLine("Nombre del equipo:_ "+nombre);
        Console.WriteLine("Tipo de equipo:_ "+tipo);
        Console.WriteLine("Costo de uso por hora:_" + Usohora);
        Console.WriteLine($"Total por prestamo:_ {CostoTotal:f2} ");
        Console.WriteLine("Estado del equipo:_ "+estado);
    }



}