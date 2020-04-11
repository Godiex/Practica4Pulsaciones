using System;

namespace CapaEntidad
{   [Serializable]
    public class Persona
    {
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public int Pulsaciones { get; set; }
        public int Edad { get; set; }
        public string Identificacion { get; set; }

        public Persona(string nombre,string identificasion, string sexo, int edad )
        {
            this.Nombre = nombre;
            this.Identificacion = identificasion;
            this.Sexo = sexo;
            this.Edad = edad;   
        }
        public Persona()
        {

        }
        public int CalcularPulsaciones() 
        {
            if (Sexo == "M")
            {
                Pulsaciones = (210 - Edad) / 10;
            }
            else
            {
                if (Sexo == "F")
                {
                    Pulsaciones = (220 - Edad) / 10;
                }
                else
                {
                    Pulsaciones = 0;
                }
            }
            return Pulsaciones;
        }
        public string MostrarPersona() 
        {
            return $"{Nombre};{ Identificacion};{Sexo};{Edad};{Pulsaciones}";
        }

    }
}
