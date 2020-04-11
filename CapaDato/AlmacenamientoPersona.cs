using System;
using System.Collections.Generic;
using CapaEntidad;
using System.IO;
namespace CapaDato
{
    public class AlmacenamientoPersona
    {
        private string ruta = @"Persona.txt";
        private FileStream flujoDelArchivo;
        private StreamWriter escritor;
        private List<Persona> personas;
        public AlmacenamientoPersona()
        {
            personas = new List<Persona>();
        }
        public void Guardar(Persona persona)
        {
            flujoDelArchivo = new FileStream(ruta, FileMode.Append);
            escritor = new StreamWriter(flujoDelArchivo);
            escritor.WriteLine(persona.MostrarPersona());
            escritor.Close();
            flujoDelArchivo.Close();
        }
        public List<Persona> Consultar()
        {
            personas.Clear();
            flujoDelArchivo = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader lector = new StreamReader(flujoDelArchivo);
            string linea = string.Empty;
            while ((linea = lector.ReadLine()) != null)
            {
                Persona persona = MapearPersona(linea);
                personas.Add(persona);
            }
            flujoDelArchivo.Close();
            lector.Close();
            return personas;
        }

        public Persona MapearPersona( string linea) 
        {
            Persona persona = new Persona();
            string[] datos = linea.Split(';');
            persona.Nombre = datos[0];
            persona.Identificacion = datos[1];
            persona.Sexo = datos[2];
            persona.Edad = int.Parse(datos[3]);
            persona.Pulsaciones = int.Parse(datos[4]);
            return persona;
        }

        public void Eliminar(string identicacion)
        {
            personas.Clear();
            personas = Consultar();
            flujoDelArchivo = new FileStream(ruta, FileMode.Create);
            flujoDelArchivo.Close();
            foreach (var item in personas)
            {
                if (item.Identificacion != identicacion)
                {
                    Guardar(item);
                }
            }
            
        }

        public void Modificar(Persona persona)
        {
            personas.Clear();
            personas = Consultar();
            flujoDelArchivo = new FileStream(ruta, FileMode.Create);
            flujoDelArchivo.Close();
            foreach (var item in personas)
            {
                if (item.Identificacion != persona.Identificacion)
                {
                    Guardar(item);
                }
                else
                {
                    Guardar(persona);
                }
            }
        }
        public Persona Buscar(String identificacion)
        {
            personas.Clear();
            personas = Consultar();

            foreach (var item in personas)
            {
                if (item.Identificacion == identificacion)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
