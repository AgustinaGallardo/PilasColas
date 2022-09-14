using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasColas
{
     class Pila:iColleccion
    {

        Stack<string> pilas = new Stack<string>();
        PilasColas pil = new PilasColas();
        

        //pilas.Push("bateria");
        //pilas.Push("bajo");
        //pilas.Push("voz");

      
        public bool EstaVacia()
        {
            bool ok = true;
            if (pilas == null)
            {
                ok = false;
            }
            return ok;
        }

        public string Extraer()
        {
            string primero = pilas.First();

            if (pilas != null)
            {
                primero = pilas.Pop();
            }
            return primero;
        }


        public string Primero()
        {
            string primero = string.Empty;

            if (pilas != null)
            {
                primero = pilas.First();

            }
            return primero;
        }


        public bool Añadir()
        {
            bool ok = true;

            pilas.Push("bateria");

            if (pilas != null)
            {
                pilas.Pop();
                return ok;
            }
            else
                return false;

        }
        public void InsertPila()
        {
            int contador = 0;

            while (pilas.Count>0)
            {
                pilas.Push("bateria");
                pilas.Push("bajo");
                pilas.Push("voz");

                contador++;
            }

        }
        public bool añadir(string elemento)
        {
            bool ok = true;
            elemento = (txtElemento.text);

            if (Pilas == null)
            {
                pilas.Push(elemento);
            }
            return ok;
        }
    }
}
