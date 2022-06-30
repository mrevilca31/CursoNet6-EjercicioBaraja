using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_14_Tarea.modelo
{
    public class Baraja
    {
        private int[] _numeroDeCarta = {1,2,3,4,5,6,7,10,11,12};
        private string[] _palo = {"espada", "basto", "oro", "copa"};
        private Stack<string> _cartas = new Stack<string>();
        private Stack<string> _monton = new Stack<string>();
  

        public void Barajar()
        {
            Random rand = new Random();
            List<string> cartasOrdenadas = GenerarBaraja(); 

            while (cartasOrdenadas.Count>0)
            {
                var indice = rand.Next(0, cartasOrdenadas.Count);
                this._cartas.Push(cartasOrdenadas[indice]);
                cartasOrdenadas.RemoveAt(indice);
            }
        }

        private List<string> GenerarBaraja()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < _palo.Length; i++)
            {
                for (int j = 0; j < _numeroDeCarta.Length; j++)
                {
                    list.Add(_numeroDeCarta[j].ToString() + " de " + _palo[i]);
                }
            }
            return list;
        }

        public void SiguienteCarta()
        {
            string respuesta;
            if (this._cartas.Count==0)
            {
                respuesta = "No hay más cartas en la baraja";
            }
            else
            {
                respuesta = this._cartas.Pop();
                this._monton.Push(respuesta);
            }
            Console.WriteLine(respuesta);
        }

        public void CartasDisponibles()
        {
            Console.WriteLine($"Hay {this._cartas.Count} cartas disponibles.");
        }

        public void DarCartas(int cantidad)
        {
            if (this._cartas.Count >= cantidad)
            {
                string carta;
                for (int i = 0; i < cantidad; i++)
                {
                    carta = this._cartas.Pop();
                    this._monton.Push(carta);
                    Console.WriteLine(carta);
                }
            }
            else
            {
                Console.WriteLine("No hay suficientes cartas en la baraja.");
            }
        }

        public void CartasMonton()
        {
            if (this._monton.Count == 0)
            {
                Console.WriteLine("Aún no se han sacado cartas de la baraja.");
            }
            else
            {
                foreach (var carta in this._monton)
                {
                    Console.WriteLine(carta);
                }
            }
        }

        public void MostrarBaraja()
        {
            foreach (var carta in this._cartas)
            {
                Console.WriteLine(carta);
            }
        }
    }
}
