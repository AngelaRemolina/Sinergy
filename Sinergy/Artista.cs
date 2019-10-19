using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entorno_visual
{
    public class Artista : Usuario
    {
        public int nombre_artistico
        {
            get => default;
            set
            {
            }
        }

        public int ingresos
        {
            get => default;
            set
            {
            }
        }

        public void subir_contenido()
        {
            throw new System.NotImplementedException();
        }

        public void ver_contenido()
        {
            throw new System.NotImplementedException();
        }

        public void ver_ingresos()
        {
            throw new System.NotImplementedException();
        }

        public void ver_estadisticas()
        {
            throw new System.NotImplementedException();
        }
    }
}