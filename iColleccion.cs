using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasColas
{
    internal interface iColleccion
    {
        bool EstaVacia();
        string Extraer();
        string Primero();
        bool Añadir();

    }
}
