using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidad;
namespace CapaLogica
{
    public class Respuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
    }
    public class RespuestaBusqueda : Respuesta
    {
        public Persona Persona {get;set;}
    }
    public class RespuestaConsulta : Respuesta
    {
        public IList<Persona> Personas { get; set; }
    }
}
