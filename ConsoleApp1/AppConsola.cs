using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaLogica;

namespace ConsoleApp1
{
    class AppConsola
    {
        private PersonaServicio personaServicio;
        public int Opcion { get; set; }
        public AppConsola()
        {
            personaServicio = new PersonaServicio();
            EjecutarProgramaPulsaciones();
        }
        public void EjecutarProgramaPulsaciones()
        {
            do
            {
                Opcion= Menu();
                EjecutarOpcion(Opcion);
            } while (Opcion!= 0);
            
        }
        public void EjecutarOpcion(int opcion)
        {
            switch (opcion)
            {
                case 1: Console.WriteLine(RegistrarPersona()); break;
                case 2: ConsultarPersona(); break;
                case 3: MostrarPersonas(); break;
                case 4: ModificarPersona(); break;
                case 5: EliminarPersona(); break;
                case 0: break;
            }
        }
        public int Menu() 
        {
            Console.Clear();
            Console.WriteLine("Programa Pulsaciones");
            Console.WriteLine("");
            Console.WriteLine("1-Registrar Persona");
            Console.WriteLine("2-Consultar Persona ");
            Console.WriteLine("3-Mostrar Personas");
            Console.WriteLine("4-Modificar Persona");
            Console.WriteLine("5-Eliminar Persona");
            Console.WriteLine("Programa Pulsaciones");
            int numero = int.Parse(Leer("Digite La opcion deseada"));
            return numero;
        }

        
        public string RegistrarPersona()
        {
            return personaServicio.Guardar(CrearPersona());
        }

        public  Persona CrearPersona()
        {
            try
            {
                string nombre;
                string sexo;
                string identificacion;
                int edad;
                nombre = Leer("digite el nombre :");
                sexo = Leer("digite el sexo M/F");
                identificacion = Leer("digite la identificacion :");
                edad = int.Parse(Leer("digite su edad"));
                Persona persona = new Persona(nombre, identificacion, sexo, edad);
                persona.CalcularPulsaciones();
                return persona;
            }
            catch (Exception e)
            {
                Console.WriteLine("errror: " + e.Message);
                Console.ReadKey();
                return null;
            }
        }
        public static string Leer(string valor)
        {
            Console.WriteLine(valor);
            return Console.ReadLine();
        }
        public void ConsultarPersona ()
        {
            string identificacion = Leer("Digite la identifcacion de la persona a buscar");
            Persona persona = personaServicio.Buscar(identificacion);
            if (persona != null)
            {
                Console.WriteLine("Identificacion----------Nombre----------Sexo----------Edad----------Pulsaciones");
                Console.WriteLine(MostrarImformacionDePesona(persona));
                Console.ReadKey();
            }
            else 
            {
                Console.WriteLine("la persona con identificacion: " + identificacion + "no se encuentra registrada");
                Console.ReadKey();
            }
            
        }

        public string MostrarImformacionDePesona(Persona persona) 
        {
            return $"{persona.Identificacion}----------{persona.Nombre}----------{persona.Sexo}----------{persona.Edad}----------{persona.Pulsaciones}";
        }

        public void MostrarPersonas()
        {
            List<Persona> personas = personaServicio.Consultar();
            if (personas != null)
            {
                Console.WriteLine("Identificacion----Nombre-----Sexo---Edad---Pulsaciones");
                foreach (var item in personas)
                {
                    Console.WriteLine(MostrarImformacionDePesona(item));
                }
                Console.ReadKey();
            }

            Console.WriteLine("Error no ha registrado datos de personas,la lista esta vacia");
        }

        public void ModificarPersona()
        {
             personaServicio.Modificar(PersonaModificada());
            Console.WriteLine("Se han actualizado los datos con exito");

        }
        public Persona PersonaModificada() 
        {
            string identificacion = Leer("Digite la identifcacion de la persona a buscar");
            Persona personaAuxiliar = personaServicio.Buscar(identificacion);
            if (personaAuxiliar != null)
            {
                string nombre;
                string sexo;
                int edad;
                nombre = Leer("digite el nombre :");
                sexo = Leer("digite el sexo M/F");
                edad = int.Parse(Leer("digite su edad"));
                Persona persona = new Persona(nombre, identificacion, sexo, edad);
                persona.CalcularPulsaciones();
                return persona;
            }
            Console.WriteLine("la persona con identificacion: " + identificacion + "no se encuentra registrada");
            Console.ReadKey();
            return null;
        }

        public void EliminarPersona()
        {
            string identificacion = Leer("Digite la identifcacion de la persona a buscar");
            Persona persona = personaServicio.Buscar(identificacion);
            if (persona == null) 
            {
                Console.WriteLine("la persona con identificacion: " + identificacion + "no se encuentra registrada");
                
            }
            Console.WriteLine("Se elimino con exito ");
            personaServicio.Eliminar(persona.Identificacion);
            Console.ReadKey();
        }
    }
    
}
