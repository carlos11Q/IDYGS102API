using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Modelos
{
    public class Personaje
    {
        [Key]
        public int PkPersonaje { get; set; }
        public string Nombre { get; set; }  
        public string Color  { get; set; }  
        public string Poder { get; set; }

        [ForeignKey("genero")]
        public int FkGenero { get; set; }
        
        public Genero genero { get; set; }

    }

    public class PersonajeResponse
    {
        public string Nombre { get; set; }
        public string Color { get; set; }
        public string Poder { get; set; }
        public int FkGenero { get; set; }
        public string genero { get; set; }
    }
}
