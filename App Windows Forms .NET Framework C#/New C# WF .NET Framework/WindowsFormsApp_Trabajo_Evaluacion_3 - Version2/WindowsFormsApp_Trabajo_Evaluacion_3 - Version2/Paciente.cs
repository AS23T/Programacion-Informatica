using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//

namespace WindowsFormsApp_Trabajo_Evaluacion_3
{
    public class Paciente
    {
        //La mascota
        public string Tipo { get; set; } // Aqui guardaremos "Perro", "Gato", etc.
        public int Edad { get; set; }

        public Paciente(string tipo, int edad)//Asignamos Tipo de animal y edad a variables
        {
            Tipo = tipo;
            Edad = edad;
        }
    }
}
