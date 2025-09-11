using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Models
{
    public class Libro
    {
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int CantidadDisponible { get; set; }
    }
}
