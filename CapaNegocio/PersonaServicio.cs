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
                if (personaRepositorio.Buscar(persona.Identificacion) != null)
                {
                    return $"los datos de {persona.Nombre } ya se encuentra registrada";
                }
                else
                {
                    personaRepositorio.Guardar(persona);
                    return $"los datos de {persona.Nombre } se han guardado con exito";
                }
            }
            catch (Exception e)
            {
                return $"Error de datos  " + e.Message;
            }
        }
        public List<Persona> Consultar()
        {
            try
            {
                List<Persona> personas = personaRepositorio.Consultar();
                return personas;
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
                return null;
            }
        }

        public string  Eliminar(string identificacion)
        {
            try
            {
                Persona persona = personaRepositorio.Buscar(identificacion);
                if (persona != null)
                {
                    personaRepositorio.Eliminar(identificacion);
                    return $"La Persona con nombre: {persona.Nombre} e identificacion: {persona.Identificacion}, se elimino con exito";
                }
                return $"La persona con identificacion :{identificacion}, no se encuentra registrada ";
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

                Persona personaAuxiliar = personaRepositorio.Buscar(persona.Identificacion);
                if (persona != null)
                {
                    personaRepositorio.Modificar(persona);
                    return $"La Persona con nombre: {persona.Nombre} e identificacion: {persona.Identificacion}, se Actualizo con exito";
                }
                return $"La persona con identificacion :{persona.Identificacion}, no se encuentra registrada ";
            }
            catch (Exception e)
            {

                return $"Error de datos" + e.Message;
            }
        }
        public Persona Buscar(string identificacion)
        {
            try
            {
                Persona persona = personaRepositorio.Buscar(identificacion);
                if (persona != null)
                {
                    return persona;

                }
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en el fichero " +e.Message);
                return null;
            }
        }


    }    
}
