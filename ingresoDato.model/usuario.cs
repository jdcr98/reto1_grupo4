using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ingresoDato.model
{
    public class usuario
    {
        //id, nombre, apellido, cedula, area, rol?
        public int id { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public int cedula { get; set; }

        public int area { get; set; }

        public int rol { get; set; }

    }
}
