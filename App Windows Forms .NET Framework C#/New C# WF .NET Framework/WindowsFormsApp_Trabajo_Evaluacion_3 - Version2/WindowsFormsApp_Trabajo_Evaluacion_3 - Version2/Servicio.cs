using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//

namespace WindowsFormsApp_Trabajo_Evaluacion_3
{
    public class Servicio
    {
        //La categoria
        public string Nombre { get; set; }
        public double PrecioUnitario { get; set; }
        public int Cantidad { get; set; }

        public Servicio(string nombre, double precio, int cantidad)//Asignar Nombre, Precio Unitario Cantidad  a  Variables
        {
            Nombre = nombre;
            PrecioUnitario = precio;
            Cantidad = cantidad;
        }

        // Metodo que realiza calculos
        public double CalcularTotalLinea()
        {
            return PrecioUnitario * Cantidad;//Calculo Integrado
        }
    }
}
