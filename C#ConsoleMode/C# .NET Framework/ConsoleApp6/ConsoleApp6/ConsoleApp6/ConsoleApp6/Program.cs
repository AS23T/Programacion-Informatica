using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ejercicio con tres diferentes versiones (for, do while, while), a traves de metodos diferentes

namespace ConsoleApp6
{
    internal class Program
    {

        static void CuantasMujeresAdultasyHombresMenoresyPersonasMayoresHayWhile()
        {
            int i = 0;

            int edad;
            char genero;
            int cuentaMujeres = 0;
            int cuentaHombres = 0;
            int PersonasMayores = 0;

            while (i < 5)
            {
                Console.Write("(M: Masculino F: Femenino)= ");
                genero = char.Parse(Console.ReadLine());

                Console.Write("Indique su edad: ");
                edad = int.Parse(Console.ReadLine());

                i++;

                if (genero == 'm' || genero == 'M')
                {
                    if (edad < 18)
                    {
                        cuentaHombres++;
                    }

                }

                if (genero == 'f' || genero == 'F')
                {
                    if (edad >= 18)
                    {
                        cuentaMujeres++;
                    }
                }

                if (edad > 60)
                {
                    PersonasMayores++;
                }
            }

            Console.WriteLine("# {0} Mujeres mayores de edad", cuentaMujeres);

            Console.WriteLine("# {0} Hombres menores de edad", cuentaHombres);

            Console.WriteLine("# {0} Personas mayores de 60 años de edad", PersonasMayores);

        }

        static void CuantasMujeresAdultasyHombresMenoresyPersonasMayoresHayDoWhile()
        {
            int i = 0;

            int edad;
            char genero;
            int cuentaMujeres = 0;
            int cuentaHombres = 0;
            int PersonasMayores = 0;

            do
            {
                Console.Write("(M: Masculino F: Femenino)= ");
                genero = char.Parse(Console.ReadLine());

                Console.Write("Indique su edad: ");
                edad = int.Parse(Console.ReadLine());

                i++;

                if (genero == 'm' || genero == 'M')
                {
                    if (edad < 18)
                    {
                        cuentaHombres++;
                    }

                }

                if (genero == 'f' || genero == 'F')
                {
                    if (edad >= 18)
                    {
                        cuentaMujeres++;
                    }
                }

                if (edad > 60)
                {
                    PersonasMayores++;
                }
            } while (i < 5);

            Console.WriteLine("# {0} Mujeres mayores de edad", cuentaMujeres);

            Console.WriteLine("# {0} Hombres menores de edad", cuentaHombres);

            Console.WriteLine("# {0} Personas mayores de 60 años de edad", PersonasMayores);
        }

        static void CuantasMujeresAdultasyHombresMenoresyPersonasMayoresHayFor()
        {

            int edad;
            char genero;

            int cuentaMujeres = 0;
            int cuentaHombres = 0;
            int PersonasMayores = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("(M: Masculino F: Femenino)= ");
                genero = char.Parse(Console.ReadLine());

                Console.Write("Indique su edad: ");
                edad = int.Parse(Console.ReadLine());

                if (genero == 'm' || genero == 'M')
                {
                    if (edad < 18)
                    {
                        cuentaHombres++;
                    }

                }

                if (genero == 'f' || genero == 'F')
                {
                    if (edad >= 18)
                    {
                        cuentaMujeres++;
                    }
                }

                if (edad > 60)
                {
                    PersonasMayores++;
                }
            }

            Console.WriteLine("# {0} Mujeres mayores de edad", cuentaMujeres);

            Console.WriteLine("# {0} Hombres menores de edad", cuentaHombres);

            Console.WriteLine("# {0} Personas mayores de 60 años de edad", PersonasMayores);
        }

        static void Main(string[] args)
        {
            int selector;

            Console.WriteLine("Seleccione una opcion\n 1. Do While\n 2. For\n 3. While");
            selector = int.Parse(Console.ReadLine());

            if (selector >= 1 && selector <= 3)
            {
                if (selector == 1)
                {
                    Console.WriteLine("Seleccionaste Do While\n");
                    CuantasMujeresAdultasyHombresMenoresyPersonasMayoresHayDoWhile();
                }
                if (selector == 2)
                {
                    Console.WriteLine("Seleccionaste For\n");
                    CuantasMujeresAdultasyHombresMenoresyPersonasMayoresHayFor();
                }
                if (selector == 3)
                {
                    Console.WriteLine("Seleccionaste While\n");
                    CuantasMujeresAdultasyHombresMenoresyPersonasMayoresHayWhile();
                }
            }
            else
            {
                Console.WriteLine("Por favor ingrese un valor dentro del rango");
                return;
            }

            Console.ReadKey();
        }
    }
}
