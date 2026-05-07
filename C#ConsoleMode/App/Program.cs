/*List<int> numeros = new List<int> {13, 45, 12, 345, 235, 654 };
Console.WriteLine(string.Join(",", numeros));

List<double> lista = new List<double> {23, 13, 34, 123};
dynamic[] datosMixtos = {"texto", 69, true, lista};

Console.WriteLine(string.Join(",", datosMixtos));

Dictionary<int, string> jugadores= new Dictionary<int, string>();
jugadores.Add(10, "Alexis");
jugadores.Add(7, "Vidal");
Console.WriteLine(jugadores[7]);

const float pi = 3.14159265359F;

bool autorizado = true; //false

if (autorizado)
{
    Console.WriteLine("Puede ingresar");
}
else
{
    Console.WriteLine("no puede ingresar");
}


int entero = 111;

if (entero > 100)
{
    Console.WriteLine("El numero es mayor a 100");
}
else if (entero == 100)
{
    Console.WriteLine("El numero es igual a 100");
}
else
{
    Console.WriteLine("El numero es menor a 100");
}


string color = "rojo";

switch (color)
{
    case "rojo":
        Console.WriteLine("El color es rojo");
        break;
    case "azul":
        Console.WriteLine("El color es azul");
        break;
    case "verde":
        Console.WriteLine("El color es verde");
        break;
    default:
        Console.WriteLine("El color no es rojo, azul ni verde");
        break;
}


int sumar(int primerNumero, int segundoNumero)
{
    return primerNumero + segundoNumero;
}

int resultado = sumar(10, 20);
Console.WriteLine(resultado);

int Entero = 15;
void multiplicar(int primerNumero, int segundoNumero)
{
    Console.WriteLine(primerNumero * segundoNumero);
}

multiplicar(Entero, 20);

void imprimirMensaje(string[] mensaje)
{
    Console.WriteLine(mensaje[0]);
}

imprimirMensaje(animales);

List<int> quicksort(List<int> lista)
{
    if (lista.Count <= 1)
    {
        return lista;
    }

    int pivote = lista[0];
    List<int> menores = new List<int>();
    List<int> mayores = new List<int>();

    for (int i = 1; i < lista.Count; i++)
    {
        if (lista[i] < pivote)
        {
            menores.Add(lista[i]);
        }
        else
        {
            mayores.Add(lista[i]);
        }
    }

    List<int> resultado = new List<int>();
    resultado.AddRange(quicksort(menores));
    resultado.Add(pivote);
    resultado.AddRange(quicksort(mayores));

    return resultado;
}
;

List<int> numeros = new List<int> {13, 45, 12, 345, 235, 654 };
List<int> numerosOrdenados = quicksort(numeros);
Console.WriteLine(string.Join(",", numerosOrdenados));

string[] animales = {"perro", "gato", "conejo", "hamster"};
foreach (string animal in animales)
{
    Console.WriteLine(animal);
}


int entero = 111;
int emergencia = 0;

while (emergencia < 3)
{
    Console.WriteLine("Ingrese el numero entero:");
    int numeroIngresado = int.Parse(Console.ReadLine());

    if (numeroIngresado == entero)
    {
        Console.WriteLine("¡Número correcto! Acceso concedido.");
        break;
    }
    else
    {
        emergencia++;
        Console.WriteLine($"Número incorrecto. Intentos restantes: {3 - emergencia}");
    }
}

Lenguaje lenguaje1 = new Lenguaje("C#", "2000");
lenguaje1.descripcion();
Lenguaje lenguaje2 = new Lenguaje("Python", "1991");
lenguaje2.descripcion();
Lenguaje lenguaje3 = new Lenguaje("Java", "1995");
lenguaje3.descripcion();
*/
