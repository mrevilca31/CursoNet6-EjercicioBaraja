using Clase_14_Tarea.modelo;

int opc;
Baraja baraja = new Baraja();


do
{
    Console.Clear();
    Console.WriteLine("SELECCIONE UNA OPCIÓN");
    Console.WriteLine("1 - Barajar");
    Console.WriteLine("2 - Mostrar siguiente carta");
    Console.WriteLine("3 - Mostrar cartas disponibles");
    Console.WriteLine("4 - Dar cartas");
    Console.WriteLine("5 - Mostrar cartas del monton");
    Console.WriteLine("6 - Mostrar baraja");
    Console.WriteLine("7 - Salir");
    opc = int.Parse(Console.ReadLine());

    Console.WriteLine("\n");
    switch (opc)
    {
        case 1:
            baraja.Barajar();
            break;
        case 2:
            baraja.SiguienteCarta();
            Console.ReadKey();
            break;
        case 3:
            baraja.CartasDisponibles();
            Console.ReadKey();
            break;
        case 4:
            Console.Write("Ingrese cantidad de cartas a dar: ");
            var cantidad = int.Parse(Console.ReadLine());
            baraja.DarCartas(cantidad);
            Console.ReadKey();
            break;
        case 5:
            baraja.CartasMonton();
            Console.ReadKey();
            break;
        case 6:
            baraja.MostrarBaraja();
            Console.ReadKey();
            break;
        default:
            break;
    }

} while (opc<7);




