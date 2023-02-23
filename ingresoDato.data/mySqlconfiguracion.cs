using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ingresoDato.data
{
    public class mySqlconfiguracion
    {
        public mySqlconfiguracion(string conexionstring) => Conexionstring = conexionstring;

        public string Conexionstring { get; set; }
    }
}
