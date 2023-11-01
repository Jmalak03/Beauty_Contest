using Microsoft.AspNetCore.Mvc;
using System;

namespace Beauty_Contest.Models
{
    public class AgregarModel
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNam { get; set; }
        public int Edad { get; set; }
        public string Peso { get; set; }
        public string Altura { get; set; }
        public string Nacionalidad { get; set; }
        public int ModeloId { get; set; }
    
    }
    
}
   
