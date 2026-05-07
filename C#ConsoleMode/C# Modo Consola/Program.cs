// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//

// area de un circulo = pi * r * r

//double radio = 5.23;
//double area = 3.1416 * radio * radio;
//Console.WriteLine(radio);

//

//double calcularAreaCirculo(double radio)
//{
//double resultado = 3.1416 * radio * radio;
//return resultado;
//}

//Console.WriteLine(calcularAreaCirculo(6));
//Console.WriteLine(calcularAreaCirculo(12));
//Console.WriteLine(calcularAreaCirculo(32));

//

//string Saludar(string nombre)
//{
//return $"Hola mi nombre es {nombre}";
//}

//Console.WriteLine(Saludar("Estefan"));
//Console.WriteLine(Saludar("Jose"));
//Console.WriteLine(Saludar("Cecilia"));

//

//int Sumar(int a, int b)
//{
//return a + b;
//}

//Console.WriteLine(Sumar(2, 3)); //a, b, c, d, e, ...

//

//void mostrarMensaje()
//{
//Console.WriteLine("Esta funcion no devuelve nada");
//}

//mostrarMensaje();

//

//int Sumar(int a, int b) => a + b;

//Console.WriteLine(Sumar(2,5));

//

void mostrarMensaje(string Mensajes, int Veces = 1)
{
    for (int i = 0; i < Veces; i++)
    {
        Console.WriteLine(Mensajes);
    }
}

mostrarMensaje("XD", 5); // por parametros

