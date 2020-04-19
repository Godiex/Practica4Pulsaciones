using System;
using CapaEntidad;
using CapaDato;
using System.Collections.Generic;

namespace CapaLogica
{
    public class PersonaServicio
    {
        private AlmacenamientoPersona personaRepositorio;
        public PersonaServicio()
        {
            personaRepositorio = new AlmacenamientoPersona();
        }
        public string Guardar(Persona persona)
        {
            try
            {
                string mensaje = IntentarGuardar(persona);
                return mensaje;
            }
            catch (Exception e)
            {
                return $"Error de datos  " + e.Message;
            }
        }
        public string IntentarGuardar(Persona persona)
        {
            string mensaje;
            RespuestaBusqueda respuestaBusqueda = Buscar(persona.Identificacion);
            if (respuestaBusqueda.Persona != null)
            {
                mensaje =  $"los datos de {persona.Nombre } ya se encuentra registrados";
            }
            else
            {
                personaRepositorio.Guardar(persona);
                mensaje= $"los datos de {persona.Nombre } se han guardado con exito";
            }
            return mensaje;
        }
        public RespuestaConsulta Consultar()
        {
            RespuestaConsulta respuestaConsulta = new RespuestaConsulta();
            respuestaConsulta.Error = false;
            try
            {
                respuestaConsulta.Personas = personaRepositorio.Consultar();
                if (respuestaConsulta.Personas.Count > 0)
                {
                    respuestaConsulta.Mensaje = $"Regitro de personas encontradas con exito ! ";
                }
                else
                {
                    respuestaConsulta.Mensaje = $"No hay personas registradas  ";
                }
                return respuestaConsulta;
            }
            catch (Exception e)
            {
                respuestaConsulta.Error = true;
                respuestaConsulta.Personas = null;
                respuestaConsulta.Mensaje = $"error en el fichero : {e.Message}";
                return respuestaConsulta;
            }
        }

        public string  Eliminar(string identificacion)
        {
            try
            {
                RespuestaBusqueda respuestaBusqueda = Buscar(identificacion);
                if (respuestaBusqueda.Persona != null)
                {
                    personaRepositorio.Eliminar(identificacion);
                    return $"La Persona con nombre: {respuestaBusqueda.Persona.Nombre} e identificacion: {respuestaBusqueda.Persona.Identificacion}, se elimino con exito";
                }
                return respuestaBusqueda.Mensaje;
            }
            catch (Exception e)
            {

                return $"Error de datos" + e.Message;
            }
        }
        public string Modificar(Persona persona)
        {
            try
            {
                RespuestaBusqueda respuestaBusqueda = Buscar(persona.Identificacion);
                if (respuestaBusqueda.Persona != null)
                {
                    personaRepositorio.Modificar(persona);
                    return $"La Persona con nombre: {persona.Nombre} e identificacion: {persona.Identificacion}, se Actualizo con exito";
                }
                return respuestaBusqueda.Mensaje;
            }
            catch (Exception e)
            {

                return $"Error de datos" + e.Message;
            }
        }
        public RespuestaBusqueda Buscar(string identificacion)
        {
            RespuestaBusqueda respuestaBusqueda = new RespuestaBusqueda();
            respuestaBusqueda.Error = false;
            try
            {
                respuestaBusqueda = ObtenerRespuestaBusqueda(identificacion, respuestaBusqueda);
                return respuestaBusqueda;
            }
            catch (Exception e)
            {
                respuestaBusqueda = ObtenerRespuestaBusqueda(e, respuestaBusqueda);
                return respuestaBusqueda;
            }
        }
        public RespuestaBusqueda ObtenerRespuestaBusqueda(string identificacion , RespuestaBusqueda respuestaBusqueda)
        {
            respuestaBusqueda.Persona = personaRepositorio.Buscar(identificacion);
            if (respuestaBusqueda.Persona != null)
            {
                respuestaBusqueda.Mensaje = $"Datos encontrado con exito";
            }
            else
            {
                respuestaBusqueda.Mensaje = $"La persona con identificacion : {identificacion}, no se encuentra registrada";
            }
            return respuestaBusqueda;
        }
        public RespuestaBusqueda ObtenerRespuestaBusqueda(Exception e, RespuestaBusqueda respuestaBusqueda)
        {
            respuestaBusqueda.Error = true;
            respuestaBusqueda.Mensaje = $"error en el fichero : {e.Message}";
            respuestaBusqueda.Persona = null;
            return respuestaBusqueda;
        }
    }    
}
