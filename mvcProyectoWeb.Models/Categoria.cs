using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcProyectoWeb.Models
{
    public class Categoria
    {

        public int Id { get; set; }
        public string NombreCategoria { get; set; }
        public int Orden {  get; set; }
    }
}
