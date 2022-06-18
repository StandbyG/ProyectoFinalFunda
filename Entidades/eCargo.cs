using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eCargo
    {
        public int idCargo { get; set; }
        public string nombreCargo { get; set; }
        public eTrabajador trabajadores { get; set; }

    }
}
