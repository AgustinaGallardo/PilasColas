using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasColas
{
     class Cola:iColleccion
    {
        Queue<string> colas = new Queue<string>();

        //colas.Enqueue("Perros");
        //colas.Enqueue("Gatos");
        //colas.Enqueue("Caballos");

        //while (colas.Count > 0)
        //{
        //    Console.WriteLine(colas.Dequeue());
        //}

        public bool EstaVacia()
        {
            bool ok = true;
            if (colas == null)
            {
                ok = false;
            }
            return ok;
        }

        public string Extraer()
        {
            string primero = colas.First();
            if (colas != null)
            {
                primero = colas.Dequeue();
            }
            return primero;

        }

        public string Primero()
        {
            string primero = string.Empty;

            if (colas != null)
            {
                primero = colas.First();

            }
            return primero;
        }


        public bool Añadir()
        {
            bool ok = true;

            colas.Enqueue("perro");
            if (colas != null)
            {
                colas.Enqueue("perro");
                return ok;
            }
            else
                return false;
        }

    }
}
