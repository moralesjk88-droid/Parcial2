// See https://aka.ms/new-console-template for more information

using System.Security.Principal;

Dictionary<int, Equipo> equipos = new Dictionary<int, Equipo>();
int opcion;

do
{
    Console.Clear();
    Console.WriteLine("1. Registrar equipo");
    Console.WriteLine("2. Modificar Equipo");
    Console.WriteLine("3. Eliminar equipo");
    Console.WriteLine("4. Buscar equipo");
    Console.WriteLine("5. Mostrar todos los equipos");
    Console.WriteLine("6. Registrar préstamo");
    Console.WriteLine("7. Registrar devolución");
    Console.WriteLine("8. Mostrar resumen general");
    Console.WriteLine("9. Mostrar equipos por estado");
    Console.WriteLine("10. Mostrar equipos por tipo");
    Console.WriteLine("11. Salir");
    opcion=int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("REGISTRO DE EQUIPO");
            Equipo In = new Equipo();
            Console.Write("Codigo del equipo:_ ");
            In.codigo = int.Parse(Console.ReadLine());

            if (equipos.ContainsKey(In.codigo))
            {
                Console.WriteLine("Codigo ya existente");
            }
            else
            {
                In.Registro();
                equipos.Add(In.codigo, In);

            }
            Console.ReadKey();


            break;
        case 2:
            Console.WriteLine("Modificar equipo:_ ");
            Console.Write("Codigo del equipo:_");
            int codmod = int.Parse(Console.ReadLine());

            if (equipos.ContainsKey(codmod))
            {
                Equipo mod = equipos[codmod];
                mod.Modificar();
                Console.ReadKey();
            }
            else
            {
                Console.Write("Equipo no encontrado");
                Console.ReadKey();
            }
            break;
        case 3:
            Console.WriteLine("Eliminar Equipo");
            Console.Write("Codigo del equipo:_ ");
            int eliminar = int.Parse(Console.ReadLine());
            if (equipos.ContainsKey(eliminar))
            {
                equipos.Remove(eliminar);
                Console.Write("Producto eliminado");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No se ha encontrado equipo");
            }

            break;
        case 4:
            Console.WriteLine("Buscar Equipo");
            Console.Write("Codigo del equipo:_ ");
            int codBus = int.Parse(Console.ReadLine());
            if (equipos.ContainsKey(codBus))
            {
                foreach (var item in equipos)
                {
                    Equipo buscar = equipos[codBus];
                    item.Value.MostrarDatos();
                    Console.ReadKey();
                }

            }
            else
            {
                Console.WriteLine("Equipo no registrado");
                Console.ReadKey();
            }
            break;
        case 5:
            Console.WriteLine("EQUIPOS REGISTRADOS");

            foreach (var item in equipos)
            {
                item.Value.MostrarDatos();
                Console.ReadKey();
            }

            break;
            case 6:
            Console.WriteLine("Registro de Prestamo");
            Console.Write("Codigo del equipo:_ ");
            int codReg=int.Parse(Console.ReadLine());

            if (equipos.ContainsKey(codReg))
            {
                Equipo registrar= equipos[codReg];

                if ()
                {
                    
                }

            }


            break;
            case 7:
            break;
            case 8:
            break;
            case 9:
            break;
            case 10:
            break;
            case 11:
            Console.WriteLine("Hasta pronto!");
            Console.ReadKey();
            break;
        default:
            Console.WriteLine("Opcion no valida");
            break;



    }


}
while (opcion!=11);







public class Equipo
{
    public int codigo;
    public string nombre;
    public string tipo;
    public double Usohora;
    public int PrestadoHora;
    public string estado;


    
         

    public void Estado()
    {
        if (estado=="disponible")
        {
           Console.WriteLine( "DISPONIBLE");
        }
        else if (estado == "prestado")
        {
            Console.WriteLine("En uso");
        }
        else if (estado =="mantenimiento")
        {
            Console.WriteLine("MANTENIMIENTO");
        }
    }

    public void Registro()
    {
       
            Console.Write("Nombre del Equipo: ");
            nombre = Console.ReadLine().ToLower();

            Console.Write("Tipo del equipo:_ ");
            tipo = Console.ReadLine().ToLower().ToUpper();
     
            Console.Write("Costo de horas:_ ");
            Usohora = double.Parse(Console.ReadLine());

            Console.Write("Cantidad de horas prestadas:_ ");
            PrestadoHora = int.Parse(Console.ReadLine());

        if (PrestadoHora<0 || Usohora<0)
        {
            Console.WriteLine("Las horas no pueden ser negativas");
        }
        else
        {
             Console.Write("Estado (Disponible, prestado, mantenimiento):_ ");
            estado = Console.ReadLine().ToLower();
        }
       
     

    }

    public void Modificar()
    {
        Console.Write("Nombre:_ ");
        nombre = Console.ReadLine();

        Console.Write("Tipo:_ ");
        tipo = Console.ReadLine();

        Console.Write("Costo de horas:_ ");
        Usohora = double.Parse(Console.ReadLine());

        Console.Write("Cantidad de horas prestadas");
        PrestadoHora = int.Parse(Console.ReadLine());

    }
 public void CostoTotal(double total)
{
        double costo = Usohora;
        int prestamo = PrestadoHora;
         total =0;
     total= costo* prestamo;

}

    public void MostrarDatos() // void para mostrar los datos
    {
        Console.WriteLine("Nombre del equipo:_ "+nombre);
        Console.WriteLine("Tipo de equipo:_ "+tipo);
        Console.WriteLine("Costo de uso por hora:_" + Usohora);
        Console.WriteLine($"Total por prestamo:_ {CostoTotal:f2} ");
        Console.WriteLine("Estado del equipo:_ "+Estado);
    }



}