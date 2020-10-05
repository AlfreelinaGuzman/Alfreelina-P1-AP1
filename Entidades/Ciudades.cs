using System;
using System.ComponentModel.DataAnnotations;

namespace Alfreelina_P1_AP1.Entidades{

    public class Ciudades{
        [Key]
        public int CiudadesID { get; set; }
        public string Nombres { get; set; }
    }
}