using Clase_14_Tarea.modelo;

Baraja baraja = new Baraja();

//baraja.MostrarBaraja();

baraja.Barajar();

baraja.MostrarBaraja();

Console.WriteLine();


for (int i = 0; i < 5; i++)
{
    baraja.CartasDisponibles();
    baraja.SiguienteCarta();
}
