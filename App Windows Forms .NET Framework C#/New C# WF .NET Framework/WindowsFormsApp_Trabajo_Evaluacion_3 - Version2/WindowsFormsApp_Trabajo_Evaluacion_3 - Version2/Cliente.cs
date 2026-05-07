using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//

namespace WindowsFormsApp_Trabajo_Evaluacion_3
{
    public class Cliente //Creacion de la clase dueño (Cliente)
    {
        //El dueño
        public string Rut { get; set; }
        public Paciente SuMascota { get; set; } // Asociacion: Cliente TIENE UNA Mascota

        public Cliente(string rut, Paciente mascota)//Asignando Variables de Rut y Mascota a Clase
        {
            Rut = rut;
            SuMascota = mascota;
        }
    }
}
